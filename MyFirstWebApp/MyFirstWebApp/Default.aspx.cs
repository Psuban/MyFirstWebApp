﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clickMeButton_Click(object sender, EventArgs e)
        {
            string firtName = firstNameTextBox.Text;

            string lastName = lastNameTextBox.Text;

            string result = "Hi " + firtName + " " + lastName;

            resultLabel.Text = result;
        }
    }
}