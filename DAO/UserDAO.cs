using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }
        private UserDAO()
        {

        }
        public List<UserDTO> Showinfo()
        {
            List<UserDTO> Lop =new List<UserDTO>();
            DataTable dataResult = DataProvider.Instance.ExecuteQuery("select * from dbo.Lop");
            foreach(DataRow item in dataResult.Rows)
            {
                string id = item[0].ToString();
                string Name = item[1].ToString();
                UserDTO newU = new UserDTO(id,Name);
                Lop.Add(newU);
            }
            return Lop;
        }
    }
}
