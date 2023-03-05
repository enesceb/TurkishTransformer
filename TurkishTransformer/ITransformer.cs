namespace TurkishTransformer
{
    public interface ITransformer
    {
        string Translate(string input);
        IEnumerable<string> ConvertToNumbers(string words);
    }
}