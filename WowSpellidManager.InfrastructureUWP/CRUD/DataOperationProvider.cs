namespace WowSpellidManager.Infrastructure.CRUD
{
    public class DataOperationProvider
    {
        private static SpellOperator fSpellOperator = new SpellOperator();
        private static SpecializationOperator fSpecializationOperator = new SpecializationOperator();
        private static WowClassOperator fWowClassOperator = new WowClassOperator();
        private static SettingsOperator fSettingsOperator = new SettingsOperator();

        public SpellOperator SpellOperator
        {
            get
            {
                return fSpellOperator;
            }

            set
            {
                fSpellOperator = value;
            }
        }
        public SpecializationOperator SpecializationOperator
        {
            set
            {
                fSpecializationOperator = value;
            }

            get
            {
                return fSpecializationOperator;
            }
        }

        public WowClassOperator WowClassOperator
        {
            get
            {
                return fWowClassOperator;
            }

            set
            {
                fWowClassOperator = value;
            }
        }

        public SettingsOperator SettingsOperator
        {
            get
            {
                return fSettingsOperator;
            }

            set
            {
                fSettingsOperator = value;
            }
        }
    }
}
