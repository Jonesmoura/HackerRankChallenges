using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getTotalX
{
    public class FormingMagicSquare
    {
        public static int formingMagicSquare(List<List<int>> s)
        {
            List<List<List<int>>> magicSquares = new List<List<List<int>>> ();
            List<List<int>> magic1 = new List<List<int>>
            {
                new List<int> { 6, 1, 8 },
                new List<int> { 7, 5, 3 },
                new List<int> { 2, 9, 4 }
            };
            List<List<int>> magic2 = new List<List<int>>
            {
                new List<int> { 4, 9, 2 },
                new List<int> { 3, 5, 7 },
                new List<int> { 8, 1, 6 }
            };
            List<List<int>> magic3 = new List<List<int>>
            {
                new List<int> { 8, 1, 6 },
                new List<int> { 3, 5, 7 },
                new List<int> { 4, 9, 2 }
            };
            List<List<int>> magic4 = new List<List<int>>
            {
                new List<int> { 8, 3, 4 },
                new List<int> { 1, 5, 9 },
                new List<int> { 6, 7, 2 }
            };
            List<List<int>> magic5 = new List<List<int>>
            {
                new List<int> { 6, 7, 2 },
                new List<int> { 1, 5, 9 },
                new List<int> { 8, 3, 4 }
            };
            List<List<int>> magic6 = new List<List<int>>
            {
                new List<int> { 6, 1, 8 },
                new List<int> { 7, 5, 3 },
                new List<int> { 2, 9, 4 }
            };
            List<List<int>> magic7 = new List<List<int>>
            {
                new List<int> { 2, 9, 4 },
                new List<int> { 7, 5, 3 },
                new List<int> { 6, 1, 8 }
            };
            List<List<int>> magic8 = new List<List<int>>
            {
                new List<int> { 2, 7, 6 },
                new List<int> { 9, 5, 1 },
                new List<int> { 4, 3, 8 }
            };
            List<List<int>> magic9 = new List<List<int>>
            {
                new List<int> { 4, 3, 8 },
                new List<int> { 9, 5, 1 },
                new List<int> { 2, 7, 6 }
            };

            magicSquares.Add(magic1);
            magicSquares.Add(magic2);
            magicSquares.Add(magic3);
            magicSquares.Add(magic4);
            magicSquares.Add(magic5);
            magicSquares.Add(magic6);
            magicSquares.Add(magic7);
            magicSquares.Add(magic8);
            magicSquares.Add(magic9);

            List<int> diffs = new List<int>();

            foreach (var magic in magicSquares)
            {
                int diff = 0;
                for(int i = 0; i < 3; i++)
                {
                    for(int j =0; j < 3; j++)
                    {
                        if(magic[i][j] != s[i][j])
                        {
                            if(magic[i][j] < s[i][j])
                            {
                                diff += s[i][j] - magic[i][j];
                            }
                            else
                            {
                                diff += magic[i][j] - s[i][j];
                            }
                            
                        }
                    }

                }
                diffs.Add(diff);
            }

            return diffs.Min();

        }
    }
}
