using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

public class Conexion
{
    private static SqlConnection objconexion;
    private static string error;
    public static SqlConnection GetConexion()
    {
        if (objconexion != null)
            return objconexion;
        objconexion = new SqlConnection();
        objconexion.ConnectionString = "workstation id=DBCinecatracho.mssql.somee.com;packet size=4096;user id=cesarsauceda_SQLLogin_1;pwd=nl65ssuu4h;data source=DBCinecatracho.mssql.somee.com;persist security info=False;initial catalog=DBCinecatracho";

        try
        {
            objconexion.Open();
            return objconexion;
        }
        catch (Exception e)
        {
            error = e.Message;
            return null;
            throw;

        }



    }
    public static void cerrarConexion()
    {
        if (objconexion != null)
            objconexion.Close();
    }
}
