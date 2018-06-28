using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.samplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {
        public static List<DDLClass> DataCollection;
        protected void Page_Load(object sender, EventArgs e)
        {
            //This method will execute on EACH and EVERY post back to this page
            //This method will execute on the first display of this page to determine if the page is new or postback 
            //use IsPostBack property

            //this method is often used as a general method to reset fields or control at the start of the page processing 
            //The label MessageLabel is used to display messages to the user
            //Old messages should be remove from this control on each pass

            //How does one reference a control on the .aspx form.
            //To reference a form control, use the control ID name
            //EACH control is an object. THEREFORE alter a PROPERTY value.
            MessageLabel.Text = "";

            //Determine if this is the first display of the page and if so load the data into the dropdownlist
            if (!Page.IsPostBack)
            {
                //Create an instance of LIST<T> for my "fake database" date
                DataCollection = new List<DDLClass>();

                //Add data to the collection, one entry at a time
                DataCollection.Add(new DDLClass(1, "COMP1008"));
                DataCollection.Add(new DDLClass(2, "DMIT1508"));
                DataCollection.Add(new DDLClass(3, "CPSC1517"));
                DataCollection.Add(new DDLClass(4, "DMIT2018"));

                //Usually, lists are sorted.
                //The LIST<T> has a sort behaviour (method)
                //(x,y) represent any two entries in the data collection at any point in time
                //The lamda symbol => basically means "do the following"
                //.CompareTo() is a method that will compare two items and return the result od comparing two items.
                //The result is interpreted by the sort to determine if the order needs to be changed
                //x vs y is ascending
                //y vs x is descending
                DataCollection.Sort((x,y) => x.DisplayField.CompareTo(y.DisplayField));

                //Place the collection into the dropdownlist
                // a) assign the collection to the control (ID = CollectionList)
                CollectionList.DataSource = DataCollection;

                // b) assigne the value and display portions of the dropdownlist to specific properties of the data Class
                CollectionList.DataTextField = nameof(DDLClass.DisplayField);
                CollectionList.DataValueField = nameof(DDLClass.ValueField);

                // c) BInd the data to the collaction (physical Attachment)
                CollectionList.DataBind();

                // d) You may wish to add a prompt line at the beginning of the list of data within the dropdownlist
                CollectionList.Items.Insert(0, "Select...");
            }
        }

        protected void SubmitButtonChoice_Click(object sender, EventArgs e)
        {
            //Grab the content of various control and manioulate the content of other control
            //Controls have certain properties that can be accessed for obtaining and assigning values

            //Textbox Property: Text
            string submitChoice = TextBoxNumberChoice.Text;
            if (string.IsNullOrEmpty(submitChoice))
            {
                MessageLabel.Text = "You did not enter a number between 1 and 4";  
            }
            else
            {
                //RadioButtonList Property: SelectedIndex, SelectedValue, SelectedItem
                //  SelectedIndex returns the physical line index
                //  SelectedValue returns the data value associated with the physical line**
                //  SelectedItem returns the data displayed associated with the physical line
                RadioButtonListListChoice.SelectedValue = submitChoice;

                //Checkbox Property: Checked (boolean)
                if(submitChoice.Equals("2") || submitChoice.Equals("4"))
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }

                //DropDownList Property: SelectedVAlue (preferred)
                //                     : SelectedIndex
                CollectionList.SelectedValue = submitChoice;

                //Label (Literal) Property: Text
                //demlonstrate using SlectedIndex, SelectedValue and SelectedItem to obtain datat off the dropdownlist
                //The data will be concatenated into a single string
                DisplayDataReadOnly.Text = CollectionList.SelectedItem.Text + " at index " + CollectionList.SelectedIndex.ToString() +
                    " having a value of " + CollectionList.SelectedValue;
            }
        }

        protected void LinkButtonSubmitChoice_Click(object sender, EventArgs e)
        {
            //Label property: Text
            MessageLabel.Text = "You pressed the submit Choice linkbutton";
        }
    }
}