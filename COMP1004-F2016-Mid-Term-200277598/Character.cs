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
using System.Linq;
using System.Text;

namespace COMP1004_F2016_Mid_Term_200277598
{
    public class Character
    {
        //Variables declaration with getter and setter methods of them
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }
    }
}