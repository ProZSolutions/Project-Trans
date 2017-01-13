using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_Transport 
{
    /// <summary>
    /// Interaction logic for load_tyre.xaml
    /// </summary>
    public partial class load_tyre : UserControl
    {
        load_tyre_view l = new load_tyre_view();
        public load_tyre()
        {
            
            
            InitializeComponent();
            
        }

        private void tyre_vehicle_number_GotFocus(object sender, RoutedEventArgs e)
        {
            Connection con = new Connection();
            con.connection_string();
            OdbcCommand cmd1 = new OdbcCommand("select Vechile_No from load_tyre ", con.str);
            OdbcDataReader da = cmd1.ExecuteReader();
            tyre_vehicle_number.Items.Clear();
            while (da.Read())
            {
                tyre_vehicle_number.Items.Add(da[0]);

            }
            con.close_string();
        }
       
        private void tyre_vehicle_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab || e.Key == Key.Enter)
            {
                if (!string.IsNullOrWhiteSpace(tyre_vehicle_number.Text))
                {
                    Connection con = new Connection();
                    con.open_connection();
                    OdbcCommand cmd1 = new OdbcCommand("select type from vechicle_details where vehicle_Number='" + tyre_vehicle_number.Text + "' ", con.conn);
                    OdbcDataReader da = cmd1.ExecuteReader();
                    while (da.Read())
                    {
                        string s = da[0].ToString();
                        if (s == "6")
                        {
                            tyre_entry_panel.Visibility = Visibility.Visible;
                            //Connection con = new Connection();
                            //con.open_connection();
                            //OdbcCommand cmd1 = new OdbcCommand("select Fl_id,Fr_id,Bbol_id,Bbil_id,Bbor_id,Bbir_id from load where vehicle_Number='" + tyre_vehicle_number.Text + "' ", con.conn);
                            //OdbcDataAdapter da = new OdbcDataAdapter(cmd1);
                            //DataTable dt = new DataTable();
                            //da.Fill(dt);
                            but1.Visibility = Visibility.Visible;
                            but2.Visibility = Visibility.Visible;
                            but3.Visibility = Visibility.Hidden;
                            but4.Visibility = Visibility.Hidden;
                            but5.Visibility = Visibility.Hidden;
                            but6.Visibility = Visibility.Hidden;
                            but7.Visibility = Visibility.Hidden;
                            but8.Visibility = Visibility.Hidden;
                            but9.Visibility = Visibility.Visible;
                            but10.Visibility = Visibility.Visible;
                            but11.Visibility = Visibility.Visible;
                            but12.Visibility = Visibility.Visible;

                        }
                        else if (s == "10")
                        {
                            tyre_entry_panel.Visibility = Visibility.Visible;

                            but1.Visibility = Visibility.Visible;
                            but2.Visibility = Visibility.Visible;
                            but3.Visibility = Visibility.Hidden;
                            but4.Visibility = Visibility.Hidden;
                            but5.Visibility = Visibility.Visible;
                            but6.Visibility = Visibility.Visible;
                            but7.Visibility = Visibility.Visible;
                            but8.Visibility = Visibility.Visible;
                            but9.Visibility = Visibility.Visible;
                            but10.Visibility = Visibility.Visible;
                            but11.Visibility = Visibility.Visible;
                            but12.Visibility = Visibility.Visible;
                        }
                        else if (s == "12")
                        {
                            tyre_entry_panel.Visibility = Visibility.Visible;
                            but1.Visibility = Visibility.Visible;
                            but2.Visibility = Visibility.Visible;
                            but3.Visibility = Visibility.Visible;
                            but4.Visibility = Visibility.Visible;
                            but5.Visibility = Visibility.Visible;
                            but6.Visibility = Visibility.Visible;
                            but7.Visibility = Visibility.Visible;
                            but8.Visibility = Visibility.Visible;
                            but9.Visibility = Visibility.Visible;
                            but10.Visibility = Visibility.Visible;
                            but11.Visibility = Visibility.Visible;
                            but12.Visibility = Visibility.Visible;
                        }
                        else if (s == "14")
                        {
                            tyre_entry_panel.Visibility = Visibility.Visible;

                        }
                        else
                        {
                            MessageBox.Show("Not a valid type");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Choose the vehicle number");
                }

            }

        }
     
        string[] s = new string[6];
      
        string b1 = null;
        string b2 = null;
        public void get_details(string s1, string s2, string s3)
        {
            if (!string.IsNullOrWhiteSpace(s3))
            {
                Connection con = new Connection();
                con.connection_string();
                OdbcCommand cmd1 = new OdbcCommand("select " + s1 + ",DATE_FORMAT(" + s2 + ",'%d-%m-%Y')Add_date from load_tyre where vechile_No='" + s3 + "' ", con.str);
                OdbcDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    string st = dr[0].ToString();
                    string d = dr[1].ToString();
                    if (st != null)
                    {
                        OdbcCommand cmd = new OdbcCommand("select No,Starting_Km,Company,Price,DATE_FORMAT(Purchase_date,'%d-%m-%Y')Purchase_date from load_tyre_details where id='" + st + "' ", con.str);
                        OdbcDataAdapter daa = new OdbcDataAdapter(cmd);
                        DataTable dtt = new DataTable();
                        daa.Fill(dtt);
                        if (dtt.Rows.Count > 0)
                        {
                            s[0] = dtt.Rows[0]["No"].ToString();
                            s[1] = dtt.Rows[0]["Starting_Km"].ToString();
                            s[2] = dtt.Rows[0]["Company"].ToString();
                            s[3] = dtt.Rows[0]["Price"].ToString();
                           s[4] = dtt.Rows[0]["Purchase_date"].ToString();
                            s[5] = d;
                           
                            l.View(s,b1,b2,s3);
                            l.Show();
                        }
                        else
                        {                          
                        l.hide(s3,b1,b2);

                            l.Show();
                        }
                    }                  
                }
            }
            else
            {
                MessageBox.Show("Please choose vehicle_Number");
            }
        }
        private void but1_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tyre_vehicle_number.Text))
            {
               

                b1 = "Fl_id"; b2 = "Fl_date";
                get_details(b1, b2, tyre_vehicle_number.Text);
               
            }
           else
            {
                MessageBox.Show("Please select vehicle_Number");
            }
        }                 
        //tl1.Visibility = Visibility.Visible;
        //tl2.Visibility = Visibility.Visible;
        //tl3.Visibility = Visibility.Hidden;
        //tl4.Visibility = Visibility.Hidden;
        //tl5.Visibility = Visibility.Hidden;
        //tl6.Visibility = Visibility.Hidden;
        //tl7.Visibility = Visibility.Hidden;
        //tl8.Visibility = Visibility.Hidden;
        //tl9.Visibility = Visibility.Hidden;
        //tl10.Visibility = Visibility.Hidden;
        //tl11.Visibility = Visibility.Hidden;
        //tl12.Visibility = Visibility.Hidden;
        //tl13.Visibility = Visibility.Hidden;
        //tl14.Visibility = Visibility.Hidden;
        //tl15.Visibility = Visibility.Hidden;
        //tl16.Visibility = Visibility.Hidden;
        //tl17.Visibility = Visibility.Hidden;
        //tl18.Visibility = Visibility.Hidden;
        //tl19.Visibility = Visibility.Hidden;
        //tl20.Visibility = Visibility.Hidden;
        //tl21.Visibility = Visibility.Hidden;
        //tl22.Visibility = Visibility.Hidden;
        //tl23.Visibility = Visibility.Hidden;
        //tl24.Visibility = Visibility.Hidden;
    

        private void but2_Click(object sender, RoutedEventArgs e)
        {
           
            b1 = "Cl_id"; b2 = "Cl_date";
            get_details(b1, b2, tyre_vehicle_number.Text);

        }
            //tl1.Visibility = Visibility.Hidden;
            //tl2.Visibility = Visibility.Hidden;
            //tl3.Visibility = Visibility.Visible;
            //tl4.Visibility = Visibility.Visible;
            //tl5.Visibility = Visibility.Hidden;
            //tl6.Visibility = Visibility.Hidden;
            //tl7.Visibility = Visibility.Hidden;
            //tl8.Visibility = Visibility.Hidden;
            //tl9.Visibility = Visibility.Hidden;
            //tl10.Visibility = Visibility.Hidden;
            //tl11.Visibility = Visibility.Hidden;
            //tl12.Visibility = Visibility.Hidden;
            //tl13.Visibility = Visibility.Hidden;
            //tl14.Visibility = Visibility.Hidden;
            //tl15.Visibility = Visibility.Hidden;
            //tl16.Visibility = Visibility.Hidden;
            //tl17.Visibility = Visibility.Hidden;
            //tl18.Visibility = Visibility.Hidden;
            //tl19.Visibility = Visibility.Hidden;
            //tl20.Visibility = Visibility.Hidden;
            //tl21.Visibility = Visibility.Hidden;
            //tl22.Visibility = Visibility.Hidden;
            //tl23.Visibility = Visibility.Hidden;
            //tl24.Visibility = Visibility.Hidden;
        

        private void but3_Click(object sender, RoutedEventArgs e)
        {
           
            b1 = "Bfil_id"; b2 = "Bfil_date";
            get_details(b1, b2, tyre_vehicle_number.Text);
            //tl1.Visibility = Visibility.Hidden;
            //tl2.Visibility = Visibility.Hidden;
            //tl3.Visibility = Visibility.Hidden;
            //tl4.Visibility = Visibility.Hidden;
            //tl5.Visibility = Visibility.Visible;
            //tl6.Visibility = Visibility.Visible;
            //tl7.Visibility = Visibility.Hidden;
            //tl8.Visibility = Visibility.Hidden;
            //tl9.Visibility = Visibility.Hidden;
            //tl10.Visibility = Visibility.Hidden;
            //tl11.Visibility = Visibility.Hidden;
            //tl12.Visibility = Visibility.Hidden;
            //tl13.Visibility = Visibility.Hidden;
            //tl14.Visibility = Visibility.Hidden;
            //tl15.Visibility = Visibility.Hidden;
            //tl16.Visibility = Visibility.Hidden;
            //tl17.Visibility = Visibility.Hidden;
            //tl18.Visibility = Visibility.Hidden;
            //tl19.Visibility = Visibility.Hidden;
            //tl20.Visibility = Visibility.Hidden;
            //tl21.Visibility = Visibility.Hidden;
            //tl22.Visibility = Visibility.Hidden;
            //tl23.Visibility = Visibility.Hidden;
            //tl24.Visibility = Visibility.Hidden;
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            
            b1 = "Bfol_id"; b2 = "Bfol_date";
            get_details(b1, b2, tyre_vehicle_number.Text);
            //tl1.Visibility = Visibility.Hidden;
            //tl2.Visibility = Visibility.Hidden;
            //tl3.Visibility = Visibility.Hidden;
            //tl4.Visibility = Visibility.Hidden;
            //tl5.Visibility = Visibility.Hidden;
            //tl6.Visibility = Visibility.Hidden;
            //tl7.Visibility = Visibility.Visible;
            //tl8.Visibility = Visibility.Visible;
            //tl9.Visibility = Visibility.Hidden;
            //tl10.Visibility = Visibility.Hidden;
            //tl11.Visibility = Visibility.Hidden;
            //tl12.Visibility = Visibility.Hidden;
            //tl13.Visibility = Visibility.Hidden;
            //tl14.Visibility = Visibility.Hidden;
            //tl15.Visibility = Visibility.Hidden;
            //tl16.Visibility = Visibility.Hidden;
            //tl17.Visibility = Visibility.Hidden;
            //tl18.Visibility = Visibility.Hidden;
            //tl19.Visibility = Visibility.Hidden;
            //tl20.Visibility = Visibility.Hidden;
            //tl21.Visibility = Visibility.Hidden;
            //tl22.Visibility = Visibility.Hidden;
            //tl23.Visibility = Visibility.Hidden;
            //tl24.Visibility = Visibility.Hidden;
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
           
            b1 = "Bbil_id"; b2 = "Bbil_date";
            get_details(b1, b2, tyre_vehicle_number.Text);
            //tl1.Visibility = Visibility.Hidden;
            //tl2.Visibility = Visibility.Hidden;
            //tl3.Visibility = Visibility.Hidden;
            //tl4.Visibility = Visibility.Hidden;
            //tl5.Visibility = Visibility.Hidden;
            //tl6.Visibility = Visibility.Hidden;
            //tl7.Visibility = Visibility.Hidden;
            //tl8.Visibility = Visibility.Hidden;
            //tl9.Visibility = Visibility.Visible;
            //tl10.Visibility = Visibility.Visible;
            //tl11.Visibility = Visibility.Hidden;
            //tl12.Visibility = Visibility.Hidden;
            //tl13.Visibility = Visibility.Hidden;
            //tl14.Visibility = Visibility.Hidden;
            //tl15.Visibility = Visibility.Hidden;
            //tl16.Visibility = Visibility.Hidden;
            //tl17.Visibility = Visibility.Hidden;
            //tl18.Visibility = Visibility.Hidden;
            //tl19.Visibility = Visibility.Hidden;
            //tl20.Visibility = Visibility.Hidden;
            //tl21.Visibility = Visibility.Hidden;
            //tl22.Visibility = Visibility.Hidden;
            //tl23.Visibility = Visibility.Hidden;
            //tl24.Visibility = Visibility.Hidden;
        }

        private void but6_Click(object sender, RoutedEventArgs e)
        {
           
            b1 = "Bbol_id"; b2 = "Bbol_date";
            get_details(b1, b2, tyre_vehicle_number.Text);
            //tl1.Visibility = Visibility.Hidden;
            //tl2.Visibility = Visibility.Hidden;
            //tl3.Visibility = Visibility.Hidden;
            //tl4.Visibility = Visibility.Hidden;
            //tl5.Visibility = Visibility.Hidden;
            //tl6.Visibility = Visibility.Hidden;
            //tl7.Visibility = Visibility.Hidden;
            //tl8.Visibility = Visibility.Hidden;
            //tl9.Visibility = Visibility.Hidden;
            //tl10.Visibility = Visibility.Hidden;
            //tl11.Visibility = Visibility.Visible;
            //tl12.Visibility = Visibility.Visible;
            //tl13.Visibility = Visibility.Hidden;
            //tl14.Visibility = Visibility.Hidden;
            //tl15.Visibility = Visibility.Hidden;
            //tl16.Visibility = Visibility.Hidden;
            //tl17.Visibility = Visibility.Hidden;
            //tl18.Visibility = Visibility.Hidden;
            //tl19.Visibility = Visibility.Hidden;
            //tl20.Visibility = Visibility.Hidden;
            //tl21.Visibility = Visibility.Hidden;
            //tl22.Visibility = Visibility.Hidden;
            //tl23.Visibility = Visibility.Hidden;
            //tl24.Visibility = Visibility.Hidden;
        }

        private void but7_Click(object sender, RoutedEventArgs e)
        {
           
            b1 = "Fr_id"; b2 = "Fr_date";
            get_details(b1, b2, tyre_vehicle_number.Text);
            //tl1.Visibility = Visibility.Hidden;
            //tl2.Visibility = Visibility.Hidden;
            //tl3.Visibility = Visibility.Hidden;
            //tl4.Visibility = Visibility.Hidden;
            //tl5.Visibility = Visibility.Hidden;
            //tl6.Visibility = Visibility.Hidden;
            //tl7.Visibility = Visibility.Hidden;
            //tl8.Visibility = Visibility.Hidden;
            //tl9.Visibility = Visibility.Hidden;
            //tl10.Visibility = Visibility.Hidden;
            //tl11.Visibility = Visibility.Hidden;
            //tl12.Visibility = Visibility.Hidden;
            //tl13.Visibility = Visibility.Visible;
            //tl14.Visibility = Visibility.Visible;
            //tl15.Visibility = Visibility.Hidden;
            //tl16.Visibility = Visibility.Hidden;
            //tl17.Visibility = Visibility.Hidden;
            //tl18.Visibility = Visibility.Hidden;
            //tl19.Visibility = Visibility.Hidden;
            //tl20.Visibility = Visibility.Hidden;
            //tl21.Visibility = Visibility.Hidden;
            //tl22.Visibility = Visibility.Hidden;
            //tl23.Visibility = Visibility.Hidden;
            //tl24.Visibility = Visibility.Hidden;
        }

        private void but8_Click(object sender, RoutedEventArgs e)
        {
            b1 = "Cr_id"; b2 = "Cr_date";
            get_details(b1, b2, tyre_vehicle_number.Text);
            //tl1.Visibility = Visibility.Hidden;
            //tl2.Visibility = Visibility.Hidden;
            //tl3.Visibility = Visibility.Hidden;
            //tl4.Visibility = Visibility.Hidden;
            //tl5.Visibility = Visibility.Hidden;
            //tl6.Visibility = Visibility.Hidden;
            //tl7.Visibility = Visibility.Hidden;
            //tl8.Visibility = Visibility.Hidden;
            //tl9.Visibility = Visibility.Hidden;
            //tl10.Visibility = Visibility.Hidden;
            //tl11.Visibility = Visibility.Hidden;
            //tl12.Visibility = Visibility.Hidden;
            //tl13.Visibility = Visibility.Hidden;
            //tl14.Visibility = Visibility.Hidden;
            //tl15.Visibility = Visibility.Visible;
            //tl16.Visibility = Visibility.Visible;
            //tl17.Visibility = Visibility.Hidden;
            //tl18.Visibility = Visibility.Hidden;
            //tl19.Visibility = Visibility.Hidden;
            //tl20.Visibility = Visibility.Hidden;
            //tl21.Visibility = Visibility.Hidden;
            //tl22.Visibility = Visibility.Hidden;
            //tl23.Visibility = Visibility.Hidden;
            //tl24.Visibility = Visibility.Hidden;
        }

        private void but9_Click(object sender, RoutedEventArgs e)
        {
            b1 = "Bfir_id"; b2 = "Bfir_date";
            get_details(b1, b2, tyre_vehicle_number.Text);
            //tl1.Visibility = Visibility.Hidden;
            //tl2.Visibility = Visibility.Hidden;
            //tl3.Visibility = Visibility.Hidden;
            //tl4.Visibility = Visibility.Hidden;
            //tl5.Visibility = Visibility.Hidden;
            //tl6.Visibility = Visibility.Hidden;
            //tl7.Visibility = Visibility.Hidden;
            //tl8.Visibility = Visibility.Hidden;
            //tl9.Visibility = Visibility.Hidden;
            //tl10.Visibility = Visibility.Hidden;
            //tl11.Visibility = Visibility.Hidden;
            //tl12.Visibility = Visibility.Hidden;
            //tl13.Visibility = Visibility.Hidden;
            //tl14.Visibility = Visibility.Hidden;
            //tl15.Visibility = Visibility.Hidden;
            //tl16.Visibility = Visibility.Hidden;
            //tl17.Visibility = Visibility.Visible;
            //tl18.Visibility = Visibility.Visible;
            //tl19.Visibility = Visibility.Hidden;
            //tl20.Visibility = Visibility.Hidden;
            //tl21.Visibility = Visibility.Hidden;
            //tl22.Visibility = Visibility.Hidden;
            //tl23.Visibility = Visibility.Hidden;
            //tl24.Visibility = Visibility.Hidden;
        }

        private void but10_Click(object sender, RoutedEventArgs e)
        {
            
            b1 = "Bfor_id"; b2 = "Bfor_date";
            get_details(b1, b2, tyre_vehicle_number.Text);
            //tl1.Visibility = Visibility.Hidden;
            //tl2.Visibility = Visibility.Hidden;
            //tl3.Visibility = Visibility.Hidden;
            //tl4.Visibility = Visibility.Hidden;
            //tl5.Visibility = Visibility.Hidden;
            //tl6.Visibility = Visibility.Hidden;
            //tl7.Visibility = Visibility.Hidden;
            //tl8.Visibility = Visibility.Hidden;
            //tl9.Visibility = Visibility.Hidden;
            //tl10.Visibility = Visibility.Hidden;
            //tl11.Visibility = Visibility.Hidden;
            //tl12.Visibility = Visibility.Hidden;
            //tl13.Visibility = Visibility.Hidden;
            //tl14.Visibility = Visibility.Hidden;
            //tl15.Visibility = Visibility.Hidden;
            //tl16.Visibility = Visibility.Hidden;
            //tl17.Visibility = Visibility.Hidden;
            //tl18.Visibility = Visibility.Hidden;
            //tl19.Visibility = Visibility.Visible;
            //tl20.Visibility = Visibility.Visible;
            //tl21.Visibility = Visibility.Hidden;
            //tl22.Visibility = Visibility.Hidden;
            //tl23.Visibility = Visibility.Hidden;
            //tl24.Visibility = Visibility.Hidden;

        }

        private void but11_Click(object sender, RoutedEventArgs e)
        {
            
            b1 = "Bbir_id"; b2 = "Bbir_date";
            get_details(b1, b2, tyre_vehicle_number.Text);
            //tl1.Visibility = Visibility.Hidden;
            //tl2.Visibility = Visibility.Hidden;
            //tl3.Visibility = Visibility.Hidden;
            //tl4.Visibility = Visibility.Hidden;
            //tl5.Visibility = Visibility.Hidden;
            //tl6.Visibility = Visibility.Hidden;
            //tl7.Visibility = Visibility.Hidden;
            //tl8.Visibility = Visibility.Hidden;
            //tl9.Visibility = Visibility.Hidden;
            //tl10.Visibility = Visibility.Hidden;
            //tl11.Visibility = Visibility.Hidden;
            //tl12.Visibility = Visibility.Hidden;
            //tl13.Visibility = Visibility.Hidden;
            //tl14.Visibility = Visibility.Hidden;
            //tl15.Visibility = Visibility.Hidden;
            //tl16.Visibility = Visibility.Hidden;
            //tl17.Visibility = Visibility.Hidden;
            //tl18.Visibility = Visibility.Hidden;
            //tl19.Visibility = Visibility.Hidden;
            //tl20.Visibility = Visibility.Hidden;
            //tl21.Visibility = Visibility.Visible;
            //tl22.Visibility = Visibility.Visible;
            //tl23.Visibility = Visibility.Hidden;
            //tl24.Visibility = Visibility.Hidden;

        }

        private void but12_Click(object sender, RoutedEventArgs e)
        {
           
            b1 = "Bbor_id"; b2 = "Bbor_date";
            get_details(b1, b2, tyre_vehicle_number.Text);
            //tl1.Visibility = Visibility.Hidden;
            //tl2.Visibility = Visibility.Hidden;
            //tl3.Visibility = Visibility.Hidden;
            //tl4.Visibility = Visibility.Hidden;
            //tl5.Visibility = Visibility.Hidden;
            //tl6.Visibility = Visibility.Hidden;
            //tl7.Visibility = Visibility.Hidden;
            //tl8.Visibility = Visibility.Hidden;
            //tl9.Visibility = Visibility.Hidden;
            //tl10.Visibility = Visibility.Hidden;
            //tl11.Visibility = Visibility.Hidden;
            //tl12.Visibility = Visibility.Hidden;
            //tl13.Visibility = Visibility.Hidden;
            //tl14.Visibility = Visibility.Hidden;
            //tl15.Visibility = Visibility.Hidden;
            //tl16.Visibility = Visibility.Hidden;
            //tl17.Visibility = Visibility.Hidden;
            //tl18.Visibility = Visibility.Hidden;
            //tl19.Visibility = Visibility.Hidden;
            //tl20.Visibility = Visibility.Hidden;
            //tl21.Visibility = Visibility.Hidden;
            //tl22.Visibility = Visibility.Hidden;
            //tl23.Visibility = Visibility.Visible;
            //tl24.Visibility = Visibility.Visible;
        }

        private void view_Click(object sender, RoutedEventArgs e)
        {

            Connection con = new Connection();
            con.open_connection();
            OdbcCommand cmd = new OdbcCommand("select No,Starting_KM from load_tyre_details where vehicle_number='" + tyre_vehicle_number.Text + "'", con.conn);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

        }

        private void tyre_print_panel_open(object sender, RoutedEventArgs e)
        {

        }

        private void but13_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
