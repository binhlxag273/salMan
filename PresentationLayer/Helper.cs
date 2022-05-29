using BussinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace PresentationLayer
{
    public class Helper
    {
        private Helper()
        {

        }

        private class UIHintMappings
        {
            public static Dictionary<string, Func<DataGridViewColumn>> DataGridViewColumns
            {
                get;
            }

            static UIHintMappings()
            {
                DataGridViewColumns = new Dictionary<string, Func<DataGridViewColumn>>();
                DataGridViewColumns.Add("TextBox",
                    () => new DataGridViewTextBoxColumn());
                DataGridViewColumns.Add("CheckBox",
                    () => new DataGridViewCheckBoxColumn(false));
                DataGridViewColumns.Add("TreeStateCheckBox",
                    () => new DataGridViewCheckBoxColumn(true));
                DataGridViewColumns.Add("Link",
                    () => new DataGridViewLinkColumn());
            }
        }

        private static Helper _instance;

        public static Helper Instance()
        {
            if (_instance == null)
            {
                _instance = new Helper();
            }

            return _instance;
        }

        public bool gIsLogin { get; set; } = false;

        public Account_DTO gAccount { get; set; }
        public StaffInfo_DTO gStaffInfo { get; set; }

        public void TrySetStaffInfo()
        {
            if (this.gAccount == null)
            {
                return;
            }

            if (this.gAccount.account_type_id == 1) // Admin doesnt have staff info
            {
                return;
            }

            KeyValuePair<bool, StaffInfo_DTO> result = StaffInfo_BUS.GetOneByAccountId(this.gAccount.id);
            if (!result.Key)
            {
                UtilityLayer.Logging.Instance().LogInfo("Error [Helper][TrySetStaffInfo]: cannot get staff by account id");
                return;
            }

            this.gStaffInfo = result.Value;
            return;
        }

        public void Bind<T>(DataGridView grid, IList<T> data, bool autoGenerateColumns = true)
        {
            if (autoGenerateColumns)
            {
                var properties = TypeDescriptor.GetProperties(typeof(T));
                var metedata = properties.Cast<PropertyDescriptor>().Select(p => new
                {
                    Name = p.Name,
                    HeaderText = p.Attributes.OfType<DisplayAttribute>()
                        .FirstOrDefault()?.Name ?? p.DisplayName,
                    ToolTipText = p.Attributes.OfType<DisplayAttribute>()
                        .FirstOrDefault()?.GetDescription() ?? p.Description,
                    Order = p.Attributes.OfType<DisplayAttribute>()
                        .FirstOrDefault()?.GetOrder() ?? int.MaxValue,
                    Visible = p.IsBrowsable,
                    ReadOnly = p.IsReadOnly,
                    Format = p.Attributes.OfType<DisplayFormatAttribute>()
                        .FirstOrDefault()?.DataFormatString,
                    Type = p.PropertyType,
                    UIHint = p.Attributes.OfType<UIHintAttribute>()
                        .FirstOrDefault()?.UIHint
                });
                var columns = metedata.OrderBy(m => m.Order).Select(m =>
                {
                    DataGridViewColumn c;
                    if (!string.IsNullOrEmpty(m.UIHint) &&
                    UIHintMappings.DataGridViewColumns.ContainsKey(m.UIHint))
                    {
                        c = UIHintMappings.DataGridViewColumns[m.UIHint].Invoke();
                    }
                    else
                    {
                        c = new DataGridViewTextBoxColumn();
                    }
                    c.DataPropertyName = m.Name;
                    c.Name = m.Name;
                    c.HeaderText = m.HeaderText;
                    c.ToolTipText = m.ToolTipText;
                    c.DefaultCellStyle.Format = m.Format;
                    c.ReadOnly = m.ReadOnly;
                    c.Visible = m.Visible;
                    return c;
                });
                grid.Columns.Clear();
                grid.Columns.AddRange(columns.ToArray());
            }

            grid.DataSource = data;
        }

        public T Clone<T>(T source) where T : new()
        {
            T dest = new T();
            foreach (PropertyInfo prop in dest.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                prop.SetValue(dest, prop.GetValue(source, null), null);
            }

            return dest;
        }

        public bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public bool AccountIsAdmin()
        {
            return this.gAccount.account_type_id == 1;
        }

        public bool AccountIsSupperUser()
        {
            if (this.AccountIsAdmin() || this.gAccount.group_type_id == 3)
            {
                return true;
            }

            return false;
        }

        public bool AccountHas_Account_ManagementPermission()
        {
            return AccountIsSupperUser();
        }

        public bool AccountHas_Account_ResetPasswordPermission(Account_DTO editAccount)
        {
            if (this.AccountHas_Account_ManagementPermission())
            {
                return true;
            }

            if (this.gAccount.id == editAccount.id)
            {
                return true;
            }

            if (this.gAccount.group_type_id >= editAccount.group_type_id)
            {
                return false;
            }

            return true;
        }

        public bool AccountHas_Account_ChangePasswordPermission(Account_DTO editAccount)
        {
            return this.AccountHas_Account_ManagementPermission();
        }

        public bool AccountHas_Account_EditPermission(Account_DTO editAccount)
        {
            return this.AccountHas_Account_ManagementPermission();
        }

        public bool AccountHas_Account_AddPermission()
        {
            return this.AccountHas_Account_ManagementPermission();
        }

        public bool AccountHas_Staff_ManagementPermission()
        {
            if (this.AccountIsSupperUser())
            {
                return true;
            }

            if (this.gAccount.group_type_id == 4)
            {
                return true;
            }

            return false;
        }

        public bool AccountHas_Staff_AddPermission()
        {
            if (this.AccountHas_Staff_ManagementPermission())
            {
                return true;
            }

            return false;
        }

        public bool AccountHas_Staff_EditPermission(StaffInfo_DTO staffInfo)
        {
            if (this.AccountHas_Staff_ManagementPermission())
            {
                return true;
            }

            if (this.gStaffInfo.id == staffInfo.id)
            {
                return true;
            }

            return false;
        }

        public bool AccountHas_Staff_DeletePermission(StaffInfo_DTO staffInfo)
        {
            if (this.AccountIsAdmin())
            {
                return true;
            }

            if (this.gStaffInfo.id == staffInfo.id)
            {
                return false;
            }

            return AccountHas_Staff_ManagementPermission();
        }

        public bool AccountHas_Staff_EvaluateTimekeepingProcess()
        {
            if (this.AccountHas_Staff_ManagementPermission())
            {
                return true;
            }

            return false;
        }

        public bool AccountHas_Category_Management()
        {
            if (this.AccountIsSupperUser())
            {
                return true;
            }

            return true;
        }
    }
}
