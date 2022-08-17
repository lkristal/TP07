using System;

namespace TP7.Models
{
    public class Pregunta
    {
        private int _IdPregunta;
        private string _TextoPregunta;
        private int _NivelDificultad;

        public Pregunta()
        {}

        public Pregunta(int pIdPregunta, string pTextoPregunta, int pNivelDificultad)
        {
            _IdPregunta=pIdPregunta;
            _NivelDificultad= pNivelDificultad;
            _TextoPregunta = pTextoPregunta;
        }

        public int IdPregunta { get{ return _IdPregunta;} set{ _IdPregunta = value;}}
        public string TextoPregunta { get{ return _TextoPregunta;} set{ _TextoPregunta = value;}}
        public int NivelDificultad { get{ return _NivelDificultad;} set{ _NivelDificultad = value;}}

    }
}
