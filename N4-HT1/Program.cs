using System;

namespace BootcampDotNET.Lesson4.HomeTasks
{


    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet. botirjon consectetur adipisicing elit. quaerat est. abdumannonov quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!";

            //ozgaruvchilarni elon qilish
            int umumiySozlar = 0;
            int qaytalanganSozlar = 0;
            int kichikSozlar = 0;
            int Sozlar2 = 0;
            int uzunSozlar = 0;

            //split
            string[] words = text.Split(' ');

            //foreach funksiyasi
            foreach (string word in words)
            {
                umumiySozlar++;

                if (word.Length > 0)
                {
                    char birinchiSoz = word[0];

                    if (!Char.IsUpper(birinchiSoz))
                    {
                        kichikSozlar++;
                    }
                }

                if (word.Length > 1)
                {
                    string kichikkSoz = word.ToLower();
                    string belgilar = new string(kichikkSoz.Where(c => Char.IsLetter(c)).ToArray());

                    if (!Array.Exists(words, w => w.Equals(belgilar)))
                    {
                        Sozlar2++;
                    }
                }

                if (word.Length > 20)
                {
                    uzunSozlar++;
                }

                if (Array.Exists(words, w => w.Equals(word) && w != word)) // bu yerda bazi malumotlarini internetdan oldim
                {
                    qaytalanganSozlar++;
                }
            }

            int totalScore = (-1 * qaytalanganSozlar * 5) + kichikSozlar * 5 - Sozlar2 * 10 + uzunSozlar * 20;

            Console.WriteLine($"Umumiy so'zlar soni: {umumiySozlar}");
            Console.WriteLine($"Takrorlanayotgan so'zlar soni: {qaytalanganSozlar}");
            Console.WriteLine($"Capital bo'lmagan birinchi so'z: {kichikSozlar}");
            Console.WriteLine($"Birinchi so'z bo'lmagan so'zlar soni: {Sozlar2}");
            Console.WriteLine($"So'zlarning uzunligi 20 dan oshgan so'zlar soni: {uzunSozlar}");
            Console.WriteLine($"Jami ballaringiz: {totalScore}");
        }
    }
}