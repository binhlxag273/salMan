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
    public partial class CategoryUpsert : Form
    {
        private Category_DTO mCategory;

        public bool mIsInsert = false;
        public bool mOperationOk = false;

        public CategoryUpsert()
        {
            InitializeComponent();
            chkIsSystem.Enabled = true;
            mCategory = new Category_DTO();
            mIsInsert = true;
        }

        public CategoryUpsert(Category_DTO category)
        {
            InitializeComponent();
            mCategory = category;

            txbAliasCode.Text = mCategory.code;
            txbDisplayName.Text = mCategory.name;
            chkIsSystem.Checked = mCategory.is_system_category;
            chkIsSystem.Enabled = false;
            btnUpsert.Enabled = category.is_system_category ? true : false;
        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            string code = txbAliasCode.Text;
            string name = txbDisplayName.Text;
            bool isSystem = chkIsSystem.Checked;

            if (code.Length == 0)
            {
                lblErrorMsg.Text = "Mã danh mục bắt buộc chọn";
                return;
            }

            if (name.Length == 0)
            {
                lblErrorMsg.Text = "Tên danh mục bắt buộc chọn";
                return;
            }

            mCategory.code = code;
            mCategory.name = name;
            mCategory.is_system_category = isSystem;

            KeyValuePair<bool, string> result;
            if (mIsInsert)
            {
                result = Category_BUS.InsertOne(mCategory);
            }
            else
            {
                result = Category_BUS.UpdateOne(mCategory);
            }

            if (result.Key == false)
            {
                lblErrorMsg.Text = "Mã danh mục đã tồn tại";
                UtilityLayer.Logging.Instance().LogInfo("[Error][CategoryUpsert][btnUpsert_Click]: " + result.Value);
                return;
            }

            mOperationOk = true;
            this.Close();
            return;
        }
    }
}
