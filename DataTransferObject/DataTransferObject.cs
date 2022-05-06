using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataTransferObject
{
    public class DataTransferObject
    {
        public class Category_DTO
        {
            public int id { get; set; }
            [Display(Name = "Mã loại")]
            public string code { get; set; }
            [Display(Name = "Tên loại")]
            public string name { get; set; } = "";
            [Display(Name = "Danh mục hệ thống")]
            [UIHint("CheckBox")]
            public bool is_system_category { get; set; }
        }

        public class CategoryDetail_DTO
        {
            [Display(Order = 1)]
            public int id { get; set; }
            [Display(Name = "Mã danh mục")]
            public string code { get; set; }
            [Display(Name = "Tên danh mục")]
            public string name { get; set; } = "";
            [Browsable(false)]
            public int category_id { get; set; }
        }

        // ------------
        public class Account_DTO
        {
            [Display(Order = 1)]
            public int id { get; set; }
            [Display(Name = "Tên tài khoản", Order = 2)]
            public string account_name { get; set; }
            [Display(Name = "Mật khẩu", Order = 3)]
            public string password { get; set; }
            public int account_type_id { get; set; }
            public int group_type_id { get; set; }
            [Display(Name = "Tài khoản đã xác thực", Order = 4)]
            [UIHint("CheckBox")]
            public bool validated { get; set; }
            [Display(Name = "Tài khoản bị khóa", Order = 5)]
            [UIHint("CheckBox")]
            public bool blocked { get; set; }
        }

        public class Account_Display_DTO : Account_DTO
        {
            [Display(Name = "Loại tài khoản")]
            public string account_type_ext { get; set; }
            [Display(Name = "Nhóm quyền")]
            public string group_type_ext { get; set; }
        }
        // ------------

        public class Permission_DTO
        {
            public int id { get; set; }
            public string display_name { get; set; }
            public bool base_permission { get; set; }
            public string managed_object_id { get; set; }
            public int permissions { get; set; } // bitwise read 00100, write 00010, add 00001, update 01000, delete 10000
        }

        // ------------
        public class StaffInfo_DTO
        {
            public int id { get; set; }
            [Display(Name = "Mã nhân viên", Order = 1)]
            public string code { get; set; }
            [Display(Name = "Tên nhân viên", Order = 2)]
            public string name { get; set; }
            [Display(Name = "Ngày sinh", Order = 3)]
            public string birth_date { get; set; } = "";
            [Display(Name = "Nơi sinh", Order = 4)]
            public string birth_place { get; set; } = "";
            [Display(Name = "Email", Order = 5)]
            public string email { get; set; } = "";
            [Display(Name = "Ngày bắt đầu công tác", Order = 6)]
            public string start_working_date { get; set; } = "";
            [Display(Name = "Đang công tác", Order = 7)]
            [UIHint("CheckBox")]
            public bool working_status { get; set; }
            [Display(Name = "Ngày kết thúc công tác", Order = 8)]
            public string end_working_date { get; set; } = "";
            [Display(Name = "Lương cơ bản", Order = 9)]
            public decimal basic_salary_amount { get; set; }
            [Display(Name = "Phụ cấp bảo hiểm", Order = 10)]
            public decimal insurance_amount { get; set; }
            [Display(Name = "Phụ cấp công vụ", Order = 11)]
            public decimal allowance_amount { get; set; }

            public int department_id { get; set; }
            public int position_id { get; set; }
            public int account_id { get; set; }
        }

        public class StaffInfo_Display_DTO : StaffInfo_DTO
        {
            [Display(Name = "Phòng ban")]
            public string department_ext { get; set; } = "";
            [Display(Name = "Chức vụ")]
            public string position_ext { get; set; } = "";
            [Display(Name = "Tên tài khoản")]
            public string account_ext { get; set; } = "";
        }

        // ------------
        public class TimekeepingProcess_DTO
        {
            public int id { get; set; }
            public int staff_info_id { get; set; }
            public string timekeeping_date { get; set; } = "";
            public bool timekeeping_status { get; set; }
            public int evaluated_by_id { get; set; }
        }
        // ------------

        public class SalaryProcess_DTO
        {
            [Display(Order = 1)]
            public int id { get; set; }
            public int staff_info_id { get; set; }
            [Display(Name = "Lương tháng")]
            public string title { get; set; } = "";
            [Display(Name = "Đã trả lương")]
            public bool is_paid { get; set; }
            [Display(Name = "Ngày trả lương")]
            public string payment_date { get; set; } = "";
            [Display(Name ="Số lương")]
            public decimal salary { get; set; }
        }

        public class SalaryProcess_Display_DTO : SalaryProcess_DTO
        {
            [Display(Name = "Tên nhân viên")]
            public string staff_info_ext { get; set; } = "";
        }
    }
}
