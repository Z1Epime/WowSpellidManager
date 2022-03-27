using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WowSpellidManager.ViewModels.Helper;
using WowSpellidManager.ViewModels.Validators.Checkers;
using WowSpellidManager.ViewModels.Validators.Errors;
using WowSpellidManager.ViewModels.Validators;

namespace WowSpellidManager.Views
{
    public sealed partial class ClassesView : Page
    {
        private HelperWowClassViewModel fHelperWowClassViewModel;
        private HelperSpellViewModel fHelperSpellViewModel = new HelperSpellViewModel();
        private SpellChecker fSpellChecker;

        private Error fNameError;
        private Error fIDError;
        private Error fDescriptionError;

        public ClassesView()
        {
            this.InitializeComponent();
            fHelperWowClassViewModel = new HelperWowClassViewModel();
            fSpellChecker = new SpellChecker();
            classListView.DataContext = fHelperWowClassViewModel.GetWowClasses();
            AddSpellStackPanel.Visibility = Visibility.Collapsed;
            specializationView.Visibility = Visibility.Collapsed;

            fNameError = new Error("moin");
            fIDError = new Error("moin");
            fDescriptionError = new Error("moin");
            ErrorsChanged();
        }

        private void classListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            specializationView.DataContext = classListView.SelectedItem;
            specializationView.Visibility = Visibility.Visible;
            AddSpellStackPanel.Visibility = Visibility.Collapsed;
        }

        private void specializationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            specializationFrame.Content = new SpecializationView(specializationView.SelectedItem, classListView.SelectedItem);
            AddSpellStackPanel.Visibility = Visibility.Visible;
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: add confirmation popup to exit button
        }

        private void AddSpellButton_Click(object sender, RoutedEventArgs e)
        {
            fHelperSpellViewModel.AddSpell(SpellAddNameTextBox.Text, SpellAddIDTextBox.Text,
                SpellAddDescriptionTextBox.Text, classListView.SelectedItem, specializationView.SelectedItem);
        }

        private void SAVE_Click(object sender, RoutedEventArgs e)
        {
            fHelperWowClassViewModel.SaveWowClasses();
        }

        private void SpellAddNameTextBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            NameErrorTextBlock.Text = "";

            Error error = fSpellChecker.CheckName(SpellAddNameTextBox.Text);
            if (error != null)
                NameErrorTextBlock.Text = error.Message;

            fNameError = error;
            ErrorsChanged();
        }

        private void SpellAddIDTextBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            IDErrorTextBlock.Text = "";

            Error error = fSpellChecker.CheckID(SpellAddIDTextBox.Text);
            if (error != null)
                IDErrorTextBlock.Text = error.Message;

            fIDError = error;
            ErrorsChanged();
        }

        private void SpellAddDescriptionTextBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            DescriptionErrorTextBlock.Text = "";

            Error error = fSpellChecker.CheckDescription(SpellAddDescriptionTextBox.Text);
            if (error != null)
                DescriptionErrorTextBlock.Text = error.Message;

            fDescriptionError = error;
            ErrorsChanged();
        }

        private void ErrorsChanged()
        {
            AddSpellButton.IsEnabled = false;

            if (fNameError == null)
                if(fIDError == null)
                    if(fDescriptionError == null)
                        AddSpellButton.IsEnabled = true;
                                 
        }
    }  
}
