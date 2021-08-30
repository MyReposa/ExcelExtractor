
namespace ExcelExtractor
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSourcePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTranslatedPath = new System.Windows.Forms.TextBox();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonOrange = new System.Windows.Forms.RadioButton();
            this.radioButtonDarkRed = new System.Windows.Forms.RadioButton();
            this.radioButtonYellow = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInject = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source file to extract from or to inject to:";
            // 
            // textBoxSourcePath
            // 
            this.textBoxSourcePath.Location = new System.Drawing.Point(15, 29);
            this.textBoxSourcePath.Name = "textBoxSourcePath";
            this.textBoxSourcePath.Size = new System.Drawing.Size(773, 20);
            this.textBoxSourcePath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Translated file to inject from (used only when post-processing):";
            // 
            // textBoxTranslatedPath
            // 
            this.textBoxTranslatedPath.Location = new System.Drawing.Point(15, 76);
            this.textBoxTranslatedPath.Name = "textBoxTranslatedPath";
            this.textBoxTranslatedPath.Size = new System.Drawing.Size(773, 20);
            this.textBoxTranslatedPath.TabIndex = 3;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(175, 129);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(96, 17);
            this.radioButtonRed.TabIndex = 4;
            this.radioButtonRed.Text = "Red (255, 0, 0)";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrange
            // 
            this.radioButtonOrange.AutoSize = true;
            this.radioButtonOrange.Location = new System.Drawing.Point(33, 152);
            this.radioButtonOrange.Name = "radioButtonOrange";
            this.radioButtonOrange.Size = new System.Drawing.Size(123, 17);
            this.radioButtonOrange.TabIndex = 5;
            this.radioButtonOrange.Text = "Orange (255, 192, 0)";
            this.radioButtonOrange.UseVisualStyleBackColor = true;
            // 
            // radioButtonDarkRed
            // 
            this.radioButtonDarkRed.AutoSize = true;
            this.radioButtonDarkRed.Location = new System.Drawing.Point(175, 152);
            this.radioButtonDarkRed.Name = "radioButtonDarkRed";
            this.radioButtonDarkRed.Size = new System.Drawing.Size(117, 17);
            this.radioButtonDarkRed.TabIndex = 6;
            this.radioButtonDarkRed.Text = "Dark red (192, 0, 0)";
            this.radioButtonDarkRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonYellow
            // 
            this.radioButtonYellow.AutoSize = true;
            this.radioButtonYellow.Checked = true;
            this.radioButtonYellow.Location = new System.Drawing.Point(33, 129);
            this.radioButtonYellow.Name = "radioButtonYellow";
            this.radioButtonYellow.Size = new System.Drawing.Size(119, 17);
            this.radioButtonYellow.TabIndex = 7;
            this.radioButtonYellow.TabStop = true;
            this.radioButtonYellow.Text = "Yellow (255, 255, 0)";
            this.radioButtonYellow.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Extract data from fields marked in (used only when pre-processing):";
            // 
            // buttonInject
            // 
            this.buttonInject.Location = new System.Drawing.Point(667, 130);
            this.buttonInject.Name = "buttonInject";
            this.buttonInject.Size = new System.Drawing.Size(121, 38);
            this.buttonInject.TabIndex = 9;
            this.buttonInject.Text = "Inject from translated file to source";
            this.buttonInject.UseVisualStyleBackColor = true;
            this.buttonInject.Click += new System.EventHandler(this.buttonInject_Click);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(437, 130);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(121, 38);
            this.buttonExtract.TabIndex = 10;
            this.buttonExtract.Text = "Extract from source\r\nto new file";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Output:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(16, 206);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(772, 232);
            this.textBoxOutput.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(611, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.buttonInject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonYellow);
            this.Controls.Add(this.radioButtonDarkRed);
            this.Controls.Add(this.radioButtonOrange);
            this.Controls.Add(this.radioButtonRed);
            this.Controls.Add(this.textBoxTranslatedPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSourcePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "Excel Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSourcePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTranslatedPath;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonOrange;
        private System.Windows.Forms.RadioButton radioButtonDarkRed;
        private System.Windows.Forms.RadioButton radioButtonYellow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInject;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

