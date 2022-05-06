using BussinessLogicLayer;
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
    public partial class CategoryDetailDateOffUpsert : Form
    {
        private CategoryDetail_DTO mCategoryDetail;

        public bool mOperationOk = false;
        public bool mIsInsert = false;

        public CategoryDetailDateOffUpsert(int category_id)
        {
            mCategoryDetail = new CategoryDetail_DTO();
            mCategoryDetail.category_id = category_id;
            InitializeComponent();
            dtCode.Format = DateTimePickerFormat.Custom;
            dtCode.CustomFormat = "dd/MM";
            mIsInsert = true;
        }

        public CategoryDetailDateOffUpsert(CategoryDetail_DTO categoryDetail)
        {
            mCategoryDetail = categoryDetail;
            InitializeComponent();
            dtCode.Format = DateTimePickerFormat.Custom;
            dtCode.CustomFormat = "dd/MM";
            dtCode.Text = categoryDetail.code;
            txbName.Text = categoryDetail.name;
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            string code = dtCode.Value.ToString("MM/dd");
            string name = txbName.Text;
            if (code.Length == 0)
            {
                lblErrorMsg.Text = "Mã danh mục không được trống";
                return;
            }

            if (name.Length == 0)
            {
                lblErrorMsg.Text = "Tên danh mục không được trống";
                return;
            }

            mCategoryDetail.code = code;
            mCategoryDetail.name = name;

            KeyValuePair<bool, string> result;
            if (mIsInsert)
            {
                result = CategoryDetail_BUS.InsertOne(mCategoryDetail);
            }
            else
            {
                result = CategoryDetail_BUS.UpdateOne(mCategoryDetail);
            }

            if (!result.Key)
            {
                lblErrorMsg.Text = "Mã danh mục bị trùng";
                return;
            }

            mOperationOk = true;

            this.Close();
            return;
        }
    }
}
