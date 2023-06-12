using Dapper;
using Event.DOM;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.DAL
{
    public class RegistrationDAL
    {
        public RegistrationDAL() { }

        private static readonly string _connection_string= "Data Source=LAPTOP-44SO5CQD;Integrated Security=True;Initial Catalog=EventDB;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public bool InsertUserData(Registration dom)
        {
            
            int rowAffected = 0;

            using (var connection = new SqlConnection(_connection_string))
            {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@Username", dom.Username);
                parameters.Add("@EmailID", dom.EmailID);
                parameters.Add("@Address", dom.Address);
                parameters.Add("@Password", dom.Password);
                parameters.Add("@ConfirmPassword", dom.ConfirmPassword);


                parameters.Add("@Code", dbType: DbType.Int32, direction: ParameterDirection.Output);
                parameters.Add("@Message", dom.message,direction: ParameterDirection.Output);

                rowAffected = connection.Execute("UserRegistration", parameters, commandType: CommandType.StoredProcedure);

                Int32 Code = parameters.Get<Int32>("@Code");
                string Message = parameters.Get<string>("@Message");

            }
            return (rowAffected > 0) ? true : false;
        }
    }
}
