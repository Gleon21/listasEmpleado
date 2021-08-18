using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lista.Dao
{
    public class PersonaRepository
    {
        public List<ClsPersona> ObtenerPersona()
        {
            return new List<ClsPersona>()
            {

                new ClsPersona(){
                Id =1,
                Nombre="Gersson"
                },
                 new ClsPersona(){
                   Id=2,
                   Nombre="Jenny"
                 },
                 new ClsPersona(){
                   Id=2,
                   Nombre="vanessa"
                 }




            };




        }
    }

    public class ClsPersona
    {
        public int Id { get; internal set; }
        public string Nombre { get; internal set; }
    }
}