using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calk
{
    public partial class CalcForm : Form
    {
        private readonly CalcKernel kernel = new CalcKernel();
        private String OutTex
        {
            get;
            set;
        }

        public CalcForm()
        {
            InitializeComponent();
        }

        private void digitsButton_Click(object sender, EventArgs e)
        {
            if (sender == digit0Button) { kernel.Push('0'); }
            else if (sender == digit1Button) { kernel.Push('1'); }
            else if (sender == digit2Button) { kernel.Push('2'); }
            else if (sender == digit3Button) { kernel.Push('3'); }
            else if (sender == digit4Button) { kernel.Push('4'); }
            else if (sender == digit5Button) { kernel.Push('5'); }
            else if (sender == digit6Button) { kernel.Push('6'); }
            else if (sender == digit7Button) { kernel.Push('7'); }
            else if (sender == digit8Button) { kernel.Push('8'); }
            else if (sender == digit9Button) { kernel.Push('9'); }
            else if (sender == dotButton) { kernel.Push('.'); }
        }
    }
}
