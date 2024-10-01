using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image_processing.methods
{
    internal class ImageFundamentals
    {
        public class WithDMA
        {
            public static void ConvertToGray(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int pixelSize = 3;
                int gs;

                BitmapData bitmapImage = image.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                BitmapData convertedBitmapImage = convertedImage.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                int padding = bitmapImage.Stride - width * pixelSize;

                unsafe
                {
                    byte* src = (byte*)bitmapImage.Scan0.ToPointer();
                    byte* destiny = (byte*)convertedBitmapImage.Scan0.ToPointer();

                    int r, g, b;
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            b = *src++;
                            g = *src++;
                            r = *src++;
                            gs = (int)(r * 0.2990 + g * 0.5870 + b * 0.1140);
                            *destiny++ = (byte)gs;
                            *destiny++ = (byte)gs;
                            *destiny++ = (byte)gs;
                        }
                        src += padding;
                        destiny += padding;
                    }
                }
                image.UnlockBits(bitmapImage);
                convertedImage.UnlockBits(convertedBitmapImage);
            }

            public static void ConvertToNegative(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int pixelSize = 3;

                BitmapData bitmapImage = image.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                BitmapData convertedBitmapImage = convertedImage.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                int padding = bitmapImage.Stride - width * pixelSize;

                unsafe
                {
                    byte* source = (byte*)bitmapImage.Scan0.ToPointer();
                    byte* destiny = (byte*)convertedBitmapImage.Scan0.ToPointer();

                    int r, g, b;
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            b = *source++;
                            g = *source++;
                            r = *source++;

                            *destiny++ = (byte)(255 - b);
                            *destiny++ = (byte)(255 - g);
                            *destiny++ = (byte)(255 - r);
                        }
                        source += padding;
                        destiny += padding;
                    }
                }
                image.UnlockBits(bitmapImage);
                convertedImage.UnlockBits(convertedBitmapImage);
            }

            public static void MirrorVertically(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int pixelSize = 3;

                BitmapData bitmapImage = image.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                BitmapData convertedBitmapImage = convertedImage.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                int padding = bitmapImage.Stride - width * pixelSize;

                unsafe
                {
                    byte* source = (byte*)bitmapImage.Scan0.ToPointer();
                    byte* destiny = (byte*)convertedBitmapImage.Scan0.ToPointer();
                    int r, g, b;

                    for (int y = 0; y < height; y++)
                    {
                        byte* aux = destiny;
                        aux = aux + convertedBitmapImage.Stride * (height - 1 - y);

                        for (int x = 0; x < width; x++)
                        {
                            b = *source++;
                            g = *source++;
                            r = *source++;

                            *aux++ = (byte)b;
                            *aux++ = (byte)g;
                            *aux++ = (byte)r;
                        }

                        source += padding;
                    }
                }

                image.UnlockBits(bitmapImage);
                convertedImage.UnlockBits(convertedBitmapImage);
            }

            public static void ConvertToBlackAndWhite(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int pixelSize = 3;

                BitmapData bitmapImage = image.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                BitmapData convertedBitmapImage = convertedImage.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                int padding = bitmapImage.Stride - width * pixelSize;
                int gs;

                unsafe
                {
                    byte* source = (byte*)bitmapImage.Scan0.ToPointer();
                    byte* destiny = (byte*)convertedBitmapImage.Scan0.ToPointer();

                    int r, g, b;
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            b = *source++;
                            g = *source++;
                            r = *source++;

                            gs = (int)(r * 0.2990 + g * 0.5870 + b * 0.1140);
                            byte bw = (byte)(gs < 128 ? 0 : 255);

                            *destiny++ = bw;
                            *destiny++ = bw;
                            *destiny++ = bw;
                        }
                        source += padding;
                        destiny += padding;
                    }
                }
                image.UnlockBits(bitmapImage);
                convertedImage.UnlockBits(convertedBitmapImage);
            }

            // REMAKE
            public static void MirrorHorizontally(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int pixelSize = 3;

                BitmapData bitmapImage = image.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                BitmapData convertedBitmapImage = convertedImage.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                int padding = bitmapImage.Stride - width * pixelSize;

                unsafe
                {
                    byte* source = (byte*)bitmapImage.Scan0.ToPointer();
                    byte* destiny = (byte*)convertedBitmapImage.Scan0.ToPointer();
                    int r, g, b;

                    for (int y = 0; y < width; y++)
                    {
                        byte* aux = destiny;
                        aux = aux + convertedBitmapImage.Stride * (width - 1 - y);

                        for (int x = 0; x < height; x++)
                        {
                            b = *source++;
                            g = *source++;
                            r = *source++;

                            *aux++ = (byte)b;
                            *aux++ = (byte)g;
                            *aux++ = (byte)r;
                        }

                        source += padding;
                    }
                }

                image.UnlockBits(bitmapImage);
                convertedImage.UnlockBits(convertedBitmapImage);
            }

            public static void RotateNinetyDegreeLeft(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int pixelSize = 3;

                BitmapData bitmapImage = image.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                BitmapData convertedBitmapImage = convertedImage.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                int padding = bitmapImage.Stride - width * pixelSize;

                unsafe
                {
                    byte* src = (byte*)bitmapImage.Scan0.ToPointer();
                    byte* dst = (byte*)convertedBitmapImage.Scan0.ToPointer();

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            int destX = y;
                            int destY = width - 1 - x;

                            byte* srcPixel = src + y * bitmapImage.Stride + x * pixelSize;
                            byte* destPixel = dst + destY * convertedBitmapImage.Stride + destX * pixelSize;

                            for (int i = 0; i < pixelSize; i++)
                            {
                                destPixel[i] = srcPixel[i];
                            }
                        }
                    }
                }

                image.UnlockBits(bitmapImage);
                convertedImage.UnlockBits(convertedBitmapImage);
            }

            public static void RotateNinetyDegreeRight(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int pixelSize = 3;

                BitmapData bitmapImage = image.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                BitmapData convertedBitmapImage = convertedImage.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                int padding = bitmapImage.Stride - width * pixelSize;

                unsafe
                {
                    byte* src = (byte*)bitmapImage.Scan0.ToPointer();
                    byte* dst = (byte*)convertedBitmapImage.Scan0.ToPointer();

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            int destX = height - 1 - y;
                            int destY = x;

                            byte* srcPixel = src + y * bitmapImage.Stride + x * pixelSize;
                            byte* destPixel = dst + destY * convertedBitmapImage.Stride + destX * pixelSize;

                            for (int i = 0; i < pixelSize; i++)
                            {
                                destPixel[i] = srcPixel[i];
                            }
                        }
                    }
                }

                image.UnlockBits(bitmapImage);
                convertedImage.UnlockBits(convertedBitmapImage);
            }

            public static void InvertRedToBlue(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int pixelSize = 3;

                BitmapData bitmapImage = image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                BitmapData convertedBitmapImage = convertedImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

                int padding = bitmapImage.Stride - width * pixelSize;

                unsafe
                {
                    byte* source = (byte*)bitmapImage.Scan0.ToPointer();
                    byte* destiny = (byte*)convertedBitmapImage.Scan0.ToPointer();

                    int r, g, b;

                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            b = *source++;
                            g = *source++;
                            r = *source++;

                            *destiny++ = (byte)r;
                            *destiny++ = (byte)g;
                            *destiny++ = (byte)b;
                        }

                        source += padding;
                        destiny += padding;
                    }

                    image.UnlockBits(bitmapImage);
                    convertedImage.UnlockBits(convertedBitmapImage);
                }
            }
        }

        public class WithoutDMA
        {
            public static void ConvertToGray(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int r, g, b;
                int gs;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color cor = image.GetPixel(x, y);

                        r = cor.R;
                        g = cor.G;
                        b = cor.B;
                        gs = (int)(r * 0.2990 + g * 0.5870 + b * 0.1140);

                        Color newcolor = Color.FromArgb(gs, gs, gs);

                        convertedImage.SetPixel(x, y, newcolor);
                    }
                }
            }

            public static void ConvertToNegative(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int r, g, b;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color cor = image.GetPixel(x, y);

                        r = cor.R;
                        g = cor.G;
                        b = cor.B;

                        Color newcolor = Color.FromArgb(255 - r, 255 - g, 255 - b);

                        convertedImage.SetPixel(x, y, newcolor);
                    }
                }
            }

            public static void MirrorVertically(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color topPixel = image.GetPixel(x, y);
                        Color bottomPixel = image.GetPixel(x, height - 1 - y);

                        convertedImage.SetPixel(x, y, bottomPixel);
                        convertedImage.SetPixel(x, height - 1 - y, topPixel);
                    }
                }
            }

            public static void MirrorHorizontally(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color pixel = image.GetPixel(x, y);

                        convertedImage.SetPixel(width - 1 - x, y, pixel);
                    }
                }
            }

            public static void ConvertToBlackAndWhite(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int r, g, b;
                int gs;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color cor = image.GetPixel(x, y);

                        r = cor.R;
                        g = cor.G;
                        b = cor.B;

                        gs = (int)(r * 0.2990 + g * 0.5870 + b * 0.1140);
                        byte bw = (byte)(gs < 128 ? 0 : 255);

                        Color newcolor = Color.FromArgb(bw, bw, bw);

                        convertedImage.SetPixel(x, y, newcolor);
                    }
                }

            }

            public static void RotateNinetyDegreeLeft(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color pixelColor = image.GetPixel(x, y);
                        convertedImage.SetPixel(y, width - 1 - x, pixelColor);
                    }
                }
            }

            public static void RotateNinetyDegreeRight(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color pixelColor = image.GetPixel(x, y);
                        convertedImage.SetPixel(height - 1 - y, x, pixelColor);
                    }
                }
            }

            public static void InvertRedToBlue(Bitmap image, Bitmap convertedImage)
            {
                int width = image.Width;
                int height = image.Height;
                int r, g, b;

                unsafe
                {
                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            Color cor = image.GetPixel(x, y);

                            r = cor.R;
                            g = cor.G;
                            b = cor.B;

                            Color newColor = Color.FromArgb(b, g, r);
                            convertedImage.SetPixel(x, y, newColor);
                        }
                    }
                }
            }
        }
    }
}
