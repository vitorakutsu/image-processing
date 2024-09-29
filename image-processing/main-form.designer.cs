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
            pictureBoxImageOne.Location = new Point(6, 7);
            pictureBoxImageOne.Margin = new Padding(4, 3, 4, 3);
            pictureBoxImageOne.Name = "pictureBoxImageOne";
            pictureBoxImageOne.Size = new Size(599, 355);
            pictureBoxImageOne.TabIndex = 102;
            pictureBoxImageOne.TabStop = false;
            // 
            // pictureBoxImageTwo
            // 
            pictureBoxImageTwo.BackColor = SystemColors.ControlLightLight;
            pictureBoxImageTwo.Location = new Point(630, 7);
            pictureBoxImageTwo.Margin = new Padding(4, 3, 4, 3);
            pictureBoxImageTwo.Name = "pictureBoxImageTwo";
            pictureBoxImageTwo.Size = new Size(599, 355);
            pictureBoxImageTwo.TabIndex = 105;
            pictureBoxImageTwo.TabStop = false;
            // 
            // buttonOpenImage
            // 
            buttonOpenImage.Location = new Point(9, 368);
            buttonOpenImage.Margin = new Padding(4, 3, 4, 3);
            buttonOpenImage.Name = "buttonOpenImage";
            buttonOpenImage.Size = new Size(104, 27);
            buttonOpenImage.TabIndex = 106;
            buttonOpenImage.Text = "Abrir Imagem";
            buttonOpenImage.UseVisualStyleBackColor = true;
            buttonOpenImage.Click += actionToOpenImage;
            // 
            // buttonClearImage
            // 
            buttonClearImage.Location = new Point(9, 401);
            buttonClearImage.Margin = new Padding(4, 3, 4, 3);
            buttonClearImage.Name = "buttonClearImage";
            buttonClearImage.Size = new Size(104, 27);
            buttonClearImage.TabIndex = 107;
            buttonClearImage.Text = "Limpar";
            buttonClearImage.UseVisualStyleBackColor = true;
            buttonClearImage.Click += actionToClearImage;
            // 
            // buttonConvertToGrayWithoutDMA
            // 
            buttonConvertToGrayWithoutDMA.Location = new Point(120, 368);
            buttonConvertToGrayWithoutDMA.Margin = new Padding(4, 3, 4, 3);
            buttonConvertToGrayWithoutDMA.Name = "buttonConvertToGrayWithoutDMA";
            buttonConvertToGrayWithoutDMA.Size = new Size(185, 27);
            buttonConvertToGrayWithoutDMA.TabIndex = 108;
            buttonConvertToGrayWithoutDMA.Text = "Luminância sem DMA";
            buttonConvertToGrayWithoutDMA.UseVisualStyleBackColor = true;
            buttonConvertToGrayWithoutDMA.Click += actionToConvertToGrayWithoutDMA;
            // 
            // buttonConvertToGrayWithDMA
            // 
            buttonConvertToGrayWithDMA.Location = new Point(120, 401);
            buttonConvertToGrayWithDMA.Margin = new Padding(4, 3, 4, 3);
            buttonConvertToGrayWithDMA.Name = "buttonConvertToGrayWithDMA";
            buttonConvertToGrayWithDMA.Size = new Size(185, 27);
            buttonConvertToGrayWithDMA.TabIndex = 109;
            buttonConvertToGrayWithDMA.Text = "Luminância com DMA";
            buttonConvertToGrayWithDMA.UseVisualStyleBackColor = true;
            buttonConvertToGrayWithDMA.Click += actionToConvertToGrayWithDMA;
            // 
            // buttonConvertToNegativeWithDMA
            // 
            buttonConvertToNegativeWithDMA.Location = new Point(120, 467);
            buttonConvertToNegativeWithDMA.Margin = new Padding(4, 3, 4, 3);
            buttonConvertToNegativeWithDMA.Name = "buttonConvertToNegativeWithDMA";
            buttonConvertToNegativeWithDMA.Size = new Size(185, 26);
            buttonConvertToNegativeWithDMA.TabIndex = 111;
            buttonConvertToNegativeWithDMA.Text = "Negativo com DMA";
            buttonConvertToNegativeWithDMA.UseVisualStyleBackColor = true;
            buttonConvertToNegativeWithDMA.Click += actionToConvertToNegativeWithDMA;
            // 
            // buttonConvertToNegativeWithoutDMA
            // 
            buttonConvertToNegativeWithoutDMA.Location = new Point(120, 434);
            buttonConvertToNegativeWithoutDMA.Margin = new Padding(4, 3, 4, 3);
            buttonConvertToNegativeWithoutDMA.Name = "buttonConvertToNegativeWithoutDMA";
            buttonConvertToNegativeWithoutDMA.Size = new Size(185, 26);
            buttonConvertToNegativeWithoutDMA.TabIndex = 110;
            buttonConvertToNegativeWithoutDMA.Text = "Negativo sem DMA";
            buttonConvertToNegativeWithoutDMA.UseVisualStyleBackColor = true;
            buttonConvertToNegativeWithoutDMA.Click += actionToConvertToNegativeWithoutDMA;
            // 
            // buttonMirrorVerticallyWithDMA
            // 
            buttonMirrorVerticallyWithDMA.Location = new Point(313, 401);
            buttonMirrorVerticallyWithDMA.Margin = new Padding(4, 3, 4, 3);
            buttonMirrorVerticallyWithDMA.Name = "buttonMirrorVerticallyWithDMA";
            buttonMirrorVerticallyWithDMA.Size = new Size(233, 27);
            buttonMirrorVerticallyWithDMA.TabIndex = 110;
            buttonMirrorVerticallyWithDMA.Text = "Espelhar verticalmente com DMA";
            buttonMirrorVerticallyWithDMA.UseVisualStyleBackColor = true;
            buttonMirrorVerticallyWithDMA.Click += actionToMirrorVerticallyWithDMA;
            // 
            // buttonMirrorVerticallyWithoutDMA
            // 
            buttonMirrorVerticallyWithoutDMA.Location = new Point(313, 368);
            buttonMirrorVerticallyWithoutDMA.Margin = new Padding(4, 3, 4, 3);
            buttonMirrorVerticallyWithoutDMA.Name = "buttonMirrorVerticallyWithoutDMA";
            buttonMirrorVerticallyWithoutDMA.Size = new Size(233, 27);
            buttonMirrorVerticallyWithoutDMA.TabIndex = 110;
            buttonMirrorVerticallyWithoutDMA.Text = "Espelhar verticalmente sem DMA";
            buttonMirrorVerticallyWithoutDMA.UseVisualStyleBackColor = true;
            buttonMirrorVerticallyWithoutDMA.Click += actionToMirrorVerticallyWithoutDMA;
            // 
            // buttonMirrorHorizontallyWithDMA
            // 
            buttonMirrorHorizontallyWithDMA.Location = new Point(313, 466);
            buttonMirrorHorizontallyWithDMA.Margin = new Padding(4, 3, 4, 3);
            buttonMirrorHorizontallyWithDMA.Name = "buttonMirrorHorizontallyWithDMA";
            buttonMirrorHorizontallyWithDMA.Size = new Size(233, 27);
            buttonMirrorHorizontallyWithDMA.TabIndex = 110;
            buttonMirrorHorizontallyWithDMA.Text = "Espelhar horizontalmente com DMA";
            buttonMirrorHorizontallyWithDMA.UseVisualStyleBackColor = true;
            buttonMirrorHorizontallyWithDMA.Click += actionToMirrorHorizontallyWithDMA;
            // 
            // buttonMirrorHorizontallyWithoutDMA
            // 
            buttonMirrorHorizontallyWithoutDMA.Location = new Point(313, 433);
            buttonMirrorHorizontallyWithoutDMA.Margin = new Padding(4, 3, 4, 3);
            buttonMirrorHorizontallyWithoutDMA.Name = "buttonMirrorHorizontallyWithoutDMA";
            buttonMirrorHorizontallyWithoutDMA.Size = new Size(233, 27);
            buttonMirrorHorizontallyWithoutDMA.TabIndex = 110;
            buttonMirrorHorizontallyWithoutDMA.Text = "Espelhar horizontalmente sem DMA";
            buttonMirrorHorizontallyWithoutDMA.UseVisualStyleBackColor = true;
            buttonMirrorHorizontallyWithoutDMA.Click += actionToMirrorHorizontallyWithoutDMA;
            // 
            // buttonConvertToBlackAndWhiteWithDMA
            // 
            buttonConvertToBlackAndWhiteWithDMA.Location = new Point(120, 533);
            buttonConvertToBlackAndWhiteWithDMA.Margin = new Padding(4, 3, 4, 3);
            buttonConvertToBlackAndWhiteWithDMA.Name = "buttonConvertToBlackAndWhiteWithDMA";
            buttonConvertToBlackAndWhiteWithDMA.Size = new Size(185, 24);
            buttonConvertToBlackAndWhiteWithDMA.TabIndex = 110;
            buttonConvertToBlackAndWhiteWithDMA.Text = "Preto e Branco com DMA";
            buttonConvertToBlackAndWhiteWithDMA.UseVisualStyleBackColor = true;
            buttonConvertToBlackAndWhiteWithDMA.Click += actionToConvertBlackAndWhiteWithDMA;
            // 
            // buttonConvertToBlackAndWhiteWithoutDMA
            // 
            buttonConvertToBlackAndWhiteWithoutDMA.Location = new Point(120, 499);
            buttonConvertToBlackAndWhiteWithoutDMA.Margin = new Padding(4, 3, 4, 3);
            buttonConvertToBlackAndWhiteWithoutDMA.Name = "buttonConvertToBlackAndWhiteWithoutDMA";
            buttonConvertToBlackAndWhiteWithoutDMA.Size = new Size(185, 27);
            buttonConvertToBlackAndWhiteWithoutDMA.TabIndex = 110;
            buttonConvertToBlackAndWhiteWithoutDMA.Text = "Preto e Branco sem DMA";
            buttonConvertToBlackAndWhiteWithoutDMA.UseVisualStyleBackColor = true;
            buttonConvertToBlackAndWhiteWithoutDMA.Click += actionToConvertBlackAndWhiteWithoutDMA;
            // 
            // buttonRotateNinetyDegreeLeftWithDMA
            // 
            buttonRotateNinetyDegreeLeftWithDMA.Location = new Point(555, 467);
            buttonRotateNinetyDegreeLeftWithDMA.Margin = new Padding(4, 3, 4, 3);
            buttonRotateNinetyDegreeLeftWithDMA.Name = "buttonRotateNinetyDegreeLeftWithDMA";
            buttonRotateNinetyDegreeLeftWithDMA.Size = new Size(249, 26);
            buttonRotateNinetyDegreeLeftWithDMA.TabIndex = 110;
            buttonRotateNinetyDegreeLeftWithDMA.Text = "Rotacionar 90 graus a esquerda com DMA";
            buttonRotateNinetyDegreeLeftWithDMA.UseVisualStyleBackColor = true;
            buttonRotateNinetyDegreeLeftWithDMA.Click += actionToRotateNinetyDegreeLeftWithDMA;
            // 
            // buttonRotateNinetyDegreeLeftWithoutDMA
            // 
            buttonRotateNinetyDegreeLeftWithoutDMA.Location = new Point(555, 433);
            buttonRotateNinetyDegreeLeftWithoutDMA.Margin = new Padding(4, 3, 4, 3);
            buttonRotateNinetyDegreeLeftWithoutDMA.Name = "buttonRotateNinetyDegreeLeftWithoutDMA";
            buttonRotateNinetyDegreeLeftWithoutDMA.Size = new Size(249, 27);
            buttonRotateNinetyDegreeLeftWithoutDMA.TabIndex = 110;
            buttonRotateNinetyDegreeLeftWithoutDMA.Text = "Rotacionar 90 graus a esquerda sem DMA";
            buttonRotateNinetyDegreeLeftWithoutDMA.UseVisualStyleBackColor = true;
            buttonRotateNinetyDegreeLeftWithoutDMA.Click += actionToRotateNinetyDegreeLeftWithoutDMA;
            // 
            // buttonRotateNinetyDegreeRightWithDMA
            // 
            buttonRotateNinetyDegreeRightWithDMA.Location = new Point(555, 401);
            buttonRotateNinetyDegreeRightWithDMA.Margin = new Padding(4, 3, 4, 3);
            buttonRotateNinetyDegreeRightWithDMA.Name = "buttonRotateNinetyDegreeRightWithDMA";
            buttonRotateNinetyDegreeRightWithDMA.Size = new Size(249, 27);
            buttonRotateNinetyDegreeRightWithDMA.TabIndex = 110;
            buttonRotateNinetyDegreeRightWithDMA.Text = "Rotacionar 90 graus a direita com DMA";
            buttonRotateNinetyDegreeRightWithDMA.UseVisualStyleBackColor = true;
            buttonRotateNinetyDegreeRightWithDMA.Click += actionToRotateNinetyDegreeRightWithDMA;
            // 
            // buttonRotateNinetyDegreeRightWithoutDMA
            // 
            buttonRotateNinetyDegreeRightWithoutDMA.Location = new Point(555, 368);
            buttonRotateNinetyDegreeRightWithoutDMA.Margin = new Padding(4, 3, 4, 3);
            buttonRotateNinetyDegreeRightWithoutDMA.Name = "buttonRotateNinetyDegreeRightWithoutDMA";
            buttonRotateNinetyDegreeRightWithoutDMA.Size = new Size(249, 27);
            buttonRotateNinetyDegreeRightWithoutDMA.TabIndex = 110;
            buttonRotateNinetyDegreeRightWithoutDMA.Text = "Rotacionar 90 graus a direita sem DMA";
            buttonRotateNinetyDegreeRightWithoutDMA.UseVisualStyleBackColor = true;
            buttonRotateNinetyDegreeRightWithoutDMA.Click += actionToRotateNinetyDegreeRightWithoutDMA;
            // 
            // buttonInvertRedAndBlueWithDMA
            // 
            buttonInvertRedAndBlueWithDMA.Location = new Point(313, 534);
            buttonInvertRedAndBlueWithDMA.Margin = new Padding(4, 3, 4, 3);
            buttonInvertRedAndBlueWithDMA.Name = "buttonInvertRedAndBlueWithDMA";
            buttonInvertRedAndBlueWithDMA.Size = new Size(233, 23);
            buttonInvertRedAndBlueWithDMA.TabIndex = 110;
            buttonInvertRedAndBlueWithDMA.Text = "Inverter vermelho e azul com DMA";
            buttonInvertRedAndBlueWithDMA.UseVisualStyleBackColor = true;
            buttonInvertRedAndBlueWithDMA.Click += actionToInvertRedAndBlueWithDMA;
            // 
            // buttonInvertRedAndBlueWithoutDMA
            // 
            buttonInvertRedAndBlueWithoutDMA.Location = new Point(313, 499);
            buttonInvertRedAndBlueWithoutDMA.Margin = new Padding(4, 3, 4, 3);
            buttonInvertRedAndBlueWithoutDMA.Name = "buttonInvertRedAndBlueWithoutDMA";
            buttonInvertRedAndBlueWithoutDMA.Size = new Size(233, 27);
            buttonInvertRedAndBlueWithoutDMA.TabIndex = 110;
            buttonInvertRedAndBlueWithoutDMA.Text = "Inverter vermelho e azul sem DMA";
            buttonInvertRedAndBlueWithoutDMA.UseVisualStyleBackColor = true;
            buttonInvertRedAndBlueWithoutDMA.Click += actionToInvertRedAndBlueWithoutDMA;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 595);
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
            Margin = new Padding(4, 3, 4, 3);
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
