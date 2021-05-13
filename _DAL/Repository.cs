
using System;
using System.Collections.Generic;
using System.Xml;

using MLApp;
using _ENTITY;

namespace _DAL
{
    public class Repository
    {
        MLApp.MLApp Api;
        public Repository()
        {
            Api = new MLApp.MLApp();
        }

        public void Interpolar()
        {
            var Command = "2+2";
            var Answer = Api.Execute(Command);
            Console.WriteLine(Answer);
        }

        public Red GetXML(string Path)
        {
            var Red = new Red();
            var Default = @"DS.xml";
            try
            {
                using (XmlReader Reader = XmlReader.Create(Path ?? Default))
                {
                    while (Reader.Read())
                    {
                        if (Reader.IsStartElement())
                        {
                            switch (Reader.Name.ToString())
                            {
                                case "I":
                                    var Iteraciones = Reader.ReadString().Trim();
                                    if (!Int32.TryParse(Iteraciones, out _))
                                    {
                                        return null;
                                    }
                                    Red.Iteraciones = Int32.Parse(Iteraciones);
                                    break;
                                case "E":
                                    var Error = Reader.ReadString().Trim();
                                    if (!Double.TryParse(Error, out _))
                                    {
                                        return null;
                                    }
                                    Red.Error = Double.Parse(Error);
                                    break;
                                case "EO":
                                    var ErrorMax = Reader.ReadString().Trim();
                                    if (!Double.TryParse(ErrorMax, out _))
                                    {
                                        return null;
                                    }
                                    Red.ErrorOptimo = Double.Parse(ErrorMax);
                                    break;
                                case "P":
                                    var Patrones = Reader.ReadString().Trim();
                                    var Split = Patrones.Split(' ');
                                    foreach (var item in Split)
                                    {
                                        var Entradas = item.Split(';');
                                        var EntradasDouble = new List<double>();
                                        foreach (var Entrada in Entradas)
                                        {
                                            if (!Double.TryParse(Entrada, out _))
                                            {
                                                return null;
                                            }
                                            EntradasDouble.Add(Double.Parse(Entrada));
                                        }
                                        Red.Patrones.Add(new Patron(EntradasDouble));
                                    }
                                    break;
                                case "YD":
                                    var Salidas = Reader.ReadString().Trim().Split(' ');
                                    //VALIDAR QUE LAS SALIDAS CONCUERDEN CON LOS PATRONES Y EL # DE NEURONAS DE SALIDA
                                    for (int i = 0; i < Salidas.Length; i++)
                                    {
                                        var Salida = Salidas[i].Split(';');
                                        for (int j = 0; j < Salida.Length; j++)
                                        {
                                            if (!Double.TryParse(Salida[j], out _))
                                            {
                                                return null;
                                            }
                                            Red.Patrones[i].Esperado.Add(Double.Parse(Salida[j]));
                                        }
                                    }
                                    break;
                                case "D":
                                    var Distancias = Reader.ReadString().Trim().Split(' ');
                                    for (int i = 0; i < Distancias.Length; i++)
                                    {
                                        Red.Radiales.Add(new Radial());
                                        if (!Double.TryParse(Distancias[i], out _))
                                        {
                                            return null;
                                        }
                                        Red.Radiales[i].Distancia = Double.Parse(Distancias[i]);
                                    }
                                    break;
                                case "W":
                                    var Pesos = Reader.ReadString().Trim().Split(' ');
                                    for (int i = 0; i < Pesos.Length; i++)
                                    {
                                        Red.Salidas.Add(new Salida());
                                        var Peso = Pesos[i].Split(';');
                                        foreach (var _item in Peso)
                                        {
                                            if (!Double.TryParse(_item, out _))
                                            {
                                                return null;
                                            }
                                            Red.Salidas[i].Pesos.Add(new Peso(Double.Parse(_item)));
                                        }
                                    }
                                    break;
                                case "U":
                                    var Umbrales = Reader.ReadString().Trim().Split(' ');
                                    var U = 0;
                                    foreach (var item in Umbrales)
                                    {
                                        var Umbral = item.Split(';');
                                        for (int i = 0; i < Umbral.Length; i++)
                                        {
                                            if (!Double.TryParse(Umbral[i], out _))
                                            {
                                                return null;
                                            }
                                            Red.Salidas[U].Umbral.Valor = Double.Parse(Umbral[i]);
                                        }
                                    }
                                    ++U;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
            return Red;
        }

        public List<Patron> GetDS(string Path)
        {
            var Patrones = new List<Patron>();
            try
            {
                using (XmlReader Reader = XmlReader.Create(Path))
                {
                    while (Reader.Read())
                    {
                        if (Reader.IsStartElement())
                        {
                            switch (Reader.Name.ToString())
                            {
                                case "P":
                                    var _Patrones = Reader.ReadString().Trim();
                                    var Split = _Patrones.Split(' ');
                                    foreach (var item in Split)
                                    {
                                        var Entradas = item.Split(';');
                                        var EntradasDouble = new List<double>();
                                        foreach (var Entrada in Entradas)
                                        {
                                            if (!Double.TryParse(Entrada, out _))
                                            {
                                                return null;
                                            }
                                            EntradasDouble.Add(Double.Parse(Entrada));
                                        }
                                        Patrones.Add(new Patron(EntradasDouble));
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
            return Patrones;
        }

        public void PostXML(Red R, string Path)
        {
            XmlDocument doc = new XmlDocument();

            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement Red = doc.CreateElement(string.Empty, "Red", string.Empty);
            doc.AppendChild(Red);

            XmlElement Iteracion = doc.CreateElement(string.Empty, "I", string.Empty);
            Red.AppendChild(Iteracion);
            XmlText IteracionText = doc.CreateTextNode(" " + R.Iteraciones.ToString() + " ");
            Iteracion.AppendChild(IteracionText);

            XmlElement Entrenamiento = doc.CreateElement(string.Empty, "EN", string.Empty);
            Red.AppendChild(Entrenamiento);
            XmlText EntrenamientoText = doc.CreateTextNode(" " + R.Entrenamientos.ToString() + " ");
            Entrenamiento.AppendChild(EntrenamientoText);

            XmlElement Error = doc.CreateElement(string.Empty, "E", string.Empty);
            Red.AppendChild(Error);
            XmlText ErrorText = doc.CreateTextNode(" " + R.Error.ToString() + " ");
            Error.AppendChild(ErrorText);

            XmlElement ErrorMax = doc.CreateElement(string.Empty, "EO", string.Empty);
            Red.AppendChild(ErrorMax);
            XmlText ErrorMaxText = doc.CreateTextNode(" " + R.ErrorOptimo.ToString() + " ");
            ErrorMax.AppendChild(ErrorMaxText);

            XmlElement Patrones = doc.CreateElement(string.Empty, "P", string.Empty);
            var i = 0;
            foreach (var item in R.Patrones)
            {
                XmlText Patron;
                if (i == 0)
                    Patron = doc.CreateTextNode(" " + item.GetPatron());
                else
                    Patron = doc.CreateTextNode(item.GetPatron());
                Patrones.AppendChild(Patron);
                ++i;
            }
            Red.AppendChild(Patrones);

            XmlElement Salidas = doc.CreateElement(string.Empty, "YD", string.Empty);
            var SalidasMap = " ";
            R.Patrones.ForEach(P =>
            {
                P.Esperado.ForEach(S =>
                {
                    SalidasMap += $"{S};";
                });
                SalidasMap = SalidasMap.Substring(0, SalidasMap.Length - 1);
                SalidasMap += " ";
            });
            SalidasMap += " ";
            XmlText SalidaText = doc.CreateTextNode(SalidasMap);
            Salidas.AppendChild(SalidaText);
            Red.AppendChild(Salidas);

            XmlElement Pesos = doc.CreateElement(string.Empty, "W", string.Empty);
            var PesosMap = "";
            foreach (var item in R.Salidas)
            {
                foreach (var neurona in item.Pesos)
                {
                    PesosMap += $"{neurona.Valor};";
                }
                PesosMap = PesosMap.Substring(0, PesosMap.Length - 1);
                PesosMap += " ";
            }
            PesosMap = PesosMap.Substring(0, PesosMap.Length - 1);
            XmlText PesosText = doc.CreateTextNode(" " + PesosMap + " ");
            Pesos.AppendChild(PesosText);
            Red.AppendChild(Pesos);

            XmlElement Umbrales = doc.CreateElement(string.Empty, "U", string.Empty);
            var UmbralesMap = "";
            foreach (var item in R.Salidas)
            {
                UmbralesMap += $"{item.Umbral};";
            }
            PesosMap = PesosMap.Substring(0, PesosMap.Length - 1);
            XmlText UmbralesText = doc.CreateTextNode(" " + PesosMap + " ");
            Umbrales.AppendChild(PesosText);
            Red.AppendChild(Umbrales);

            var Default = @"DS.xml";
            doc.Save(Path ?? Default);
        }

    }
}
