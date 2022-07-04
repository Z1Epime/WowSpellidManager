using WowSpellidManager.ViewModels.Validators.Errors;

namespace WowSpellidManager.ViewModels.Validators.Checkers
{
    public class SpellChecker
    {
        private Checker fChecker;
        // TODO: add constants for max values etc. here
        public SpellChecker()
        {
            fChecker = new Checker();
        }

        public Error CheckEveryThing(string aName, string aID, string aDecription)
        {
            Error error;

            error = CheckName(aName);
            if (error != null) return error;

            error = CheckID(aID);
            if (error != null) return error;

            error = CheckDescription(aDecription);
            if (error != null) return error;

            return null;
        }

        public Error CheckName(string aName)
        {
            Error error;

            error = fChecker.Empty(aName, "spell name");
            if (error != null) return error;

            error = fChecker.Numbers(aName, "spell name");
            if (error != null) return error;

            error = fChecker.OnlyLettersAndCertainCharacters(aName, "spell name");
            if (error != null) return error;

            error = fChecker.MaxCharacters(aName, 50, "spell name");
            if (error != null) return error;

            return null;
        }
        public Error CheckID(string aID)
        {
            Error error;

            error = fChecker.Empty(aID, "spell id");
            if (error != null) return error;

            error = fChecker.OnlyNumbers(aID, "spell id");
            if (error != null) return error;

            error = fChecker.MaxCharacters(aID, 12, "spell id");
            if (error != null) return error;

            return null;
        }

        public Error CheckDescription(string aDescription)
        {
            Error error;

            error = fChecker.Empty(aDescription, "spell description");
            if (error != null) return error;

            error = fChecker.MaxCharacters(aDescription, 256, "spell description");
            if (error != null) return error;

            return null;
        }
    }
}
