using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace image_processing.methods
{
    internal class ImageHighlight
    {
        public class WithoutDMA
        {
            private static int[] GetColorBits (int color)
            {
                int[] bits = new int[8];
                for (int i = 0; i < 8; i++)
                {
                    bits[i] = color % 2;
                    color = color / 2;
                }

                return bits;
            }

            private static int BitToInt(int[] bits, int layer)
            {
                if (bits[layer] == 1) return 255;

                return 0;
            }

            private static Color GetPixel(Color color, int layer)
            {
                int[] a = GetColorBits(color.A);
                int[] r = GetColorBits(color.R);
                int[] g = GetColorBits(color.G);
                int[] b = GetColorBits(color.B);

                return Color.FromArgb(BitToInt(a, layer), BitToInt(r, layer), BitToInt(g, layer), BitToInt(b, layer));
            }

            private static Color GetAverageNeighbours(Bitmap image, int x, int y)
            {
                int index = 0;
                int[] a = new int[25];
                int[] r = new int[25];
                int[] g = new int[25];
                int[] b = new int[25];

                for(int i = x - 2; i <= x + 2; i++)
                {
                    for(int j = y - 2; j <= y + 2; j++)
                    {
                        a[index] = image.GetPixel(i, j).A;
                        r[index] = image.GetPixel(i, j).R;
                        g[index] = image.GetPixel(i, j).G;
                        b[index] = image.GetPixel(i, j).B;

                        index++;
                    }
                }

                return Color.FromArgb((int)Math.Round(a.Average()), (int)Math.Round(r.Average()), (int)Math.Round(g.Average()), (int)Math.Round(b.Average()));
            }

            private static Color GetMedianNeighbours(Bitmap image, int x, int y)
            {
                int index = 0;
                int[] a = new int[25];
                int[] r = new int[25];
                int[] g = new int[25];
                int[] b = new int[25];

                for (int i = x - 2; i <= x + 2; i++)
                {
                    for (int j = y - 2; j <= y + 2; j++)
                    {
                        a[index] = image.GetPixel(i, j).A;
                        r[index] = image.GetPixel(i, j).R;
                        g[index] = image.GetPixel(i, j).G;
                        b[index] = image.GetPixel(i, j).B;

                        index++;
                    }
                }

                return Color.FromArgb(a.Order().ElementAt(12), r.Order().ElementAt(12), g.Order().ElementAt(12), b.Order().ElementAt(12));
            }

            private static int GetNearValues(int[] values, int value)
            {
                int count = 0;
                int index = 0;
                bool stop = false;

                for(int i = 0; i < values.Length; i++)
                {
                    if (!stop && value == values[i])
                    {
                        index = i;
                        stop = true;
                    }
                }

                int minIndex = index, maxIndex = index;

                while (maxIndex - minIndex != 9)
                {
                    if (maxIndex + 1 < values.Length && minIndex - 1 >= 0)
                    {
                        if (value - values[minIndex - 1] < values[maxIndex + 1] - value) minIndex--;
                        else maxIndex++;
                    }
                    else
                    {
                        if (minIndex - 1 < 0) maxIndex++;
                        else minIndex--;
                    }
                }

                for(int i = minIndex; i < maxIndex; i++)
                {
                    count += values[i];
                }

                return count;
            }

            private static Color GetKNeighbours(Bitmap image, int x, int y)
            {
                int index = 0;

                int[] a = new int[25];
                int[] r = new int[25];
                int[] g = new int[25];
                int[] b = new int[25];

                for (int i = x - 2; i <= x + 2; i++)
                {
                    for (int j = y - 2; j <= y + 2; j++)
                    {
                        a[index] = image.GetPixel(i, j).A;
                        r[index] = image.GetPixel(i, j).R;
                        g[index] = image.GetPixel(i, j).G;
                        b[index] = image.GetPixel(i, j).B;

                        index++;
                    }
                }

                a = a.Order().ToArray();
                r = r.Order().ToArray();
                g = g.Order().ToArray();
                b = b.Order().ToArray();

                return Color.FromArgb(GetNearValues(a, image.GetPixel(x, y).A) / 9, GetNearValues(r, image.GetPixel(x, y).R) / 9, GetNearValues(g, image.GetPixel(x, y).G) / 9, GetNearValues(b, image.GetPixel(x, y).B) / 9);
            }

            public static void BitPlaneSlicing(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;

                for (int i = 7; i >= 0; i--)
                {
                    for (int x = 0; x < width - 1; x++)
                    {
                        for (int y = 0; y < height - 1; y++)
                        {
                            convertedImage.SetPixel(x, y, GetPixel(image.GetPixel(x, y), i));
                        }
                    }
                    convertedImage.Save("C:\\Users\\VITOR\\Documents\\image-processing\\image-processing\\assets\\images\\bits-slicing\\slicing" +(i) + ".png");
                }
            }

            public static void HistogramEqualization(Bitmap image, Bitmap convertedImage)
            {
                Bitmap imageGray = new Bitmap(image.Width, image.Height);

                int width = image.Width;
                int height = image.Height;
                int I = (width * height) / 255;
                int[,] table = new int[256, 3];
                int r;

                ImageFundamentals.WithDMA.ConvertToGray(image, imageGray);
                image = imageGray;

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        r = image.GetPixel(x, y).R;

                        table[r, 0]++;
                    }
                }

                for(int x = 0; x < table.GetLength(0) - 1; x++)
                {
                    if (x == 0) table[x, 1] = table[x, 0];
                    table[x + 1, 1] = table[x + 1, 0] + table[x, 1];
                }

                for(int x = 0; x < table.GetLength(0) - 1; x++)
                {
                    int q = (int)Math.Round((double)table[x, 1] / I);
                    int value = Math.Max(0, q);

                    table[x, 2] = value;
                }

                //for (int i = 0; i < 3; i++)
                //{
                //    Console.WriteLine("I = " + i);
                //    for (int x = 0; x < 256; x++)
                //    {
                //        Console.WriteLine(table[x, i]);
                //    }
                //}

                for (int y = 0; y < height; y++)
                {
                    for(int x = 0; x < width; x++)
                    {
                        r = image.GetPixel(x, y).R;
                        convertedImage.SetPixel(x, y, Color.FromArgb(table[r, 2], table[r, 2], table[r, 2]));
                    }
                }
            }

            public static void FilterSmoothingByAverage(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;

                for (int y = 2; y < height - 2; y++)
                {
                    for(int x = 2; x < width - 2; x++)
                    {
                        convertedImage.SetPixel(x - 2, y - 2, GetAverageNeighbours(image, x, y));
                    }
                }
            }

            public static void FilterSmoothingByMedian(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;

                for (int y = 2; y < height - 2; y++)
                {
                    for (int x = 2; x < width - 2; x++)
                    {
                        convertedImage.SetPixel(x - 2, y - 2, GetMedianNeighbours(image, x, y));
                    }
                }
            }

            public static void FilterSmoothingByKNeighbours(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;

                for(int y = 2; y < height - 2; y++)
                {
                    for(int x = 2; x < width - 2; x++)
                    {
                        convertedImage.SetPixel(x - 2, y - 2, GetKNeighbours(image, x, y));
                    }
                }
            }
        }
    }
}
