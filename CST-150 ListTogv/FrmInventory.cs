using CST_150_ListTogv.BuisnessLayer;
using CST_150_ListTogv.Models;

namespace CST_150_ListTogv
{
    public partial class FrmInventory : Form
    {

        //Create the class level object
        //This is called an inventory reference variable
        //This is our master inventory object that Must always contain the most updated inventory.
        List<InvItem> invItems = new List<InvItem>();
        //List that will hold all items found for search
        List<InvItem> invSearch = new List<InvItem>();

        //properties
        private int SelectedGridIndex { get; set; }
        public FrmInventory()
        {
            InitializeComponent();

        }


        ///<summary>
        /// Populate the grid when the form loads use this event handler
        /// //to build "Bind a DataGrid control to List of Objects.
        /// </summary>
        /// <Param name="sender"></Param>
        /// <Param name="e"></Param>
        private void PopulateGrid_LoadEventHandler(object sender, EventArgs e)
        {
            //Instantiate the buisness class and get all the inventory items
            //from the text file.
            Inventory readInv = new Inventory();
            invItems = readInv.ReadInventory(invItems);

            //After the list has been populated, set the DataSouce Property of the DG control to the list.
            gvInv.DataSource = null;
            gvInv.DataSource = invItems;

            //what if we do not liek the names in the ehader of the GridView?
            //Let's iterate through the header one column at a time and change the header names.
            foreach (DataGridViewColumn column in gvInv.Columns)
            {
                //Switch statement to change header text
                //column.Index starts at 0 - end count
                switch (column.Index)

                {
                    case 0:
                        column.HeaderText = "Bunny Type";
                        break;
                    case 1:
                        column.HeaderText = "Bunny Color";
                        break;
                    case 2:
                        column.HeaderText = "Quantity";
                        //number format with nothing to the right of the decimal
                        column.DefaultCellStyle.Format = "N0";
                        //All numbers shouwl vbe right jsutified
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    default:
                        //show a message indicating soemthing did not work correctly.
                        MessageBox.Show("Invalid column was trying to be accessed!");
                        //C# requires a closing break
                        break;

                }
            }
        }
        /// <summary>
        /// <summary>
        /// Event handler to manage click events of DataGridView
        /// </summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_ClickEventHandler(object sender, EventArgs e)
        {
            //Get the selected row
            SelectedGridIndex = gvInv.CurrentRow.Index;
            //Now we also know the index into the List to get all our information
        }
        /// <summary>
        /// Event Handler to Manage button to incremement quantity
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIncQty_clickEventHandler(object sender, EventArgs e)
        {
            //Make sure the logic is not in the presentation layer so inc qty in inventory class
            //Instantiate the inventory class so we can use the inc qty method
            Inventory incQty = new Inventory();
            //Invoke this mehtod to inc qty and ge the master list back
            invItems = incQty.IncQtyValue(invItems, SelectedGridIndex);

            //Save the updated inventory to the text file
            incQty.SaveInventory(invItems);
            //Since the list contains the master inventory
            //refresh the data int he DataGrid View
            //Since we have already bound the list to the DGV
            gvInv.Refresh();
        }

        private void BtnDeleteItem_EventHandler(object sender, EventArgs e)
        {
            //We already know the selected row which is the index
            //Make syre we remove the item form the master inventory
            invItems.RemoveAt(SelectedGridIndex);
            //We have to be careful when deleting items since we will get an out of range exception
            //since the datasource is bound to the intial number of rows.
            //Therefore, we can not just refresh the data grid view 
            //Reset the datasource by clearing it out and setting it to null
            gvInv.DataSource = null;
            //Last step is to bing the new data back to the DataGridView
            gvInv.DataSource = invItems;
            //Key --> invitems still has the master inventory!!!
        }

        private void BtnSearch_ClickEvent(object sender, EventArgs e)
        {
            //our goal is to read from the textbox and search the list in the type column for a match.
            //If there is a match or multiple matches then we shopw the matches
            //in the gridview on the secondary form.
            string searchFor = txtSearch.Text;
            //since the searching is logic - we need to do this in the buisness layer.
            Inventory buisnessLayer = new Inventory();
            //Search for the match and put results in the search list
            invSearch = buisnessLayer.SearchItem(invItems, invSearch, searchFor);
            //Send this invSearch over to the secondary form to be displayed.
            //Make sure to set up the secondary form now....
            FrmSecondary frmSecondary = new FrmSecondary(invSearch);
            //Now to show the form
            //notive .show() method shows the form in a non Modal form.  This means you can click ont eh parent form.
            //.showdialog() method shows the from modally, meaning you cannot go to the parent form.
            frmSecondary.ShowDialog();

        }
    }
}
