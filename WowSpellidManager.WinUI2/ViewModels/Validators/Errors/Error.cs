namespace WowSpellidManager.ViewModels.Validators.Errors
{
    public class Error
    {
        private string fMessage;
        public string Message
        {
            get
            {
                return fMessage;
            }
            set
            {
                fMessage = value;
            }
        }

        public Error(string aMessage)
        {
            Message = aMessage;
        }
    }
}
