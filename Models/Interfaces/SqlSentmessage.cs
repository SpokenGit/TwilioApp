using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwilioWeb.Data;
using TwilioWeb.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace TwilioWeb.Models.Interfaces
{
    public class SqlSentmessage: IdbOperations
    {
        private sentmessages sentmessages_;
        private readonly MyContext _context;
        public SqlSentmessage(sentmessages sentmessages, MyContext context)
        {
            sentmessages_ = sentmessages;
            _context = context;
        }

        public SqlSentmessage()
        { }

        public string Insert()
        {
            try
            {
                sentmessages_.sentdate = DateTime.Now;
                _context.Add(sentmessages_);
                _context.SaveChanges();
                return sentmessages_.Id.ToString();
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }

        }

        public IEnumerable<object> Select()
        {

            try {

                string StrSelect = "select * from TEmployee " ;
                List<sentmessages> lista;

              

                //using (var cn = new SqlConnection( Configuration.GetConnectionString("myDb1")))
                //{
                //    var comando = new SqlCommand(StrSelect, cn);
                //    comando.CommandType = System.Data.CommandType.Text;
                //    try
                //    {
                //        cn.Open();
                //        var dr = comando.ExecuteReader();
                //        lista = new List<sentmessages>();
                //        sentmessages sentMessages;
                //        while (dr.Read())
                //        {
                //            messageSent = new sentmessages()
                //            {
                //                EmployeeFirtsName = (string)dr["EmployeeFirtsName"],
                //                EmployeeLastName = (string)dr["EmployeeLastName"],
                //                EmployeePhone = (string)dr["EmployeePhone"],
                //                EmployeeZip = (string)dr["EmployeeZip"],
                //                EmployeeHireDate = (DateTime)dr["EmployeeHireDate"]
                //            };
                //            lista.Add(empleado);
                //        }


                //    }
                //    catch (Exception e) { lista = new List<EmployeeCLS>(); }

                //}
               




                return  null;// _context.sentmessagess.ToList();
            } catch  
            {
                return null;
            }
           
        }

    }
}
