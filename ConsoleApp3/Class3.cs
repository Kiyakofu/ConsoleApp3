using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Class3
    {
        public static void Run()
        {
            Console.Write("string: ");
            string input = Console.ReadLine();

            Console.Write("krock: ");
            int key = int.Parse(Console.ReadLine());

            string encrypted = CaesarCipher(input, key);
            Console.WriteLine($"Shifr: {encrypted}");

            string decrypted = CaesarCipher(encrypted, -key);
            Console.WriteLine($"normal: {decrypted}");
        }

        private static string CaesarCipher(string text, int key)
        {
            char[] buffer = text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (char)(buffer[i] + key);
            }
            return new string(buffer);
        }
    }
}
