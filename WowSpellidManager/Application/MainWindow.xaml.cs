using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WowSpellidManager.Infrastructure.ViewModels;
using WowSpellidManager.Infrastructure;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WowSpellidManager
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        SpellViewModel fSpellViewModel;
        public MainWindow()
        {
            this.InitializeComponent();
            
            fSpellViewModel = new SpellViewModel();
            itemListView.DataContext = fSpellViewModel.Holder.Spells;
            fSpellViewModel.AddSpell("Hammer of Justice", "5 Sec Stun, 1 min CD", 912476);
        }

        private void AddSpell_Click(object sender, RoutedEventArgs e)
        {
            fSpellViewModel.AddSpell(designationBox.Text, descriptionBox.Text, Convert.ToInt32(idBox.Text));
        }
    }
}
