using DataAccessLayer;
using DataTransferObject;
using static DataTransferObject.DataTransferObject;

namespace BussinessLogicLayer
{
    public class Category_BUS
    {
        public static KeyValuePair<bool, string> DeleteMany(List<int> list_int)
        {
            return Category_DAO.DeleteMany(list_int);
        }

        public static KeyValuePair<bool, string> DeleteOne(int id)
        {
            return Category_DAO.DeleteOne(id);
        }

        public static KeyValuePair<bool, List<Category_DTO>> GetMany()
        {
            return Category_DAO.GetMany();
        }

        public static KeyValuePair<bool, Category_DTO> GetOne(int id)
        {
            return Category_DAO.GetOne(id);
        }

        public static KeyValuePair<bool, string> UpdateOne(Category_DTO category)
        {
            return Category_DAO.UpdateOne(category);
        }

        public static KeyValuePair<bool, string> InsertOne(Category_DTO category)
        {
            return Category_DAO.InsertOne(category);
        }
    }
}