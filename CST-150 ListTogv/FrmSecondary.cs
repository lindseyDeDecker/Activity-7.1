/*Lindsey DeDecker
 * CST- 150
 * Activity 7
 * August 10, 2024
 */

using CST_150_ListTogv.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_ListTogv
{
    public partial class FrmSecondary : Form
    {
        //Class level List
        List<InvItem> mySearch = new List<InvItem>();

        /// <summary>
        /// Parameterized constructor
        /// Since this class is public we have to make invItems.cs a public class 
        /// </summary>
        public FrmSecondary(List<InvItem> invSearch)
        {
            InitializeComponent();

            this.mySearch = invSearch;
        }

        /// <summary>
        /// When the form is loaded populate the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmSecondary_Load(object sender, EventArgs e)
        {
            gvSearchResults.DataSource = this.mySearch;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close the secondary form
            this.Close();
        }
    }
}
