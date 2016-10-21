/*******************************
 * Application: COMP1004-F2016-Mid-Term Exam
 * Author: Naga Rimmalapudi
 * Student ID: 200277598
 * Date: October 20, 2016 
 * 
 * Description: This application uses
 *   several windows forms and logics
 *   to create character's:
 *   - Name
 *   - Stats
 *   - Race
 * 
 */
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
        // Declaring private variables
        private string _FirstName;
        private string _LastName;
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        // Form loader
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        //This method is activated when user clicks on Generate names
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            // Assigning the values to the Program.character.FirstName and LastName
            Program.character.FirstName = FirstNametextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }

        //This method generates random values for first name and last name fields
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

        //This method is activated when user clicks on Next button
        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();
        }

        
    }
}
