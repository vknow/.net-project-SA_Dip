using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA39_TEAM5.Report
{
    public partial class crosstab_form : Form
    {
        public crosstab_form()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Team5_DS ds = new Team5_DS();
            Team5_DSTableAdapters.bookingdetailsTableAdapter book_ta = new Team5_DSTableAdapters.bookingdetailsTableAdapter();
            book_ta.Fill(ds.bookingdetails);
            Team5_DSTableAdapters.facilitydetailsTableAdapter faci_ta = new Team5_DSTableAdapters.facilitydetailsTableAdapter();
            faci_ta.Fill(ds.facilitydetails);
            Team5_DSTableAdapters.memberdetailsTableAdapter mem_ta = new Team5_DSTableAdapters.memberdetailsTableAdapter();
            mem_ta.Fill(ds.memberdetails);
            Transaction re = new Transaction();
            re.SetDataSource(ds);
            crystalReportViewer1.ReportSource = re;
        }
    }
}
