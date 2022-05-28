using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace DataAccessLayer
{
    public class CategoryDetail_DAO
    {
        public static KeyValuePair<bool, string> DeleteOne(int id)
        {
            return DataProvider.Instance().DeleteOne("CategoryDetail", id);
        }

        public static KeyValuePair<bool, string> DeleteMany(List<int> list_int)
        {
            return DataProvider.Instance().DeleteMany("CategoryDetail", list_int);
        }

        public static KeyValuePair<bool, string> DeleteManyById(int id)
        {
            string command_builder = "delete from CategoryDetail where category_id=@id";

            return DataProvider.Instance().CrudQuery(command_builder, sqlCommand =>
            {
                sqlCommand.Parameters.AddWithValue("@id", id);
            });
        }

        public static KeyValuePair<bool, List<CategoryDetail_DTO>> GetMany()
        {
            return DataProvider.Instance().GetMany<CategoryDetail_DTO>("CategoryDetail");
        }

        public static KeyValuePair<bool, List<CategoryDetail_DTO>> GetMany<V>(string key, V value)
        {
            return DataProvider.Instance().GetMany<CategoryDetail_DTO, V>("CategoryDetail", key, value);
        }

        public static KeyValuePair<bool, CategoryDetail_DTO> GetOne(int id)
        {
            return DataProvider.Instance().GetOne<CategoryDetail_DTO>("CategoryDetail", id);
        }

        public static KeyValuePair<bool, string> UpdateOne(CategoryDetail_DTO detail)
        {
            return DataProvider.Instance().UpdateOne<CategoryDetail_DTO>("CategoryDetail", detail);
        }

        public static KeyValuePair<bool, List<CategoryDetail_DTO>> GetMany(string command, Action<SqlCommand> cb)
        {
            return DataProvider.Instance().GetMany<CategoryDetail_DTO>(command, cb);
        }

        public static KeyValuePair<bool, string> InsertOne(CategoryDetail_DTO detail)
        {
            return DataProvider.Instance().InsertOne<CategoryDetail_DTO>("CategoryDetail", detail);
        }
    }
}
