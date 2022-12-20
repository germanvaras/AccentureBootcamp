using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Transporte
    {
        public Transporte(string nombre, string modelo, string color, double peso, bool motor, bool carga, int cantPersonas, string tipo ){
            Nombre = nombre;
            Modelo = modelo;
            Color = color;
            Peso = peso;
            Motor = motor;
            Carga = carga;
            CantPersonas = cantPersonas;
            Tipo = tipo;

            }
    public string Nombre { get; set; }
    public string Modelo { get; set; }
    public string Color { get; set; }
    public double Peso { get; set; }
    public bool Motor{ get; set; }
    public bool Carga { get; set; }
    public int CantPersonas { get; set; }
    public string Tipo { get; set; }

    }
    }
    
