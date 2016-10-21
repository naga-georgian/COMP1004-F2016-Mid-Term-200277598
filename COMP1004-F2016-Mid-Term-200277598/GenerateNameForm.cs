using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_200277598
{
    public partial class GenerateNameForm : Form
    {
        private string _FirstName;
        private string _LastName;
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            Program.character.FirstName = FirstNametextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }

        private void GenerateNames()
        {
            Random rand = new Random();

            int FirstNameLength = FirstNameListBox.Items.Count;
            int LastNameLength = LastNameListBox.Items.Count;

            _FirstName = FirstNameListBox.Items[rand.Next(FirstNameLength)].ToString();
            _LastName = LastNameListBox.Items[rand.Next(LastNameLength)].ToString();

            FirstNametextBox.Text = _FirstName;
            LastNameTextBox.Text = _LastName;

            Program.character.FirstName = _FirstName;
            Program.character.LastName = _LastName;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();
        }

        
    }
}
