using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class UserBUS
    {
        private static UserBUS instance;
        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserBUS();
                }
                return instance;
            }
        }

        private UserBUS()
        {

        }
        public void setgridview(DataGridView data)
        {
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Mã lớp";
            col1.DataPropertyName = "id";
            data.Columns.Add(col1);
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Tên lớp";
            col2.DataPropertyName = "namelop";
            data.Columns.Add(col2);
        }
        public void Showinfo(DataGridView data)
        {
            data.DataSource = UserDAO.Instance.Showinfo();
        }
    }
}
