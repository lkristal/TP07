using System;

namespace TP7.Models
{
    public class Respuesta
    {
        private int _IdRespuesta;
        private int _IdPregunta;
        private char _OpcionRespuesta;
        private string _TextoRespuesta;
        private bool _Correcta;

        public Respuesta()
        {}

        public Respuesta(int pIdRespuesta, int pIdPregunta, char pOpcionRespuesta, string pTextoRespuesta, bool pCorrecta)
        {
            _IdPregunta=pIdPregunta;
            _IdRespuesta=pIdRespuesta;
            _OpcionRespuesta= pOpcionRespuesta;
            _TextoRespuesta = pTextoRespuesta;
            _Correcta = pCorrecta;
        }

        public int IdRespuesta { get{ return _IdRespuesta;} set{ _IdRespuesta = value;}}
        public int IdPregunta { get{ return _IdPregunta;} set{ _IdPregunta = value;}}
        public char OpcionRespuesta { get{ return _OpcionRespuesta;} set{ _OpcionRespuesta = value;}}
        public string TextoRespuesta { get{ return _TextoRespuesta;} set{ _TextoRespuesta = value;}}
        public bool Correcta { get{ return _Correcta;} set{ _Correcta = value;}}
    }
}
