using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureVillageEstadisticas
{
    class ModeloCuentaUsuario
    {
        private string idUsuario;
        private int EspacioInv;
        private int Ataque;
        private int Defensa;
        private int Vida;
        private int VidaMax;
        private int Monedas;
        private int Experiencia;
        private int Energia;
        private int TiempoJugado_Mins;

        public string _idUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public int _EspacioInv { get { return EspacioInv; } set { EspacioInv = value; } }
        public int _Ataque { get { return Ataque; } set { Ataque = value; } }
        public int _Defensa { get { return Defensa; } set { Defensa = value; } }
        public int _Vida { get { return Vida; } set { Vida = value; } }
        public int _VidaMax { get { return VidaMax; } set { VidaMax = value; } }
        public int _Monedas { get { return Monedas; } set { Monedas = value; } }
        public int _Experiencia { get { return Experiencia; } set { Experiencia = value; } }
        public int _Energia { get { return Energia; } set { Energia = value; } }
        public int _TiempoJugado_Mins { get { return TiempoJugado_Mins; } set { TiempoJugado_Mins = value; } }


        public ModeloCuentaUsuario()
        {
            idUsuario = "";
            EspacioInv = 30;
            Ataque = 10;
            Defensa = 12;
            Vida = 140;
            VidaMax = 140;
            Monedas = 100;
            Experiencia = 0;
            Energia = 100;
            TiempoJugado_Mins = 0;
        }

        public ModeloCuentaUsuario(string Nuevo)
        {
            idUsuario = Nuevo;
            EspacioInv = 30;
            Ataque = 10;
            Defensa = 12;
            Vida = 140;
            VidaMax = 140;
            Monedas = 100;
            Experiencia = 0;
            Energia = 100;
            TiempoJugado_Mins = 0;
        }

        public ModeloCuentaUsuario(string idUsuario_, int EspInv, int ATK, int DEF, int HP, int HPMax, int Money, int EXP, int Energy, int Play)
        {
            idUsuario = idUsuario_;
            EspacioInv = EspInv;
            Ataque = ATK;
            Defensa = DEF;
            Vida = HP;
            VidaMax = HPMax;
            Monedas = Money;
            Experiencia = EXP;
            Energia = Energy;
            TiempoJugado_Mins = Play;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
