using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Connection
/// </summary>
public class Connection
{
    public Connection()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public SqlConnection SCon=new SqlConnection("Data Source=172.168.3.122;Initial Catalog=rfid;User ID=sa;Password=123456");

    public bool OpenSqlConnection()
    {
        bool Status=false;
        try 
        {
            SCon=new SqlConnection("Data Source=172.168.3.122;Initial Catalog=rfid;User ID=sa;Password=123456");
            SCon.Open();
            Status=true;
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        { SCon.Close(); }
        return Status;
    }
}