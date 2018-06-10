using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;

public class My_Function_1
{
    public static void Value_workers(SqlInt32 id_temp)
           {
                using (SqlConnection connection = new SqlConnection("context connection=true"))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "SELECT COUNT(*) FROM Сотрудники WHERE Сотрудники.[ID проекта] = @id_temp;";
                    
                    SqlParameter parameter = new SqlParameter("@id_temp", SqlDbType.Int);
                    parameter.Value = id_temp;
                    command.Parameters.Add(parameter);
     
                    connection.Open();
                    SqlContext.Pipe.ExecuteAndSend(command);
                }
            }

}
