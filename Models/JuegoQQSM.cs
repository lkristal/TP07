using System.Security.Authentication.ExtendedProtection;
using System.Runtime.CompilerServices;
using System.Data.Common;
using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace TP7.Models
{
    public static class JuegoQQSM
    {
        private static string _connectionString = @"Server=LEOK\SQLEXPRESS; DataBase=JuegoQQSM;Trusted_Connection=True;";

        private static int _PreguntaActual;
        private static char _RespuestaCorrectaActual;
        private static int _PosicionPozo;
        private static int _PozoAcumuladoSeguro;
        private static int _PozoAcumulado;
        private static List<Pozo> _ListaPozo = new List<Pozo>();
        private static Jugador _Player;
        public static void IniciarJuego(string Nombre)
        {
            _PreguntaActual = 1;
            _RespuestaCorrectaActual=' ';
            _PosicionPozo = 0;
            _PozoAcumuladoSeguro=0;
            _PozoAcumulado =0;

            _ListaPozo = LlenarListaPozo();

           
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string SQL= "INSERT INTO Jugadores(Nombre, FechaHora, Comodin50, ComodinSaltear, ComodinDobleChance) values (@pNombre, @pFechaHora,1,1,1)";
                db.Execute(SQL, new {pNombre=Nombre, pFechaHora=DateTime.Now});
                SQL = "SELECT * FROM Jugadores ORDER BY IdJugador DESC OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY"; 
                _Player = db.QueryFirstOrDefault<Jugador>(SQL);
            }
            
        }

        private static List<Pozo> LlenarListaPozo()
        {
            List<Pozo> ListaTemp = new List<Pozo>();
            ListaTemp.Add(new Pozo(100,false));
            ListaTemp.Add(new Pozo(500,false));
            ListaTemp.Add(new Pozo(1000,false));
            ListaTemp.Add(new Pozo(2000,false));
            ListaTemp.Add(new Pozo(5000,true));
            ListaTemp.Add(new Pozo(7500,false));
            ListaTemp.Add(new Pozo(10000,false));
            ListaTemp.Add(new Pozo(20000,false));
            ListaTemp.Add(new Pozo(50000,false));
            ListaTemp.Add(new Pozo(75000,false));
            ListaTemp.Add(new Pozo(100000,true));
            ListaTemp.Add(new Pozo(200000,false));
            ListaTemp.Add(new Pozo(500000,false));
            ListaTemp.Add(new Pozo(1000000,false));
            ListaTemp.Add(new Pozo(1500000,false));
            ListaTemp.Add(new Pozo(2000000,false));
            return ListaTemp;
        }
        public static Pregunta ObtenerProximaPregunta()
        {
            Pregunta Preg = null;
            string SQL= "SELECT * FROM Preguntas WHERE IdPregunta=@pIdPregunta";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                Preg = db.QueryFirstOrDefault<Pregunta>(SQL, new {pIdPregunta=_PreguntaActual});
            }
            return Preg;

        }
    
        public static List<Respuesta> ObtenerRespuestas()
        {
            List<Respuesta> ListaRespuestas = null;
            string SQL= "SELECT * FROM Respuestas WHERE IdPregunta=@pIdPregunta";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                ListaRespuestas = db.Query<Respuesta>(SQL, new {pIdPregunta=_PreguntaActual}).ToList();
            }

            foreach(Respuesta item in ListaRespuestas)
            { 
                if (item.Correcta) _RespuestaCorrectaActual=item.OpcionRespuesta;
            }
            return ListaRespuestas;
        }

        public static bool RespuestaUsuario(char Opcion, char OpcionComodin='X')
        {
            bool Devuelve=false;
            if (OpcionComodin != 'X')
            {
                //ActualizoOpcionComodin("Doble")
            }
            if (Opcion == _RespuestaCorrectaActual || OpcionComodin== _RespuestaCorrectaActual){
                Devuelve = true;
                
                // Verifico si ya gane algo seguro e incremento la posición del pozo,
                if (_ListaPozo[_PosicionPozo].ValorSeguro == true)
                {
                    _PozoAcumuladoSeguro = _ListaPozo[_PosicionPozo].Importe;
                }
                _PozoAcumulado=_ListaPozo[_PosicionPozo].Importe;
                _PosicionPozo++;

                _PreguntaActual++;

            }
            return Devuelve;
        }

        public static List<Pozo> DevolverListaPozo()
        {
            return _ListaPozo;
        }

        public static int DevolverPosicionPozo()
        {
            return _PosicionPozo;
        }

        public static List<char> DescartarComodin50()
        {
            List<char> OpcionesDescartar = new List<char>();
            switch (_RespuestaCorrectaActual)
            {
                case 'A':
                    OpcionesDescartar.Add('B');
                    OpcionesDescartar.Add('C'); 
                    break; 
                case 'B':
                    OpcionesDescartar.Add('A');
                    OpcionesDescartar.Add('C'); 
                    break;
                case 'C':
                    OpcionesDescartar.Add('B');
                    OpcionesDescartar.Add('A'); 
                    break;
                case 'D':
                    OpcionesDescartar.Add('B');
                    OpcionesDescartar.Add('C'); 
                    break;
            }
            ActualizoOpcionComodin("Comodin50");
            return OpcionesDescartar;
        }

        private static void ActualizoOpcionComodin(string Comodin)
        {
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                string SQL= "Update Jugadores SET " + Comodin+ "=0 WHERE IdJugador=@pIdJugador";
                db.Execute(SQL, new {pIdJugador = _Player.IdJugador});
                SQL = "SELECT * FROM Jugadores ORDER BY IdJugador DESC OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY"; 
                _Player = db.QueryFirstOrDefault<Jugador>(SQL);
            }
        }
    
        public static void SaltearPregunta()
        {
            _PreguntaActual++;
        }
      
        public static Jugador DevolverJugador()
        {
            return _Player;
        }
    }
}