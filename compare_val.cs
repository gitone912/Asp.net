using System;
using System.Web.UI;

namespace CompareValidatorDemo
{
    public partial class CompareValidatorDemo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // You can handle the submit button click event here.
            // In this demo, we are just showing a message if the validation passes.
            if (IsValid)
            {
                lblMessage.Text = "Validation passed!";
            }
        }
    }
}
