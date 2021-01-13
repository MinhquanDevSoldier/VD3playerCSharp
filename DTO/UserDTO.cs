using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        private String id;
        public String ID
        {
            get { return id; }
            set { id = value; }
        }
        private String NameLop;
        public String namelop
        {
            get { return NameLop; }
            set { NameLop = value; }
        }
        public UserDTO(String Id,String TenLop)
        {
            this.id = Id;
            this.NameLop = TenLop;
        }

    }
}
