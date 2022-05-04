using System.ComponentModel;

namespace DataTransferObject
{
    public class DataTransferObject
    {
        public class CategoryType_DTO
        {
            public int id { get; set; }
            public string display_name { get; set; }
        }

        public class Category_DTO
        {
            public int id { get; set; }
            public string display_name { get; set; }
            public int category_type_id { get; set; }
            public string note { get; set; }
        }

        public class Permission_DTO
        {
            public int id { get; set; }
            public string display_name { get; set; }
            public bool base_permission { get; set; }
            public string managed_object_id { get; set; }
            public int permissions { get; set; } // bitwise read 00100, write 00010, add 00001, update 01000, delete 10000
        }

        public class Account_DTO
        {
            public int id { get; set; }
            [DisplayName("Tên tài khoản")]
            public string account_name { get; set; }
            [DisplayName("Mật khẩu")]
            public string password { get; set; }
            public int account_type_id { get; set; }
            public int group_type_id { get; set; }
            [DisplayName("Tài khoản đã xác thực")]
            public bool validated { get; set; }
            [DisplayName("Tài khoản bị khỏa")]
            public bool blocked { get; set; }
        }

        public class StaffInfo_DTO
        {
            public int id { get; set;}
            public string staff_code { get; set; }
            public string display_name { get; set; }
            public DateOnly birth_date { get; set; }
            public int birth_place { get; set; }
            public string email { get; set; }
            public DateOnly start_working_date { get; set; }
            public DateOnly end_working_date { get; set; }

            public int basic_salary_amount { get; set; }
            public int insurance_amount { get; set; }
            public int work_allowance_amount { get; set; }

            public int department_id { get; set; }
            public int position_id { get; set; }
            public int account_id { get; set; }
        }

        public class TimeKeepingProcess_DTO
        {
            public int id { get; set; }
            public int staff_info_id { get; set; }
            public DateTime timekeeping_date { get; set; }
            public int timekeeping_status_id { get; set; }
            public int evaluated_by { get; set; }
        }

        public class BonusEvent_DTO
        {
            public int id { get; set; }
            public int inform_content { get; set; }
            public int bonus_amount { get; set; }
            public string received_staffes { get; set; }
        }

        public class SystemLog_DTO
        {
            public int id { get; set; }
            public string log_content { get; set; }
            public string log_date { get; set; }
            public int log_type_id { get; set; }
        }
    }
}