﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using academia_03data;
using Mysqlx.Datatypes;
using Org.BouncyCastle.Math;

class GestionAlumnos
{
    public Alumno Alumno { set; get; } //El alumno con el que trabajaremos
    public GestionAlumnos()
    {
        Alumno = new Alumno();
    }
    public string Error()
    {
        //Devuelve el error si lo hay de la clase BaseDatos
    }
    public Alumno Primero()
    {
        //Busca el primer alumno y si lo encuentra lo asigna a la propiedad Alumno
    }
    public Alumno Ultimo()
    {
        //Busca el último alumno y si lo encuentra lo asigna a la propiedad Alumno
    }
    public Alumno Siguiente()
    {
        //Busca el siguiente alumno al actual (this.Alumno.dni) y si lo encuentra lo asigna a la
        //propiedad Alumno
    }
    public Alumno Anterior()
    {
        //Busca el anterior alumno al actual (this.Alumno.dni) y si lo encuentra lo asigna a la
        //propiedad Alumno
    }
    //Este método actualiza los datos de alumno cargado, hace un select con la clave principal
    //Aluno.Dni y si existe en la base de datos hace un update, en caso de no existir devuelve -1 para que la
    //capa de encima pueda sacar un mensaje
    public int Edit()
        {
            string sql = "select * from alumnos where dni = '" + this.Alumno.Dni + "'";
            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "update alumnos set nombre = '" + this.Alumno.Nombre + "', apellidos = '"
                + this.Alumno.Apellidos + "', telefono = '" + this.Alumno.Telefono +
                "', poblacion = '" + this.Alumno.Poblacion + "' where dni = '" + this.Alumno.Dni +
                "'";
                return (BaseDatos.Modificacion(sql));
            }
            return -1;
        }
    //Este método inserta un nuevo alumno cuyos datos tenemos cargados en la propiedad Alumno, para ello
    //primero mira que el alumno no exista en la base de datos, en caso de que ya exista devuelve -1
    public int Insert()
    {
            /*Este método hace intenta insertar el alumno que tenemos en la propiedad
            GestionAlumnos.Alumno:
            -si no existe su DNI en la base de datos lo inserta y devuelve 1
            - Si existe su DNI o hay algún error devuelve -1*/
    }
    public int Remove()
    {
        //Este método borra de la base de la base de datos el alumno con la clave principal:
        //Alumno.dni.Habrá que sacar una ventana de advertencia antes de borrarlo
    }
    //Este método obtiene el alumno cuyo dni se pasa como parámetro
    public Alumno GetById(string dni)
    {
        DataTable dt = BaseDatos.Consulta("select * from alumnos where dni = '" + dni + "'");
        if (dt != null && dt.Rows.Count > 0)
        {
            Alumno a = new Alumno(dt.Rows[0]["dni"].ToString(), dt.Rows[0]["nombre"].ToString(),
            dt.Rows[0]["apellidos"].ToString(), dt.Rows[0]["telefono"].ToString(), dt.Rows[0]
            ["poblacion"].ToString());
            return (a);
        }
        return (null);
    }
    //Este método obtiene una lista con todos los alumnos
    public List<Alumno> GetAll()
    {
        List<Alumno> alumnos = new List<Alumno>();
        DataTable dt = BaseDatos.Consulta("select * from alumnos order by dni");
        for (int i = 0; dt != null && i < dt.Rows.Count; i++)
        {
            alumnos.Add(new Alumno(dt.Rows[i]["dni"].ToString(), dt.Rows[i]["nombre"].ToString(),
            dt.Rows[i]["apellidos"].ToString(), dt.Rows[i]["telefono"].ToString(), dt.Rows[0]
            ["poblacion"].ToString()));
        }
        return (alumnos);
    }
    //Este método obtiene un alumno (el primero en orden) a partir de una consulta SQL
    public Alumno GetOneBySql(string sql)
    {
        DataTable dt = BaseDatos.Consulta(sql);
        if (dt != null && dt.Rows.Count > 0)
        {
            Alumno a = new Alumno(dt.Rows[0]["dni"].ToString(), dt.Rows[0]["nombre"].ToString(),
            dt.Rows[0]["apellidos"].ToString(), dt.Rows[0]["telefono"].ToString(), dt.Rows[0]
            ["poblacion"].ToString());
            return (a);
        }
        return (null);
    }
    //Este método devuelve un DataTable con el resultado de la consulta que se le pase
    public DataTable GetAllBySql(string sql)
    {
        return BaseDatos.Consulta(sql);
    }
}