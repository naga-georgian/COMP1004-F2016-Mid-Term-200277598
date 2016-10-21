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
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }
        //This  method is activated when user clicks on Back button
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        //This  method is activated when user clicks on exit menu item
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // form loader
        private void FinalForm_Load(object sender, EventArgs e)
        {
            // re-assigning values to display in the final form
            FirstNameTextBox.Text = Program.character.FirstName;
            LastNameTextBox.Text = Program.character.LastName;
            RaceTextBox.Text = Program.character.Race;

            StrengthTextBox.Text = Program.character.Strength;
            DexterityTextBox.Text = Program.character.Dexterity;
            ConstitutionTextBox.Text = Program.character.Constitution;
            IntelligenceTextBox.Text = Program.character.Intelligence;
            WisdomTextBox.Text = Program.character.Wisdom;
            CharismaTextBox.Text = Program.character.Charisma;
        }
    }
}
