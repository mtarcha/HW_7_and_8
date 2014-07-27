using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Створюємо динамічну матрицю за допомогою масивів. Відповідно цей метод витрачає багато додаткової памяті.
            MatrixArray<int> someMatrix = new MatrixArray<int>(2, 3);
            someMatrix.AddRows(1);
            someMatrix.AddColumns(6);
            someMatrix[1,1]=6;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(Convert.ToString(someMatrix[i, j]) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            ///Створюємо динамічну матрицю за допомогою спискі. Відповідно цей метод не витрачає додаткової памяті, але капець повільний
            MatrixList<int> a = new MatrixList<int>(3,2);
            a.AddColumn(2);
            a.AddRow(2);
            a[2,3] = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(Convert.ToString(a[i,j])+" ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
