using System;
using System.Collections.Generic;
using System.Data;
using Academia._02aplication;
using Academia._03data;


namespace Academia._02aplication
{
    public class GestionAlumnos
    {
        public Alumno Alumno { get; set; }        
        public GestionAlumnos()
        {
            Alumno = new Alumno();
        }
        public string Error()
        {
            return BasedeDatos.Error;
        }
        public Alumno Primero()
        {
            return ObtenerAlumno("SELECT * FROM alumnos ORDER BY dni ASC LIMIT 1");
        }
        public Alumno Ultimo()
        {
            return ObtenerAlumno("SELECT * FROM alumnos ORDER BY dni DESC LIMIT 1");
        }
        public Alumno Siguiente()
        {
            if (string.IsNullOrEmpty(Alumno.Dni))
                return null;

            return MoverAlumno("SELECT * FROM alumnos WHERE dni > '{0}' ORDER BY dni ASC LIMIT 1");
        }
        public Alumno Anterior()
        {
            if (string.IsNullOrEmpty(Alumno.Dni))
                return null;

            return MoverAlumno("SELECT * FROM alumnos WHERE dni < '{0}' ORDER BY dni DESC LIMIT 1");
        }
        private Alumno MoverAlumno(string consulta)
        {
            var nuevoAlumno = ObtenerAlumno(string.Format(consulta, Alumno.Dni));
            if (nuevoAlumno != null)
                Alumno = nuevoAlumno;
            return Alumno;
        }
        public int Edit()
        {
           
            if (ExisteAlumno(Alumno.Dni))
            {
                string updateSql = $@"
                    UPDATE alumnos SET 
                        nombre = '{Alumno.Nombre}',
                        apellidos = '{Alumno.Apellidos}',
                        telefono = '{Alumno.Telefono}',
                        poblacion = '{Alumno.Poblacion}'
                    WHERE dni = '{Alumno.Dni}'";

                return BasedeDatos.Modificacion(updateSql);
            }
            return -1;
        }
        public int Insert()
        {
            if (ExisteAlumno(Alumno.Dni))
                return -1;

            string insertSql = $@"
                INSERT INTO alumnos (dni, nombre, apellidos, telefono, poblacion)
                VALUES ('{Alumno.Dni}', '{Alumno.Nombre}', '{Alumno.Apellidos}', '{Alumno.Telefono}', '{Alumno.Poblacion}')";

            return BasedeDatos.Modificacion(insertSql);
        }
        public int Remove()
        {
            if (string.IsNullOrEmpty(Alumno.Dni))
                return -1;

            int filas = BasedeDatos.Modificacion($"DELETE FROM alumnos WHERE dni = '{Alumno.Dni}'");
            if (filas > 0)
                Alumno = new Alumno();
            return filas;
        }
        public Alumno GetById(string dni)
        {
            
            return ObtenerAlumno($"SELECT * FROM alumnos WHERE dni = '{dni}'");
          
        }
        public List<Alumno> GetAll()
        {
            List<Alumno> lista = new List<Alumno>();
            var datos = BasedeDatos.Consulta("SELECT * FROM alumnos ORDER BY dni");

            if (datos != null)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    lista.Add(new Alumno(
                        fila["dni"].ToString(),
                        fila["nombre"].ToString(),
                        fila["apellidos"].ToString(),
                        fila["poblacion"].ToString(),
                        fila["telefono"].ToString()
                    ));
                }
            }
            return lista;
        }
        public List<Alumno> Buscar(string dni, string nombre, string apellidos, string telefono, string poblacion)
        {
            List<string> condiciones = new List<string>();

            if (!string.IsNullOrWhiteSpace(dni))
                condiciones.Add("dni LIKE '%" + dni + "%'");

            if (!string.IsNullOrWhiteSpace(nombre))
                condiciones.Add("nombre LIKE '%" + nombre + "%'");

            if (!string.IsNullOrWhiteSpace(apellidos))
                condiciones.Add("apellidos LIKE '%" + apellidos + "%'");

            if (!string.IsNullOrWhiteSpace(telefono))
                condiciones.Add("telefono LIKE '%" + telefono + "%'");

            if (!string.IsNullOrWhiteSpace(poblacion))
                condiciones.Add("poblacion LIKE '%" + poblacion + "%'");

            string whereClause = "";

            if (condiciones.Count > 0)
                whereClause = "WHERE " + string.Join(" AND ", condiciones);

            string sql = string.Format("SELECT * FROM alumnos {0} ORDER BY dni", whereClause);

            List<Alumno> lista = new List<Alumno>();

            var datos = BasedeDatos.Consulta(sql);

            if (datos != null)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    lista.Add(new Alumno(
                        fila["dni"].ToString(),
                        fila["nombre"].ToString(),
                        fila["apellidos"].ToString(),
                        fila["poblacion"].ToString(),
                        fila["telefono"].ToString()
                    ));
                }
            }

            return lista;
        }
        private Alumno ObtenerAlumno(string sql)
        {
            var resultado = BasedeDatos.Consulta(sql);

            if (resultado != null && resultado.Rows.Count > 0)
            {
                var fila = resultado.Rows[0];
                return new Alumno(
                    fila["dni"].ToString(),
                    fila["nombre"].ToString(),
                    fila["apellidos"].ToString(),
                    fila["poblacion"].ToString(),
                    fila["telefono"].ToString()
                );
            }

            return null;
        }
        private bool ExisteAlumno(string dni)
        {
            var resultado = BasedeDatos.Consulta($"SELECT 1 FROM alumnos WHERE dni = '{dni}'");
            return resultado != null && resultado.Rows.Count > 0;
        }
    }
}