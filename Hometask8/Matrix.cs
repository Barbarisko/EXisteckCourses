using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hometask8
{
    //Розробити додаток для багато поточного множення матриць.
    //Мінімальний розмір матриці 10x10.
    //Кожна ітерація перемноження має виконуватися в окремому потоці.
    //Далі результат кожної ітерації просумувати і вивести остаточний результат.
    public class Matrix
    {
        private readonly uint rows;
        private readonly uint columns;
        private int[,] matrix;
        public uint Rows => rows;
        public uint Columns => columns;
        public Matrix(uint _rows, uint _cols)
        {
            rows = _rows;
            columns = _cols;

            matrix = new int[rows, columns];

            var rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }
       }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.rows != m2.columns && m1.columns != m2.rows)
                throw new ArgumentOutOfRangeException("Matrixes are not complementary");

            List<int>[,] res = new List<int>[m1.rows, m2.columns];
            List<Thread> ths = new List<Thread>();
            for (int i = 0; i < m1.rows; i++)
            {
                for (int j = 0; j < m2.columns; j++)
                {
                    res[i, j] = new List<int>();
                    for (int k = 0; k < m1.columns; k++)
                    {
                        var t1 = new Thread(Multiply);
                        t1.Start(new WorkingParams()
                        {
                            M1 = m1.matrix[i, k],
                            M2 = m2.matrix[k, j],
                            I = i,
                            J = j,
                            Res = res
                        });
                        ths.Add(t1);

                        //Multiply(m1.matrix[i,k], m2.matrix[k,j], i, j, res);
                    }
                }
            }
            foreach(var t in ths)
            {
                t.Join();
            }
            var new_m = new Matrix(m1.rows, m2.columns);

            SumElements(res, new_m);

            return new_m;
        }
        private static void Multiply(object obj)
        {
            if (obj is WorkingParams workp)
            {
                //Console.WriteLine($"{workp.M1} * {workp.M2} = {workp.M1 * workp.M2}");

                lock (workp.Res)
                {
                    workp.Res[workp.I, workp.J].Add(workp.M1 * workp.M2);
                }
            }            
        }
        private static void SumElements(List<int>[,] res, Matrix new_m)
        {
            for (int i = 0; i < new_m.rows; i++)
            {
                for (int j = 0; j < new_m.columns; j++)
                {
                    int sum = 0;
                    foreach (var k in res[i, j])
                    {
                        sum += k;
                    }
                    new_m.matrix[i, j] = sum;
                }
            }
        }
        
        public void PrintMatrix(Matrix m)
        {
            for (int i = 0; i < m.rows; i++)
            {
                for (int j = 0; j < m.columns; j++)
                {
                    Console.Write($"{m.matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("======================");
        }
        
    }
}
