using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image_processing.methods
{
    internal class ImageRepresentation
    {
        public class WithDMA
        {

        }

        public class WithoutDMA
        {
            private static bool GetNeighbours(Bitmap image, int x, int y, bool isConnectivity4)
            {
                bool hasNeighbours = false;

                if (isConnectivity4)
                {
                    if (x + 1 < image.Width && Utils.isBlack(image.GetPixel(x + 1, y))) hasNeighbours = true;
                    else if (y + 1 < image.Height && Utils.isBlack(image.GetPixel(x, y + 1))) hasNeighbours = true;
                    else if (x - 1 >= 0 && Utils.isBlack(image.GetPixel(x - 1, y))) hasNeighbours = true;
                    else if (y - 1 >= 0 && Utils.isBlack(image.GetPixel(x, y - 1))) hasNeighbours = true;
                }
                else
                {
                    if (x + 1 < image.Width && Utils.isBlack(image.GetPixel(x + 1, y))) hasNeighbours = true;
                    else if (y + 1 < image.Height && Utils.isBlack(image.GetPixel(x, y + 1))) hasNeighbours = true;
                    else if (x - 1 >= 0 && Utils.isBlack(image.GetPixel(x - 1, y))) hasNeighbours = true;
                    else if (y - 1 >= 0 && Utils.isBlack(image.GetPixel(x, y - 1))) hasNeighbours = true;
                    else if (x + 1 < image.Width && y + 1 < image.Height && Utils.isBlack(image.GetPixel(x + 1, y + 1))) hasNeighbours = true;
                    else if (x - 1 >= 0 && y + 1 < image.Height && Utils.isBlack(image.GetPixel(x - 1, y + 1))) hasNeighbours = true;
                    else if (x + 1 < image.Width && y - 1 >= 0 && Utils.isBlack(image.GetPixel(x + 1, y - 1))) hasNeighbours = true;
                    else if (x - 1 >= 0 && y - 1 >= 0 && Utils.isBlack(image.GetPixel(x - 1, y - 1))) hasNeighbours = true;
                }

                return hasNeighbours;
            }

            private static Color AverageBetweenThePixel(Bitmap image, int x, int y, int dinamicNumber)
            {
                Color[] color = new Color[dinamicNumber * dinamicNumber];

                for (int i = 0; i < dinamicNumber; i++)
                {
                    for (int j = 0; j < dinamicNumber; j++)
                    {
                        color[(i * dinamicNumber) + j] = image.GetPixel(x + i, y + j);
                    }
                }

                int r = 0, g = 0, b = 0;

                for (int i = 0; i < color.Length; i++)
                {
                    r += color[i].R;
                    g += color[i].G;
                    b += color[i].B;
                }

                return Color.FromArgb(r / (dinamicNumber * dinamicNumber), g / (dinamicNumber * dinamicNumber), b / (dinamicNumber * dinamicNumber));
            }

            private static List<(int x, int y)> GetElement(Bitmap image, int x, int y, bool isConnectivityFour)
            {
                List<(int x, int y)> toBeAuxiliary = new List<(int x, int y)>();
                List<(int x, int y)> toBeMarked = new List<(int x, int y)>();

                toBeAuxiliary.Add((x, y));
                toBeMarked.Add((x, y));

                while(toBeAuxiliary.Count > 0)
                {
                    (int x, int y) current = toBeAuxiliary[0];
                    toBeAuxiliary.RemoveAt(0);

                    // Ve o vizinho da direita, se for preto, ele salva nas Listas
                    if (current.x + 1 < image.Width && Utils.isBlack(image.GetPixel(current.x + 1, current.y)) && !toBeMarked.Contains((current.x + 1, current.y)))
                    {
                        toBeAuxiliary.Add((current.x + 1, current.y));
                        toBeMarked.Add((current.x + 1, current.y));
                    }

                    // Ve o vizinho de baixo, se for preto, ele salva nas Listas
                    if (current.y + 1 < image.Height && Utils.isBlack(image.GetPixel(current.x, current.y + 1)) && !toBeMarked.Contains((current.x, current.y + 1)))
                    {
                        toBeAuxiliary.Add((current.x, current.y + 1));
                        toBeMarked.Add((current.x, current.y + 1));
                    }

                    // Ve o vizinho da esquerda, se for preto, ele salva nas Listas
                    if (current.x - 1 >= 0 && Utils.isBlack(image.GetPixel(current.x - 1, current.y)) && !toBeMarked.Contains((current.x - 1, current.y)))
                    {
                        toBeAuxiliary.Add((current.x - 1, current.y));
                        toBeMarked.Add((current.x - 1, current.y));
                    }

                    // Ve o vizinho de cima, se for preto, ele salva nas Listas
                    if (current.y - 1 >= 0 && Utils.isBlack(image.GetPixel(current.x, current.y - 1)) && !toBeMarked.Contains((current.x, current.y - 1)))
                    {
                        toBeAuxiliary.Add((current.x, current.y - 1));
                        toBeMarked.Add((current.x, current.y - 1));
                    }

                    if(!isConnectivityFour)
                    {
                        // Ve o vizinho inferior direito, se for preto, ele salva nas Listas
                        if(current.x + 1 < image.Width && current.y + 1 < image.Height && Utils.isBlack(image.GetPixel(current.x + 1, current.y + 1)) && !toBeMarked.Contains((current.x + 1, current.y + 1)))
                        {
                            toBeAuxiliary.Add((current.x + 1, current.y + 1));
                            toBeMarked.Add((current.x + 1, current.y + 1));
                        }

                        // Ve o vizinho superior direito, se for preto, ele salva nas Listas
                        if(current.x + 1 < image.Width && current.y - 1 >= 0 && Utils.isBlack(image.GetPixel(current.x + 1, current.y - 1)) && !toBeMarked.Contains((current.x + 1, current.y - 1)))
                        {
                            toBeAuxiliary.Add((current.x + 1, current.y - 1));
                            toBeMarked.Add((current.x + 1, current.y - 1));
                        }

                        // Ve o vizinho inferior esquerdo, se for preto, ele salva nas Listas
                        if (current.x - 1 >= 0 && current.y + 1 < image.Height && Utils.isBlack(image.GetPixel(current.x - 1, current.y + 1)) && !toBeMarked.Contains((current.x - 1, current.y + 1)))
                        {
                            toBeAuxiliary.Add((current.x - 1, current.y + 1));
                            toBeMarked.Add((current.x - 1, current.y + 1));
                        }

                        // Ve o vizinho superior esquerdo, se for preto, ele salva nas Listas
                        if (current.x - 1 >= 0 && current.y - 1 >= 0 && Utils.isBlack(image.GetPixel(current.x - 1, current.y - 1)) && !toBeMarked.Contains((current.x - 1, current.y - 1)))
                        {
                            toBeAuxiliary.Add((current.x - 1, current.y - 1));
                            toBeMarked.Add((current.x - 1, current.y - 1));
                        }
                    }

                }

                return toBeMarked;
            }

            private static Color GetColorByIndex(int index)
            {
                switch (index) 
                {
                    case 0:
                        return Color.FromArgb(255, 0, 0);
                    case 1:
                        return Color.FromArgb(0, 255, 0);
                    case 2:
                        return Color.FromArgb(0, 0, 255);
                    case 3:
                        return Color.FromArgb(255, 255, 0);
                    case 4:
                        return Color.FromArgb(255, 0, 255);
                    case 5:
                        return Color.FromArgb(0, 255, 255);
                    case 6:
                        return Color.FromArgb(255, 255, 255);
                    case 7:
                        return Color.FromArgb(0, 0, 0);
                    default:
                        return Color.FromArgb(0, 0, 0);
                }

            }

            public static void Connectivity4(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int colors = 0;

                List<(int x, int y)> toBeMarked = new List<(int x, int y)>();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (Utils.isBlack(image.GetPixel(x, y))) toBeMarked = GetElement(image, x, y, true);

                        if (toBeMarked.Count > 0)
                        {
                            foreach (var value in toBeMarked)
                            {
                                image.SetPixel(value.x, value.y, GetColorByIndex(colors));
                                convertedImage.SetPixel(value.x, value.y, GetColorByIndex(colors));
                            }

                            toBeMarked.Clear();
                            colors++;
                        }

                    }
                }
            }

            public static void Connectivity8(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int colors = 0;

                List<(int x, int y)> toBeMarked = new List<(int x, int y)>();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (Utils.isBlack(image.GetPixel(x, y))) toBeMarked = GetElement(image, x, y, false);

                        if(toBeMarked.Count > 0)
                        {
                            foreach(var value in toBeMarked)
                            {
                                image.SetPixel(value.x, value.y, GetColorByIndex(colors));
                                convertedImage.SetPixel(value.x, value.y, GetColorByIndex(colors));
                            }

                            toBeMarked.Clear();
                            colors++;
                        }

                    }
                }
            }

            public static void ReduceByHalf(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;

                for (int y = 0; y < height - 1; y+=2)
                {
                    for (int x = 0; x < width - 1; x+=2)
                    {
                        convertedImage.SetPixel(x / 2, y / 2, AverageBetweenThePixel(image, x, y, 2));
                    }
                }
            }

            public static void ReduceByDinamicValue(Bitmap image, Bitmap convertedImage, int dinamicValue)
            {
                int width = image.Width;
                int height = image.Height;

                for (int y = 0; y < height - 1; y += dinamicValue)
                {
                    for (int x = 0; x < width - 1; x += dinamicValue)
                    {
                        convertedImage.SetPixel(x / dinamicValue, y / dinamicValue, AverageBetweenThePixel(image, x, y, dinamicValue));
                    }
                }
            }
        }
    }
}
