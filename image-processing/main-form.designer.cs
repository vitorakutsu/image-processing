namespace image_processing
{
    partial class MainForm
    {
        private PictureBox pictureBoxImageOne;
        private PictureBox pictureBoxImageTwo;

        private Button buttonOpenImage;
        private Button buttonClearImage;
        private Button buttonSaveImage;

        private Button buttonFirstList;
        private Button buttonSecondList;
        private Button buttonThirdList;
        private Button buttonFourthList;

        private OpenFileDialog openFileDialog;
        private OpenFileDialog saveFileDialog;

        private Button buttonBack;

        private Button[] buttonsWithoutDMA_FirstList;
        private Button[] buttonsWithDMA_FirstList;

        private Button[] buttonsWithoutDMA_SecondList;
        private Button[] buttonsWithDMA_SecondList;

        private Button[] buttonsWithoutDMA_ThirdList;
        private Button[] buttonsWithDMA_ThirdList;

        private Button[] buttonsWithoutDMA_FourthList;
        private Button[] buttonsWithDMA_FourthList;

        private GroupBox groupBoxMethodsWithoutDMA;
        private GroupBox groupBoxMethodsWithDMA;

        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            pictureBoxImageOne = new PictureBox();
            pictureBoxImageTwo = new PictureBox();
            buttonOpenImage = new Button();
            buttonClearImage = new Button();
            buttonSaveImage = new Button();
            openFileDialog = new OpenFileDialog();

            buttonFirstList = new Button();
            buttonSecondList = new Button();
            buttonThirdList = new Button();
            buttonFourthList = new Button();

            buttonBack = new Button();

            groupBoxMethodsWithoutDMA = new GroupBox();
            groupBoxMethodsWithDMA = new GroupBox();

            buttonsWithoutDMA_FirstList = new Button[]
            {
                CreateButton("Luminância", 10, 20, ActionToConvertToGrayWithoutDMA),
                CreateButton("Negativo", 10, 60, ActionToConvertToNegativeWithoutDMA),
                CreateButton("Espelhar verticalmente", 10, 100, ActionToMirrorVerticallyWithoutDMA),
                CreateButton("Espelhar horizontalmente", 10, 140, ActionToMirrorHorizontallyWithoutDMA),
                CreateButton("Preto e Branco", 10, 180, ActionToConvertBlackAndWhiteWithoutDMA),
                CreateButton("Rotacionar 90 graus a esquerda", 10, 220, ActionToRotateNinetyDegreeLeftWithoutDMA),
                CreateButton("Rotacionar 90 graus a direita", 10, 260, ActionToRotateNinetyDegreeRightWithoutDMA),
                CreateButton("Inverter vermelho e azul", 10, 300, ActionToInvertRedAndBlueWithoutDMA),
            };

            buttonsWithDMA_FirstList = new Button[]
            {
                CreateButton("Luminância", 10, 20, ActionToConvertToGrayWithDMA),
                CreateButton("Negativo", 10, 60, ActionToConvertToNegativeWithDMA),
                CreateButton("Espelhar verticalmente", 10, 100, ActionToMirrorVerticallyWithDMA),
                CreateButton("Espelhar horizontalmente", 10, 140, ActionToMirrorHorizontallyWithDMA),
                CreateButton("Preto e Branco", 10, 180, ActionToConvertBlackAndWhiteWithDMA),
                CreateButton("Rotacionar 90 graus a esquerda", 10, 220, ActionToRotateNinetyDegreeLeftWithDMA),
                CreateButton("Rotacionar 90 graus a direita", 10, 260, ActionToRotateNinetyDegreeRightWithDMA),
                CreateButton("Inverter vermelho e azul", 10, 300, ActionToInvertRedAndBlueWithDMA),
            };

            buttonsWithoutDMA_SecondList = new Button[]
            {
                CreateButton("Conectividade 4", 10, 20, ActionToConnectivity4WithoutDMA),
                CreateButton("Conectividade 8", 10, 60, ActionToConnectivity8WithoutDMA),
                CreateButton("Reduzir pela metade", 10, 100, ActionToReduceByHalf),
                CreateButton("Reduzir dinamico", 10, 140, ActionToReduceByDinamicValue),
            };

            buttonsWithDMA_SecondList = new Button[] { };

            buttonsWithoutDMA_ThirdList = new Button[]
            {
                CreateButton("Fatiamento de Bits", 10, 20, ActionToBitPlaneSlicingWithoutDMA),
                CreateButton("Equalizacao do Histograma", 10, 60 , ActionToHistogramEqualizationWithoutDMA),
                CreateButton("Suavização Média de Vizinhança 5 x 5", 10, 100 , ActionToFilterSmoothingByAverageWithoutDMA),
                CreateButton("Suavização Mediana 5 x 5", 10, 140, ActionToFilterSmoothingByMedianWithoutDMA),
                CreateButton("Suavização K Vizinhos", 10, 180, ActionToFilterSmoothingByKNeighboursWithoutDMA),
            };

            buttonsWithDMA_ThirdList = new Button[] { };

            buttonsWithoutDMA_FourthList = new Button[] { };

            buttonsWithDMA_FourthList = new Button[] { };

            ((System.ComponentModel.ISupportInitialize)pictureBoxImageOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageTwo).BeginInit();
            SuspendLayout();

            ConfigurePictureBox(pictureBoxImageOne, "pictureBoxImageOne", new Point(6, 7), new Size(599, 355));
            ConfigurePictureBox(pictureBoxImageTwo, "pictureBoxImageTwo", new Point(630, 7), new Size(599, 355));

            ConfigureButton(buttonOpenImage, "Abrir Imagem", new Point(9, 368), new Size(150, 30), ActionToOpenImage);
            ConfigureButton(buttonClearImage, "Limpar Imagem", new Point(9, 410), new Size(150, 30), ActionToClearImage);
            ConfigureButton(buttonSaveImage, "Salvar Imagem", new Point(9, 450), new Size(150, 30), ActionToSaveImage);

            ConfigureButton(buttonFirstList, "Fundamentos de Imagens", new Point(170, 368), new Size(200, 30), ShowMethodButtonsFirstList);
            ConfigureButton(buttonSecondList, "Representação de Imagens", new Point(170, 410), new Size(200, 30), ShowMethodButtonsSecondList);
            ConfigureButton(buttonThirdList, "Realce de Imagens", new Point(170, 450), new Size(200, 30), ShowMethodButtonsThirdList);
            ConfigureButton(buttonFourthList, "Segmentação", new Point(170, 490), new Size(200, 30), ShowMethodButtonsFourthList);

            ConfigureButton(buttonBack, "Voltar", new Point(170, 530), new Size(200, 30), ShowMainButtons);

            ConfigureGroupBox(groupBoxMethodsWithoutDMA, "Métodos sem DMA", new Point(381, 368), new Size(250, 400));
            ConfigureGroupBox(groupBoxMethodsWithDMA, "Métodos com DMA", new Point(650, 368), new Size(250, 400));

            groupBoxMethodsWithoutDMA.Visible = false;
            groupBoxMethodsWithDMA.Visible = false;

            Controls.Add(pictureBoxImageOne);
            Controls.Add(pictureBoxImageTwo);
            Controls.Add(buttonOpenImage);
            Controls.Add(buttonClearImage);
            Controls.Add(buttonSaveImage);
            Controls.Add(buttonFirstList);
            Controls.Add(buttonSecondList);
            Controls.Add(buttonThirdList);
            Controls.Add(buttonFourthList);
            Controls.Add(buttonBack);
            Controls.Add(groupBoxMethodsWithoutDMA);
            Controls.Add(groupBoxMethodsWithDMA);

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 800);
            Name = "MainForm";
            Text = "Processamento de Imagens";
            ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageTwo).EndInit();
        }

        private Button CreateButton(string text, int x, int y, EventHandler clickEvent)
        {
            Button newButton = new Button
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(230, 30),
                UseVisualStyleBackColor = true,
            };

            newButton.Click += clickEvent;

            return newButton;
        }

        private void ConfigurePictureBox(PictureBox pictureBox, string name, Point location, Size size)
        {
            pictureBox.BackColor = SystemColors.ControlLightLight;
            pictureBox.Location = location;
            pictureBox.Name = name;
            pictureBox.Size = size;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
        }

        private void ConfigureButton(Button button, string text, Point location, Size size, EventHandler clickEvent)
        {
            button.Text = text;
            button.Location = location;
            button.Size = size;
            button.UseVisualStyleBackColor = true;
            button.Click += clickEvent;
        }

        private void ConfigureGroupBox(GroupBox groupBox, string text, Point location, Size size)
        {
            groupBox.Text = text;
            groupBox.Location = location;
            groupBox.Size = size;
            groupBox.TabStop = false;
        }

        private void ShowMethodButtonsFirstList(object sender, EventArgs e)
        {
            ShowMethods(buttonsWithoutDMA_FirstList, buttonsWithDMA_FirstList);
        }

        private void ShowMethodButtonsSecondList(object sender, EventArgs e)
        {
            ShowMethods(buttonsWithoutDMA_SecondList, buttonsWithDMA_SecondList);
        }

        private void ShowMethodButtonsThirdList(object sender, EventArgs e)
        {
            ShowMethods(buttonsWithoutDMA_ThirdList, buttonsWithDMA_ThirdList);
        }

        private void ShowMethodButtonsFourthList(object sender, EventArgs e)
        {
            ShowMethods(buttonsWithoutDMA_FourthList, buttonsWithDMA_FourthList);
        }

        private void ShowMainButtons(object sender, EventArgs e)
        {
            groupBoxMethodsWithoutDMA.Visible = false;
            groupBoxMethodsWithDMA.Visible = false;
        }

        private void ShowMethods(Button[] withoutDMAButtons, Button[] withDMAButtons)
        {
            // Clear existing buttons
            groupBoxMethodsWithoutDMA.Controls.Clear();
            groupBoxMethodsWithDMA.Controls.Clear();

            // Add buttons without DMA
            foreach (Button button in withoutDMAButtons)
            {
                groupBoxMethodsWithoutDMA.Controls.Add(button);
            }

            // Add buttons with DMA
            foreach (Button button in withDMAButtons)
            {
                groupBoxMethodsWithDMA.Controls.Add(button);
            }

            // Show the group boxes
            groupBoxMethodsWithoutDMA.Visible = true;
            groupBoxMethodsWithDMA.Visible = true;
        }
    }
}
