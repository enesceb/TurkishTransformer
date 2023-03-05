namespace TurkishTransformer.Factory
{
    public class TransformerFactory
    {
        public enum NameOfInstance
        {
            TurkishTransformer
        }
        public static ITransformer Create(NameOfInstance locale)
        {
            ITransformer _transformer = null;

            switch (locale)
            {
                case NameOfInstance.TurkishTransformer:
                    _transformer = new TurkishTransformer();
                    break;
            }
            return _transformer;
        }

    }
}
