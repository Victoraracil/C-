using System;
using System.Collections.Generic;
using System.Data;
using Academia._02aplication;
using Academia._03data;


namespace Academia._02aplication
{
    public class GestionCursos
    {
        public Curso Curso { get; set; }

        public GestionCursos()
        {
            Curso = new Curso();
        }

        public string Error()
        {
            return BasedeDatos.Error;
        }

        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            var datos = BasedeDatos.Consulta("SELECT codigo, titulo, lugar_realizacion, n_plazas, precio FROM cursos ORDER BY codigo");

            if (datos != null)
            {
                foreach (DataRow fila in datos.Rows)
                {
                    cursos.Add(MapearCurso(fila));
                }
            }

            return cursos;
        }

        public Curso Primero()
        {
            return BuscarCurso("SELECT codigo, titulo, lugar_realizacion, n_plazas, precio FROM cursos ORDER BY codigo ASC LIMIT 1");
        }

        public Curso Ultimo()
        {
            return BuscarCurso("SELECT codigo, titulo, lugar_realizacion, n_plazas, precio FROM cursos ORDER BY codigo DESC LIMIT 1");
        }

        public Curso Siguiente()
        {
            if (string.IsNullOrEmpty(Curso.Codigo))
                return null;

            string consulta = $"SELECT codigo, titulo, lugar_realizacion, n_plazas, precio FROM cursos WHERE codigo > '{Curso.Codigo}' ORDER BY codigo ASC LIMIT 1";
            return BuscarCurso(consulta);
        }

        public Curso Anterior()
        {
            if (string.IsNullOrEmpty(Curso.Codigo))
                return null;

            string consulta = $"SELECT codigo, titulo, lugar_realizacion, n_plazas, precio FROM cursos WHERE codigo < '{Curso.Codigo}' ORDER BY codigo DESC LIMIT 1";
            return BuscarCurso(consulta);
        }

        public Curso GetById(string codigo)
        {
            return BuscarCurso($"SELECT codigo, titulo, lugar_realizacion, n_plazas, precio FROM cursos WHERE codigo = '{codigo}'");
        }

        public int Insert()
        {
            if (ExisteCurso(Curso.Codigo))
                return -1;

            string insertSql = $@"
                INSERT INTO cursos (codigo, titulo, lugar_realizacion, n_plazas, precio) 
                VALUES ('{Curso.Codigo}', '{Curso.Titulo}', '{Curso.Lugar}', {Curso.NumPlaza}, {Curso.Precio})";

            return BasedeDatos.Modificacion(insertSql);
        }

        public int Edit()
        {
            if (!ExisteCurso(Curso.Codigo))
                return -1;

            string updateSql = $@"
                UPDATE cursos SET 
                    titulo = '{Curso.Titulo}',
                    lugar_realizacion = '{Curso.Lugar}',
                    n_plazas = {Curso.NumPlaza},
                    precio = {Curso.Precio}
                WHERE codigo = '
            {Curso.Codigo}'";

            return BasedeDatos.Modificacion(updateSql);
        }

        public int Remove()
        {
            if (string.IsNullOrEmpty(Curso.Codigo))
                return -1;

            return BasedeDatos.Modificacion($"DELETE FROM cursos WHERE codigo = '{Curso.Codigo}'");
        }

       
        private Curso BuscarCurso(string sql)
        {
            var resultado = BasedeDatos.Consulta(sql);

            if (resultado != null && resultado.Rows.Count > 0)
            {
                Console.WriteLine(resultado.Rows[0]);
                return MapearCurso(resultado.Rows[0]);
            }

            return null;
        }

        private Curso MapearCurso(DataRow fila)
        {
            Console.WriteLine("Mapeando curso:");
            Console.WriteLine($"Codigo: {fila["codigo"]}, Titulo: {fila["titulo"]}, Lugar: {fila["lugar_realizacion"]}, N_Plazas: {fila["n_plazas"]}, Precio: {fila["precio"]}");

            return new Curso(
                fila["codigo"].ToString(),
                fila["titulo"].ToString(),
                fila["lugar_realizacion"].ToString(),
                fila["n_plazas"].ToString(),
                fila["precio"].ToString()
            );
        }

        private bool ExisteCurso(string codigo)
        {
            var existe = BasedeDatos.Consulta($"SELECT 1 FROM cursos WHERE codigo = '{codigo}'");
            return existe != null && existe.Rows.Count > 0;
        }
    }
}