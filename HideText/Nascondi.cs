using System.Collections.Generic;

namespace HideText
{
    public class Nascondi
    {
        private string _originale = "";
        private string _segreto = "";
        private string _risultato = "";

        public Nascondi(string originale, string segreto)
        {
            _originale = originale;
            _segreto = segreto;
            _risultato = "";
        }

        public Nascondi(string risultato)
        {
            _originale = "";
            _segreto = "";
            _risultato = risultato;
        }

        public List<(string, string)> carattere = new List<(string, string)>
        {
            // Pensare di usare due caratteri
            ("A",  "\u034F\u034F"),
            ("B",  "\u061C\u034F"),
            ("C",  "\u200B\u034F"),
            ("D",  "\u200C\u034F"),
            ("E",  "\u200D\u034F"),
            ("F",  "\u200E\u034F"),
            ("G",  "\u200F\u034F"),
            ("H",  "\u202A\u034F"),
            ("I",  "\u202C\u034F"),
            ("J",  "\u202D\u034F"), 
            ("K",  "\uFE00\u034F"),
            ("L",  "\uFEFF\u034F"), // 
            ("M",  "\u034F\u061C"),
            ("N",  "\u061C\u061C"),
            ("O",  "\u200B\u061C"),
            ("P",  "\u200C\u061C"),
            ("Q",  "\u200D\u061C"),
            ("R",  "\u200E\u061C"),
            ("S",  "\u200F\u061C"),
            ("T",  "\u202A\u061C"), 
            ("U",  "\u202C\u061C"),
            ("V",  "\u202D\u061C"),
            ("X",  "\uFE00\u061C"),
            ("Y",  "\uFEFF\u061C"), //
            ("Z",  "\u034F\u200B"),
            ("a",  "\u061C\u200B"),
            ("b",  "\u200B\u200B"),
            ("c",  "\u200C\u200B"),
            ("d",  "\u200D\u200B"),
            ("e",  "\u200E\u200B"), 
            ("f",  "\u200F\u200B"),
            ("g",  "\u202A\u200B"),
            ("h",  "\u202C\u200B"),
            ("i",  "\u202D\u200B"),
            ("j",  "\uFE00\u200B"),
            ("k",  "\uFEFF\u200B"), //
            ("l",  "\u034F\u200C"),
            ("m",  "\u061C\u200C"),
            ("n",  "\u200B\u200C"),
            ("o",  "\u200C\u200C"), 
            ("p",  "\u200D\u200C"),
            ("q",  "\u200E\u200C"),
            ("r",  "\u200F\u200C"),
            ("s",  "\u202A\u200C"),
            ("t",  "\u202C\u200C"),
            ("u",  "\u202D\u200C"),
            ("v",  "\uFE00\u200C"),
            ("x",  "\uFEFF\u200C"), //
            ("y",  "\u034F\u200D"),
            ("z",  "\u061C\u200D"), 
            ("0",  "\u200B\u200D"),
            ("1",  "\u200C\u200D"),
            ("2",  "\u200D\u200D"),
            ("3",  "\u200E\u200D"),
            ("4",  "\u200F\u200D"),
            ("5",  "\u202A\u200D"),
            ("6",  "\u202C\u200D"),
            ("7",  "\u202D\u200D"),
            ("8",  "\uFE00\u200D"),
            ("9",  "\uFEFF\u200D"), // 
            (".",  "\u034F\u200E"),
            (",",  "\u061C\u200E"),
            (":",  "\u200B\u200E"),
            (";",  "\u200C\u200E"),
            ("-",  "\u200D\u200E"),
            ("+",  "\u200E\u200E"),
            ("=",  "\u200F\u200E"),
            ("_",  "\u202A\u200E"),
            ("@",  "\u202C\u200E"),
            ("/",  "\u202D\u200E"), 
            ("'",  "\uFE00\u200E"),
            ("!",  "\uFEFF\u200E"), //
            ("?",  "\u034F\u200F"),
            ("(",  "\u061C\u200F"),
            (")",  "\u200B\u200F"),
            ("$",  "\u200C\u200F"),
            ("€",  "\u200D\u200F"),
            ("%",  "\u200E\u200F"),
            ("^",  "\u200F\u200F"),
            ("<",  "\u202A\u200F"), 
            (">",  "\u202C\u200F"),
            ("à",  "\u202D\u200F"),
            ("è",  "\uFE00\u200F"),
            ("é",  "\uFEFF\u200F"), // 
            ("ì",  "\u034F\u202A"),
            ("ò",  "\u061C\u202A"),
            ("ù",  "\u200B\u202A"),
            ("*",  "\u200C\u202A"),
            ("£",  "\u200D\u202A"),
            ("\\", "\u200E\u202A"), 
            ("\"", "\u200F\u202A"),
            ("|",  "\u202A\u202A"),
            ("°",  "\u202C\u202A"),
            ("#",  "\u202D\u202A"),
            ("[",  "\uFE00\u202A"),
            ("]",  "\uFEFF\u202A"), // 
            ("&",  "\u034F\u202C"),
            ("À",  "\u061C\u202C"),
            ("È",  "\u200B\u202C"),
            ("É",  "\u200C\u202C"), 
            ("Ì",  "\u200D\u202C"),
            ("Ò",  "\u200E\u202C"),
            ("Ù",  "\u200F\u202C"),
            ("w",  "\u202A\u202C"),
            ("W",  "\u202C\u202C"),
            (" ",  "\u202D\u202C"),
            ("\n", "\uFE00\u202C"),
            ("\r", "\uFEFF\u202C"),
        };          

        public string[] nascosti =
        {
            "\u034F", // 00 - SEGNI INVISIBILI
            "\u061C", // 01 - SEGNI INVISIBILI
            "\u200B", // 02 - SEGNI INVISIBILI
            "\u200C", // 03 - SEGNI INVISIBILI
            "\u200D", // 04 - SEGNI INVISIBILI
            "\u200E", // 05 - SEGNI INVISIBILI
            "\u200F", // 06 - SEGNI INVISIBILI
            "\u202A", // 07 - SEGNI INVISIBILI
            "\u202C", // 08 - SEGNI INVISIBILI
            "\u202D", // 09 - SEGNI INVISIBILI
            "\uFE00", // 10 - SEGNI INVISIBILI
            "\uFEFF", // 11 - SEGNI INVISIBILI

            "\u00A0", // 01- SEGNI VISIBILI            
            "\u115F", // 02- SEGNI VISIBILI
            "\u1160", // 03- SEGNI VISIBILI            
            "\u2000", // 04- SEGNI VISIBILI
            "\u2001", // 05- SEGNI VISIBILI
            "\u2002", // 06- SEGNI VISIBILI
            "\u2003", // 07- SEGNI VISIBILI
            "\u2004", // 08- SEGNI VISIBILI
            "\u2005", // 09- SEGNI VISIBILI

            "\u2006", // 10- SEGNI VISIBILI
            "\u2007", // 11- SEGNI VISIBILI
            "\u2008", // 12- SEGNI VISIBILI
            "\u2009", // 13- SEGNI VISIBILI
            "\u200A", // 14- SEGNI VISIBILI            
            "\u202F", // 15- SEGNI VISIBILI
            "\u205F", // 16- SEGNI VISIBILI
            "\u2800", // 17- SEGNI VISIBILI
            "\u3000", // 18- SEGNI VISIBILI
            "\u3164", // 19- SEGNI VISIBILI            
        };

        public string Check()
        {
            for (int c = 0; c < _originale.Length; c++)
            {
                if (carattere.FindIndex(s => s.Item1 == _originale[c].ToString()) == -1)
                {
                    return "Original message contains illegal characters";
                }
            }

            for (int c = 0; c < _segreto.Length; c++)
            {
                if (carattere.FindIndex(s => s.Item1 == _segreto[c].ToString()) == -1)
                {
                    return "Secret message contains illegal characters";
                }
            }

            if (_originale.Length < _segreto.Length)
            {
                return "Original message is too short to hide the secret";
            } else
            {
                return "Ok";
            }            
        }

        public string Calcola()
        {
            for (int c = 0; c < _originale.Length; c++)
            {
                string orig = _originale[c].ToString();
                string segr = "";
                string risu = "";

                if (c < _segreto.Length)
                {
                    segr = _segreto[c].ToString();
                    risu = carattere.Find(s => s.Item1 == segr).Item2;
                }
                else
                {
                    risu = "";
                }

                _risultato += $"{orig}{risu}";
            }

            return _risultato;
        }

        public (string, string) Estrai()
        {
            for (int c = 0; c < _risultato.Length - 1; c++)
            {
                string risu1 = _risultato[c].ToString();
                string risu2 = _risultato[c + 1].ToString();

                if (carattere.FindIndex(s => s.Item2 == (risu1 + risu2)) != -1)
                {
                    _segreto += carattere.Find(s => s.Item2 == (risu1 + risu2)).Item1;
                }
                else
                {
                    if (carattere.FindIndex(s => s.Item1 == risu1) != -1)
                    {
                        _originale += risu1;
                    }
                }
            }
      
            return (_originale, _segreto);
        }
    }
}
