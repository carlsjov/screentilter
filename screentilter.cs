using System;

namespace ScreenTilter {
    class ScreenDir {
        //Näytön eri suunnat
        public int OrientChooser{

        //Katsoo valinnan
        if (a == 1) {
            Console.WriteLine("Your screen is now vertical!");
        }
        else (a == 2) {
            Console.WriteLine("Your screen is now horizontal!");
        }
        }
    }
    class ExecuteScreenDir {
        static void Main(string[] args) {
            ScreenDir s = new ScreenDir();
            Console.WriteLine("You want to change to horizontal or vertical?");
            int a = Convert.ToInt32(Console.ReadLine());
            s.OrientChooser();
        }
    }
}

