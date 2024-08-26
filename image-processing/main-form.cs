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

        private void actionToOpenImage(object sender, EventArgs e)
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

        private void actionToClearImage(object sender, EventArgs e)
        {
            pictureBoxImageOne.Image = pictureBoxImageTwo.Image = null;
        }

        private void actionToConvertToGrayWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.convertToGray_withoutDMA(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToConvertToGrayWithDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.convertToGray_withDMA(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToConvertToNegativeWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.convertToNegative_withoutDMA(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToConvertToNegativeWithDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.convertToNegative_withDMA(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToMirrorVerticallyWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.mirrorVertically_withoutDMA(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToMirrorVerticallyWithDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.mirrorVertically_withDMA(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToMirrorHorizontallyWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.mirrorHorizontally_withoutDMA(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToMirrorHorizontallyWithDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.mirrorHorizontally_withDMA(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToConvertBlackAndWhiteWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.convertToBlackAndWhite_withoutDMA(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToConvertBlackAndWhiteWithDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.convertToBlackAndWhite_withDMA(imageBitmap, convertedImage);
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToRotateNinetyDegreeLeftWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.rotateNinetyDegreeLeft_withoutDMA(imageBitmap, convertedImage);
            image = convertedImage;
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToRotateNinetyDegreeLeftWithDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.rotateNinetyDegreeLeft_withDMA(imageBitmap, convertedImage);
            image = convertedImage;
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToRotateNinetyDegreeRightWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.rotateNinetyDegreeRight_withoutDMA(imageBitmap, convertedImage);
            image = convertedImage;
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToRotateNinetyDegreeRightWithDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.rotateNinetyDegreeRight_withDMA(imageBitmap, convertedImage);
            image = convertedImage;
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToInvertRedAndBlueWithoutDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.invertRedToBlue_withoutDMA(imageBitmap, convertedImage);
            image = convertedImage;
            pictureBoxImageTwo.Image = convertedImage;
        }

        private void actionToInvertRedAndBlueWithDMA(object sender, EventArgs e)
        {
            Bitmap convertedImage = new Bitmap(image);
            imageBitmap = (Bitmap)image;
            filters.invertRedToBlue_withDMA(imageBitmap, convertedImage);
            image = convertedImage;
            pictureBoxImageTwo.Image = convertedImage;
        }
    }
}
