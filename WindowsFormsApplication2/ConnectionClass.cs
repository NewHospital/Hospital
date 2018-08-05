using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication2;
using System.Data.SqlClient;
using System.Data;

namespace Hospital
{   public enum MyCommandtype { text= 1, storedProcedure= 2}; 
    public enum ExecuteReaderOrNonQuery { executeReader= 1, executeNonQuery= 2};



    class ConnectionClass
    {
        static SqlConnection ConnectMe;
        public static DataTable MyDataTable;
        public static List<SqlParameter> ParameterList; 

        public static void Connection(string conn)
        {
            SqlConnection MyConnection = new SqlConnection(conn);
            ConnectMe= MyConnection  ; 
        }

        public static void parameters (params SqlParameter [] MyParameters)
        {
            ParameterList = new List<SqlParameter>();
            

            foreach (var item in MyParameters)
              
            {
                ParameterList.Add(item);
            }
        }


        public static void SQLCommand (string CommandText, MyCommandtype CT, ExecuteReaderOrNonQuery Ex)
        {
            ConnectMe.Open();
            SqlCommand MyCommand = new SqlCommand(CommandText, ConnectMe); 
            switch (CT)
            {
                case MyCommandtype.text:
                    MyCommand.CommandType = CommandType.Text; 
                    
                        switch (Ex)
                        {
                            case ExecuteReaderOrNonQuery.executeReader:
                                
                                    SqlDataReader DataReader = MyCommand.ExecuteReader ();
                                    MyDataTable = new DataTable();
                                    MyDataTable.Load(DataReader);
                                    break;
                                
                            case ExecuteReaderOrNonQuery.executeNonQuery:
                                
                                    MyCommand.ExecuteNonQuery();
                                    MyCommand.Parameters.AddRange(ParameterList.ToArray ());
                                    break;
                        }
                        break;

                case MyCommandtype.storedProcedure:
                    {
                        MyCommand.CommandType = CommandType.StoredProcedure; 
                        switch (Ex)
                        {
                            case ExecuteReaderOrNonQuery.executeReader:
                                SqlDataReader DataReader = MyCommand.ExecuteReader();
                                MyDataTable = new DataTable();
                                MyDataTable.Load(DataReader);
                                break;
                            case ExecuteReaderOrNonQuery.executeNonQuery:
                                MyCommand.Parameters.AddRange(ParameterList.ToArray());
                                MyCommand.ExecuteNonQuery();
                                break;
                        }

                        break;
                    }
                    
            }
            ConnectMe.Close();
        }
       
        
        
        

    }
}
