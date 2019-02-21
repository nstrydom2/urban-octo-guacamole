using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainWindow : Form
    {
        LowLevelKeyboardListener keyboard = new LowLevelKeyboardListener();

        private bool hookEnabled = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void hookButton_Click(object sender, EventArgs e)
        {
            if (hookEnabled == false)
            {
                keyboard.hook();
                hookEnabled = true;
                this.outputBox.AppendText("Hook Enabled!\n");
            }
        }

        private void OnKeyPressed(object sender, LowLevelKeyboardListener.KeyPressedArgs e)
        {
            if (hookEnabled == true)
            {
                this.outputBox.AppendText(e.KeyPressed.ToString());
            }
        }

        private void unhookButton_Click(object sender, EventArgs e)
        {
            if (hookEnabled == true)
            {
                keyboard.unhook();
                hookEnabled = false;
                this.outputBox.AppendText("\nHook Disabled!\n");
            }
        }

    }
}
