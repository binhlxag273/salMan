using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace BussinessLogicLayer
{
    public class CategoryDetail_BUS
    {
        public static KeyValuePair<bool, string> DeleteMany(List<int> list_int)
        {
            return CategoryDetail_DAO.DeleteMany(list_int);
        }

        public static KeyValuePair<bool, string> DeleteOne(int id)
        {
            return CategoryDetail_DAO.DeleteOne(id);
        }

        public static KeyValuePair<bool, List<CategoryDetail_DTO>> GetMany()
        {
            return CategoryDetail_DAO.GetMany();
        }

        public static KeyValuePair<bool, List<CategoryDetail_DTO>> GetMany<T>(string key, T value)
        {
            return CategoryDetail_DAO.GetMany<T>(key, value);
        }

        public static KeyValuePair<bool, CategoryDetail_DTO> GetOne(int id)
        {
            return CategoryDetail_DAO.GetOne(id);
        }

        public static KeyValuePair<bool, string> UpdateOne(CategoryDetail_DTO detail)
        {
            return CategoryDetail_DAO.UpdateOne(detail);
        }

        public static KeyValuePair<bool, string> InsertOne(CategoryDetail_DTO detail)
        {
            return CategoryDetail_DAO.InsertOne(detail);
        }
    }
}
