using System;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace JSONParser1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI events

        private void cmdDeserialise_Click(object sender, EventArgs e)
        {
            //debugOutput(txtInput.Text);
            deserialiseJSON(txtInput.Text);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;
        }

        #endregion

        #region json functions

        private void deserialiseJSON(string strJSON)
        {
            try
            {
                var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);

                //var jPerson = JsonConvert.DeserializeObject<jsonPersonSimple>(strJSON);
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonComplex>(strJSON);
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonArray>(strJSON);

                debugOutput("Here's our JSON object: " + jPerson.ToString());

                

                debugOutput("Here's the First Name: " + jPerson.firstname);
                //debugOutput("Here's the street address: " + jPerson.address.streetAddress);
                /*
                debugOutput("Attempting to print phone numbers....");

                foreach(var num in jPerson.phoneNumbers)
                {
                    debugOutput(num.type.ToString() + " - " + num.number.ToString());
                }
                */
            }
            catch(Exception ex)
            {
                debugOutput("We had a problem: " + ex.Message.ToString());
            }
        }


        #endregion

        #region Debug Output

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                txtDebugOutput.SelectionStart = txtDebugOutput.TextLength;
                txtDebugOutput.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }


        #endregion
    }
}
