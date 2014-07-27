using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{    
        public class MatrixList<T>
        {
            List<List<T>> matrix;

            int _column;
            int _row;

            public MatrixList(int row,int column)
            {
                matrix = new List<List<T>>();
                for(int i=0; i<row;i++)
                {
                    List<T> Row=new List<T>();
                    for (int j = 0; j < column; j++)
                    {
                        Row.Add(default(T));
                    }
                    matrix.Add(Row);
                }
                _column = column;
                _row = row;
            }

            public void AddRow(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    List<T> Row = new List<T>();
                    for (int j = 0; j < _column; j++)
                    {
                        Row.Add(default(T));
                    }
                    matrix.Add(Row);
                }
                _row += n;
            }

            public void AddColumn(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < _row; j++)
                    {
                        
                        matrix[j].Add(default(T));
                    }
                }
                _column += n;
            }
            
            public T this[int x, int y]
            {
                get 
                { 
                    return matrix[x][y]; 
                }
                set
                {
                    matrix[x][y] = value;
                }
            }

            
        }
}
