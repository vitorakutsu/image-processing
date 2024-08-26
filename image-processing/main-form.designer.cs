namespace image_processing
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxImageOne = new PictureBox();
            pictureBoxImageTwo = new PictureBox();
            buttonOpenImage = new Button();
            buttonClearImage = new Button();
            openFileDialog = new OpenFileDialog();
            buttonConvertToGrayWithoutDMA = new Button();
            buttonConvertToGrayWithDMA = new Button();
            buttonConvertToNegativeWithDMA = new Button();
            buttonConvertToNegativeWithoutDMA = new Button();
            buttonMirrorVerticallyWithDMA = new Button();
            buttonMirrorVerticallyWithoutDMA = new Button();
            buttonMirrorHorizontallyWithDMA = new Button();
            buttonMirrorHorizontallyWithoutDMA = new Button();
            buttonConvertToBlackAndWhiteWithDMA = new Button();
            buttonConvertToBlackAndWhiteWithoutDMA = new Button();
            buttonRotateNinetyDegreeLeftWithDMA = new Button();
            buttonRotateNinetyDegreeLeftWithoutDMA = new Button();
            buttonRotateNinetyDegreeRightWithDMA = new Button();
            buttonRotateNinetyDegreeRightWithoutDMA = new Button();
            buttonInvertRedAndBlueWithDMA = new Button();
            buttonInvertRedAndBlueWithoutDMA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageTwo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImageOne
            // 
            pictureBoxImageOne.BackColor = SystemColors.ControlLightLight;
            pictureBoxImageOne.Location = new Point(15, 19);
            pictureBoxImageOne.Margin = new Padding(10, 8, 10, 8);
            pictureBoxImageOne.Name = "pictureBoxImageOne";
            pictureBoxImageOne.Size = new Size(1455, 971);
            pictureBoxImageOne.TabIndex = 102;
            pictureBoxImageOne.TabStop = false;
            // 
            // pictureBoxImageTwo
            // 
            pictureBoxImageTwo.BackColor = SystemColors.ControlLightLight;
            pictureBoxImageTwo.Location = new Point(1529, 19);
            pictureBoxImageTwo.Margin = new Padding(10, 8, 10, 8);
            pictureBoxImageTwo.Name = "pictureBoxImageTwo";
            pictureBoxImageTwo.Size = new Size(1455, 971);
            pictureBoxImageTwo.TabIndex = 105;
            pictureBoxImageTwo.TabStop = false;
            // 
            // buttonOpenImage
            // 
            buttonOpenImage.Location = new Point(22, 1006);
            buttonOpenImage.Margin = new Padding(10, 8, 10, 8);
            buttonOpenImage.Name = "buttonOpenImage";
            buttonOpenImage.Size = new Size(252, 74);
            buttonOpenImage.TabIndex = 106;
            buttonOpenImage.Text = "Abrir Imagem";
            buttonOpenImage.UseVisualStyleBackColor = true;
            buttonOpenImage.Click += actionToOpenImage;
            // 
            // buttonClearImage
            // 
            buttonClearImage.Location = new Point(22, 1096);
            buttonClearImage.Margin = new Padding(10, 8, 10, 8);
            buttonClearImage.Name = "buttonClearImage";
            buttonClearImage.Size = new Size(252, 74);
            buttonClearImage.TabIndex = 107;
            buttonClearImage.Text = "Limpar";
            buttonClearImage.UseVisualStyleBackColor = true;
            buttonClearImage.Click += actionToClearImage;
            // 
            // buttonConvertToGrayWithoutDMA
            // 
            buttonConvertToGrayWithoutDMA.Location = new Point(291, 1007);
            buttonConvertToGrayWithoutDMA.Margin = new Padding(10, 8, 10, 8);
            buttonConvertToGrayWithoutDMA.Name = "buttonConvertToGrayWithoutDMA";
            buttonConvertToGrayWithoutDMA.Size = new Size(450, 74);
            buttonConvertToGrayWithoutDMA.TabIndex = 108;
            buttonConvertToGrayWithoutDMA.Text = "Luminância sem DMA";
            buttonConvertToGrayWithoutDMA.UseVisualStyleBackColor = true;
            buttonConvertToGrayWithoutDMA.Click += actionToConvertToGrayWithoutDMA;
            // 
            // buttonConvertToGrayWithDMA
            // 
            buttonConvertToGrayWithDMA.Location = new Point(291, 1097);
            buttonConvertToGrayWithDMA.Margin = new Padding(10, 8, 10, 8);
            buttonConvertToGrayWithDMA.Name = "buttonConvertToGrayWithDMA";
            buttonConvertToGrayWithDMA.Size = new Size(450, 74);
            buttonConvertToGrayWithDMA.TabIndex = 109;
            buttonConvertToGrayWithDMA.Text = "Luminância com DMA";
            buttonConvertToGrayWithDMA.UseVisualStyleBackColor = true;
            buttonConvertToGrayWithDMA.Click += actionToConvertToGrayWithDMA;
            // 
            // buttonConvertToNegativeWithDMA
            // 
            buttonConvertToNegativeWithDMA.Location = new Point(291, 1276);
            buttonConvertToNegativeWithDMA.Margin = new Padding(10, 8, 10, 8);
            buttonConvertToNegativeWithDMA.Name = "buttonConvertToNegativeWithDMA";
            buttonConvertToNegativeWithDMA.Size = new Size(450, 71);
            buttonConvertToNegativeWithDMA.TabIndex = 111;
            buttonConvertToNegativeWithDMA.Text = "Negativo com DMA";
            buttonConvertToNegativeWithDMA.UseVisualStyleBackColor = true;
            buttonConvertToNegativeWithDMA.Click += actionToConvertToNegativeWithDMA;
            // 
            // buttonConvertToNegativeWithoutDMA
            // 
            buttonConvertToNegativeWithoutDMA.Location = new Point(291, 1187);
            buttonConvertToNegativeWithoutDMA.Margin = new Padding(10, 8, 10, 8);
            buttonConvertToNegativeWithoutDMA.Name = "buttonConvertToNegativeWithoutDMA";
            buttonConvertToNegativeWithoutDMA.Size = new Size(450, 71);
            buttonConvertToNegativeWithoutDMA.TabIndex = 110;
            buttonConvertToNegativeWithoutDMA.Text = "Negativo sem DMA";
            buttonConvertToNegativeWithoutDMA.UseVisualStyleBackColor = true;
            buttonConvertToNegativeWithoutDMA.Click += actionToConvertToNegativeWithoutDMA;
            // 
            // buttonMirrorVerticallyWithDMA
            // 
            buttonMirrorVerticallyWithDMA.Location = new Point(761, 1097);
            buttonMirrorVerticallyWithDMA.Margin = new Padding(10, 8, 10, 8);
            buttonMirrorVerticallyWithDMA.Name = "buttonMirrorVerticallyWithDMA";
            buttonMirrorVerticallyWithDMA.Size = new Size(567, 74);
            buttonMirrorVerticallyWithDMA.TabIndex = 110;
            buttonMirrorVerticallyWithDMA.Text = "Espelhar verticalmente com DMA";
            buttonMirrorVerticallyWithDMA.UseVisualStyleBackColor = true;
            buttonMirrorVerticallyWithDMA.Click += actionToMirrorVerticallyWithDMA;
            // 
            // buttonMirrorVerticallyWithoutDMA
            // 
            buttonMirrorVerticallyWithoutDMA.Location = new Point(761, 1007);
            buttonMirrorVerticallyWithoutDMA.Margin = new Padding(10, 8, 10, 8);
            buttonMirrorVerticallyWithoutDMA.Name = "buttonMirrorVerticallyWithoutDMA";
            buttonMirrorVerticallyWithoutDMA.Size = new Size(567, 74);
            buttonMirrorVerticallyWithoutDMA.TabIndex = 110;
            buttonMirrorVerticallyWithoutDMA.Text = "Espelhar verticalmente sem DMA";
            buttonMirrorVerticallyWithoutDMA.UseVisualStyleBackColor = true;
            buttonMirrorVerticallyWithoutDMA.Click += actionToMirrorVerticallyWithoutDMA;
            // 
            // buttonMirrorHorizontallyWithDMA
            // 
            buttonMirrorHorizontallyWithDMA.Location = new Point(761, 1273);
            buttonMirrorHorizontallyWithDMA.Margin = new Padding(10, 8, 10, 8);
            buttonMirrorHorizontallyWithDMA.Name = "buttonMirrorHorizontallyWithDMA";
            buttonMirrorHorizontallyWithDMA.Size = new Size(567, 74);
            buttonMirrorHorizontallyWithDMA.TabIndex = 110;
            buttonMirrorHorizontallyWithDMA.Text = "Espelhar horizontalmente com DMA";
            buttonMirrorHorizontallyWithDMA.UseVisualStyleBackColor = true;
            buttonMirrorHorizontallyWithDMA.Click += actionToMirrorHorizontallyWithDMA;
            // 
            // buttonMirrorHorizontallyWithoutDMA
            // 
            buttonMirrorHorizontallyWithoutDMA.Location = new Point(761, 1184);
            buttonMirrorHorizontallyWithoutDMA.Margin = new Padding(10, 8, 10, 8);
            buttonMirrorHorizontallyWithoutDMA.Name = "buttonMirrorHorizontallyWithoutDMA";
            buttonMirrorHorizontallyWithoutDMA.Size = new Size(567, 74);
            buttonMirrorHorizontallyWithoutDMA.TabIndex = 110;
            buttonMirrorHorizontallyWithoutDMA.Text = "Espelhar horizontalmente sem DMA";
            buttonMirrorHorizontallyWithoutDMA.UseVisualStyleBackColor = true;
            buttonMirrorHorizontallyWithoutDMA.Click += actionToMirrorHorizontallyWithoutDMA;
            // 
            // buttonConvertToBlackAndWhiteWithDMA
            // 
            buttonConvertToBlackAndWhiteWithDMA.Location = new Point(291, 1457);
            buttonConvertToBlackAndWhiteWithDMA.Margin = new Padding(10, 8, 10, 8);
            buttonConvertToBlackAndWhiteWithDMA.Name = "buttonConvertToBlackAndWhiteWithDMA";
            buttonConvertToBlackAndWhiteWithDMA.Size = new Size(450, 66);
            buttonConvertToBlackAndWhiteWithDMA.TabIndex = 110;
            buttonConvertToBlackAndWhiteWithDMA.Text = "Preto e Branco com DMA";
            buttonConvertToBlackAndWhiteWithDMA.UseVisualStyleBackColor = true;
            buttonConvertToBlackAndWhiteWithDMA.Click += actionToConvertBlackAndWhiteWithDMA;
            // 
            // buttonConvertToBlackAndWhiteWithoutDMA
            // 
            buttonConvertToBlackAndWhiteWithoutDMA.Location = new Point(291, 1363);
            buttonConvertToBlackAndWhiteWithoutDMA.Margin = new Padding(10, 8, 10, 8);
            buttonConvertToBlackAndWhiteWithoutDMA.Name = "buttonConvertToBlackAndWhiteWithoutDMA";
            buttonConvertToBlackAndWhiteWithoutDMA.Size = new Size(450, 74);
            buttonConvertToBlackAndWhiteWithoutDMA.TabIndex = 110;
            buttonConvertToBlackAndWhiteWithoutDMA.Text = "Preto e Branco sem DMA";
            buttonConvertToBlackAndWhiteWithoutDMA.UseVisualStyleBackColor = true;
            buttonConvertToBlackAndWhiteWithoutDMA.Click += actionToConvertBlackAndWhiteWithoutDMA;
            // 
            // buttonRotateNinetyDegreeLeftWithDMA
            // 
            buttonRotateNinetyDegreeLeftWithDMA.Location = new Point(1348, 1276);
            buttonRotateNinetyDegreeLeftWithDMA.Margin = new Padding(10, 8, 10, 8);
            buttonRotateNinetyDegreeLeftWithDMA.Name = "buttonRotateNinetyDegreeLeftWithDMA";
            buttonRotateNinetyDegreeLeftWithDMA.Size = new Size(605, 71);
            buttonRotateNinetyDegreeLeftWithDMA.TabIndex = 110;
            buttonRotateNinetyDegreeLeftWithDMA.Text = "Rotacionar 90 graus a esquerda com DMA";
            buttonRotateNinetyDegreeLeftWithDMA.UseVisualStyleBackColor = true;
            buttonRotateNinetyDegreeLeftWithDMA.Click += actionToRotateNinetyDegreeLeftWithDMA;
            // 
            // buttonRotateNinetyDegreeLeftWithoutDMA
            // 
            buttonRotateNinetyDegreeLeftWithoutDMA.Location = new Point(1348, 1184);
            buttonRotateNinetyDegreeLeftWithoutDMA.Margin = new Padding(10, 8, 10, 8);
            buttonRotateNinetyDegreeLeftWithoutDMA.Name = "buttonRotateNinetyDegreeLeftWithoutDMA";
            buttonRotateNinetyDegreeLeftWithoutDMA.Size = new Size(605, 74);
            buttonRotateNinetyDegreeLeftWithoutDMA.TabIndex = 110;
            buttonRotateNinetyDegreeLeftWithoutDMA.Text = "Rotacionar 90 graus a esquerda sem DMA";
            buttonRotateNinetyDegreeLeftWithoutDMA.UseVisualStyleBackColor = true;
            buttonRotateNinetyDegreeLeftWithoutDMA.Click += actionToRotateNinetyDegreeLeftWithoutDMA;
            // 
            // buttonRotateNinetyDegreeRightWithDMA
            // 
            buttonRotateNinetyDegreeRightWithDMA.Location = new Point(1348, 1097);
            buttonRotateNinetyDegreeRightWithDMA.Margin = new Padding(10, 8, 10, 8);
            buttonRotateNinetyDegreeRightWithDMA.Name = "buttonRotateNinetyDegreeRightWithDMA";
            buttonRotateNinetyDegreeRightWithDMA.Size = new Size(605, 74);
            buttonRotateNinetyDegreeRightWithDMA.TabIndex = 110;
            buttonRotateNinetyDegreeRightWithDMA.Text = "Rotacionar 90 graus a direita com DMA";
            buttonRotateNinetyDegreeRightWithDMA.UseVisualStyleBackColor = true;
            buttonRotateNinetyDegreeRightWithDMA.Click += actionToRotateNinetyDegreeRightWithDMA;
            // 
            // buttonRotateNinetyDegreeRightWithoutDMA
            // 
            buttonRotateNinetyDegreeRightWithoutDMA.Location = new Point(1348, 1007);
            buttonRotateNinetyDegreeRightWithoutDMA.Margin = new Padding(10, 8, 10, 8);
            buttonRotateNinetyDegreeRightWithoutDMA.Name = "buttonRotateNinetyDegreeRightWithoutDMA";
            buttonRotateNinetyDegreeRightWithoutDMA.Size = new Size(605, 74);
            buttonRotateNinetyDegreeRightWithoutDMA.TabIndex = 110;
            buttonRotateNinetyDegreeRightWithoutDMA.Text = "Rotacionar 90 graus a direita sem DMA";
            buttonRotateNinetyDegreeRightWithoutDMA.UseVisualStyleBackColor = true;
            buttonRotateNinetyDegreeRightWithoutDMA.Click += actionToRotateNinetyDegreeRightWithoutDMA;
            // 
            // buttonInvertRedAndBlueWithDMA
            // 
            buttonInvertRedAndBlueWithDMA.Location = new Point(761, 1459);
            buttonInvertRedAndBlueWithDMA.Margin = new Padding(10, 8, 10, 8);
            buttonInvertRedAndBlueWithDMA.Name = "buttonInvertRedAndBlueWithDMA";
            buttonInvertRedAndBlueWithDMA.Size = new Size(567, 64);
            buttonInvertRedAndBlueWithDMA.TabIndex = 110;
            buttonInvertRedAndBlueWithDMA.Text = "Inverter vermelho e azul com DMA";
            buttonInvertRedAndBlueWithDMA.UseVisualStyleBackColor = true;
            buttonInvertRedAndBlueWithDMA.Click += actionToInvertRedAndBlueWithDMA;
            // 
            // buttonInvertRedAndBlueWithoutDMA
            // 
            buttonInvertRedAndBlueWithoutDMA.Location = new Point(761, 1363);
            buttonInvertRedAndBlueWithoutDMA.Margin = new Padding(10, 8, 10, 8);
            buttonInvertRedAndBlueWithoutDMA.Name = "buttonInvertRedAndBlueWithoutDMA";
            buttonInvertRedAndBlueWithoutDMA.Size = new Size(567, 74);
            buttonInvertRedAndBlueWithoutDMA.TabIndex = 110;
            buttonInvertRedAndBlueWithoutDMA.Text = "Inverter vermelho e azul sem DMA";
            buttonInvertRedAndBlueWithoutDMA.UseVisualStyleBackColor = true;
            buttonInvertRedAndBlueWithoutDMA.Click += actionToInvertRedAndBlueWithoutDMA;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3028, 1836);
            Controls.Add(buttonInvertRedAndBlueWithDMA);
            Controls.Add(buttonInvertRedAndBlueWithoutDMA);
            Controls.Add(buttonRotateNinetyDegreeRightWithoutDMA);
            Controls.Add(buttonRotateNinetyDegreeRightWithDMA);
            Controls.Add(buttonRotateNinetyDegreeLeftWithoutDMA);
            Controls.Add(buttonRotateNinetyDegreeLeftWithDMA);
            Controls.Add(buttonConvertToBlackAndWhiteWithDMA);
            Controls.Add(buttonConvertToBlackAndWhiteWithoutDMA);
            Controls.Add(buttonMirrorHorizontallyWithDMA);
            Controls.Add(buttonMirrorHorizontallyWithoutDMA);
            Controls.Add(buttonMirrorVerticallyWithoutDMA);
            Controls.Add(buttonMirrorVerticallyWithDMA);
            Controls.Add(buttonConvertToNegativeWithDMA);
            Controls.Add(buttonConvertToNegativeWithoutDMA);
            Controls.Add(buttonConvertToGrayWithDMA);
            Controls.Add(buttonConvertToGrayWithoutDMA);
            Controls.Add(buttonClearImage);
            Controls.Add(buttonOpenImage);
            Controls.Add(pictureBoxImageTwo);
            Controls.Add(pictureBoxImageOne);
            Margin = new Padding(10, 8, 10, 8);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageTwo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxImageOne;
        private PictureBox pictureBoxImageTwo;
        private Button buttonOpenImage;
        private Button buttonClearImage;
        private OpenFileDialog openFileDialog;
        private Button buttonConvertToGrayWithoutDMA;
        private Button buttonConvertToGrayWithDMA;
        private Button buttonConvertToNegativeWithDMA;
        private Button buttonConvertToNegativeWithoutDMA;
        private Button buttonMirrorVerticallyWithDMA;
        private Button buttonMirrorVerticallyWithoutDMA;
        private Button buttonMirrorHorizontallyWithDMA;
        private Button buttonMirrorHorizontallyWithoutDMA;
        private Button buttonConvertToBlackAndWhiteWithoutDMA; 
        private Button buttonConvertToBlackAndWhiteWithDMA;
        private Button buttonRotateNinetyDegreeLeftWithoutDMA; 
        private Button buttonRotateNinetyDegreeLeftWithDMA; 
        private Button buttonRotateNinetyDegreeRightWithoutDMA;
        private Button buttonRotateNinetyDegreeRightWithDMA;
        private Button buttonInvertRedAndBlueWithoutDMA;
        private Button buttonInvertRedAndBlueWithDMA;
    }
}
