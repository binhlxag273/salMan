using BussinessLogicLayer;
using DataAccessLayer;
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
    public partial class CategoryDetailAll : Form
    {
        private Category_DTO mCategory;

        private void LoadCategoryDetails()
        {
            KeyValuePair<bool, List<CategoryDetail_DTO>> result = CategoryDetail_BUS.GetMany("category_id", mCategory.id);
            if (result.Key == false)
            {
                MessageBox.Show("Lỗi kết nối");
                return;
            }

            Helper.Instance().Bind(dgCategoryDetails, result.Value);
            dgCategoryDetails.Columns["id"].Visible = false;
        }

        public CategoryDetailAll(Category_DTO category)
        {
            InitializeComponent();
            this.Text = "Danh mục chi tiết - " + category.name;
            mCategory = category;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mCategory.id == 5)
            {
                CategoryDetailDateOffUpsert date_upsert = new CategoryDetailDateOffUpsert(mCategory.id);
                date_upsert.ShowDialog();
                
                if (date_upsert.mOperationOk == true)
                {
                    LoadCategoryDetails();
                    MessageBox.Show("Thêm thành công");
                }
            }
            else
            {
                CategoryDetailUpsert detail_upsert = new CategoryDetailUpsert(mCategory.id);
                detail_upsert.ShowDialog();

                if (detail_upsert.mOperationOk == true)
                {
                    LoadCategoryDetails();
                    MessageBox.Show("Thêm thành công");
                }
            }
        }

        private void CategoryDetailAll_Load(object sender, EventArgs e)
        {
            LoadCategoryDetails();
        }

        private void dgCategoryDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_idx = e.RowIndex;
            if (row_idx < 0) return;

            CategoryDetail_DTO detail = (CategoryDetail_DTO)dgCategoryDetails.CurrentRow.DataBoundItem;
            CategoryDetailUpsert categoryUpsert = new CategoryDetailUpsert(detail);
            categoryUpsert.ShowDialog();

            if (categoryUpsert.mOperationOk)
            {
                LoadCategoryDetails();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCategoryDetails.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            int row_idx = dgCategoryDetails.SelectedCells[0].RowIndex;
            CategoryDetail_DTO detail = (CategoryDetail_DTO)dgCategoryDetails.Rows[row_idx].DataBoundItem;
            if (mCategory.id == 5)
            {
                CategoryDetailDateOffUpsert date_upsert = new CategoryDetailDateOffUpsert(detail);
                date_upsert.ShowDialog();

                if (date_upsert.mOperationOk)
                {
                    LoadCategoryDetails();
                    MessageBox.Show("Cập nhật thành công");
                }
            }
            else
            {
                CategoryDetailUpsert detail_upsert = new CategoryDetailUpsert(detail);
                detail_upsert.ShowDialog();

                if (detail_upsert.mOperationOk)
                {
                    LoadCategoryDetails();
                    MessageBox.Show("Cập nhật thành công");
                }
            }
        }
    }
}
