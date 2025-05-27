using System;
using System.Collections.Generic;
using System.Data;
using Academia._02aplication;
using Academia._03data;


namespace Academia._02aplication
{
    public class GestionMatriculas
    {
        public Matricula Matricula { get; set; } = new Matricula();

        public string Error()
        {
            return BasedeDatos.Error;
        }

        public List<Matricula> GetAll()
        {
            var matriculas = new List<Matricula>();
            var datos = BasedeDatos.Consulta("SELECT dni, codigo FROM matriculas ORDER BY dni, codigo");

            if (datos != null)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    matriculas.Add(new Matricula(
                        fila["dni"].ToString(),
                        fila["codigo"].ToString()
                    ));
                }
            }

            return matriculas;
        }

        public List<Alumno> GetAllNames()
        {
            var alumnos = new List<Alumno>();
            var datos = BasedeDatos.Consulta("SELECT * FROM alumnos ORDER BY dni");

            if (datos != null)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    alumnos.Add(new Alumno(
                        fila["dni"].ToString(),
                        fila["nombre"].ToString(),
                        fila["apellidos"].ToString(),
                        fila["telefono"].ToString(),
                        fila["poblacion"].ToString()
                    ));
                }
            }

            return alumnos;
        }

        public List<Alumno> GetAlumnosPorCurso(string codigo)
        {
            var alumnos = new List<Alumno>();
            var sql = $@"
            SELECT a.dni, a.nombre, a.apellidos, a.telefono, a.poblacion
            FROM alumnos a
            JOIN matriculas m ON a.dni = m.dni
            WHERE m.codigo = '{Escapar(codigo)}'";

            Console.WriteLine(sql); 

            var datos = BasedeDatos.Consulta(sql);

            if (datos != null)
            {
                Console.WriteLine($"Filas devueltas: {datos.Rows.Count}"); 
                foreach (DataRow fila in datos.Rows)
                {
                    alumnos.Add(new Alumno(
                        fila["dni"].ToString(),
                        fila["nombre"].ToString(),
                        fila["apellidos"].ToString(),
                        fila["telefono"].ToString(),
                        fila["poblacion"].ToString()
                    ));
                }
            }

            return alumnos;
        }

        public List<Curso> GetCursosPorAlumno(string dni)
        {
            var cursos = new List<Curso>();
            var sql = $@"
                SELECT c.codigo, c.titulo, c.lugar_realizacion AS LugarRealizacion, c.n_plazas AS NumPlazas, c.precio
                FROM cursos c
                JOIN matriculas m ON c.codigo = m.codigo
                WHERE m.dni = '{dni}'";

            var datos = BasedeDatos.Consulta(sql);

            if (datos != null)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    cursos.Add(new Curso(
                        fila["codigo"].ToString(),
                        fila["titulo"].ToString(),
                        fila["LugarRealizacion"].ToString(),
                        fila["NumPlazas"].ToString(),
                        fila["precio"].ToString()
                    ));
                }
            }

            return cursos;
        }

        public int Insert()
        {
            if (ExisteMatricula(Matricula.Dni, Matricula.CodigoCurso))
                return -1;

            string sql = $@"
                INSERT INTO matriculas (dni, codigo)
                VALUES ('{Escapar(Matricula.Dni)}', '{Escapar(Matricula.CodigoCurso)}')";

            return BasedeDatos.Modificacion(sql);
        }

        public int Remove()
        {
            if (string.IsNullOrEmpty(Matricula.Dni) || string.IsNullOrEmpty(Matricula.CodigoCurso))
                return -1;

            string sql = $"DELETE FROM matriculas WHERE dni = '{Matricula.Dni}' AND codigo = '{Matricula.CodigoCurso}'";
            return BasedeDatos.Modificacion(sql);
        }

        public Matricula GetById(string dni, string codigo)
        {
            var datos = BasedeDatos.Consulta($"SELECT dni, codigo FROM matriculas WHERE dni = '{dni}' AND codigo = '{codigo}'");

            if (datos != null && datos.Rows.Count > 0)
            {
                var fila = datos.Rows[0];
                return new Matricula(
                    fila["dni"].ToString(),
                    fila["codigo"].ToString()
                );

            }

            return null;
        }

        private bool ExisteMatricula(string dni, string codigo)
        {
            var sql = $@"
                SELECT COUNT(*) AS Total
                FROM matriculas
                WHERE dni = '{Escapar(dni)}' AND codigo = '{Escapar(codigo)}'";

            var datos = BasedeDatos.Consulta(sql);

            if (datos != null && datos.Rows.Count > 0)
            {
                return int.Parse(datos.Rows[0]["Total"].ToString()) > 0;
            }

            return false;
        }

        private string Escapar(string valor)
        {
            return valor.Replace("'", "''");
        }
    }
}