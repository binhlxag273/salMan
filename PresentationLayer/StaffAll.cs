using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DataTransferObject.DataTransferObject;

namespace PresentationLayer
{
    public partial class StaffAll : Form
    {
        public class SearchOptions
        {
            public int mSearchTypeIndex = 0;
            public string mSearchFromDate = "";
            public string mSearchToDate = "";
            public bool mUseAdvance = false;
        }

        private SearchOptions mSearchOptions = new SearchOptions();
        private bool mUseCaseSensitive = false;
        private bool mUseAccentSensitive = false;

        private void LoadStaffes()
        {
            KeyValuePair<bool, List<StaffInfo_Display_DTO>> result = StaffInfo_BUS.GetManyDisplay();
            if (!result.Key)
            {
                MessageBox.Show("Lỗi kết nối");
                return;
            }

            Helper.Instance().Bind(dgStaffes, result.Value);
            dgStaffes.Columns["id"].Visible = false;
            dgStaffes.Columns["department_id"].Visible = false;
            dgStaffes.Columns["position_id"].Visible = false;
            dgStaffes.Columns["account_id"].Visible = false;
            dgStaffes.Columns["end_working_date"].Visible = false;
            dgStaffes.Columns["insurance_amount"].Visible = false;
            dgStaffes.Columns["allowance_amount"].Visible = false;
        }

        private void SearchHandler(string search_key)
        {
            KeyValuePair<bool, List<StaffInfo_Display_DTO>> result;
            string command = "";
            Action<SqlCommand> cb;
            if (!mSearchOptions.mUseAdvance)
            {
                command = "select staff.*, cd_1.name as department_ext, cd_2.name as position_ext, acc.account_name as account_ext from StaffInfo as staff, CategoryDetail as cd_1, CategoryDetail as cd_2, Account as acc where staff.department_id = cd_1.id and staff.position_id = cd_2.id and staff.account_id = acc.id and staff.name like @search_key";
                cb = sqlCommand =>
                {
                    sqlCommand.Parameters.AddWithValue("@search_key", '%' + search_key + '%');
                };
            }
            else
            {
                switch (mSearchOptions.mSearchTypeIndex)
                {
                    case 0:
                        command = "select staff.*, cd_1.name as department_ext, cd_2.name as position_ext, acc.account_name as account_ext from StaffInfo as staff, CategoryDetail as cd_1, CategoryDetail as cd_2, Account as acc where staff.department_id = cd_1.id and staff.position_id = cd_2.id and staff.account_id = acc.id and staff.name like @search_key and staff.start_working_date > @from_date and staff.start_working_date < @to_date";
                        break;
                    case 1:
                        command = "select staff.*, cd_1.name as department_ext, cd_2.name as position_ext, acc.account_name as account_ext from StaffInfo as staff, CategoryDetail as cd_1, CategoryDetail as cd_2, Account as acc where staff.department_id = cd_1.id and staff.position_id = cd_2.id and staff.account_id = acc.id and staff.code like @search_key and staff.start_working_date > @from_date and staff.start_working_date < @to_date";
                        break;
                    case 2:
                        command = "select staff.*, cd_1.name as department_ext, cd_2.name as position_ext, acc.account_name as account_ext from StaffInfo as staff, CategoryDetail as cd_1, CategoryDetail as cd_2, Account as acc where staff.department_id = cd_1.id and staff.position_id = cd_2.id and staff.account_id = acc.id and acc.account_name like @search_key and staff.start_working_date > @from_date and staff.start_working_date < @to_date";
                        break;
                    case 3:
                        command = "select staff.*, cd_1.name as department_ext, cd_2.name as position_ext, acc.account_name as account_ext from StaffInfo as staff, CategoryDetail as cd_1, CategoryDetail as cd_2, Account as acc where staff.department_id = cd_1.id and staff.position_id = cd_2.id and staff.account_id = acc.id and cd_1.name like @search_key and staff.start_working_date > @from_date and staff.start_working_date < @to_date";
                        break;
                    case 4:
                        command = "select staff.*, cd_1.name as department_ext, cd_2.name as position_ext, acc.account_name as account_ext from StaffInfo as staff, CategoryDetail as cd_1, CategoryDetail as cd_2, Account as acc where staff.department_id = cd_1.id and staff.position_id = cd_2.id and staff.account_id = acc.id and cd_2.name like @search_key and staff.start_working_date > @from_date and staff.start_working_date < @to_date";
                        break;
                    default:
                        command = "select staff.*, cd_1.name as department_ext, cd_2.name as position_ext, acc.account_name as account_ext from StaffInfo as staff, CategoryDetail as cd_1, CategoryDetail as cd_2, Account as acc where staff.department_id = cd_1.id and staff.position_id = cd_2.id and staff.account_id = acc.id and staff.name like @search_key and staff.start_working_date > @from_date and staff.start_working_date < @to_date";
                        break;
                }

                cb = sqlCommand =>
                {
                    sqlCommand.Parameters.AddWithValue("@search_key", '%' + search_key + '%');
                    sqlCommand.Parameters.AddWithValue("@from_date", mSearchOptions.mSearchFromDate);
                    sqlCommand.Parameters.AddWithValue("@to_date", mSearchOptions.mSearchToDate);
                };
            }

            if (mUseCaseSensitive && mUseAccentSensitive) command += " collate Latin1_General_CS_AS";
            else if (mUseCaseSensitive && !mUseAccentSensitive) command += " collate Latin1_General_CS_AI";
            else if (!mUseCaseSensitive && mUseAccentSensitive) command += " collate Latin1_General_CI_AS";
            else if (!mUseCaseSensitive && !mUseAccentSensitive) command += " collate Latin1_General_CI_AI";

            result = StaffInfo_BUS.GetManyDisplayCommand(command, cb);

            if (!result.Key)
            {
                return;
            }

            Helper.Instance().Bind<StaffInfo_Display_DTO>(dgStaffes, result.Value);
            dgStaffes.Columns["id"].Visible = false;
            dgStaffes.Columns["department_id"].Visible = false;
            dgStaffes.Columns["position_id"].Visible = false;
            dgStaffes.Columns["account_id"].Visible = false;
            dgStaffes.Columns["end_working_date"].Visible = false;
            dgStaffes.Columns["insurance_amount"].Visible = false;
            dgStaffes.Columns["allowance_amount"].Visible = false;
        }

        public StaffAll()
        {
            InitializeComponent();
        }

        private void StaffAll_Load(object sender, EventArgs e)
        {
            LoadStaffes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Helper.Instance().AccountHas_Staff_AddPermission())
            {
                MessageBox.Show("Tài khoản chưa cấp quyền thực hiện tính năng này");
                return;
            }

            StaffUpsert staffUpsert = new StaffUpsert();
            staffUpsert.ShowDialog();

            if (staffUpsert.mOperationOk)
            {
                LoadStaffes();
                MessageBox.Show("Thêm thành công");
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgStaffes.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            int row_idx = dgStaffes.SelectedCells[0].RowIndex;
            StaffInfo_DTO staff = (StaffInfo_DTO)dgStaffes.Rows[row_idx].DataBoundItem;

            if (!Helper.Instance().AccountHas_Staff_EditPermission(staff))
            {
                MessageBox.Show("Tài chưa được cấp quyền cho tính năng này");
                return;
            }

            StaffUpsert staffUpsert = new StaffUpsert(staff);
            staffUpsert.ShowDialog();

            if (staffUpsert.mOperationOk)
            {
                LoadStaffes();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void dgStaffes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_idx = e.RowIndex;
            if (row_idx < 0) return;

            StaffInfo_DTO staff = (StaffInfo_DTO)dgStaffes.Rows[row_idx].DataBoundItem;

            if (!Helper.Instance().AccountHas_Staff_EditPermission(staff))
            {
                MessageBox.Show("Tài khoản chưa được cấp quyền cho tính năng này");
                return;
            }

            StaffUpsert staffUpsert = new StaffUpsert(staff);
            staffUpsert.ShowDialog();

            if (staffUpsert.mOperationOk)
            {
                LoadStaffes();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Các dữ liệu liên quan đều sẽ bị xóa, bạn có muốn xóa không?", "Chú ý", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.No) return;

            if (dgStaffes.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            bool[] counts = new bool[dgStaffes.Rows.Count];
            for (int i = 0; i < dgStaffes.SelectedCells.Count; ++i)
            {
                int row_idx = dgStaffes.SelectedCells[i].RowIndex;
                counts[row_idx] = true;
            }

            List<int> list_staff_id = new List<int>();
            List<int> list_account_id = new List<int>();
            for (int i = 0; i < counts.Length; ++i)
            {
                StaffInfo_DTO staff = (StaffInfo_DTO)dgStaffes.Rows[i].DataBoundItem;
                if (!Helper.Instance().AccountHas_Staff_DeletePermission(staff))
                {
                    MessageBox.Show("Tài khoản không có quyền thực hiện thao tác này");
                    return;
                }

                if (counts[i]) list_staff_id.Add(Int32.Parse(dgStaffes.Rows[i].Cells["id"].Value.ToString()));
                if (counts[i]) list_account_id.Add(Int32.Parse(dgStaffes.Rows[i].Cells["account_id"].Value.ToString()));
            }

            KeyValuePair<bool, string> result = StaffInfo_BUS.DeleteMany(list_staff_id);
            if (result.Key == false)
            {
                MessageBox.Show(result.Value);
                return;
            }

            result = Account_BUS.DeleteMany(list_account_id);
            if (result.Key == false)
            {
                MessageBox.Show(result.Value);
                return;
            }

            LoadStaffes();
            MessageBox.Show("Xóa thành công");
        }

        private async void txbSearchBar_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int textLength = tb.Text.Length;

            await Task.Delay(500);
            if (textLength == tb.Text.Length)
            {
                SearchHandler(tb.Text);
            }
        }

        private void btnSearchAdvance_Click(object sender, EventArgs e)
        {
            StaffSearchAdvance staff_search = new StaffSearchAdvance(mSearchOptions);
            staff_search.ShowDialog();

            mSearchOptions = staff_search.mSearchOptions;
            if (mSearchOptions.mUseAdvance == true)
            {
                btnClearSearch.Text = "✘";
                btnClearSearch.BackColor = Color.Red;
                btnClearSearch.ForeColor = Color.White;
            }
        }

        private void btnSearchCaseSensitive_Click(object sender, EventArgs e)
        {
            if (mUseCaseSensitive == false)
            {
                mUseCaseSensitive = true;
                btnSearchCaseSensitive.BackColor = Color.LightCoral;
            }
            else
            {
                mUseCaseSensitive = false;
                btnSearchCaseSensitive.BackColor = Color.White;
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            mSearchOptions.mSearchTypeIndex = 0;
            mSearchOptions.mSearchFromDate = "";
            mSearchOptions.mSearchToDate = "";
            mSearchOptions.mUseAdvance = false;

            if (btnClearSearch.Text != "✓")
            {
                btnClearSearch.Text = "✓";
                btnClearSearch.BackColor = Color.White;
                btnClearSearch.ForeColor = Color.Black;
                SearchHandler(txbSearchBar.Text);
            }
        }

        private void btnAccentSensitive_Click(object sender, EventArgs e)
        {
            if (mUseAccentSensitive == false)
            {
                mUseAccentSensitive = true;
                btnAccentSensitive.BackColor = Color.LightCoral;
            }
            else
            {
                mUseAccentSensitive = false;
                btnAccentSensitive.BackColor = Color.White;
            }
        }

        private void btnTimeKeeping_Click(object sender, EventArgs e)
        {
            if (dgStaffes.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu nào được chọn");
                return;
            }

            int row_idx = dgStaffes.SelectedCells[0].RowIndex;
            StaffInfo_DTO staff = (StaffInfo_DTO)dgStaffes.Rows[row_idx].DataBoundItem;

            StaffDetail detail = new StaffDetail(staff);
            detail.ShowDialog();
        }
    }
}
