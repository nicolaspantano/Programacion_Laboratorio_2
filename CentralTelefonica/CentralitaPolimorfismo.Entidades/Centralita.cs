﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaPolimorfismo.Entidades
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal { get { return CalcularGanancia(TipoLLamada.Local); } }
        public float GananciaPorProvincial { get { return CalcularGanancia(TipoLLamada.Provincial); } }
        public float GananciaTotal { get { return CalcularGanancia(TipoLLamada.Todas); } }
        public List<Llamada> Llamadas { get { return this._listaDeLlamadas; } }

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;                        
        }

        private void AgregarLLamada(Llamada nuevaLLamada)
        {
            if (!(nuevaLLamada.Equals(null)))
            {
                this._listaDeLlamadas.Add(nuevaLLamada);
            }
        }
        /// <summary>
        /// HACER
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(TipoLLamada tipo)
        {
            float retorno = 0;

            switch (tipo)
            {
                case TipoLLamada.Local:
                    foreach(Llamada actual in this._listaDeLlamadas)
                    {
                        if(actual is Local)
                        {
                            retorno += actual.CostoLLamada;
                        }
                    }
                    break;

                case TipoLLamada.Provincial:
                    foreach (Llamada actual in this._listaDeLlamadas)
                    {
                        if (actual is Provincial)
                        {
                            retorno += actual.CostoLLamada;
                        }
                    }
                    break;

                case TipoLLamada.Todas:
                    foreach (Llamada actual in this._listaDeLlamadas)
                    {                        
                            retorno += actual.CostoLLamada;                       
                    }
                    break;
            }

            return retorno;
        }

        public void OrdenarLLamadas(int tipo)
        {
            if(tipo==-1)
            {
                this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracionDesc);
            }
            else
            {
                this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracionAsc);
            }

            
            
        }

        public static bool operator ==(Centralita central,Llamada nuevaLLamada)
        {
            foreach(Llamada actual in central._listaDeLlamadas)
            {
                if (actual == nuevaLLamada)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita central,Llamada nuevaLLamada)
        {
            return !(central == nuevaLLamada);
        }

        public static Centralita operator +(Centralita central,Llamada nuevaLLamada)
        {
            if (central == nuevaLLamada)
            {
                Console.WriteLine("La llamada ya esta en la central");
            }
            else
            {
                central._listaDeLlamadas.Add(nuevaLLamada);
            }
            return central;
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            foreach(Llamada actual in this.Llamadas)
            {
                sb.Append(actual.ToString());
            }

            return sb.ToString();
        }
    }
}
