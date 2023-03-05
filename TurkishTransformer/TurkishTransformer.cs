using System.Text.RegularExpressions;

namespace TurkishTransformer
{
    public class TurkishTransformer : ITransformer
    {
        public  string Translate(string input) =>
           ConvertToNumbers(input).Aggregate(string.Empty, (current, word) => current + (word + " ")).TrimEnd();

        public IEnumerable<string> ConvertToNumbers(string words)
        {
            if (string.IsNullOrEmpty(words))
            {
                return Enumerable.Empty<string>();
            }

            int signatureFlag;
            var matches = Regex.Matches(words, @"\w+").ToList();
            var lowerCases = matches.Select(m => m.Value.ToLowerInvariant()).ToList();
            var isConvertable = lowerCases.Select(l => Numbers.ContainsKey(l)).ToList();
            var list = new List<string>();
            var sentence = new List<string>();
            for (var index = 0; index < isConvertable.Count; index++)
            {
                var token = isConvertable[index];
                if (token)
                {
                    list.Add(lowerCases[index]);
                }
                else
                {
                    if (list.Any())
                    {
                        signatureFlag = list.FirstOrDefault()!.Equals("eksi") ? -1 : 1;
                        sentence.Add(GetDigits(list.Select(n => Numbers[n]), signatureFlag).ToString());
                        list = new List<string>();
                    }

                    sentence.Add(matches[index].Value);
                }
            }

            if (!list.Any() || sentence.Any())
            {
                return sentence;
            }

            signatureFlag = list.FirstOrDefault()!.Equals("eksi") ? -1 : 1;
            sentence.Add(GetDigits(list.Select(n => Numbers[n]), signatureFlag).ToString());

            return sentence;
        }

        private long GetDigits(IEnumerable<long> numbers, int signatureFlag = 1)
        {
            var percentile = 0L;
            var result = 0L;
            foreach (var number in numbers)
            {
                switch (number)
                {
                    case >= 1000:
                        result += percentile * number;
                        percentile = 0;
                        break;
                    case >= 100:
                        percentile *= number;
                        break;
                    default:
                        percentile += number;
                        break;
                }
            }

            return (result + percentile) * signatureFlag;
        }

        private readonly Dictionary<string, long> Numbers = new()
        {
            { "bir", 1 },
            { "iki", 2 },
            { "üç", 3 },
            { "dört", 4 },
            { "beş", 5 },
            { "altı", 6 },
            { "yedi", 7 },
            { "sekiz", 8 },
            { "dokuz", 9 },
            { "on", 10 },
            { "yirmi", 20 },
            { "otuz", 30 },
            { "kırk", 40 },
            { "elli", 50 },
            { "altmış", 60 },
            { "yetmiş", 70 },
            { "seksen", 80 },
            { "doksan", 90 },
            {"yüz", 100},
            {"bin", 1000},
            {"milyon", 1000000},
            {"milyar", 1000000000},
            {"trilyon", 1000000000000}
        };
    }
}
