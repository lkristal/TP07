using System;

namespace TP7.Models
{
    public class Jugador
    {
        private int _IdJugador;
        private DateTime _FechaHora;
        private string _Nombre;
        private int _PozoGanado;
        private bool _ComodinDobleChance;
        private bool _Comodin50;
        private bool _ComodinSaltear;

        public Jugador()
        {}

        public Jugador(int pIdJugador, DateTime pFechaHora, string pNombre, int pPozoGanado, bool pComodinDobleChance, bool pComodin50, bool pComodinSaltear)
        {
            _IdJugador=pIdJugador;
            _FechaHora=pFechaHora;
            _Nombre= pNombre;
            _PozoGanado = pPozoGanado;
            _Comodin50 = pComodin50;
            _ComodinDobleChance = pComodinDobleChance;
            _ComodinSaltear = pComodinSaltear;
        }

        public int IdJugador { get{ return _IdJugador;} set{ _IdJugador = value;}}
        public DateTime FechaHora { get{ return _FechaHora;} set{ _FechaHora = value;}}
        public string Nombre { get{ return _Nombre;} set{ _Nombre = value;}}
        public int PozoGanado { get{ return _PozoGanado;} set{ _PozoGanado = value;}}
        public bool Comodin50 { get{ return _Comodin50;} set{ _Comodin50 = value;}}
        public bool ComodinDobleChance { get{ return _ComodinDobleChance;} set{ _ComodinDobleChance = value;}}
        public bool ComodinSaltear { get{ return _ComodinSaltear;} set{ _ComodinSaltear = value;}}
    }
}
