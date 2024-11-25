using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__5
{
    public class Calculation
    {
        private static double CalculationSlope(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2)
            {
                return double.PositiveInfinity;
            }
            return (double)(y2 - y1) / (x2 - x1);
        }

        public static int[,] LoadPoints(string filename)
        {
            var lines = System.IO.File.ReadAllLines(filename);
            var A = int.Parse(lines[0]);
            var dots = new int[A, 2];
            for (var i = 0; i < A; i++)
            {
                var coords = lines[i + 1].Split(' ');
                dots[i, 0] = int.Parse(coords[0]);
                dots[i, 1] = int.Parse(coords[1]);
            }
            return dots;
        }

        public static int[,] BruteForceLines(int[,] dot, double error = 0.001)
        {
            var A = dot.GetLength(0);
            var maxLines = (A * (A - 1)) / 2;
            var lines = new int[maxLines, 8];
            var linecount = 0;

            for (var i = 0; i < A; i++)
            {
                for (var j = i + 1; j < A; j++)
                {
                    for (var k = j + 1; k < A; k++)
                    {
                        for (var l = k + 1; l < A; l++)
                        {
                            var slope1 = CalculationSlope(dot[i, 0], dot[i, 1], dot[j, 0], dot[j, 1]);
                            var slope2 = CalculationSlope(dot[i, 0], dot[i, 1], dot[k, 0], dot[k, 1]);
                            var slope3 = CalculationSlope(dot[i, 0], dot[i, 1], dot[l, 0], dot[l, 1]);

                            if (Math.Abs(slope1 - slope2) < error && Math.Abs(slope1 - slope3) < error)
                            {
                                lines[linecount, 0] = dot[i, 0];
                                lines[linecount, 1] = dot[i, 1];
                                lines[linecount, 2] = dot[j, 0];
                                lines[linecount, 3] = dot[j, 1];
                                lines[linecount, 4] = dot[k, 0];
                                lines[linecount, 5] = dot[k, 1];
                                lines[linecount, 6] = dot[l, 0];
                                lines[linecount, 7] = dot[l, 1];

                                linecount++;
                            }
                        }
                    }
                }
            }
            var result = new int[linecount, 8];
            Array.Copy(lines, result, linecount * 8);
            return result;
        }
        public static int[,] IntelectualLines(int[,] dot, double error = 0.001)
        {
            var A = dot.GetLength(0);
            var lines = new List<int[]>();

            for (var i = 0; i < A; i++)
            {
                var slopes = new Dictionary<double, List<int[]>>();

                for (var j = 0; j < A; j++)
                {
                    if (i != j)
                    {
                        double slope = CalculationSlope(dot[i, 0], dot[i, 1], dot[j, 0], dot[j, 1]);
                        bool found = false;

                        foreach (var key in slopes.Keys)
                        {
                            if (Math.Abs(key - slope) < error)
                            {
                                slopes[key].Add(new int[] { dot[j, 0], dot[j, 1] });
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            slopes[slope] = new List<int[]> { new int[] { dot[i, 0], dot[i, 1] }, new int[] { dot[j, 0], dot[j, 1] } };
                        }
                    }
                }

                foreach (var linePoints in slopes.Values)
                {
                    if (linePoints.Count >= 4)
                    {
                        var lineArray = new int[8];
                        for (int k = 0; k < 4; k++)
                        {
                            lineArray[k * 2] = linePoints[k][0];
                            lineArray[k * 2 + 1] = linePoints[k][1];
                        }
                        lines.Add(lineArray);
                    }
                }
            }

            var result = new int[lines.Count, 8];
            for (int i = 0; i < lines.Count; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    result[i, j] = lines[i][j];
                }
            }
            return result;
        }
    }
}
