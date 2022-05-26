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
    public partial class frReportStaffSalaryTable : DevExpress.XtraEditors.XtraForm
    {
        private StaffInfo_DTO mStaffInfo;
        private SalaryProcess_DTO mSalaryProcess;

        public frReportStaffSalaryTable(StaffInfo_DTO staffInfo, SalaryProcess_DTO salaryProcess)
        {
            InitializeComponent();
            mStaffInfo = staffInfo;
            mSalaryProcess = salaryProcess;
        }
        public void PrintReport()
        {
            ReportStaffSalaryTable report = new ReportStaffSalaryTable();
            report.BindData(mStaffInfo, mSalaryProcess);
            docViewer.DocumentSource = report;
            report.CreateDocument();
        }
    }
}