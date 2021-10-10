using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movement_Loop_Generator_2._0
{
    public partial class ParseDetalis : Form
    {
        private string parseName;
        private string parseAuthor;
        private int parseSpeed;
        private int parseDelay;
        private string parseFunction;

        public ParseDetalis()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            
            
            parseName = tbSpawnName.Text;
            parseAuthor = tbAuthorName.Text;
            if (string.IsNullOrEmpty(tbSpeed.Text))
            {
                parseSpeed = 2;
            }
            else
            {
                parseSpeed = Convert.ToInt32(tbSpeed.Text);
            }
            if (string.IsNullOrEmpty(tbDelay.Text))
            {
                parseDelay = 0;
            }
            else
            {
                parseDelay = Convert.ToInt32(tbDelay.Text);
            }
            parseFunction = tbFunction.Text;
            if (string.IsNullOrEmpty(tbAuthorName.Text))
            {
                parseAuthor = "Generated with Movement Loop Generator 2.0";
            }
            if (string.IsNullOrEmpty(tbSpawnName.Text))
            {

                MessageBox.Show("Spawn Name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Close();
            }
        }

        public string getName()
        {
            return parseName;
        }
        public string getAuthor()
        {
            return parseAuthor;
        }
        public int getSpeed()
        {
            return parseSpeed;
        }
        public int getDelay()
        {
            return parseDelay;
        }
        public string getFunction()
        {
            return parseFunction;
        }

        private void ParseDetalis_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnParse;
        }
    }
}
