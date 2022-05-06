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

    }
}
