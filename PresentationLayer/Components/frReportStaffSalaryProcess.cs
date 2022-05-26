using DevExpress.XtraEditors;
using PresentationLayer.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataTransferObject.DataTransferObject;

namespace PresentationLayer
{
    public partial class frReportStaffSalaryProcess : DevExpress.XtraEditors.XtraForm
    {
        private StaffInfo_DTO mStaffInfo;
        public frReportStaffSalaryProcess(StaffInfo_DTO staffInfo)
        {
            InitializeComponent();
            mStaffInfo = staffInfo;
        }
        public void PrintReport()
        {
            ReportStaffSalaryProcess report = new ReportStaffSalaryProcess();
            report.BindData(mStaffInfo);
            docViewer.DocumentSource = report;
            report.CreateDocument();
        }
    }
}