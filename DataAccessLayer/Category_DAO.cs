using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace DataAccessLayer
{
    public class Category_DAO
    {
        public static KeyValuePair<bool, string> DeleteOne(int id)
        {
            return DataProvider.Instance().DeleteOne("Category", id);
        }

        public static KeyValuePair<bool, string> DeleteMany(List<int> list_int)
        {
            return DataProvider.Instance().DeleteMany("Category", list_int);
        }

        public static KeyValuePair<bool, List<Category_DTO>> GetMany()
        {
            return DataProvider.Instance().GetMany<Category_DTO>("Category");
        }

        public static KeyValuePair<bool, Category_DTO> GetOne(int id)
        {
            return DataProvider.Instance().GetOne<Category_DTO>("Category", id);
        }

        public static KeyValuePair<bool, string> UpdateOne(Category_DTO category)
        {
            return DataProvider.Instance().UpdateOne<Category_DTO>("Category", category);
        }

        public static KeyValuePair<bool, string> InsertOne(Category_DTO category)
        {
            return DataProvider.Instance().InsertOne<Category_DTO>("Category", category);
        }
    }
}
