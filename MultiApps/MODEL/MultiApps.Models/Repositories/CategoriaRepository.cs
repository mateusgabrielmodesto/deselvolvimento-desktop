using Dapper;
using MultiApps.Models.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MultiApps.Models.Repositories
{
    public class CategoriaRepository
    {
        public string ConnectionString = "Server=localhost;Database=multapps_dev; Uid=root;Pwd=root";

        public static object ListarTodasCategorias()
        {
            throw new NotImplementedException();
        }

        public bool CadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO )";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", categoria.Nome);
                parametros.Add("@Status", categoria.Status);


                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }
        public List<Categoria> listartodasCategotia()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT * FROW Categoria";

                var parametros = new DynamicParameters();
                var resultado = db.Query<Categoria>(comandoSql).ToList();
                return resultado;
            }
        }
    }
}

