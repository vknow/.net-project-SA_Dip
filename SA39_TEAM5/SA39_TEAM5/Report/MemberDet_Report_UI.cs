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
    public partial class MemberDet_Report_UI : Form
    {
        public MemberDet_Report_UI()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Team5_DS ds = new Team5_DS();
            Team5_DSTableAdapters.memberdetailsTableAdapter mem_ta = new Team5_DSTableAdapters.memberdetailsTableAdapter();
            mem_ta.Fill(ds.memberdetails);
            MemberReport cr = new MemberReport();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
