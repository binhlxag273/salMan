using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryType_DAO
    {
        public static List<DataTransferObject.DataTransferObject.CategoryType_DTO> GetCategoryType()
        {
            DataTable dt = DataProvider.Instance().GetDataTable("select * from category_type", sqlCommand => {
            });

            List<DataTransferObject.DataTransferObject.CategoryType_DTO> result = new List<DataTransferObject.DataTransferObject.CategoryType_DTO>();

            foreach (DataRow dr in dt.Rows)
            {
                DataTransferObject.DataTransferObject.CategoryType_DTO ct = new DataTransferObject.DataTransferObject.CategoryType_DTO();
                ct.id = Int32.Parse(dr["id"].ToString());
                ct.display_name = dr["display_name"].ToString();
                result.Add(ct);
            }

            return result;
        }
    }
}
