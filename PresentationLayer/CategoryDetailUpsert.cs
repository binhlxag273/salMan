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
    public partial class CategoryDetailUpsert : Form
    {
        private CategoryDetail_DTO mCategoryDetail;
        private bool mIsInsert = false;
        public bool mOperationOk = false;

        public CategoryDetailUpsert(int category_id)
        {
            InitializeComponent();
            mCategoryDetail = new CategoryDetail_DTO();
            mCategoryDetail.category_id = category_id;
            mIsInsert = true;
        }

        public CategoryDetailUpsert(CategoryDetail_DTO category_detail)
        {
            InitializeComponent();
            mCategoryDetail = category_detail;
            txbCode.Text = mCategoryDetail.code;
            txbName.Text = mCategoryDetail.name;
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            string code = txbCode.Text;
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
