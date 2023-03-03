using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        string text = "Містер Дурслі завмер. Його охопив жах. Він озирнувся на тих шептунів, наче хотів їм щось сказати, проте передумав. Він перебіг вулицю, поспіхом піднявся до кабінету, гукнув секретарці не турбувати його, схопив телефон і почав набирати свій домашній номер, аж раптом зупинився. Поклав слухавку й замислено погладив вуса. Та ні, яка дурниця. Виходить Поттер — не таке вже й рідкісне прізвище. Є безліч людей, які мають не тільки це прізвище, а й сина на ім'я Гаррі. Так міркуючи, Дурслі вже навіть не знав, чи його племінника справді звуть Гаррі. Він його ніколи й не бачив. Може, то Гарві. Або Гарольд. Не варто хвилювати місіс Дурслі, вона й так дратується на саму згадку про сестру. Він їй не докоряв: якби така сестра була в нього… А все ж оті люди в мантіях… Тепер Дурслі було значно важче зосередитися на свердлах і, виходячи о п'ятій пополудні з будинку, він був такий неуважний, що наскочив на когось біля самих дверей.";

        int sentenceCount = 0;
        for (int i = 0; i < text.Length; i++)
        {
            char endOfSentenceSymbol = text[i];
            if (endOfSentenceSymbol == '.' || endOfSentenceSymbol == '?' || endOfSentenceSymbol == '!' || endOfSentenceSymbol == '…')
            {
                sentenceCount++;
            }
        }
        Console.WriteLine($"Количество предложений: {sentenceCount}");

        string[] sentences = text.Split(new char[] { '.', '!', '?', '…' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < sentences.Length; i++)
        {
            string sentence = sentences[i].Trim();
            if (sentence.Length > 0)
            {
                char firstChar = sentence[0];
                if (char.IsUpper(firstChar))
                {
                    char lowerFirstChar = char.ToLower(firstChar);
                    sentences[i] = lowerFirstChar + sentence.Substring(1);
                }
            }
        }

        string modifiedText = string.Join(' ', sentences);

        string[] words = modifiedText.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '-', '—', '(', ')', '«', '»' }, StringSplitOptions.RemoveEmptyEntries);
        
        var capitalizedWords = words.Where(word => char.IsUpper(word[0])).Distinct().ToArray();

        Console.WriteLine($"Количество уникальных слов: {capitalizedWords.Length}");
        Console.Write("Уникальные слова: ");
        foreach (string word in capitalizedWords)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}