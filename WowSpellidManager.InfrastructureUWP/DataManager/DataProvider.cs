using WowSpellidManager.Domain.Exceptions;

namespace WowSpellidManager.Infrastructure.DataManager
{
    public class DataProvider
    {
        private DataHolder fDataHolder;
        private DataParser fDataParser = new DataParser();
        public DataHolder DataHolder
        {
            get
            {
                if (fDataHolder == null)
                {
                    DataHolder tempHolder = fDataParser.Load();
                    ArgumentGuard.CheckNull(tempHolder);
                    fDataHolder = tempHolder;
                }
                return fDataHolder;
            }
            set
            {
                fDataHolder = value;
            }
        }

        public DataParser DataParser
        {
            get
            {
                return fDataParser;
            }
            set
            {
                fDataParser = value;
            }
        }
    }
}
