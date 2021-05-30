
using System;
using System.Collections.Generic;
using System.Xml;

using _ENTITY;

namespace _DAL
{
    public class Repository
    {
        MLApp.MLApp Api;
        
        public Repository()
        {
            Api = new MLApp.MLApp();
            //Api.MinimizeCommandWindow();
            //Api.Quit();
        }

        public Red Interpolar(Red Red)
        {
            var A = "[";
            for (int i = 0; i < Red.Patrones.Count; i++)
            {
                A += "1";
                Red.Radiales.ForEach(r =>
                {
                    A += (" " + r.Activacion[i]).Replace(',','.');
                });
                A += ";";
            }
            A = A.Remove(A.Length - 1, 1);
            A += "]";
            //Console.WriteLine(A);

            var Y = "[";
            Red.Patrones.ForEach(p =>
            {
                p.Esperado.ForEach(e =>
                {
                    Y += (e + " ").Replace(',', '.');
                });
                Y = Y.Remove(Y.Length - 1, 1);
                Y += ";";
            });
            Y = Y.Remove(Y.Length - 1, 1);
            Y += "]";
            //Console.WriteLine(Y);

            var Operation = $"Y = {Y};\n A = {A};\n A\\Y";
            //Console.WriteLine(Operation);

            var Answer = Api.Execute(Operation);
            //Api.MinimizeCommandWindow();
            //Api.Quit();
            Console.WriteLine(Answer);

            var Lines = Answer.Split('\n');
            var umbral = true;
            Red.Salidas.ForEach(s =>
            {
                s.Pesos.Clear();
            });
            for (int i = 0; i < Lines.Length; i++)
            {
                if (Lines[i] != "" && Lines[i] != "ans =")
                {
                    var Clean = Lines[i].Trim('*').Trim();
                    var NumberSplit = Clean.Split(' ');
                    var s = 0;
                    foreach (var item in NumberSplit)
                    {
                        if(item != "")
                        {
                            var number = item.Replace('.', ',');
                            if (umbral)
                            {
                                Red.Salidas[s].Umbral.Valor = Double.Parse(number);
                            }
                            else
                                Red.Salidas[s].Pesos.Add(new Peso(Double.Parse(number)));
                            //Console.WriteLine(item);
                            if (s >= (Red.Salidas.Count - 1))
                            {
                                s = 0;
                                umbral = false;
                            }
                            s++;
                        }
                    }
                }
            }

            return Red;
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
                                case "R":
                                    var Radiales = Reader.ReadString().Trim();
                                    if (!Double.TryParse(Radiales, out _))
                                    {
                                        return null;
                                    }
                                    for (int i = 0; i < Int32.Parse(Radiales); i++)
                                    {
                                        Red.Radiales.Add(new Radial());
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
                                case "V":
                                    var Valores = Reader.ReadString().Trim().Split(' ');
                                    for (int i = 0; i < Valores.Length; i++)
                                    {
                                        var Valor = Valores[i].Split(';');
                                        for (int j = 0; j < Valor.Length; j++)
                                        {
                                            if (!Double.TryParse(Valor[i], out _))
                                            {
                                                return null;
                                            }
                                            Red.Radiales[i].Valores.Add(Double.Parse(Valor[i]));
                                        }
                                    }
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
            var Patron = "";
            foreach (var item in R.Patrones)
            {
                Patron += " " + item.GetPatron();
            }
            Patron += " ";
            XmlText PatronText = doc.CreateTextNode(Patron);
            Patrones.AppendChild(PatronText);
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

            XmlElement Radiales = doc.CreateElement(string.Empty, "R", string.Empty);
            XmlText RadialesText = doc.CreateTextNode(" " + R.Radiales.Count.ToString() + " ");
            Radiales.AppendChild(RadialesText);
            Red.AppendChild(Radiales);

            XmlElement Pesos = doc.CreateElement(string.Empty, "W", string.Empty);
            var PesosMap = "";
            foreach (var item in R.Salidas)
            {
                foreach (var neurona in item.Pesos)
                {
                    PesosMap += $"{neurona.Valor};";
                }
                PesosMap = PesosMap.Remove(PesosMap.Length - 1, 1);
                PesosMap += " ";
            }
            PesosMap = PesosMap.Remove(PesosMap.Length - 1, 1);
            XmlText PesosText = doc.CreateTextNode(" " + PesosMap + " ");
            Pesos.AppendChild(PesosText);
            Red.AppendChild(Pesos);

            XmlElement Umbrales = doc.CreateElement(string.Empty, "U", string.Empty);
            var UmbralesMap = "";
            foreach (var item in R.Salidas)
            {
                UmbralesMap += $"{item.Umbral.Valor};";
            }
            UmbralesMap = UmbralesMap.Remove(UmbralesMap.Length - 1, 1);
            XmlText UmbralesText = doc.CreateTextNode(" " + UmbralesMap + " ");
            Umbrales.AppendChild(UmbralesText);
            Red.AppendChild(Umbrales);

            XmlElement Valores = doc.CreateElement(string.Empty, "V", string.Empty);
            var ValoresMap = " ";
            foreach (var item in R.Radiales)
            {
                foreach (var valor in item.Valores)
                {
                    ValoresMap += $"{valor};";
                }
                ValoresMap = ValoresMap.Remove(ValoresMap.Length - 1, 1);
                ValoresMap += " ";
            }
            XmlText ValoresText = doc.CreateTextNode(ValoresMap);
            Valores.AppendChild(ValoresText);
            Red.AppendChild(Valores);

            var Default = @"DS.xml";
            doc.Save(Path ?? Default);
        }

    }
}
