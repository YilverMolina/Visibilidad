using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SemillerosUA.Models.BD
{
    public class Seguridad
    {
        private static string[] inj = new string[11] {
         "' or 1=1 or \"='",
        "' or 1=1--",
        "' or 1=1#",
        "' or 1=1/*",
        "') or '1'='1--",
        "') or ('1'='1--",
        "' or 1=1--",
        "or 1=1--",
        "or 1=1",
        "' or 1=1 or '",
        "aaaa' OR 'a'='a"};

        public static bool ValidarIngreso(string user, string pass)
        {
            return Validar(user, pass);
        }
        public static bool Validar(string email, string clave)
        {
            if ((email = email.Trim()).Length > 0
                    && (clave = clave.Trim()).Trim().Length > 0)
            {
                string aux_email = RegularEspacios(email);
                string aux_clave = RegularEspacios(clave);
                foreach (string inj1 in inj)
                {
                    if (inj1.Equals(aux_email)
                            || inj1.Equals(Comilla_to_simple(aux_email))
                            || inj1.Equals(aux_clave)
                            || inj1.Equals(Comilla_to_simple(aux_clave))
                        || email.Contains(inj1)
                        || clave.Contains(inj1))
                    {
                        return false;
                    }
                }
            }
            return ValidacionEmail(email);
        }

        private static String Comilla_to_simple(String sql_)
        {
            return sql_.Replace("'", "\"");
        }

        private static String RegularEspacios(String sql)
        {
            String aux_sql = "";
            sql = sql.Trim();
            for (int i = 0; i < sql.Length; i++)
            {
                if (sql[i] == ' ' && sql[i] == sql[i + 1])
                {
                    continue;
                }
                aux_sql += sql[i];
            }
            return aux_sql;
        }

        public static bool ValidacionEmail(string input)
        {
            input = input.Trim();
            //matches devuelve un true o false si se cumple el patron dado en el parametro

            //if (Regex.Matches(input, "[-\\w\\.]+@\\w+\\.\\w+").Count > 0) {
            //	//System.out.println("No sirve ese correo");
            //	return false;
            //}

            //if (Regex.Matches(input, "^www.").Count > 0) {
            //	//System.out.println("Los emails no empiezan por www.");
            //	return false;
            //}
            //// comprueba que no contenga caracteres prohibidos
            //if (Regex.Matches(input, "[^A-Za-z0-9.@_-~#]+").Count > 0) {
            //	//System.out.println("La cadena contiene caracteres especiales");
            //	return false;
            //}
            Regex regex = new Regex(@"[-\\w\\.]+@\\w+\\.\\w+");
            Match match = regex.Match(input);
            if (match.Success)
            {
                return false;
            }
            regex = new Regex(@"^www.");
            match = regex.Match(input);
            if (match.Success)
            {
                return false;
            }
            regex = new Regex(@"[^A-Za-z0-9.@_-~#]+");
            match = regex.Match(input);
            if (match.Success)
            {
                return false;
            }

            return true;
        }
    }
}