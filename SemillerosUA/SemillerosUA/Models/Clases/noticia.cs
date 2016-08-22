using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class noticia
    {
        public long ncia_idnoticia { get; set; }
        public string ncia_titulo { get; set; }
        public string ncia_rutaimagen { get; set; }
        public string ncia_descripcion { get; set; }
        public string ncia_fechapublicacion { get; set; }
        public string ncia_mostrardesde { get; set; }
        public string ncia_mostrarhasta { get; set; }
        public string ncia_estado { get; set; }
        public int smlr_idsemillero { get; set; }
        public long user_idusuario { get; set; }
        public string ncia_linkvideo { get; set; }
        public int tntc_idtipo_noticia { get; set; }
        public string ncia_rutaadjunto { get; set; }

        Conexion conexion = new Conexion();

        public noticia() { }

        public noticia(long ncia_idnoticia, string ncia_titulo, string ncia_rutaimagen, string ncia_descripcion, string ncia_fechapublicacion, string ncia_mostrardesde, string ncia_mostrarhasta, string ncia_estado, int smlr_idsemillero, long user_idusuario, string ncia_linkvideo, int tntc_idtipo_noticia, string ncia_rutaadjunto)
        {
            this.ncia_idnoticia = ncia_idnoticia;
            this.ncia_titulo = ncia_titulo;
            this.ncia_rutaimagen = ncia_rutaimagen;
            this.ncia_descripcion = ncia_descripcion;
            this.ncia_fechapublicacion = ncia_fechapublicacion;
            this.ncia_mostrardesde = ncia_mostrardesde;
            this.ncia_mostrarhasta = ncia_mostrarhasta;
            this.ncia_estado = ncia_estado;
            this.smlr_idsemillero = smlr_idsemillero;
            this.user_idusuario = user_idusuario;
            this.ncia_linkvideo = ncia_linkvideo;
            this.tntc_idtipo_noticia = tntc_idtipo_noticia;
            this.ncia_rutaadjunto = ncia_rutaadjunto;
        }

        public DataTable get_noticia()
        {
            return conexion.realizarConsulta("PR_SELECT_NOTICIA ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(noticia obj)
        {
            Parametro[] param = new Parametro[13];
            param[0] = new Parametro("NCIA_IDNOTICIA", obj.ncia_idnoticia);
            param[1] = new Parametro("NCIA_TITULO", obj.ncia_titulo);
            param[2] = new Parametro("NCIA_RUTAIMAGEN", obj.ncia_rutaimagen);
            param[3] = new Parametro("NCIA_DESCRIPCION", obj.ncia_descripcion);
            param[4] = new Parametro("NCIA_FECHAPUBLICACION", obj.ncia_fechapublicacion);
            param[5] = new Parametro("NCIA_MOSTRARDESDE", obj.ncia_mostrardesde);
            param[6] = new Parametro("NCIA_MOSTRARHASTA", obj.ncia_mostrarhasta);
            param[7] = new Parametro("NCIA_ESTADO", obj.ncia_estado);
            param[8] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            param[9] = new Parametro("USER_IDUSUARIO", obj.user_idusuario);
            param[10] = new Parametro("NCIA_LINKVIDEO", obj.ncia_linkvideo);
            param[11] = new Parametro("TNTC_IDTIPO_NOTICIA", obj.tntc_idtipo_noticia);
            param[12] = new Parametro("NCIA_RUTAADJUNTO", obj.ncia_rutaadjunto);
            return param;
        }

        public bool insert_noticia(noticia obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_NOTICIA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_noticia(noticia obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_NOTICIA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
