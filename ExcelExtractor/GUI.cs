using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelExtractor
{
    public partial class GUI : Form
    {
        Logger logger;
        Extractor extractor;
        Injector injector;

        public GUI()
        {
            InitializeComponent();
            this.logger = new Logger();
            logger.DisplayMsg += DisplayMessage;
        }

        void DisplayMessage(object sender, string textToDisplay)
        {
            this.textBoxOutput.AppendText($"• {textToDisplay}\r\n\r\n");
        }

        private void buttonExtract_Click(object sender, EventArgs e)
        {
            if (textBoxSourcePath.Text == null||textBoxSourcePath.Text == "")
            {
                logger.Log("Please pick a source file.");
                return;
            }
            
            this.buttonExtract.Enabled = false;
            this.buttonInject.Enabled = false;
            this.textBoxSourcePath.Enabled = false;
            this.textBoxTranslatedPath.Enabled = false;
            this.radioButtonYellow.Enabled = false;
            this.radioButtonRed.Enabled = false;
            this.radioButtonOrange.Enabled = false;
            this.radioButtonDarkRed.Enabled = false;

            this.extractor = new Extractor(this.logger, this.textBoxSourcePath.Text, this.radioButtonYellow.Checked, this.radioButtonOrange.Checked, this.radioButtonRed.Checked, this.radioButtonDarkRed.Checked);
            this.extractor.Work();
        }

        private void buttonInject_Click(object sender, EventArgs e)
        {
            if (textBoxSourcePath.Text == null || textBoxSourcePath.Text == "")
            {
                logger.Log("Please pick a source file.");
                return;
            }
            
            if (textBoxTranslatedPath.Text == null || textBoxTranslatedPath.Text == "")
            {
                logger.Log("Please pick a file after translation.");
                return;
            }
            
            this.buttonExtract.Enabled = false;
            this.buttonInject.Enabled = false;
            this.textBoxSourcePath.Enabled = false;
            this.textBoxTranslatedPath.Enabled = false;
            this.radioButtonYellow.Enabled = false;
            this.radioButtonRed.Enabled = false;
            this.radioButtonOrange.Enabled = false;
            this.radioButtonDarkRed.Enabled = false;

            this.injector = new Injector(this.logger, this.textBoxSourcePath.Text, this.textBoxTranslatedPath.Text);
            this.injector.Work();
        }
    }
}
