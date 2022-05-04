using DataAccessLayer;
using DataTransferObject;

namespace BussinessLogicLayer
{
    public class CategoryType_BUS
    {
        public static List<DataTransferObject.DataTransferObject.CategoryType_DTO> GetCategoryType()
        {
            return DataAccessLayer.CategoryType_DAO.GetCategoryType();
        }
    }
}