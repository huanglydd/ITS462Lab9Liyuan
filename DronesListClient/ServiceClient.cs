using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DronesListClient.DronesListService;

namespace DronesListClient
{
    public partial class ServiceClient : Form
    {
        // Globle variable to store which option was choosen now
        string choice = "";

        public ServiceClient()
        {
            InitializeComponent();

            //Initialize the start options in comboSelect
            comboSelect.Items.Clear();

            comboSelect.Items.Add("Drone");
            comboSelect.Items.Add("Manufacturer");
            comboSelect.Items.Add("ModelSize");
        }

        private void comboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = (string)comboSelect.SelectedItem;
            switch(choice)
            {
                case "Drone":
                case "Manufacturer":
                case "ModelSize":
                    DisplayContent(choice);
                    break;
                default:
                    MessageBox.Show("error");
                    break;
            }
        }

        public void DisplayContent(string value)
        {
            // reset the text in two textboxes
            textDisplay_Large.Clear();
            listBox_Small.Items.Clear();

            // Create Service Client Object
            Service1Client client = new Service1Client();

            if (value == "Drone")
            {
                //textDisplay_Large.Text = client.GetDrones();
                string temp = "";
                temp = client.GetDrones();
                string[] split = temp.Split(',');

                // loop through the data returned and add them to listbox
                for (int i=0; i< split.Count(); i++)
                {
                    if (split[i] != null)
                    {
                        listBox_Small.Items.Add(split[i]);
                    }
                }
            }
            else if (value == "Manufacturer")
            {
                //textDisplay_Small.Text = client.GetManufacturerList();
                string temp = "";
                temp = client.GetManufacturerList();
                string[] split = temp.Split(',');

                // loop through the data returned and add them to listbox
                for (int i = 0; i < split.Count(); i++)
                {
                    if (split[i] != null)
                    {
                        listBox_Small.Items.Add(split[i]);
                    }
                }

            }
            else
            {
                //textDisplay_Small.Text = client.GetModelSizeList();
                string temp = "";
                temp = client.GetModelSizeList();
                string[] split = temp.Split(',');

                // loop through the data returned and add them to listbox
                for (int i = 0; i < split.Count(); i++)
                {
                    if (split[i] != null)
                    {
                        listBox_Small.Items.Add(split[i]);
                    }
                }
            }

        }

        private void listBox_Small_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Now_Selecting = listBox_Small.SelectedItem.ToString();
            switch (choice)
            {
                case "Drone":
                case "Manufacturer":
                case "ModelSize":
                    DisplayDetailedContent(choice,Now_Selecting);
                    break;
                default:
                    MessageBox.Show("error");
                    break;
            }
        }

        public void DisplayDetailedContent(string choice_value, string selected_value)
        {
            // clear the large textbox
            textDisplay_Large.Clear();

            // Create Service Client Object
            Service1Client client = new Service1Client();

            if (choice_value == "Drone")
            {
                textDisplay_Large.Text = client.GetDroneById(selected_value);
            }
            else if(choice_value == "Manufacturer")
            {
                textDisplay_Large.Text = client.GetDronesByManufacturerId(selected_value);
            }
            else{
                textDisplay_Large.Text = client.GetDronesByModelSizeId(selected_value);
            }
        }
    }
}
