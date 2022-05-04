using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Category_DAO
    {
        public static List<DataTransferObject.DataTransferObject.Category_DTO> GetCategory(int type_id)
        {
            DataTable dt = DataProvider.Instance().GetDataTable("select * from Category where type_id=@type_id", sqlCommand => {
                sqlCommand.Parameters.AddWithValue("@type_id", type_id);
            });

            List<DataTransferObject.DataTransferObject.Category_DTO> result = new List<DataTransferObject.DataTransferObject.Category_DTO>();

            foreach (DataRow dr in dt.Rows)
            {
                DataTransferObject.DataTransferObject.Category_DTO ct = new DataTransferObject.DataTransferObject.Category_DTO();
                ct.id = Int32.Parse(dr["id"].ToString());
                ct.display_name = dr["display_name"].ToString();
                result.Add(ct);
            }

            return result;
        }
    }
}
