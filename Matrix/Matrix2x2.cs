using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixArray<T>
    {
        int _rowCount;
        int _columnCount;
        T[,] matrix;

        public MatrixArray(int rowCount, int columnCount)
        {
            matrix = new T[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = default(T);
                }
            }
            _rowCount = rowCount;
            _columnCount = columnCount;
        }

        public T this[int x, int y]
        {
            get
            {
                return matrix[x, y];
            }
            set
            {
                matrix[x, y] = value;
            }
        }

        public void AddRows(int n)
        {
            T[,] temporary = new T[_rowCount + n, _columnCount];
            for (int i = 0; i < _rowCount; i++)
            {
                for (int j = 0; j < _columnCount; j++)
                    temporary[i, j] = matrix[i, j];
            }
            matrix = (T[,])temporary.Clone();
            _rowCount += n;
        }

        public void AddColumns(int n)
        {
            T[,] temporary = new T[_rowCount, _columnCount + n];
            for (int i = 0; i < _rowCount; i++)
            {
                for (int j = 0; j < _columnCount; j++)
                    temporary[i, j] = matrix[i, j];
            }

            matrix = (T[,])temporary.Clone();
            _columnCount += n;
        }

    }
}
