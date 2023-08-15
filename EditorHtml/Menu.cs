using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
        }

        public static void DrawScreen()
        {
            CreateLine();

            for(int lines = 0; lines <= 10; lines ++)
            {
                CreateLine("|", " ");
            }

            CreateLine();
        }

        public static void CreateLine(string firstCharacter = "+", string secondCharacter = "-")
        {
            Console.Write(firstCharacter);
            for (int i = 0; i <= 30; i+=1)
                Console.Write(secondCharacter);
            Console.Write(firstCharacter);
            Console.Write("\n");
        }
    }
}