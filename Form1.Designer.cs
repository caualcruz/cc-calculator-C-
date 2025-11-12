namespace Exemplo
{
    partial class Form1
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
            inputTextX = new TextBox();
            labelOutput = new Label();
            inputTextY = new TextBox();
            btnSoma = new Button();
            btnSub = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnQuad = new Button();
            btnRaiz = new Button();
            btnPorc = new Button();
            btnBin = new Button();
            btnElev = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // inputTextX
            // 
            inputTextX.Location = new Point(11, 35);
            inputTextX.Margin = new Padding(2);
            inputTextX.Name = "inputTextX";
            inputTextX.PlaceholderText = "X";
            inputTextX.Size = new Size(157, 23);
            inputTextX.TabIndex = 1;
            inputTextX.TextChanged += inputTextX_TextChanged;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.BackColor = Color.Gray;
            labelOutput.ForeColor = Color.Black;
            labelOutput.Location = new Point(259, 13);
            labelOutput.Margin = new Padding(2, 0, 2, 0);
            labelOutput.MaximumSize = new Size(280, 210);
            labelOutput.MinimumSize = new Size(280, 210);
            labelOutput.Name = "labelOutput";
            labelOutput.Padding = new Padding(7, 6, 7, 6);
            labelOutput.Size = new Size(280, 210);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "'";
            labelOutput.Visible = false;
            // 
            // inputTextY
            // 
            inputTextY.Location = new Point(11, 64);
            inputTextY.Margin = new Padding(2);
            inputTextY.Name = "inputTextY";
            inputTextY.PlaceholderText = "Y";
            inputTextY.Size = new Size(157, 23);
            inputTextY.TabIndex = 2;
            inputTextY.TextChanged += inputTextY_TextChanged;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(11, 114);
            btnSoma.Margin = new Padding(2);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(49, 30);
            btnSoma.TabIndex = 5;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += onSomaClick;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(64, 114);
            btnSub.Margin = new Padding(2);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(49, 30);
            btnSub.TabIndex = 6;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += onSubClick;
            // 
            // btnMult
            // 
            btnMult.Location = new Point(118, 114);
            btnMult.Margin = new Padding(2);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(49, 30);
            btnMult.TabIndex = 7;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += onMultClick;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(64, 154);
            btnDiv.Margin = new Padding(2);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(49, 30);
            btnDiv.TabIndex = 8;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += onDivClick;
            // 
            // btnQuad
            // 
            btnQuad.Location = new Point(118, 193);
            btnQuad.Margin = new Padding(2);
            btnQuad.Name = "btnQuad";
            btnQuad.Size = new Size(49, 30);
            btnQuad.TabIndex = 9;
            btnQuad.Text = "x²";
            btnQuad.UseVisualStyleBackColor = true;
            btnQuad.Click += onQuadClick;
            // 
            // btnRaiz
            // 
            btnRaiz.Location = new Point(118, 154);
            btnRaiz.Margin = new Padding(2);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(49, 30);
            btnRaiz.TabIndex = 10;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += onRaizClick;
            // 
            // btnPorc
            // 
            btnPorc.Location = new Point(11, 193);
            btnPorc.Margin = new Padding(2);
            btnPorc.Name = "btnPorc";
            btnPorc.Size = new Size(49, 30);
            btnPorc.TabIndex = 11;
            btnPorc.Text = "%";
            btnPorc.UseVisualStyleBackColor = true;
            btnPorc.Click += onPorcClick;
            // 
            // btnBin
            // 
            btnBin.Location = new Point(64, 193);
            btnBin.Margin = new Padding(2);
            btnBin.Name = "btnBin";
            btnBin.Size = new Size(49, 30);
            btnBin.TabIndex = 12;
            btnBin.Text = "0101";
            btnBin.UseVisualStyleBackColor = true;
            btnBin.Click += onBinClick;
            // 
            // btnElev
            // 
            btnElev.Location = new Point(11, 154);
            btnElev.Margin = new Padding(2);
            btnElev.Name = "btnElev";
            btnElev.Size = new Size(49, 30);
            btnElev.TabIndex = 13;
            btnElev.Text = "x^y";
            btnElev.UseVisualStyleBackColor = true;
            btnElev.Click += onElevClick;
            // 
            // button1
            // 
            button1.Location = new Point(259, 226);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "CE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(560, 270);
            Controls.Add(button1);
            Controls.Add(btnMult);
            Controls.Add(btnDiv);
            Controls.Add(btnPorc);
            Controls.Add(btnElev);
            Controls.Add(btnBin);
            Controls.Add(btnQuad);
            Controls.Add(btnRaiz);
            Controls.Add(btnSub);
            Controls.Add(btnSoma);
            Controls.Add(inputTextY);
            Controls.Add(labelOutput);
            Controls.Add(inputTextX);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora do rei Cauã Lindão";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputTextX;
        private Label labelOutput;
        private TextBox inputTextY;
        private Button btnSoma;
        private Button btnSub;
        private Button btnMult;
        private Button btnDiv;
        private Button btnQuad;
        private Button btnRaiz;
        private Button btnPorc;
        private Button btnBin;
        private Button btnElev;
        private Button button1;
    }
}