using Windows.UI.Xaml.Controls;
using WowSpellidManager.ViewModels.Validators.Checkers;
using WowSpellidManager.ViewModels.Validators.Errors;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WowSpellidManager.WinUI2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddSpellView : Page
    {
        public string SpellName { get; set; }
        public string ID { get; set; }

        #region Errors

        private Error fNameError;
        private Error fIDError;
        private SpellChecker fSpellChecker;

        #endregion

        private ContentDialog fDialog;

        public AddSpellView(ContentDialog aDialog)
        {
            this.InitializeComponent();
            fNameError = new Error("you should not see this");
            fIDError = new Error("you should not see this");
            fSpellChecker = new SpellChecker();
            fDialog = aDialog;
            ErrorsChanged();
        }

        private void spellNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            spellNameErrorTextBlock.Text = "";

            Error error = fSpellChecker.CheckName(spellNameTextBox.Text);
            if (error != null)
                spellNameErrorTextBlock.Text = error.Message;

            fNameError = error;
            ErrorsChanged();


            SpellName = spellNameTextBox.Text;
        }

        private void spellidTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            spellidErrorTextBlock.Text = "";

            Error error = fSpellChecker.CheckID(spellidTextBox.Text);
            if (error != null)
                spellidErrorTextBlock.Text = error.Message;

            fIDError = error;
            ErrorsChanged();



            ID = spellidTextBox.Text;
        }

        private void ErrorsChanged()
        {
            fDialog.IsPrimaryButtonEnabled = false;

            if (fNameError == null)
                if (fIDError == null)
                        fDialog.IsPrimaryButtonEnabled = true;

        }
    }
}
