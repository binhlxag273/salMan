using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace BussinessLogicLayer
{
    public class StaffInfo_BUS
    {
        public static KeyValuePair<bool, string> DeleteMany(List<int> list_int)
        {
            return StaffInfo_DAO.DeleteMany(list_int);
        }

        public static KeyValuePair<bool, string> DeleteOne(int id)
        {
            return StaffInfo_DAO.DeleteOne(id);
        }

        public static KeyValuePair<bool, List<StaffInfo_DTO>> GetMany()
        {
            return StaffInfo_DAO.GetMany();
        }

        public static KeyValuePair<bool, List<StaffInfo_DTO>> GetMany<T>(string key, T value)
        {
            return StaffInfo_DAO.GetMany<T>(key, value);
        }

        public static KeyValuePair<bool, StaffInfo_DTO> GetOne(int id)
        {
            return StaffInfo_DAO.GetOne(id);
        }

        public static KeyValuePair<bool, string> UpdateOne(StaffInfo_DTO detail)
        {
            return StaffInfo_DAO.UpdateOne(detail);
        }

        public static KeyValuePair<bool, string> InsertOne(StaffInfo_DTO detail)
        {
            return StaffInfo_DAO.InsertOne(detail);
        }

        public static KeyValuePair<bool, List<StaffInfo_Display_DTO>> GetManyDisplay()
        {
            return StaffInfo_DAO.GetMany("select staff.*, cd_1.name as department_ext, cd_2.name as position_ext, acc.account_name as account_ext from StaffInfo as staff, CategoryDetail as cd_1, CategoryDetail as cd_2, Account as acc where staff.department_id = cd_1.id and staff.position_id = cd_2.id and staff.account_id = acc.id", sqlCommand =>
            {

            });
        }

        public static KeyValuePair<bool, List<StaffInfo_Display_DTO>> GetManyDisplayCommand(string command, Action<SqlCommand> cb)
        {
            return StaffInfo_DAO.GetMany(command, cb);
        }

        public static KeyValuePair<bool, StaffInfo_Display_DTO> GetOneDisplay(StaffInfo_DTO staffInfo)
        {
            string command_builder = "select s.*, cat_1.name as department_ext, cat_2.name as position_ext, acc.account_name as account_ext from StaffInfo as s, CategoryDetail as cat_1, CategoryDetail as cat_2, Account as acc where s.id = @id and s.department_id = cat_1.id and s.position_id = cat_2.id and s.account_id = acc.id;";

            return StaffInfo_DAO.GetOne(command_builder, sqlCommand =>
            {
                sqlCommand.Parameters.AddWithValue("@id", staffInfo.id);
            });
        }
    }
}
