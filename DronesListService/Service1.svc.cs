using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml;

namespace DronesListService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // Define Constant Variables
        //string connString = "Data Source=J:\\Spring 2016\\ITS 462\\Lab8Liyuan\\New_Normalized_Drones_Dataset.sqlite;Version=3;";
        string connString = "Data Source=|DataDirectory|New_Normalized_Drones_Dataset.sqlite";

        //ArrayList ManufacturerNameIdPair = { "", "", "", "", "", "", "", "", "", "", "", "" };   //new string[12];   //
        //string[] ModelSizeNameIdPair = new string[6];     //{ "", "", "", "", "", ""};

        public String GetManufacturerList()
        {
            // create connection object
            SQLiteConnection conn = new SQLiteConnection();

            // define connection path
            conn.ConnectionString = connString;

            // create a command object
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "SELECT * FROM Manufacturer";

            // open connection
            conn.Open();

            // retrieve data to a data reader object
            SQLiteDataReader dr = cmd.ExecuteReader();

            string temp = "";

            // loop through all the rows
            if (dr.HasRows)
            {
                
                while (dr.Read())
                {

                    temp += dr.GetString(1) + ",";
                    //temp += dr.GetString(0) + " -- " + dr.GetString(1) + "\r\n";

                }
            }
            else
            {
                temp += "No data found.";
            }
            dr.Close();

            // close the connection
            conn.Close();

            return temp;
        }

        public String GetModelSizeList()
        {
            // create connection object
            SQLiteConnection conn = new SQLiteConnection();

            // define connection path
            conn.ConnectionString = connString;

            // create a command object
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "SELECT * FROM \"Model Size\"";

            // open connection
            conn.Open();

            // retrieve data to a data reader object
            SQLiteDataReader dr = cmd.ExecuteReader();

            string temp = "";

            // loop through all the rows
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    temp += dr.GetString(1) + ",";
                    //temp += dr.GetString(0) + " -- " + dr.GetString(1) + "\r\n";

                }
            }
            else
            {
                temp += "No data found.";
            }
            dr.Close();

            // close the connection
            conn.Close();

            return temp;
        }

        public String GetDrones()
        {
            // create connection object
            SQLiteConnection conn = new SQLiteConnection();

            // define connection path
            conn.ConnectionString = connString;

            // create a command object
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "SELECT Model_Name FROM \"Drones Data\"";

            // open connection
            conn.Open();

            // retrieve data to a data reader object
            SQLiteDataReader dr = cmd.ExecuteReader();

            string temp = "";

            // loop through all the rows
            if (dr.HasRows)
            {
                //temp += "Dones Data Table:\r\n";
                //temp += "Man_Id\tModel_Name\tEstimated Price($)\tFlight Time(min)\tSize_Id\r\n";
                while (dr.Read())
                {
                    //String Man_Name = "";
                    //String Size_Name = "";

                    // get the foreign keys' values
                    //SQLiteCommand cmd1 = new SQLiteCommand(conn);
                    //cmd1.CommandText = "SELECT Man_Name FROM Manufacturer where Man_Id = \""+ dr.GetString(0) + "\"";
                    //SQLiteCommand cmd2 = new SQLiteCommand(conn);
                    //cmd2.CommandText = "SELECT Size_Name FROM \"Model Size\" where Size_Id = \"" + dr.GetString(4) + "\"";

                    //SQLiteDataReader dr1 = cmd1.ExecuteReader();
                    //SQLiteDataReader dr2 = cmd2.ExecuteReader();

                    //dr1.Read();
                    //dr2.Read();

                    //Man_Name = dr1.GetString(0);
                    //Size_Name = dr2.GetString(0);

                    temp += dr.GetString(0) + ",";
                    //temp += Man_Name + "\t" + dr.GetString(1) + "\t" + dr.GetString(2) + "\t" + dr.GetString(3) + "\t" + Size_Name + "\r\n";
                    //temp += dr.GetString(0) + "\t" + dr.GetString(1) + "\t" + dr.GetString(2) + "\t" + dr.GetString(3) + "\t" + dr.GetString(4) + "\r\n";
                }
            }
            else
            {
                temp += "No data found.";
            }
            dr.Close();

            // close the connection
            conn.Close();

            return temp;
        }

        public string GetDroneById(string value)
        {

            // create connection object
            SQLiteConnection conn = new SQLiteConnection();

            // define connection path
            conn.ConnectionString = connString;

            // create a command object
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "SELECT * FROM \"Drones Data\" where Model_Name=\"" + value + "\"";

            // open connection
            conn.Open();

            // retrieve data to a data reader object
            SQLiteDataReader dr = cmd.ExecuteReader();

            string temp = "";

            // loop through all the rows
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    String Man_Name = "";
                    String Size_Name = "";

                    // get the foreign keys' values
                    SQLiteCommand cmd1 = new SQLiteCommand(conn);
                    cmd1.CommandText = "SELECT Man_Name FROM Manufacturer where Man_Id = \"" + dr.GetString(0) + "\"";
                    SQLiteCommand cmd2 = new SQLiteCommand(conn);
                    cmd2.CommandText = "SELECT Size_Name FROM \"Model Size\" where Size_Id = \"" + dr.GetString(4) + "\"";

                    SQLiteDataReader dr1 = cmd1.ExecuteReader();
                    SQLiteDataReader dr2 = cmd2.ExecuteReader();

                    dr1.Read();
                    dr2.Read();

                    Man_Name = dr1.GetString(0);
                    Size_Name = dr2.GetString(0);

                    temp += Man_Name + "\t" + dr.GetString(1) + "\t" + dr.GetString(2) + "\t" + dr.GetString(3) + "\t" + Size_Name + "\r\n";

                }
            }
            else
            {
                temp += "No data found.";
            }
            dr.Close();

            // close the connection
            conn.Close();

            return temp;
        }

        public string GetDronesByManufacturerId(string value)
        {
            // create connection object
            SQLiteConnection conn = new SQLiteConnection();

            // define connection path
            conn.ConnectionString = connString;

            // create a command object
            SQLiteCommand cmd = new SQLiteCommand(conn);
            

            // open connection
            conn.Open();

            //get Id to complete the cmd statement follow:   such as 1 -> DJI; 2 -> Phantom
            string ID = "";
            SQLiteCommand cmd_prep = new SQLiteCommand(conn);
            cmd_prep.CommandText = "SELECT Man_Id FROM Manufacturer where Man_Name = \"" + value + "\"";
            SQLiteDataReader dr_prep = cmd_prep.ExecuteReader();
            dr_prep.Read();
            ID = dr_prep.GetString(0);

            // statement
            cmd.CommandText = "SELECT * FROM \"Drones Data\" where Man_Id=\"" + ID + "\"";

            // retrieve data to a data reader object
            SQLiteDataReader dr = cmd.ExecuteReader();

            string temp = "";

            // loop through all the rows
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    String Man_Name = "";
                    String Size_Name = "";

                    // get the foreign keys' values
                    SQLiteCommand cmd1 = new SQLiteCommand(conn);
                    cmd1.CommandText = "SELECT Man_Name FROM Manufacturer where Man_Id = \"" + dr.GetString(0) + "\"";
                    SQLiteCommand cmd2 = new SQLiteCommand(conn);
                    cmd2.CommandText = "SELECT Size_Name FROM \"Model Size\" where Size_Id = \"" + dr.GetString(4) + "\"";

                    SQLiteDataReader dr1 = cmd1.ExecuteReader();
                    SQLiteDataReader dr2 = cmd2.ExecuteReader();

                    dr1.Read();
                    dr2.Read();

                    Man_Name = dr1.GetString(0);
                    Size_Name = dr2.GetString(0);

                    temp += Man_Name + "\t" + dr.GetString(1) + "\t" + dr.GetString(2) + "\t" + dr.GetString(3) + "\t" + Size_Name + "\r\n";

                }
            }
            else
            {
                temp += "No data found.";
            }
            dr.Close();

            // close the connection
            conn.Close();

            return temp;
        }

        public string GetDronesByModelSizeId(string value)
        {
            // create connection object
            SQLiteConnection conn = new SQLiteConnection();

            // define connection path
            conn.ConnectionString = connString;

            

            // create a command object
            SQLiteCommand cmd = new SQLiteCommand(conn);
            

            // open connection
            conn.Open();

            //get Id to complete the cmd statement follow:   such as 1 -> Small; 2 -> Medium
            string ID = "";
            SQLiteCommand cmd_prep = new SQLiteCommand(conn);
            cmd_prep.CommandText = "SELECT Size_Id FROM \"Model Size\" where Size_Name = \"" + value + "\"";
            SQLiteDataReader dr_prep = cmd_prep.ExecuteReader();
            dr_prep.Read();
            ID = dr_prep.GetString(0);

            // statement
            cmd.CommandText = "SELECT * FROM \"Drones Data\" where Size_Id=\"" + ID + "\"";

            // retrieve data to a data reader object
            SQLiteDataReader dr = cmd.ExecuteReader();

            string temp = "";

            // loop through all the rows
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    String Man_Name = "";
                    String Size_Name = "";

                    // get the foreign keys' values
                    SQLiteCommand cmd1 = new SQLiteCommand(conn);
                    cmd1.CommandText = "SELECT Man_Name FROM Manufacturer where Man_Id = \""+ dr.GetString(0) + "\"";
                    SQLiteCommand cmd2 = new SQLiteCommand(conn);
                    cmd2.CommandText = "SELECT Size_Name FROM \"Model Size\" where Size_Id = \"" + dr.GetString(4) + "\"";

                    SQLiteDataReader dr1 = cmd1.ExecuteReader();
                    SQLiteDataReader dr2 = cmd2.ExecuteReader();

                    dr1.Read();
                    dr2.Read();

                    Man_Name = dr1.GetString(0);
                    Size_Name = dr2.GetString(0);

                    temp += Man_Name + "\t" + dr.GetString(1) + "\t" + dr.GetString(2) + "\t" + dr.GetString(3) + "\t" + Size_Name + "\r\n";
                    
                }
            }
            else
            {
                temp += "No data found.";
            }
            dr.Close();

            // close the connection
            conn.Close();

            return temp;
        }
    }
}
