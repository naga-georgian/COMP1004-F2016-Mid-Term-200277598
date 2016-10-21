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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_200277598
{
    public partial class RaceAndClassForm : Form
    {
        // creating a variable of type AbilityGeneratorForm
        public AbilityGeneratorForm previousForm;
        

        public RaceAndClassForm()
        {
            InitializeComponent();
        }

        //This method is activated when user clicks on Back button
        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = Program.character.Race;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        // This method have the values of race and assigns them to Program.character.Race
        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;

            Program.character.Race = selectedRace.Text;
        }

        //This method is activated when user clicks on next button
        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }

        private void RaceAndClassForm_Load(object sender, EventArgs e)
        {

        }

      
    }
}
