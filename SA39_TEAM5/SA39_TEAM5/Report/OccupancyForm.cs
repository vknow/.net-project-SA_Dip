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
    public partial class OccupancyForm : Form
    {
        public OccupancyForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Team5_DS ds = new Team5_DS();
            Team5_DSTableAdapters.OccupancyTableAdapter occu_ts = new  Team5_DSTableAdapters.OccupancyTableAdapter();
            occu_ts.Fill(ds.Occupancy);
            OccupancyChar re = new OccupancyChar();
            re.SetDataSource(ds);
            crystalReportViewer1.ReportSource = re;
        }
    }
}
