// If you want to Control something with the Arrow Keys, like a Small game
            //do
            //{
            //    if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
            //    {
            //        if (Essentials.CursorPosition[0] != ' ') continue;
            //        for (int i = 1; i < Essentials.CursorPosition.Count; i++)
            //        {
            //            if (Essentials.CursorPosition[i] == 'X')
            //            {
            //                Essentials.CursorPosition[i] = ' ';
            //                Essentials.CursorPosition[i -  1] = 'X';
            //                break;
            //            }
            //        }
            //      Call Draw
            //    }
            //    if (Console.ReadKey().Key == ConsoleKey.RightArrow)
            //    {
            //        if (Essentials.CursorPosition[6] != ' ') continue;
            //        for (int i = 0; i < Essentials.CursorPosition.Count - 1; i++)
            //        {
            //            if (Essentials.CursorPosition[i] == 'X')
            //            {
            //                Essentials.CursorPosition[i] = ' ';
            //                Essentials.CursorPosition[i + 1] = 'X';
            //                break;
            //            }
            //        }
            //     Call Draw
            //    }

            //    Helper.DrawField();
            //} while (Console.ReadKey().Key != ConsoleKey.Enter);
            
     // Needs to be in a Draw Loop to Display each Time user presses key       
// Draw Cursor
            Console.Write("   ");
            foreach(char Cursor in Essentials.CursorPosition)
            {
                Console.Write($"  {Cursor} ");
            }
            Console.WriteLine();
            
// Save of Cursor Position
        public static List<char> CursorPosition = new List<char> { 'X', ' ', ' ', ' ', ' ', ' ', ' ' };
