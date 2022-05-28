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
    public partial class CategoryAll : Form
    {
        private void LoadCategories()
        {
            KeyValuePair<bool, List<Category_DTO>> result = Category_BUS.GetMany();
            if (result.Key == false)
            {
                MessageBox.Show("Lỗi kết nối");
                return;
            }

            Helper.Instance().Bind(dgCategories, result.Value);
            dgCategories.Columns["id"].Visible = false;
        }

        public CategoryAll()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Helper.Instance().AccountHas_Category_Management())
            {
                MessageBox.Show("Tài khoản của bạn không có quyền thực hiện tính năng nay");
                return;
            }

            CategoryUpsert category = new CategoryUpsert();
            category.ShowDialog();

            if (category.mOperationOk)
            {
                LoadCategories();
                MessageBox.Show("Thêm thành công");
            }
        }

        private void CategoryAll_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void dgCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Helper.Instance().AccountHas_Category_Management())
            {
                MessageBox.Show("Tài khoản của bạn không có quyền thực hiện tính năng này");
                return;
            }

            int row_idx = e.RowIndex;
            if (row_idx < 0) return;

            Category_DTO category = (Category_DTO)dgCategories.CurrentRow.DataBoundItem;
            CategoryUpsert categoryUpsert = new CategoryUpsert(category);
            categoryUpsert.ShowDialog();

            if (categoryUpsert.mOperationOk)
            {
                LoadCategories();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!Helper.Instance().AccountHas_Category_Management())
            {
                MessageBox.Show("Tài khoản của bạn không có quyền thực hiện tính năng này");
                return;
            }

            if (dgCategories.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            int row_idx = dgCategories.SelectedCells[0].RowIndex;
            Category_DTO category = (Category_DTO)dgCategories.Rows[row_idx].DataBoundItem;
            CategoryUpsert categoryUpsert = new CategoryUpsert(category);
            categoryUpsert.ShowDialog();

            if (categoryUpsert.mOperationOk)
            {
                LoadCategories();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Helper.Instance().AccountHas_Category_Management())
            {
                MessageBox.Show("Tài khoản của bạn không có quyền thực hiện tính năng này.");
                return;
            }
            DialogResult dlr = MessageBox.Show("Các dữ liệu liên quan đều sẽ bị xóa, bạn có muốn xóa không?", "Chú ý", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.No) return;

            if (dgCategories.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            bool[] counts = new bool[dgCategories.Rows.Count];
            for (int i = 0; i < dgCategories.SelectedCells.Count; ++i)
            {
                int row_idx = dgCategories.SelectedCells[i].RowIndex;
                Category_DTO category = (Category_DTO)dgCategories.Rows[row_idx].DataBoundItem;
                if (category.is_system_category)
                {
                    MessageBox.Show("Không thể xóa danh mục hệ thống");
                    return;
                }
                counts[row_idx] = true;
            }

            List<int> list_id = new List<int>();
            for (int i = 0; i < counts.Length; ++i)
            {
                if (counts[i]) list_id.Add(Int32.Parse(dgCategories.Rows[i].Cells["id"].Value.ToString()));
            }

            KeyValuePair<bool, string> result = Category_BUS.DeleteMany(list_id);
            if (result.Key == false)
            {
                MessageBox.Show(result.Value);
                return;
            }

            foreach(int id in list_id)
            {
                result = CategoryDetail_BUS.DeleteManyByCategoryId(id);
                if (!result.Key)
                {
                    UtilityLayer.Logging.Instance().LogInfo("Error: [CategoryAll][btnDelete_Click]:" + result.Value);
                }
            }

            LoadCategories();
            MessageBox.Show("Xóa thành công");
        }

        private void btnOpenDetail_Click(object sender, EventArgs e)
        {
            if (dgCategories.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            int row_idx = dgCategories.SelectedCells[0].RowIndex;
            Category_DTO category = (Category_DTO)dgCategories.Rows[row_idx].DataBoundItem;

            CategoryDetailAll detail_all = new CategoryDetailAll(category);
            detail_all.ShowDialog();
        }
    }
}
