namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            const int MAX_SMASK_SIZE = 96;
            const int MIN_SMASK_SIZE = 3;

            // 1. Завдання
            // Зробити логічний зсув (logical shift) змінної 'mask' таким чином, щоб змогли розшифрувати слово у змінній 'word' 

            // маска
            int mask = 0b0001100; // 0000 1100;
            string word = string.Empty;
            mask = mask << 2;

            // Зашифроване слово
            int w = 82;
            int o = 85;
            int r = 67;
            int d = 68;

            // Розшифрувати слово використовуючи якусь одну побітову операцію до кожної змінної(замінити '?' на якусь побітову операцію)
            w = w ^ mask; 
            o = o ^ mask; 
            r = r ^ mask; 
            d = d ^ mask;

            // 2. Завдання
            // Спростити багатогілкову констукцію до одного if
            if (mask < MAX_SMASK_SIZE && mask > MIN_SMASK_SIZE && w < o && o < r && !(r > d) && o != '\x77' ^ w == 'J')
            {
                // Будуємо слово
                word = CreateWord(w, o, r, d);
            }

            PrintMask(mask);
            Console.WriteLine(string.IsNullOrEmpty(word) ? "Try again ;)" : word);
            Console.ReadKey();
        }

        /// <summary>
        /// Виводимо на дісплей маску
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static void PrintMask(int number)
        {
            // Конвертуємо int в string
            // Будуємо строку з символів
            string mask = Convert.ToString(number, 2).PadLeft(8, '0');

            //Виводимо на дісплей маску
            Console.WriteLine($"Your mask is: {mask}");

        }

        /// <summary>
        /// Будуємо слово
        /// </summary>
        /// <param name="w"></param>
        /// <param name="o"></param>
        /// <param name="r"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        static string CreateWord(int w, int o, int r, int d)
        {
            // Конвертуємо тип int в char
            // Будуємо строку з символів
            return $" Your word is: {(char)w}{(char)o}{(char)r}{(char)d}";
        }
    }
}