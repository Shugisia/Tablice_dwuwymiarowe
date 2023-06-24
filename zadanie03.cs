using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj rozmiar tablicy:");
        int rozmiar = WczytajLiczbeCalkowita();

        int[,] tablica = new int[rozmiar, rozmiar];

        WypelnijTablice(tablica);
        WyswietlTablice(tablica);

        int rozmiar2 = WczytajLiczbeDruga();
        int[,] array = new int[rozmiar2, rozmiar2];
        Wypelnij(array, rozmiar2);
        Wyswietl(array);

    }

    static void WypelnijTablice(int[,] tablica)
    {
        int rozmiar = tablica.GetLength(0);

        for (int i = 0; i < rozmiar; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = i * rozmiar + j + 1;
                }
            }
            else
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tablica[i, j] = i * rozmiar + rozmiar - j;
                }
            }
        }
    }

    static void WyswietlTablice(int[,] tablica)
    {
        int rozmiar = tablica.GetLength(0);

        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write(tablica[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }
    static int WczytajLiczbeCalkowita()
    {
        int liczba;
        while (!int.TryParse(Console.ReadLine(), out liczba) || liczba <= 0)
        {
            Console.WriteLine("Podaj poprawną liczbę całkowitą większą od zera:");
        }
        return liczba;
    }

    // -------------------------------------------------------------- tablica z zadania pierwszego

    static int WczytajLiczbeDruga()
    {
        int rozmiar2;
        while (true)
        {
            Console.Write("Podaj rozmiar tablicy: ");
            if (int.TryParse(Console.ReadLine(), out rozmiar2) && rozmiar2 > 0)
            {
                return rozmiar2;
            }
            else
            {
                Console.WriteLine("Podaj poprawną liczbę całkowitą większą od zera:");
            }
        }
    }

    static void Wypelnij(int[,] array, int rozmiar2)
    {
        int currentNumber = 1;
        int row = 0, col = 0;
        int lastRow = rozmiar2 - 1, lastCol = rozmiar2 - 1;

        while (currentNumber <= rozmiar2 * rozmiar2)
        {
            for (int i = col; i <= lastCol; i++)
            {
                array[row, i] = currentNumber++;
            }
            row++;

            for (int i = row; i <= lastRow; i++)
            {
                array[i, lastCol] = currentNumber++;
            }
            lastCol--;

            for (int i = lastCol; i >= col; i--)
            {
                array[lastRow, i] = currentNumber++;
            }
            lastRow--;

            for (int i = lastRow; i >= row; i--)
            {
                array[i, col] = currentNumber++;
            }
            col++;
        }
    }

    static void Wyswietl(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }
    }


}
