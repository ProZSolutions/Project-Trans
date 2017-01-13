using System;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.Odbc;
using System.Windows.Input;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Project_Transport
{
    /// <summary>
    /// Interaction logic for Trailer_Tyre_Entry.xaml
    /// </summary>
    public partial class Trailer_Tyre_Entry : UserControl
    {
        public Trailer_Tyre_Entry()
        {
            InitializeComponent();
            time1.Interval = new TimeSpan(0, 0, 0, 0, 100);
            time1.Tick += time_tick1;
        }
        string p1 = null;string p2 = null;
        System.Windows.Threading.DispatcherTimer time1 = new System.Windows.Threading.DispatcherTimer();
        //int ii = 0;
        //string chr = null;
        Trailer_Tyre_View ttv = new Trailer_Tyre_View();
        void time_tick1(object sender, EventArgs e)
        {
            //if (ii == 10)
            //{
            //    if (chr == "i")
            //    {
            //        tyre_insert_img1.Visibility = System.Windows.Visibility.Visible;
            //        tyre_insert_img2.Visibility = System.Windows.Visibility.Hidden;
            //        time1.Stop();
            //        chr = "";
            //    }
            //    else if (chr == "u")
            //    {
            //        tyre_update_img1.Visibility = System.Windows.Visibility.Visible;
            //        tyre_update_img2.Visibility = System.Windows.Visibility.Hidden;
            //        time1.Stop();
            //        chr = "";
            //    }
            //}
            //ii++;
        }
        private void tyre_vehicle_number_GotFocus(object sender, RoutedEventArgs e)
        {
            Connection con = new Connection();
            con.connection_string();
            OdbcCommand cmd = new OdbcCommand("select vehicle_no from trailer", con.str);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tyre_vehicle_numbers.Items.Clear();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tyre_vehicle_numbers.Items.Add(dt.Rows[i]["vehicle_no"]);
                }
            }
            con.close_string();
        }
      

       

        void tank_back_left_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "acol_id";p2 = "acol_date";
            ttv.Get_Details(p1,p2,tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void tank_back_left_inner_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "acil_id"; p2 = "acil_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }


        void tank_front_left_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "afol_id"; p2 = "afol_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void tank_front_left_inner_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "afil_id"; p2 = "afil_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void zeep_back_left_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "cbol_id"; p2 = "cbol_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void zeep_back_left_inner_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "cbil_id"; p2 = "cbil_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void zeep_center_left_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "cfol_id"; p2 = "ccol_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void zeep_center_left_inner_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "cfil_id"; p2 = "ccil_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void zeep_front_left_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "fl_id"; p2 = "fl_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void tank_back_right_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "acor_id"; p2 = "acor_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void tank_back_right_inner_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "acir_id"; p2 = "acir_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void tank_front_right_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "afor_id"; p2 = "afor_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void tank_front_right_inner_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "afir_id"; p2 = "afir_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void zeep_back_right_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "cbor_id"; p2 = "cbor_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void zeep_back_right_inner_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "cbir_id"; p2 = "cbir_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void zeep_center_right_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "cfor_id"; p2 = "ccor_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void zeep_center_right_inner_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "cfir_id"; p2 = "ccir_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        void zeep_front_right(object sender, RoutedEventArgs e)
        {
            p1 = "fr_id"; p2 = "fr_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        private void tank_back1_left_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "abol_id"; p2 = "abol_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        private void tank_back2_left_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "abil_id"; p2 = "abil_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        private void tank_back3_left_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "abor_id"; p2 = "abor_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        private void tank_back4_left_outer_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "abir_id"; p2 = "abir_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }

        private void stepny_clicked(object sender, RoutedEventArgs e)
        {
            p1 = "adt_id"; p2 = "adt_date";
            ttv.Get_Details(p1, p2, tyre_vehicle_numbers.Text);
            ttv.ShowDialog();
        }
        


        void tyre_print_panel_open(object sender, RoutedEventArgs e)
        {
            tyre_print_panel.Visibility = Visibility.Visible;
            if (!string.IsNullOrWhiteSpace(tyre_vehicle_numbers.Text))
            {
                print_data();
            }
            else
            {
                MessageBox.Show("Please Select Vehicle Number");
            }

        }

        void Tyre_Report_Back_Click(object sender, RoutedEventArgs e)
        {
            tyre_print_panel.Visibility = Visibility.Hidden;
            Report_Viewer.Clear();
        }
        void print_data()
        {
            ReportParameter[] param = new ReportParameter[98];
            try
            {
                Connection con = new Connection();
                con.connection_string();
                OdbcCommand cmd = new OdbcCommand("SELECT * FROM crown_left JOIN crown_right ON crown_left.VEHICLE_NUMBER=crown_right.VEHICLE_NUMBER WHERE crown_left.VEHICLE_NUMBER='" + tyre_vehicle_numbers.Text + "' ", con.str);
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                MainWindow m = new MainWindow();
                //Report_Viewer.Clear();
                Report_Viewer.LocalReport.ReportEmbeddedResource = "Project_Transport.Tyre_Details_Report.rdlc";
                param[0] = new ReportParameter("Title_Param", m.Title_Name.Content.ToString());
                param[1] = new ReportParameter("Vehicle_Number_Param", (tyre_vehicle_numbers.Text).ToString());
                param[2] = new ReportParameter("Date_Param", Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy"));
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string r1, r2, r3, r4, r5;
                    r1 = dt.Rows[0]["cfl_type"].ToString();
                    if (r1 == "N")
                    {
                        param[3] = new ReportParameter("Left_Param1", "NEW");
                        param[4] = new ReportParameter("Left_Param2", dt.Rows[0]["cfl_tyre_no"].ToString());
                        param[5] = new ReportParameter("Left_Param3", dt.Rows[0]["cfl_km"].ToString());
                        param[6] = new ReportParameter("Left_Param4", dt.Rows[0]["cfl_company"].ToString());
                        param[7] = new ReportParameter("Left_Param5", Convert.ToDateTime(dt.Rows[0]["cfl_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r1 == "B")
                    {
                        param[3] = new ReportParameter("Left_Param1", "RE-BUILD");
                        param[4] = new ReportParameter("Left_Param2", dt.Rows[0]["cfl_tyre_no"].ToString());
                        param[5] = new ReportParameter("Left_Param3", dt.Rows[0]["cfl_km"].ToString());
                        param[6] = new ReportParameter("Left_Param4", dt.Rows[0]["cfl_company"].ToString());
                        param[7] = new ReportParameter("Left_Param5", Convert.ToDateTime(dt.Rows[0]["cfl_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[3] = new ReportParameter("Left_Param1", "Nil");
                        param[4] = new ReportParameter("Left_Param2", "Nil");
                        param[5] = new ReportParameter("Left_Param3", "Nil");
                        param[6] = new ReportParameter("Left_Param4", "Nil");
                        param[7] = new ReportParameter("Left_Param5", "Nil");
                    }
                    r2 = dt.Rows[0]["cclin_type"].ToString();
                    if (r2 == "N")
                    {
                        param[8] = new ReportParameter("Left_Param11", "NEW");
                        param[9] = new ReportParameter("Left_Param12", dt.Rows[0]["cclin_tyre_no"].ToString());
                        param[10] = new ReportParameter("Left_Param13", dt.Rows[0]["cclin_km"].ToString());
                        param[11] = new ReportParameter("Left_Param14", dt.Rows[0]["cclin_company"].ToString());
                        param[12] = new ReportParameter("Left_Param15", Convert.ToDateTime(dt.Rows[0]["cclin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r2 == "B")
                    {
                        param[8] = new ReportParameter("Left_Param11", "RE-BUILD");
                        param[9] = new ReportParameter("Left_Param12", dt.Rows[0]["cclin_tyre_no"].ToString());
                        param[10] = new ReportParameter("Left_Param13", dt.Rows[0]["cclin_km"].ToString());
                        param[11] = new ReportParameter("Left_Param14", dt.Rows[0]["cclin_company"].ToString());
                        param[12] = new ReportParameter("Left_Param15", Convert.ToDateTime(dt.Rows[0]["cclin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[8] = new ReportParameter("Left_Param11", "Nil");
                        param[9] = new ReportParameter("Left_Param12", "Nil");
                        param[10] = new ReportParameter("Left_Param13", "Nil");
                        param[11] = new ReportParameter("Left_Param14", "Nil");
                        param[12] = new ReportParameter("Left_Param15", "Nil");
                    }
                    r3 = dt.Rows[0]["cclout_type"].ToString();
                    if (r3 == "N")
                    {
                        param[13] = new ReportParameter("Left_Param6", "NEW");
                        param[14] = new ReportParameter("Left_Param7", dt.Rows[0]["cclout_tyre_no"].ToString());
                        param[15] = new ReportParameter("Left_Param8", dt.Rows[0]["cclout_km"].ToString());
                        param[16] = new ReportParameter("Left_Param9", dt.Rows[0]["cclout_company"].ToString());
                        param[17] = new ReportParameter("Left_Param10", Convert.ToDateTime(dt.Rows[0]["cclout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r3 == "B")
                    {
                        param[13] = new ReportParameter("Left_Param6", "RE-Build");
                        param[14] = new ReportParameter("Left_Param7", dt.Rows[0]["cclout_tyre_no"].ToString());
                        param[15] = new ReportParameter("Left_Param8", dt.Rows[0]["cclout_km"].ToString());
                        param[16] = new ReportParameter("Left_Param9", dt.Rows[0]["cclout_company"].ToString());
                        param[17] = new ReportParameter("Left_Param10", Convert.ToDateTime(dt.Rows[0]["cclout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[13] = new ReportParameter("Left_Param6", "Nil");
                        param[14] = new ReportParameter("Left_Param7", "Nil");
                        param[15] = new ReportParameter("Left_Param8", "Nil");
                        param[16] = new ReportParameter("Left_Param9", "Nil");
                        param[17] = new ReportParameter("Left_Param10", "Nil");
                    }
                    r4 = dt.Rows[0]["cblin_type"].ToString();
                    if (r4 == "N")
                    {
                        param[18] = new ReportParameter("Left_Param21", "NEW");
                        param[19] = new ReportParameter("Left_Param22", dt.Rows[0]["cblin_tyre_no"].ToString());
                        param[20] = new ReportParameter("Left_Param23", dt.Rows[0]["cblin_km"].ToString());
                        param[21] = new ReportParameter("Left_Param24", dt.Rows[0]["cblin_company"].ToString());
                        param[22] = new ReportParameter("Left_Param25", Convert.ToDateTime(dt.Rows[0]["cblin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r4 == "B")
                    {
                        param[18] = new ReportParameter("Left_Param21", "RE-BUILD");
                        param[19] = new ReportParameter("Left_Param22", dt.Rows[0]["cblin_tyre_no"].ToString());
                        param[20] = new ReportParameter("Left_Param23", dt.Rows[0]["cblin_km"].ToString());
                        param[21] = new ReportParameter("Left_Param24", dt.Rows[0]["cblin_company"].ToString());
                        param[22] = new ReportParameter("Left_Param25", Convert.ToDateTime(dt.Rows[0]["cblin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[18] = new ReportParameter("Left_Param21", "Nil");
                        param[19] = new ReportParameter("Left_Param22", "Nil");
                        param[20] = new ReportParameter("Left_Param23", "Nil");
                        param[21] = new ReportParameter("Left_Param24", "Nil");
                        param[22] = new ReportParameter("Left_Param25", "Nil");
                    }
                    r5 = dt.Rows[0]["cblout_type"].ToString();
                    if (r5 == "N")
                    {
                        param[23] = new ReportParameter("Left_Param16", "NEW");
                        param[24] = new ReportParameter("Left_Param17", dt.Rows[0]["cblout_tyre_no"].ToString());
                        param[25] = new ReportParameter("Left_Param18", dt.Rows[0]["cblout_km"].ToString());
                        param[26] = new ReportParameter("Left_Param19", dt.Rows[0]["cblout_company"].ToString());
                        param[27] = new ReportParameter("Left_Param20", Convert.ToDateTime(dt.Rows[0]["cblout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r5 == "B")
                    {
                        param[23] = new ReportParameter("Left_Param16", "RE-BUILD");
                        param[24] = new ReportParameter("Left_Param17", dt.Rows[0]["cblout_tyre_no"].ToString());
                        param[25] = new ReportParameter("Left_Param18", dt.Rows[0]["cblout_km"].ToString());
                        param[26] = new ReportParameter("Left_Param19", dt.Rows[0]["cblout_company"].ToString());
                        param[27] = new ReportParameter("Left_Param20", Convert.ToDateTime(dt.Rows[0]["cblout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[23] = new ReportParameter("Left_Param16", "Nil");
                        param[24] = new ReportParameter("Left_Param17", "Nil");
                        param[25] = new ReportParameter("Left_Param18", "Nil");
                        param[26] = new ReportParameter("Left_Param19", "Nil");
                        param[27] = new ReportParameter("Left_Param20", "Nil");
                    }
                    string r6, r7, r8, r9, r10;
                    r6 = dt.Rows[0]["cfr_type"].ToString();
                    if (r6 == "N")
                    {
                        param[28] = new ReportParameter("Right_Param1", "NEW");
                        param[29] = new ReportParameter("Right_Param2", dt.Rows[0]["cfr_tyre_no"].ToString());
                        param[30] = new ReportParameter("Right_Param3", dt.Rows[0]["cfr_km"].ToString());
                        param[31] = new ReportParameter("Right_Param4", dt.Rows[0]["cfr_company"].ToString());
                        param[32] = new ReportParameter("Right_Param5", Convert.ToDateTime(dt.Rows[0]["cfr_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r6 == "B")
                    {
                        param[28] = new ReportParameter("Right_Param1", "RE-BUILD");
                        param[29] = new ReportParameter("Right_Param2", dt.Rows[0]["cfr_tyre_no"].ToString());
                        param[30] = new ReportParameter("Right_Param3", dt.Rows[0]["cfr_km"].ToString());
                        param[31] = new ReportParameter("Right_Param4", dt.Rows[0]["cfr_company"].ToString());
                        param[32] = new ReportParameter("Right_Param5", Convert.ToDateTime(dt.Rows[0]["cfr_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[28] = new ReportParameter("Right_Param1", "Nil");
                        param[29] = new ReportParameter("Right_Param2", "Nil");
                        param[30] = new ReportParameter("Right_Param3", "Nil");
                        param[31] = new ReportParameter("Right_Param4", "Nil");
                        param[32] = new ReportParameter("Right_Param5", "Nil");
                    }
                    r7 = dt.Rows[0]["ccrin_type"].ToString();
                    if (r7 == "N")
                    {
                        param[33] = new ReportParameter("Right_Param6", "NEW");
                        param[34] = new ReportParameter("Right_Param7", dt.Rows[0]["ccrin_tyre_no"].ToString());
                        param[35] = new ReportParameter("Right_Param8", dt.Rows[0]["ccrin_km"].ToString());
                        param[36] = new ReportParameter("Right_Param9", dt.Rows[0]["ccrin_company"].ToString());
                        param[37] = new ReportParameter("Right_Param10", Convert.ToDateTime(dt.Rows[0]["ccrin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r7 == "B")
                    {
                        param[33] = new ReportParameter("Right_Param6", "RE-BUILD");
                        param[34] = new ReportParameter("Right_Param7", dt.Rows[0]["ccrin_tyre_no"].ToString());
                        param[35] = new ReportParameter("Right_Param8", dt.Rows[0]["ccrin_km"].ToString());
                        param[36] = new ReportParameter("Right_Param9", dt.Rows[0]["ccrin_company"].ToString());
                        param[37] = new ReportParameter("Right_Param10", Convert.ToDateTime(dt.Rows[0]["ccrin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[33] = new ReportParameter("Right_Param6", "Nil");
                        param[34] = new ReportParameter("Right_Param7", "Nil");
                        param[35] = new ReportParameter("Right_Param8", "Nil");
                        param[36] = new ReportParameter("Right_Param9", "Nil");
                        param[37] = new ReportParameter("Right_Param10", "Nil");
                    }
                    r8 = dt.Rows[0]["ccrout_type"].ToString();
                    if (r8 == "N")
                    {
                        param[38] = new ReportParameter("Right_Param11", "NEW");
                        param[39] = new ReportParameter("Right_Param12", dt.Rows[0]["ccrout_tyre_no"].ToString());
                        param[40] = new ReportParameter("Right_Param13", dt.Rows[0]["ccrout_km"].ToString());
                        param[41] = new ReportParameter("Right_Param14", dt.Rows[0]["ccrout_company"].ToString());
                        param[42] = new ReportParameter("Right_Param15", Convert.ToDateTime(dt.Rows[0]["ccrout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r8 == "B")
                    {
                        param[38] = new ReportParameter("Right_Param11", "RE-BUILD");
                        param[39] = new ReportParameter("Right_Param12", dt.Rows[0]["ccrout_tyre_no"].ToString());
                        param[40] = new ReportParameter("Right_Param13", dt.Rows[0]["ccrout_km"].ToString());
                        param[41] = new ReportParameter("Right_Param14", dt.Rows[0]["ccrout_company"].ToString());
                        param[42] = new ReportParameter("Right_Param15", Convert.ToDateTime(dt.Rows[0]["ccrout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[38] = new ReportParameter("Right_Param11", "Nil");
                        param[39] = new ReportParameter("Right_Param12", "Nil");
                        param[40] = new ReportParameter("Right_Param13", "Nil");
                        param[41] = new ReportParameter("Right_Param14", "Nil");
                        param[42] = new ReportParameter("Right_Param15", "Nil");
                    }
                    r9 = dt.Rows[0]["cbrin_type"].ToString();
                    if (r9 == "N")
                    {
                        param[43] = new ReportParameter("Right_Param16", "NEW");
                        param[44] = new ReportParameter("Right_Param17", dt.Rows[0]["cbrin_tyre_no"].ToString());
                        param[45] = new ReportParameter("Right_Param18", dt.Rows[0]["cbrin_km"].ToString());
                        param[46] = new ReportParameter("Right_Param19", dt.Rows[0]["cbrin_company"].ToString());
                        param[47] = new ReportParameter("Right_Param20", Convert.ToDateTime(dt.Rows[0]["cbrin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r9 == "B")
                    {
                        param[43] = new ReportParameter("Right_Param16", "RE-BUILD");
                        param[44] = new ReportParameter("Right_Param17", dt.Rows[0]["cbrin_tyre_no"].ToString());
                        param[45] = new ReportParameter("Right_Param18", dt.Rows[0]["cbrin_km"].ToString());
                        param[46] = new ReportParameter("Right_Param19", dt.Rows[0]["cbrin_company"].ToString());
                        param[47] = new ReportParameter("Right_Param20", Convert.ToDateTime(dt.Rows[0]["cbrin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[43] = new ReportParameter("Right_Param16", "Nil");
                        param[44] = new ReportParameter("Right_Param17", "Nil");
                        param[45] = new ReportParameter("Right_Param18", "Nil");
                        param[46] = new ReportParameter("Right_Param19", "Nil");
                        param[47] = new ReportParameter("Right_Param20", "Nil");
                    }
                    r10 = dt.Rows[0]["cbrout_type"].ToString();
                    if (r10 == "N")
                    {
                        param[48] = new ReportParameter("Right_Param21", "NEW");
                        param[49] = new ReportParameter("Right_Param22", dt.Rows[0]["cbrout_tyre_no"].ToString());
                        param[50] = new ReportParameter("Right_Param23", dt.Rows[0]["cbrout_km"].ToString());
                        param[51] = new ReportParameter("Right_Param24", dt.Rows[0]["cbrout_company"].ToString());
                        param[52] = new ReportParameter("Right_Param25", Convert.ToDateTime(dt.Rows[0]["cbrout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r10 == "B")
                    {
                        param[48] = new ReportParameter("Right_Param21", "RE-BUILD");
                        param[49] = new ReportParameter("Right_Param22", dt.Rows[0]["cbrout_tyre_no"].ToString());
                        param[50] = new ReportParameter("Right_Param23", dt.Rows[0]["cbrout_km"].ToString());
                        param[51] = new ReportParameter("Right_Param24", dt.Rows[0]["cbrout_company"].ToString());
                        param[52] = new ReportParameter("Right_Param25", Convert.ToDateTime(dt.Rows[0]["cbrout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[48] = new ReportParameter("Right_Param21", "Nil");
                        param[49] = new ReportParameter("Right_Param22", "Nil");
                        param[50] = new ReportParameter("Right_Param23", "Nil");
                        param[51] = new ReportParameter("Right_Param24", "Nil");
                        param[52] = new ReportParameter("Right_Param25", "Nil");
                    }
                    string r11 = dt.Rows[0]["add_type"].ToString();
                    if (r11 == "N")
                    {
                        param[93] = new ReportParameter("Add_type", "NEW");
                        param[94] = new ReportParameter("Add_tyre_no", dt.Rows[0]["add_tyre_no"].ToString());
                        param[95] = new ReportParameter("Add_km", dt.Rows[0]["add_km"].ToString());
                        param[96] = new ReportParameter("Add_company", dt.Rows[0]["add_company"].ToString());
                        param[97] = new ReportParameter("Add_date", Convert.ToDateTime(dt.Rows[0]["add_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r11 == "B")
                    {
                        param[93] = new ReportParameter("Add_type", "RE-BUILD");
                        param[94] = new ReportParameter("Add_tyre_no", dt.Rows[0]["add_tyre_no"].ToString());
                        param[95] = new ReportParameter("Add_km", dt.Rows[0]["add_km"].ToString());
                        param[96] = new ReportParameter("Add_company", dt.Rows[0]["add_company"].ToString());
                        param[97] = new ReportParameter("Add_date", Convert.ToDateTime(dt.Rows[0]["add_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[93] = new ReportParameter("Add_type", "Nil");
                        param[94] = new ReportParameter("Add_tyre_no", "Nil");
                        param[95] = new ReportParameter("Add_km", "Nil");
                        param[96] = new ReportParameter("Add_company", "Nil");
                        param[97] = new ReportParameter("Add_date", "Nil");
                    }
                    con.close_string();
                }
                else
                {
                    //MessageBox.Show("Record Doesnot Exist");
                    param[3] = new ReportParameter("Left_Param1", "Nil");
                    param[4] = new ReportParameter("Left_Param2", "Nil");
                    param[5] = new ReportParameter("Left_Param3", "Nil");
                    param[6] = new ReportParameter("Left_Param4", "Nil");
                    param[7] = new ReportParameter("Left_Param5", "Nil");
                    param[8] = new ReportParameter("Left_Param11", "Nil");
                    param[9] = new ReportParameter("Left_Param12", "Nil");
                    param[10] = new ReportParameter("Left_Param13", "Nil");
                    param[11] = new ReportParameter("Left_Param14", "Nil");
                    param[12] = new ReportParameter("Left_Param15", "Nil");
                    param[13] = new ReportParameter("Left_Param6", "Nil");
                    param[14] = new ReportParameter("Left_Param7", "Nil");
                    param[15] = new ReportParameter("Left_Param8", "Nil");
                    param[16] = new ReportParameter("Left_Param9", "Nil");
                    param[17] = new ReportParameter("Left_Param10", "Nil");
                    param[18] = new ReportParameter("Left_Param21", "Nil");
                    param[19] = new ReportParameter("Left_Param22", "Nil");
                    param[20] = new ReportParameter("Left_Param23", "Nil");
                    param[21] = new ReportParameter("Left_Param24", "Nil");
                    param[22] = new ReportParameter("Left_Param25", "Nil");
                    param[23] = new ReportParameter("Left_Param16", "Nil");
                    param[24] = new ReportParameter("Left_Param17", "Nil");
                    param[25] = new ReportParameter("Left_Param18", "Nil");
                    param[26] = new ReportParameter("Left_Param19", "Nil");
                    param[27] = new ReportParameter("Left_Param20", "Nil");
                    param[28] = new ReportParameter("Right_Param1", "Nil");
                    param[29] = new ReportParameter("Right_Param2", "Nil");
                    param[30] = new ReportParameter("Right_Param3", "Nil");
                    param[31] = new ReportParameter("Right_Param4", "Nil");
                    param[32] = new ReportParameter("Right_Param5", "Nil");
                    param[33] = new ReportParameter("Right_Param6", "Nil");
                    param[34] = new ReportParameter("Right_Param7", "Nil");
                    param[35] = new ReportParameter("Right_Param8", "Nil");
                    param[36] = new ReportParameter("Right_Param9", "Nil");
                    param[37] = new ReportParameter("Right_Param10", "Nil");
                    param[38] = new ReportParameter("Right_Param11", "Nil");
                    param[39] = new ReportParameter("Right_Param12", "Nil");
                    param[40] = new ReportParameter("Right_Param13", "Nil");
                    param[41] = new ReportParameter("Right_Param14", "Nil");
                    param[42] = new ReportParameter("Right_Param15", "Nil");
                    param[43] = new ReportParameter("Right_Param16", "Nil");
                    param[44] = new ReportParameter("Right_Param17", "Nil");
                    param[45] = new ReportParameter("Right_Param18", "Nil");
                    param[46] = new ReportParameter("Right_Param19", "Nil");
                    param[47] = new ReportParameter("Right_Param20", "Nil");
                    param[48] = new ReportParameter("Right_Param21", "Nil");
                    param[49] = new ReportParameter("Right_Param22", "Nil");
                    param[50] = new ReportParameter("Right_Param23", "Nil");
                    param[51] = new ReportParameter("Right_Param24", "Nil");
                    param[52] = new ReportParameter("Right_Param25", "Nil");
                    param[93] = new ReportParameter("Add_type", "Nil");
                    param[94] = new ReportParameter("Add_tyre_no", "Nil");
                    param[95] = new ReportParameter("Add_km", "Nil");
                    param[96] = new ReportParameter("Add_company", "Nil");
                    param[97] = new ReportParameter("Add_date", "Nil");
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error :" + ex);
            }
            try
            {
                Connection con3 = new Connection();
                con3.connection_string();
                OdbcCommand cmd2 = new OdbcCommand("select * from tank_left join tank_right on tank_left.vehicle_number=tank_right.vehicle_number where tank_left.vehicle_number='" + tyre_vehicle_numbers.Text + "' ", con3.str);
                OdbcDataAdapter da2 = new OdbcDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    string r1, r2, r3, r4;
                    r1 = dt2.Rows[0]["tflin_type"].ToString();
                    if (r1 == "N")
                    {
                        param[53] = new ReportParameter("Left_Param31", "NEW");
                        param[54] = new ReportParameter("Left_Param32", dt2.Rows[0]["tflin_tyre_no"].ToString());
                        param[55] = new ReportParameter("Left_Param33", dt2.Rows[0]["tflin_km"].ToString());
                        param[56] = new ReportParameter("Left_Param34", dt2.Rows[0]["tflin_company"].ToString());
                        param[57] = new ReportParameter("Left_Param35", Convert.ToDateTime(dt2.Rows[0]["tflin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r1 == "B")
                    {
                        param[53] = new ReportParameter("Left_Param31", "RE-BUILD");
                        param[54] = new ReportParameter("Left_Param32", dt2.Rows[0]["tflin_tyre_no"].ToString());
                        param[55] = new ReportParameter("Left_Param33", dt2.Rows[0]["tflin_km"].ToString());
                        param[56] = new ReportParameter("Left_Param34", dt2.Rows[0]["tflin_company"].ToString());
                        param[57] = new ReportParameter("Left_Param35", Convert.ToDateTime(dt2.Rows[0]["tflin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[53] = new ReportParameter("Left_Param31", "Nil");
                        param[54] = new ReportParameter("Left_Param32", "Nil");
                        param[55] = new ReportParameter("Left_Param33", "Nil");
                        param[56] = new ReportParameter("Left_Param34", "Nil");
                        param[57] = new ReportParameter("Left_Param35", "Nil");
                    }
                    r2 = dt2.Rows[0]["tflout_type"].ToString();
                    if (r2 == "N")
                    {
                        param[58] = new ReportParameter("Left_Param26", "NEW");
                        param[59] = new ReportParameter("Left_Param27", dt2.Rows[0]["tflout_tyre_no"].ToString());
                        param[60] = new ReportParameter("Left_Param28", dt2.Rows[0]["tflout_km"].ToString());
                        param[61] = new ReportParameter("Left_Param29", dt2.Rows[0]["tflout_company"].ToString());
                        param[62] = new ReportParameter("Left_Param30", Convert.ToDateTime(dt2.Rows[0]["tflout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r2 == "B")
                    {
                        param[58] = new ReportParameter("Left_Param26", "RE-BUILD");
                        param[59] = new ReportParameter("Left_Param27", dt2.Rows[0]["tflout_tyre_no"].ToString());
                        param[60] = new ReportParameter("Left_Param28", dt2.Rows[0]["tflout_km"].ToString());
                        param[61] = new ReportParameter("Left_Param29", dt2.Rows[0]["tflout_company"].ToString());
                        param[62] = new ReportParameter("Left_Param30", Convert.ToDateTime(dt2.Rows[0]["tflout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[58] = new ReportParameter("Left_Param26", "Nil");
                        param[59] = new ReportParameter("Left_Param27", "Nil");
                        param[60] = new ReportParameter("Left_Param28", "Nil");
                        param[61] = new ReportParameter("Left_Param29", "Nil");
                        param[62] = new ReportParameter("Left_Param30", "Nil");
                    }
                    r3 = dt2.Rows[0]["tblin_type"].ToString();
                    if (r3 == "N")
                    {
                        param[63] = new ReportParameter("Left_Param41", "NEW");
                        param[64] = new ReportParameter("Left_Param42", dt2.Rows[0]["tblin_tyre_no"].ToString());
                        param[65] = new ReportParameter("Left_Param43", dt2.Rows[0]["tblin_km"].ToString());
                        param[66] = new ReportParameter("Left_Param44", dt2.Rows[0]["tblin_company"].ToString());
                        param[67] = new ReportParameter("Left_Param45", Convert.ToDateTime(dt2.Rows[0]["tblout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r3 == "B")
                    {
                        param[63] = new ReportParameter("Left_Param41", "RE-BUILD");
                        param[64] = new ReportParameter("Left_Param42", dt2.Rows[0]["tblin_tyre_no"].ToString());
                        param[65] = new ReportParameter("Left_Param43", dt2.Rows[0]["tblin_km"].ToString());
                        param[66] = new ReportParameter("Left_Param44", dt2.Rows[0]["tblin_company"].ToString());
                        param[67] = new ReportParameter("Left_Param45", Convert.ToDateTime(dt2.Rows[0]["tblout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[63] = new ReportParameter("Left_Param41", "Nil");
                        param[64] = new ReportParameter("Left_Param42", "Nil");
                        param[65] = new ReportParameter("Left_Param43", "Nil");
                        param[66] = new ReportParameter("Left_Param44", "Nil");
                        param[67] = new ReportParameter("Left_Param45", "Nil");
                    }
                    r4 = dt2.Rows[0]["tblout_type"].ToString();
                    if (r4 == "N")
                    {
                        param[68] = new ReportParameter("Left_Param36", "NEW");
                        param[69] = new ReportParameter("Left_Param37", dt2.Rows[0]["tblout_tyre_no"].ToString());
                        param[70] = new ReportParameter("Left_Param38", dt2.Rows[0]["tblout_km"].ToString());
                        param[71] = new ReportParameter("Left_Param39", dt2.Rows[0]["tblout_company"].ToString());
                        param[72] = new ReportParameter("Left_Param40", Convert.ToDateTime(dt2.Rows[0]["tblout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r4 == "B")
                    {
                        param[68] = new ReportParameter("Left_Param36", "RE-BUILD");
                        param[69] = new ReportParameter("Left_Param37", dt2.Rows[0]["tblout_tyre_no"].ToString());
                        param[70] = new ReportParameter("Left_Param38", dt2.Rows[0]["tblout_km"].ToString());
                        param[71] = new ReportParameter("Left_Param39", dt2.Rows[0]["tblout_company"].ToString());
                        param[72] = new ReportParameter("Left_Param40", Convert.ToDateTime(dt2.Rows[0]["tblout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[68] = new ReportParameter("Left_Param36", "Nil");
                        param[69] = new ReportParameter("Left_Param37", "Nil");
                        param[70] = new ReportParameter("Left_Param38", "Nil");
                        param[71] = new ReportParameter("Left_Param39", "Nil");
                        param[72] = new ReportParameter("Left_Param40", "Nil");
                    }
                    string r5, r6, r7, r8;
                    r5 = dt2.Rows[0]["tfrin_type"].ToString();
                    if (r5 == "N")
                    {
                        param[73] = new ReportParameter("Right_Param26", "NEW");
                        param[74] = new ReportParameter("Right_Param27", dt2.Rows[0]["tfrin_tyre_no"].ToString());
                        param[75] = new ReportParameter("Right_Param28", dt2.Rows[0]["tfrin_km"].ToString());
                        param[76] = new ReportParameter("Right_Param29", dt2.Rows[0]["tfrin_company"].ToString());
                        param[77] = new ReportParameter("Right_Param30", Convert.ToDateTime(dt2.Rows[0]["tfrin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r5 == "B")
                    {
                        param[73] = new ReportParameter("Right_Param26", "RE-BUILD");
                        param[74] = new ReportParameter("Right_Param27", dt2.Rows[0]["tfrin_tyre_no"].ToString());
                        param[75] = new ReportParameter("Right_Param28", dt2.Rows[0]["tfrin_km"].ToString());
                        param[76] = new ReportParameter("Right_Param29", dt2.Rows[0]["tfrin_company"].ToString());
                        param[77] = new ReportParameter("Right_Param30", Convert.ToDateTime(dt2.Rows[0]["tfrin_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[73] = new ReportParameter("Right_Param26", "Nil");
                        param[74] = new ReportParameter("Right_Param27", "Nil");
                        param[75] = new ReportParameter("Right_Param28", "Nil");
                        param[76] = new ReportParameter("Right_Param29", "Nil");
                        param[77] = new ReportParameter("Right_Param30", "Nil");
                    }
                    r6 = dt2.Rows[0]["tfrout_type"].ToString();
                    if (r6 == "N")
                    {
                        param[78] = new ReportParameter("Right_Param31", "NEW");
                        param[79] = new ReportParameter("Right_Param32", dt2.Rows[0]["tfrout_tyre_no"].ToString());
                        param[80] = new ReportParameter("Right_Param33", dt2.Rows[0]["tfrout_km"].ToString());
                        param[81] = new ReportParameter("Right_Param34", dt2.Rows[0]["tfrout_company"].ToString());
                        param[82] = new ReportParameter("Right_Param35", Convert.ToDateTime(dt2.Rows[0]["tfrout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r6 == "B")
                    {
                        param[78] = new ReportParameter("Right_Param31", "RE-BUILD");
                        param[79] = new ReportParameter("Right_Param32", dt2.Rows[0]["tfrout_tyre_no"].ToString());
                        param[80] = new ReportParameter("Right_Param33", dt2.Rows[0]["tfrout_km"].ToString());
                        param[81] = new ReportParameter("Right_Param34", dt2.Rows[0]["tfrout_company"].ToString());
                        param[82] = new ReportParameter("Right_Param35", Convert.ToDateTime(dt2.Rows[0]["tfrout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[78] = new ReportParameter("Right_Param31", "Nil");
                        param[79] = new ReportParameter("Right_Param32", "Nil");
                        param[80] = new ReportParameter("Right_Param33", "Nil");
                        param[81] = new ReportParameter("Right_Param34", "Nil");
                        param[82] = new ReportParameter("Right_Param35", "Nil");
                    }
                    r7 = dt2.Rows[0]["tbrin_type"].ToString();
                    if (r7 == "N")
                    {
                        param[83] = new ReportParameter("Right_Param36", "NEW");
                        param[84] = new ReportParameter("Right_Param37", dt2.Rows[0]["tbrin_tyre_no"].ToString());
                        param[85] = new ReportParameter("Right_Param38", dt2.Rows[0]["tbrin_km"].ToString());
                        param[86] = new ReportParameter("Right_Param39", dt2.Rows[0]["tbrin_company"].ToString());
                        param[87] = new ReportParameter("Right_Param40", Convert.ToDateTime(dt2.Rows[0]["tbrout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r7 == "B")
                    {
                        param[83] = new ReportParameter("Right_Param36", "RE-BUILD");
                        param[84] = new ReportParameter("Right_Param37", dt2.Rows[0]["tbrin_tyre_no"].ToString());
                        param[85] = new ReportParameter("Right_Param38", dt2.Rows[0]["tbrin_km"].ToString());
                        param[86] = new ReportParameter("Right_Param39", dt2.Rows[0]["tbrin_company"].ToString());
                        param[87] = new ReportParameter("Right_Param40", Convert.ToDateTime(dt2.Rows[0]["tbrout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[83] = new ReportParameter("Right_Param36", "Nil");
                        param[84] = new ReportParameter("Right_Param37", "Nil");
                        param[85] = new ReportParameter("Right_Param38", "Nil");
                        param[86] = new ReportParameter("Right_Param39", "Nil");
                        param[87] = new ReportParameter("Right_Param40", "Nil");
                    }
                    r8 = dt2.Rows[0]["tbrout_type"].ToString();
                    if (r8 == "N")
                    {
                        param[88] = new ReportParameter("Right_Param41", "NEW");
                        param[89] = new ReportParameter("Right_Param42", dt2.Rows[0]["tbrout_tyre_no"].ToString());
                        param[90] = new ReportParameter("Right_Param43", dt2.Rows[0]["tbrout_km"].ToString());
                        param[91] = new ReportParameter("Right_Param44", dt2.Rows[0]["tbrout_company"].ToString());
                        param[92] = new ReportParameter("Right_Param45", Convert.ToDateTime(dt2.Rows[0]["tbrout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else if (r8 == "B")
                    {
                        param[88] = new ReportParameter("Right_Param41", "RE-BUILD");
                        param[89] = new ReportParameter("Right_Param42", dt2.Rows[0]["tbrout_tyre_no"].ToString());
                        param[90] = new ReportParameter("Right_Param43", dt2.Rows[0]["tbrout_km"].ToString());
                        param[91] = new ReportParameter("Right_Param44", dt2.Rows[0]["tbrout_company"].ToString());
                        param[92] = new ReportParameter("Right_Param45", Convert.ToDateTime(dt2.Rows[0]["tbrout_date"]).ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        param[88] = new ReportParameter("Right_Param41", "Nil");
                        param[89] = new ReportParameter("Right_Param42", "Nil");
                        param[90] = new ReportParameter("Right_Param43", "Nil");
                        param[91] = new ReportParameter("Right_Param44", "Nil");
                        param[92] = new ReportParameter("Right_Param45", "Nil");
                    }
                    con3.close_string();
                }
                else
                {
                    //MessageBox.Show("Record Doesnot Exist");
                    param[53] = new ReportParameter("Left_Param31", "Nil");
                    param[54] = new ReportParameter("Left_Param32", "Nil");
                    param[55] = new ReportParameter("Left_Param33", "Nil");
                    param[56] = new ReportParameter("Left_Param34", "Nil");
                    param[57] = new ReportParameter("Left_Param35", "Nil");
                    param[58] = new ReportParameter("Left_Param26", "Nil");
                    param[59] = new ReportParameter("Left_Param27", "Nil");
                    param[60] = new ReportParameter("Left_Param28", "Nil");
                    param[61] = new ReportParameter("Left_Param29", "Nil");
                    param[62] = new ReportParameter("Left_Param30", "Nil");
                    param[63] = new ReportParameter("Left_Param41", "Nil");
                    param[64] = new ReportParameter("Left_Param42", "Nil");
                    param[65] = new ReportParameter("Left_Param43", "Nil");
                    param[66] = new ReportParameter("Left_Param44", "Nil");
                    param[67] = new ReportParameter("Left_Param45", "Nil");
                    param[68] = new ReportParameter("Left_Param36", "Nil");
                    param[69] = new ReportParameter("Left_Param37", "Nil");
                    param[70] = new ReportParameter("Left_Param38", "Nil");
                    param[71] = new ReportParameter("Left_Param39", "Nil");
                    param[72] = new ReportParameter("Left_Param40", "Nil");
                    param[73] = new ReportParameter("Right_Param26", "Nil");
                    param[74] = new ReportParameter("Right_Param27", "Nil");
                    param[75] = new ReportParameter("Right_Param28", "Nil");
                    param[76] = new ReportParameter("Right_Param29", "Nil");
                    param[77] = new ReportParameter("Right_Param30", "Nil");
                    param[78] = new ReportParameter("Right_Param31", "Nil");
                    param[79] = new ReportParameter("Right_Param32", "Nil");
                    param[80] = new ReportParameter("Right_Param33", "Nil");
                    param[81] = new ReportParameter("Right_Param34", "Nil");
                    param[82] = new ReportParameter("Right_Param35", "Nil");
                    param[83] = new ReportParameter("Right_Param36", "Nil");
                    param[84] = new ReportParameter("Right_Param37", "Nil");
                    param[85] = new ReportParameter("Right_Param38", "Nil");
                    param[86] = new ReportParameter("Right_Param39", "Nil");
                    param[87] = new ReportParameter("Right_Param40", "Nil");
                    param[88] = new ReportParameter("Right_Param41", "Nil");
                    param[89] = new ReportParameter("Right_Param42", "Nil");
                    param[90] = new ReportParameter("Right_Param43", "Nil");
                    param[91] = new ReportParameter("Right_Param44", "Nil");
                    param[92] = new ReportParameter("Right_Param45", "Nil");
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error :" + ex);
            }
            Report_Viewer.LocalReport.SetParameters(param);
            Report_Viewer.RefreshReport();
        }
        void Tyre_Vehicle_Number_PreviewKeydown(object sender, KeyEventArgs e) 
        {
            int len = 0;
            string s = tyre_vehicle_numbers.Text;
            if (!string.IsNullOrWhiteSpace(tyre_vehicle_numbers.Text))
            {
                len = tyre_vehicle_numbers.Text.Length;
            }
            else
            {
                len = 0;
            }
            if (len <= 2)
            {
                for (int i = 0; i < len; i++)
                {
                    bool isletter = char.IsLetter(s[i]);
                    if (isletter == true)
                    {
                    }
                    else
                    {
                        MessageBox.Show("Should Enter First Two Letter Character");
                        tyre_vehicle_numbers.Text = "";
                    }
                }
            }
            if (len > 10)
            {
                if (e.Key != Key.Back)
                {
                    System.Media.SystemSounds.Beep.Play();
                    e.Handled = true;
                }
            }
        }

       

       

       

       
       
        List<string> t_no = new List<string>();
        List<string> s_km = new List<string>();
        private void View_Click(object sender, RoutedEventArgs e)
        {
            
            if(!string.IsNullOrWhiteSpace( tyre_vehicle_numbers.Text))
            {
                Connection con = new Connection();
                con.connection_string();
                OdbcCommand cmd = new OdbcCommand("select fl_id,fr_id,cfol_id,cfil_id,cfor_id,cfir_id,ccol_id,ccil_id,ccor_id,ccir_id,cbol_id,cbil_id,cbor_id,cbir_id,afol_id,afil_id,afor_id,afir_id,acol_id,acil_id,acor_id,acir_id,abol_id,abil_id,abor_id,abir_id,adt_id from trailer where vehicle_no='"+tyre_vehicle_numbers.Text+"'",con.str);
                OdbcDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    for(int i=0;i<27;i++)
                    {                     
                        string DR = dr[i].ToString();
                        if (!string.IsNullOrWhiteSpace(DR))
                        {
                            OdbcCommand cmd1 = new OdbcCommand("select no,starting_km from trailer_tyre_details where id='" + DR + "'", con.str);
                            OdbcDataReader dr1 = cmd1.ExecuteReader();
                            while (dr1.Read())
                            {
                                t_no.Add(dr1[0].ToString());
                                s_km.Add(dr1[1].ToString());                                
                            }
                        }
                        else
                        {
                            t_no.Add("");
                            s_km.Add("");                            
                        }
                    }
                    view_content();
                }
               
                con.close_string();
                
            }
            else
            {
                MessageBox.Show("Please Select Vehicle Number");
            }
            tyre_view.Visibility = Visibility.Visible;
        }
        void view_content()
        {
            zl1.Content = t_no[0]; zr1.Content = t_no[1];
            zl2.Content = s_km[0]; zr2.Content = s_km[1];
            zl3.Content = t_no[6]; zr5.Content = t_no[8];
            zl4.Content = s_km[6]; zr6.Content = s_km[8];
            zl5.Content = t_no[7]; zr3.Content = t_no[9];
            zl6.Content = s_km[7]; zr4.Content = s_km[9];
            zl7.Content = t_no[10]; zr9.Content = t_no[12];
            zl8.Content = s_km[10]; zr10.Content = t_no[12];
            zl9.Content = t_no[11]; zr7.Content = t_no[13];
            zl10.Content = s_km[11]; zr8.Content = t_no[13];

            tl1.Content = t_no[14]; tr3.Content = t_no[16];
            tl2.Content = s_km[14]; tr4.Content = s_km[16];
            tl3.Content = t_no[15]; tr1.Content = t_no[17];
            tl4.Content = s_km[15]; tr2.Content = s_km[17];
            tl5.Content = t_no[18]; tr7.Content = t_no[20];
            tl6.Content = s_km[18]; tr8.Content = s_km[20];
            tl7.Content = t_no[19]; tr5.Content = t_no[21];
            tl8.Content = s_km[19]; tr6.Content = s_km[21];
            tl9.Content = t_no[22]; tr11.Content = t_no[24];
            tl10.Content = s_km[22]; tr12.Content = s_km[24];
            tl11.Content = t_no[23]; tr9.Content = t_no[25];
            tl12.Content = s_km[23]; tr10.Content = s_km[25];
            adno.Content = t_no[26];adkm.Content = s_km[26];
        }
        private void View_Back_Click(object sender, RoutedEventArgs e)
        {
            tyre_view.Visibility = Visibility.Hidden;
            t_no.Clear();
            s_km.Clear();
            zl1.Content = ""; zr1.Content = "";
            zl2.Content = ""; zr2.Content = "";
            zl3.Content = ""; zr5.Content = "";
            zl4.Content = ""; zr6.Content = "";
            zl5.Content = ""; zr3.Content = "";
            zl6.Content = ""; zr4.Content = "";
            zl7.Content = ""; zr9.Content = "";
            zl8.Content = ""; zr10.Content = "";
            zl9.Content = ""; zr7.Content = "";
            zl10.Content = ""; zr8.Content = "";

            tl1.Content = ""; tr3.Content = "";
            tl2.Content = ""; tr4.Content = "";
            tl3.Content = ""; tr1.Content = "";
            tl4.Content = ""; tr2.Content = "";
            tl5.Content = ""; tr7.Content = "";
            tl6.Content = ""; tr8.Content = "";
            tl7.Content = ""; tr5.Content = "";
            tl8.Content = ""; tr6.Content = "";
            tl9.Content = ""; tr11.Content = "";
            tl10.Content = ""; tr12.Content = "";
            tl11.Content = ""; tr9.Content = "";
            tl12.Content = ""; tr10.Content ="";
        }

     

        private void tyre_vehicle_numbers_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Tab||e.Key==Key.Enter)
            {
                if (!string.IsNullOrWhiteSpace(tyre_vehicle_numbers.Text))
                {
                    Connection con = new Connection();
                    con.open_connection();
                    OdbcCommand cmd = new OdbcCommand("select type from vechicle_details where vehicle_number='" + tyre_vehicle_numbers.Text + "'", con.conn);
                    OdbcDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string no = dr[0].ToString();
                        string ctn=null;
                        string btn=null;
                        if (no != null)
                        {
                            if(no.Length==5)
                            {
                                 ctn = no.Substring(0, 2);
                                 btn = no.Substring(3, 2);
                            }
                            else if(no.Length==4)
                            {
                                 ctn = Regex.Replace(no.Substring(0, 2), "[^0-9]+", string.Empty);                                
                                 btn = Regex.Replace(no.Substring(-2, 2), "[^0-9]+", string.Empty);
                            }
                            else if(no.Length==3)
                            {
                                ctn = no.Substring(0, 1);
                                btn = no.Substring(-1, 1);
                            }
                            button_visible();
                            
                            if (ctn == "6" && btn == "8")
                            {
                                but1.Visibility = Visibility.Hidden; but2.Visibility = Visibility.Hidden; but14.Visibility = Visibility.Hidden; but15.Visibility = Visibility.Hidden;
                                but3.Visibility = Visibility.Hidden; but5.Visibility = Visibility.Hidden; but12.Visibility = Visibility.Hidden; but13.Visibility = Visibility.Hidden;
                            }
                            else if (ctn == "6" && btn == "12")
                            {
                                but4.Visibility = Visibility.Hidden; but6.Visibility = Visibility.Hidden; but14.Visibility = Visibility.Hidden; but15.Visibility = Visibility.Hidden;                               
                            }
                            else if (ctn == "10" && btn == "8")
                            {                                
                                but3.Visibility = Visibility.Hidden; but5.Visibility = Visibility.Hidden; but12.Visibility = Visibility.Hidden; but13.Visibility = Visibility.Hidden;
                            }
                            else if (ctn == "10" && btn == "12")
                            {
                                button_visible();
                            }
                        }
                        else
                        {
                            tyre_vehicle_numbers.Text = string.Empty;
                            MessageBox.Show("Vehicle Type Not Exist");
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Please Select Vehicle Number");
                }
            }
           
        }
        void button_visible()
        {
            but1.Visibility = Visibility.Visible; but2.Visibility = Visibility.Visible; but3.Visibility = Visibility.Visible; but4.Visibility = Visibility.Visible;
            but5.Visibility = Visibility.Visible; but6.Visibility = Visibility.Visible; but7.Visibility = Visibility.Visible; but8.Visibility = Visibility.Visible;
            but9.Visibility = Visibility.Visible; but10.Visibility = Visibility.Visible; but11.Visibility = Visibility.Visible; but12.Visibility = Visibility.Visible;
            but13.Visibility = Visibility.Visible; but14.Visibility = Visibility.Visible; but15.Visibility = Visibility.Visible; but16.Visibility = Visibility.Visible;
            but17.Visibility = Visibility.Visible; but18.Visibility = Visibility.Visible; but19.Visibility = Visibility.Visible; but20.Visibility = Visibility.Visible;
            but21.Visibility = Visibility.Visible; bu22.Visibility = Visibility.Visible;addtional.Visibility = Visibility.Visible;
            Veh_img.Visibility = Visibility.Visible;
            ad_img.Visibility = Visibility.Visible;
            ad_line.Visibility = Visibility.Visible;
        }

        
    }
}
