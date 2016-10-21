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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        // Below method will be activated when SplashFormTimer ticks
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            // Stops the timer
            SplashFormTimer.Enabled = false;
            //generates a new GeneratenameForm Object
            GenerateNameForm generateNameForm = new GenerateNameForm();
            // new generated object displays
            generateNameForm.Show();
            //Current method hides
            this.Hide();

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
