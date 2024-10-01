using image_processing.methods;
using System.Drawing.Imaging;

namespace image_processing
{
    public partial class MainForm : Form
    {
        private Image image;
        private Bitmap imageBitmap;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ActionToOpenImage(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Images as (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pictureBoxImageOne.Image = image;
                pictureBoxImageOne.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void ActionToClearImage(object sender, EventArgs e)
        {
            pictureBoxImageOne.Image = pictureBoxImageTwo.Image = null;
        }

        private void ActionToSaveImage(object sender, EventArgs e)
        {
            if (pictureBoxImageTwo.Image == null)
            {
                MessageBox.Show("Nenhuma imagem convertida disponível para salvar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif";
                saveFileDialog.Title = "Save Image File";
                saveFileDialog.FileName = "converted_image";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileExtension = System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower();

                    ImageFormat format = ImageFormat.Png;
                    if (fileExtension == ".jpg" || fileExtension == ".jpeg")
                    {
                        format = ImageFormat.Jpeg;
                    }
                    else if (fileExtension == ".bmp")
                    {
                        format = ImageFormat.Bmp;
                    }
                    else if (fileExtension == ".gif")
                    {
                        format = ImageFormat.Gif;
                    }

                    pictureBoxImageTwo.Image.Save(saveFileDialog.FileName, format);
                    MessageBox.Show("Imagem salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ApplyFilter(Action<Bitmap, Bitmap> filterMethod)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filterMethod(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void ActionToConvertToGrayWithoutDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithoutDMA.ConvertToGray);
        }

        private void ActionToConvertToNegativeWithoutDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithoutDMA.ConvertToNegative);
        }

        private void ActionToMirrorVerticallyWithoutDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithoutDMA.MirrorVertically);
        }
        
        private void ActionToMirrorHorizontallyWithoutDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithoutDMA.MirrorHorizontally);
        }

        private void ActionToConvertBlackAndWhiteWithoutDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithoutDMA.ConvertToBlackAndWhite);
        }

        private void ActionToRotateNinetyDegreeLeftWithoutDMA(object sender, EventArgs e)
        {
            ApplyFilter((bmp, converted) =>
            {
                ImageFundamentals.WithoutDMA.RotateNinetyDegreeLeft(bmp, converted);
                image = converted;
            });
        }

        private void ActionToRotateNinetyDegreeRightWithoutDMA(object sender, EventArgs e)
        {
            ApplyFilter((bmp, converted) =>
            {
                ImageFundamentals.WithoutDMA.RotateNinetyDegreeRight(bmp, converted);
                image = converted;
            });
        }

        private void ActionToInvertRedAndBlueWithoutDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithoutDMA.InvertRedToBlue);
        }

        private void ActionToConnectivity4WithoutDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageRepresentation.WithoutDMA.Connectivity4);
        }

        private void ActionToConnectivity8WithoutDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageRepresentation.WithoutDMA.Connectivity8);
        }

        private void ActionToReduceByHalf(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image.Width / 2, image.Height / 2);
            imageBitmap = (Bitmap)image;
            ImageRepresentation.WithoutDMA.ReduceByHalf(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void ActionToReduceByDinamicValue(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image.Width / 4, image.Height / 4);
            imageBitmap = (Bitmap)image;
            ImageRepresentation.WithoutDMA.ReduceByDinamicValue(imageBitmap, convertedImage, 4);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void ActionToBitPlaneSlicingWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            ImageHighlight.WithoutDMA.BitPlaneSlicing(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void ActionToHistogramEqualizationWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            ImageHighlight.WithoutDMA.HistogramEqualization(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void ActionToFilterSmoothingByAverageWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image.Width - 2, image.Height - 2);
            imageBitmap = (Bitmap)image;
            ImageHighlight.WithoutDMA.FilterSmoothingByAverage(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void ActionToFilterSmoothingByMedianWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image.Width - 2, image.Height - 2);
            imageBitmap = (Bitmap)image;
            ImageHighlight.WithoutDMA.FilterSmoothingByMedian(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void ActionToFilterSmoothingByKNeighboursWithoutDMA(object sender, EventArgs e) {
            Bitmap convertedImage = new Bitmap(image.Width - 2, image.Height - 2);
            imageBitmap = (Bitmap)image;
            ImageHighlight.WithoutDMA.FilterSmoothingByKNeighbours(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void ActionToConvertToGrayWithDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithDMA.ConvertToGray);
        }

        private void ActionToConvertToNegativeWithDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithDMA.ConvertToNegative);
        }

        private void ActionToMirrorVerticallyWithDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithDMA.MirrorVertically);
        }

        private void ActionToMirrorHorizontallyWithDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithDMA.MirrorHorizontally);
        }

        private void ActionToConvertBlackAndWhiteWithDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithDMA.ConvertToBlackAndWhite);
        }

        private void ActionToRotateNinetyDegreeLeftWithDMA(object sender, EventArgs e)
        {
            ApplyFilter((bmp, converted) =>
            {
                ImageFundamentals.WithDMA.RotateNinetyDegreeLeft(bmp, converted);
                image = converted;
            });
        }

        private void ActionToRotateNinetyDegreeRightWithDMA(object sender, EventArgs e)
        {
            ApplyFilter((bmp, converted) =>
            {
                ImageFundamentals.WithDMA.RotateNinetyDegreeRight(bmp, converted);
                image = converted;
            });
        }

        private void ActionToInvertRedAndBlueWithDMA(object sender, EventArgs e)
        {
            ApplyFilter(ImageFundamentals.WithDMA.InvertRedToBlue);
        }
    }
}
