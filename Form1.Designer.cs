namespace Genrate_Keys
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.MyName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNumberOfDigits = new System.Windows.Forms.TextBox();
            this.rbMix = new System.Windows.Forms.RadioButton();
            this.rbNumbers = new System.Windows.Forms.RadioButton();
            this.rbSymbols = new System.Windows.Forms.RadioButton();
            this.rbLetters1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOption = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumberOfKeys = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(712, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 36);
            this.button3.TabIndex = 47;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Tomato;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(418, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 36);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Tomato;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerate.Location = new System.Drawing.Point(418, 330);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(108, 36);
            this.btnGenerate.TabIndex = 45;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
            // 
            // MyName
            // 
            this.MyName.AutoSize = true;
            this.MyName.BackColor = System.Drawing.Color.Tomato;
            this.MyName.Font = new System.Drawing.Font("Edwardian Script ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyName.ForeColor = System.Drawing.Color.Black;
            this.MyName.Location = new System.Drawing.Point(306, 56);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(198, 25);
            this.MyName.TabIndex = 44;
            this.MyName.Text = "By : Djibril Bocar Sall";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNumberOfDigits);
            this.groupBox1.Controls.Add(this.rbMix);
            this.groupBox1.Controls.Add(this.rbNumbers);
            this.groupBox1.Controls.Add(this.rbSymbols);
            this.groupBox1.Controls.Add(this.rbLetters1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 178);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbNumberOfDigits
            // 
            this.tbNumberOfDigits.BackColor = System.Drawing.Color.Salmon;
            this.tbNumberOfDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberOfDigits.Location = new System.Drawing.Point(218, 27);
            this.tbNumberOfDigits.Name = "tbNumberOfDigits";
            this.tbNumberOfDigits.Size = new System.Drawing.Size(111, 26);
            this.tbNumberOfDigits.TabIndex = 7;
            this.tbNumberOfDigits.Text = " ";
            this.tbNumberOfDigits.TextChanged += new System.EventHandler(this.tbNumberOfDigits_TextChanged);
            this.tbNumberOfDigits.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumberOfDigits_Validating);
            // 
            // rbMix
            // 
            this.rbMix.AutoSize = true;
            this.rbMix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMix.ForeColor = System.Drawing.Color.White;
            this.rbMix.Location = new System.Drawing.Point(172, 129);
            this.rbMix.Name = "rbMix";
            this.rbMix.Size = new System.Drawing.Size(48, 20);
            this.rbMix.TabIndex = 6;
            this.rbMix.TabStop = true;
            this.rbMix.Text = "Mix";
            this.rbMix.UseVisualStyleBackColor = true;
            // 
            // rbNumbers
            // 
            this.rbNumbers.AutoSize = true;
            this.rbNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNumbers.ForeColor = System.Drawing.Color.White;
            this.rbNumbers.Location = new System.Drawing.Point(172, 87);
            this.rbNumbers.Name = "rbNumbers";
            this.rbNumbers.Size = new System.Drawing.Size(87, 20);
            this.rbNumbers.TabIndex = 5;
            this.rbNumbers.TabStop = true;
            this.rbNumbers.Text = "Numbers";
            this.rbNumbers.UseVisualStyleBackColor = true;
            // 
            // rbSymbols
            // 
            this.rbSymbols.AutoSize = true;
            this.rbSymbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSymbols.ForeColor = System.Drawing.Color.White;
            this.rbSymbols.Location = new System.Drawing.Point(26, 129);
            this.rbSymbols.Name = "rbSymbols";
            this.rbSymbols.Size = new System.Drawing.Size(85, 20);
            this.rbSymbols.TabIndex = 4;
            this.rbSymbols.TabStop = true;
            this.rbSymbols.Text = "Symbols";
            this.rbSymbols.UseVisualStyleBackColor = true;
            // 
            // rbLetters1
            // 
            this.rbLetters1.AutoSize = true;
            this.rbLetters1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLetters1.ForeColor = System.Drawing.Color.White;
            this.rbLetters1.Location = new System.Drawing.Point(26, 87);
            this.rbLetters1.Name = "rbLetters1";
            this.rbLetters1.Size = new System.Drawing.Size(72, 20);
            this.rbLetters1.TabIndex = 3;
            this.rbLetters1.Text = "Letters";
            this.rbLetters1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Digits:";
            // 
            // btnOption
            // 
            this.btnOption.BackColor = System.Drawing.Color.Tomato;
            this.btnOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOption.Location = new System.Drawing.Point(12, 185);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(108, 36);
            this.btnOption.TabIndex = 42;
            this.btnOption.Text = "Options";
            this.btnOption.UseVisualStyleBackColor = false;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click_1);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(12, 97);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(118, 25);
            this.lbResult.TabIndex = 40;
            this.lbResult.Text = "Result Is :";
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.Black;
            this.lbText.Location = new System.Drawing.Point(261, 21);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(281, 35);
            this.lbText.TabIndex = 39;
            this.lbText.Text = "Generate Keys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Number of Keys:";
            // 
            // tbNumberOfKeys
            // 
            this.tbNumberOfKeys.BackColor = System.Drawing.Color.Salmon;
            this.tbNumberOfKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberOfKeys.Location = new System.Drawing.Point(577, 277);
            this.tbNumberOfKeys.Name = "tbNumberOfKeys";
            this.tbNumberOfKeys.Size = new System.Drawing.Size(111, 26);
            this.tbNumberOfKeys.TabIndex = 49;
            this.tbNumberOfKeys.Text = "1";
            this.tbNumberOfKeys.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumberOfKeys_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Salmon;
            this.flowLayoutPanel1.Controls.Add(this.tbResult);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(147, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(541, 124);
            this.flowLayoutPanel1.TabIndex = 50;
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.Salmon;
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbResult.Location = new System.Drawing.Point(3, 3);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(541, 124);
            this.tbResult.TabIndex = 41;
            this.tbResult.TabStop = false;
            this.tbResult.TextChanged += new System.EventHandler(this.tbResult_TextChanged);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tbNumberOfKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.MyName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label MyName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNumberOfDigits;
        private System.Windows.Forms.RadioButton rbMix;
        private System.Windows.Forms.RadioButton rbNumbers;
        private System.Windows.Forms.RadioButton rbSymbols;
        private System.Windows.Forms.RadioButton rbLetters1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumberOfKeys;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

