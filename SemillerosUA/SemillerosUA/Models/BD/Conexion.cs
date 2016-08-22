using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Collections;

namespace SemillerosUA.Models.BD
{
    public class Conexion
    {
        public string stringConnection = ConfigurationManager.ConnectionStrings["oracleConexion"].ConnectionString;

        public OracleConnection ConexionOracle()
        {
            OracleConnection Conexion = new OracleConnection(stringConnection);
            try
            {
                Conexion.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("No se realizo la conexion a la base de datos: " + ex.Message);
            }
            return Conexion;
        }

        public DataTable realizarConsulta(string Procedure, string Cursor, Parametro[] Parameters)
        {
            DataTable data = new DataTable();
            OracleConnection conn = new OracleConnection();
            conn = ConexionOracle();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = Procedure;
            cmd.CommandType = CommandType.StoredProcedure;

            if (Parameters != null)
            {
                for (int i = 0; i < Parameters.Length; i++)
                {
                    cmd.Parameters.Add(Parameters[i].Nombre, Parameters[i].Value).Direction = ParameterDirection.Input;
                }
            }
            cmd.Parameters.Add(Cursor, OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            try
            {
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(data);
                return data;
            }
            catch (Exception e)
            {
                throw new Exception("Sentencia de consulta invalida " + e.Message);
            }
        }

        public bool realizarTransaccion(Transaction[] list)
        {
            bool state = false;
            OracleConnection conn = new OracleConnection();
            OracleCommand cmd = null;
            conn = ConexionOracle();

            OracleTransaction Transa = conn.BeginTransaction();

            try
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] != null)
                    {
                        cmd = new OracleCommand(list[i].Procedure, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (Parametro obj in list[i].Parameters)
                        {
                            cmd.Parameters.Add(obj.Nombre, obj.Value);
                        }
                        cmd.Transaction = Transa;
                        cmd.ExecuteNonQuery();
                    }
                }
                Transa.Commit();
                conn.Close();
                conn.Dispose();
                Transa.Dispose();
                state = true;
            }
            catch
            {
                Transa.Rollback();
                conn.Close();
                conn.Dispose();
                state = false;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
            return state;
        }
    }
}