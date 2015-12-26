﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Bonus630.vsta.FacaCaixaAuto
{
    class FacaMan
    {

        private List<Type> typeCorrects;
        private IFaca objIFaca;

        public FacaMan()
        {
            typeCorrects = new List<Type>();
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in types)
            {
                if (typeof(IFaca).IsAssignableFrom(type) && !type.IsInterface)
                {
                    typeCorrects.Add(type);
                }
            }
        }
        public Dictionary<string, bool> ListaClass()
        {
            Dictionary<string, bool> lista = new Dictionary<string, bool>();
            foreach (Type type in typeCorrects)
            {
                FieldInfo fieldInfoName = type.GetField("name");
                FieldInfo fieldInfoSimetric = type.GetField("simetric");
                lista.Add(fieldInfoName.GetValue(new object()).ToString(), (bool)fieldInfoSimetric.GetValue(new object()));
            }
            return lista;
        }
        private void generateNewInstance(string nameClass, params object[] args)
        {
            foreach (Type type in typeCorrects)
            {
                if (nameClass == type.GetField("name").GetValue(new object()).ToString())
                {
                    objIFaca = Activator.CreateInstance(type, args) as IFaca;
                    break;
                }

            }
        }
        public void inicialize(string nameClass, params object[] args)
        {
            generateNewInstance(nameClass, args);
            
        }
        public string version
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
    }
}
