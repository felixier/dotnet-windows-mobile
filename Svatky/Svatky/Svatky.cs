#region Using directives

using System;
using System.Text;

#endregion

namespace Svatky
{
    /// <summary>
    /// Summary description for Svatky.
    /// </summary>
    public class Svatky
    {
        private static string[] den = new string[7];
        private static string[] mesic = new string[12];
        private static string[] svatky = new string[1232];

        static Svatky()
        {
            for(int i = 0; i < 1232; i++)
            {
                svatky[i] = "";
            }
            den[0] = "ned�le";
            den[1] = "pond�l�";
            den[2] = "�ter�";
            den[3] = "st�eda";
            den[4] = "�tvrtek";
            den[5] = "p�tek";
            den[6] = "sobota";
            mesic[0] = "ledna";
            mesic[1] = "�nora";
            mesic[2] = "b�ezna";
            mesic[3] = "dubna";
            mesic[4] = "kv�tna";
            mesic[5] = "�ervna";
            mesic[6] = "�ervence";
            mesic[7] = "srpna";
            mesic[8] = "z���";
            mesic[9] = "��jna";
            mesic[10] = "listopadu";
            mesic[11] = "prosince";
            svatky[1231] = "Silvestr";
            svatky[1230] = "David";
            svatky[1229] = "Judita";
            svatky[1228] = "Bohumila";
            svatky[1227] = "�aneta";
            svatky[1226] = "�t�p�n";
            svatky[1225] = "1. sv�tek v�no�n�";
            svatky[1224] = "Adam, Eva";
            svatky[1223] = "Vlasta";
            svatky[1222] = "�imon";
            svatky[1221] = "Nat�lie";
            svatky[1220] = "Dagmar";
            svatky[1219] = "Ester";
            svatky[1218] = "Miloslav";
            svatky[1217] = "Daniel, Dan";
            svatky[1216] = "Alb�na";
            svatky[1215] = "Radana";
            svatky[1214] = "L�die, Livie";
            svatky[1213] = "Lucie";
            svatky[1212] = "Simona";
            svatky[1211] = "Dana";
            svatky[1210] = "Julie, Liana";
            svatky[1209] = "Vratislav-a";
            svatky[1208] = "Kv�toslava";
            svatky[1207] = "Benjam�n";
            svatky[1206] = "Mikul�";
            svatky[1205] = "Jitka";
            svatky[1204] = "Barbora";
            svatky[1203] = "Svatoslav";
            svatky[1202] = "Blanka";
            svatky[1201] = "Iva";
            svatky[1130] = "Ond�ej";
            svatky[1129] = "Zina";
            svatky[1128] = "Ren�";
            svatky[1127] = "X�nie, Oxana";
            svatky[1126] = "Artur";
            svatky[1125] = "Kate�ina";
            svatky[1124] = "Em�lie";
            svatky[1123] = "Klement";
            svatky[1122] = "Cec�lie";
            svatky[1121] = "Albert";
            svatky[1120] = "Nikola";
            svatky[1119] = "Al�b�ta";
            svatky[1118] = "Romana";
            svatky[1117] = "Mahulena";
            svatky[1116] = "Otmar";
            svatky[1115] = "Leopold";
            svatky[1114] = "S�va";
            svatky[1113] = "Tibor";
            svatky[1112] = "Benedikt";
            svatky[1111] = "Martin";
            svatky[1110] = "Ev�en";
            svatky[1109] = "Bohdan";
            svatky[1108] = "Bohum�r-a";
            svatky[1107] = "Saskie";
            svatky[1106] = "Lib�na";
            svatky[1105] = "Miriam";
            svatky[1104] = "Karel";
            svatky[1103] = "Hubert";
            svatky[1102] = "Pam�tka zesnul�ch";
            svatky[1101] = "Felix";
            svatky[1031] = "�t�p�nka";
            svatky[1030] = "Tade�";
            svatky[1029] = "Silvie, Sylva";
            svatky[1028] = "St�tn� sv�tek - Den vzniku samostatn�ho �eskoslovensk�ho st�tu";
            svatky[1027] = "�arlota, Sabrina";
            svatky[1026] = "Erik";
            svatky[1025] = "Be�ta";
            svatky[1024] = "Nina";
            svatky[1023] = "Teodor";
            svatky[1022] = "Sabina";
            svatky[1021] = "Brigita, Ur�ula";
            svatky[1020] = "Vendel�n";
            svatky[1019] = "Michaela";
            svatky[1018] = "Luk�";
            svatky[1017] = "Hedvika";
            svatky[1016] = "Havel";
            svatky[1015] = "Tereza";
            svatky[1014] = "Ag�ta";
            svatky[1013] = "Ren�ta, Edvard";
            svatky[1012] = "Marcel";
            svatky[1011] = "Andrej";
            svatky[1010] = "Marina";
            svatky[1009] = "�tefan, S�ra";
            svatky[1008] = "V�ra, V�roslava";
            svatky[1007] = "Just�na, Sergej";
            svatky[1006] = "Hanu�";
            svatky[1005] = "Eli�ka";
            svatky[1004] = "Franti�ek";
            svatky[1003] = "Bohumil";
            svatky[1002] = "Ol�vie, Oliver";
            svatky[1001] = "Igor";
            svatky[930] = "Jeron�m";
            svatky[929] = "Michal";
            svatky[928] = "V�clav";
            svatky[927] = "Jon�";
            svatky[926] = "Andrea";
            svatky[925] = "Zlata";
            svatky[924] = "Jarom�r-a";
            svatky[923] = "Berta";
            svatky[922] = "Darina";
            svatky[921] = "Matou�";
            svatky[920] = "Oleg";
            svatky[919] = "Zita";
            svatky[918] = "Kry�tof";
            svatky[917] = "Nad�da";
            svatky[916] = "Ludmila, Lola";
            svatky[915] = "Jolana";
            svatky[914] = "Radka, Radoslava";
            svatky[913] = "Lubor";
            svatky[912] = "Marie, M�ja";
            svatky[911] = "Denisa, Denis";
            svatky[910] = "Irma";
            svatky[909] = "Daniela";
            svatky[908] = "Mariana";
            svatky[907] = "Reg�na";
            svatky[906] = "Boleslav";
            svatky[905] = "Boris, Larisa";
            svatky[904] = "Jindri�ka";
            svatky[903] = "Bronislav-a";
            svatky[902] = "Ad�la";
            svatky[901] = "Linda, Samuel";
            svatky[831] = "Pavl�na";
            svatky[830] = "Vlad�na";
            svatky[829] = "Evel�na";
            svatky[828] = "August�n";
            svatky[827] = "Otakar";
            svatky[826] = "Lud�k, Lu�ka";
            svatky[825] = "Radim";
            svatky[824] = "Bartolom�j";
            svatky[823] = "Sandra";
            svatky[822] = "Bohuslav";
            svatky[821] = "Johana";
            svatky[820] = "Bernard";
            svatky[819] = "Ludv�k, Ludvika";
            svatky[818] = "Helena";
            svatky[817] = "Petra";
            svatky[816] = "J�chym, Abrah�m";
            svatky[815] = "Hana";
            svatky[814] = "Alan";
            svatky[813] = "Alena";
            svatky[812] = "Kl�ra";
            svatky[811] = "Zuzana";
            svatky[810] = "Vav�inec";
            svatky[809] = "Roman";
            svatky[808] = "Sob�slav-a";
            svatky[807] = "Lada";
            svatky[806] = "Old�i�ka";
            svatky[805] = "Kristi�n";
            svatky[804] = "Dominik-a";
            svatky[803] = "Milu�e";
            svatky[802] = "Gustav";
            svatky[801] = "Oskar";
            svatky[731] = "Ign�c";
            svatky[730] = "Bo�ivoj";
            svatky[729] = "Marta";
            svatky[728] = "Viktor";
            svatky[727] = "V�roslav";
            svatky[726] = "Anna";
            svatky[725] = "Jakub";
            svatky[724] = "Krist�na";
            svatky[723] = "Libor";
            svatky[722] = "Magdal�na, Magda";
            svatky[721] = "V�t�zslav-a";
            svatky[720] = "Ilja";
            svatky[719] = "�en�k";
            svatky[718] = "Drahom�r-a";
            svatky[717] = "Martina";
            svatky[716] = "Lubo�";
            svatky[715] = "Jind�ich";
            svatky[714] = "Karol�na, Karla";
            svatky[713] = "Mark�ta";
            svatky[712] = "Bo�ek";
            svatky[711] = "Olga";
            svatky[710] = "Libu�e";
            svatky[709] = "Drahoslava";
            svatky[708] = "Nora";
            svatky[707] = "Bohuslava";
            svatky[706] = "St�tn� sv�tek - Den up�len� Mistra Jana Husa";
            svatky[705] = "St�tn� sv�tek - Cyril a Metod�j";
            svatky[704] = "Prokop";
            svatky[703] = "Radom�r-a";
            svatky[702] = "Patricie";
            svatky[701] = "Jaroslava";
            svatky[630] = "��rka";
            svatky[629] = "Petr, Pavel";
            svatky[628] = "Lubom�r-a";
            svatky[627] = "Ladislav-a";
            svatky[626] = "Adriana";
            svatky[625] = "Ivan";
            svatky[624] = "Jan";
            svatky[623] = "Zde�ka";
            svatky[622] = "Pavla";
            svatky[621] = "Alois";
            svatky[620] = "Kv�ta";
            svatky[619] = "Leo�, Alfr�d";
            svatky[618] = "Milan, Sedrik";
            svatky[617] = "Adolf, Adina";
            svatky[616] = "Zbyn�k";
            svatky[615] = "V�t";
            svatky[614] = "Roland";
            svatky[613] = "Anton�n, Antal";
            svatky[612] = "Antonie, Iz�k";
            svatky[611] = "Bruno";
            svatky[610] = "Gita";
            svatky[609] = "Stanislava, Morgan";
            svatky[608] = "Medard";
            svatky[607] = "Iveta";
            svatky[606] = "Norbert";
            svatky[605] = "Dobroslav-a, Dobrom�r-a";
            svatky[604] = "Dalibor";
            svatky[603] = "Tamara, Le�ek";
            svatky[602] = "Jarmil";
            svatky[601] = "Laura";
            svatky[531] = "Kamila";
            svatky[530] = "Ferdinand";
            svatky[529] = "Maxmili�n, Maxim";
            svatky[528] = "Vil�m";
            svatky[527] = "Valdemar";
            svatky[526] = "Filip";
            svatky[525] = "Viola";
            svatky[524] = "Jana";
            svatky[523] = "Vladim�r-a";
            svatky[522] = "Emil, Rita";
            svatky[521] = "Monika";
            svatky[520] = "Zby�ek";
            svatky[519] = "Ivo";
            svatky[518] = "Nata�a";
            svatky[517] = "Aneta";
            svatky[516] = "P�emysl";
            svatky[515] = "�ofie";
            svatky[514] = "Bonif�c";
            svatky[513] = "Serv�c";
            svatky[512] = "Pankr�c";
            svatky[511] = "Svatava, Miranda";
            svatky[510] = "Bla�ena";
            svatky[509] = "Ctibor";
            svatky[508] = "St�tn� sv�tek - Den osvobozen�";
            svatky[507] = "Stanislav";
            svatky[506] = "Radoslav";
            svatky[505] = "Klaudie";
            svatky[504] = "Kv�toslav";
            svatky[503] = "Alexej";
            svatky[502] = "Zikmund";
            svatky[501] = "St�tn� sv�tek - Sv�tek pr�ce";
            svatky[430] = "Blahoslav";
            svatky[429] = "Robert";
            svatky[428] = "Vlastislav-a";
            svatky[427] = "Jaroslav";
            svatky[426] = "Oto";
            svatky[425] = "Marek";
            svatky[424] = "Ji��, Debora";
            svatky[423] = "Vojt�ch";
            svatky[422] = "Ev�enie";
            svatky[421] = "Alexandra, Saskia";
            svatky[420] = "Marcela";
            svatky[419] = "Rostislav-a";
            svatky[418] = "Val�rie";
            svatky[417] = "Rudolf";
            svatky[416] = "Irena";
            svatky[415] = "Anast�zie";
            svatky[414] = "Vincenc";
            svatky[413] = "Ale�";
            svatky[412] = "Julius, Juli�n";
            svatky[411] = "Izabela";
            svatky[410] = "Darja";
            svatky[409] = "Du�an";
            svatky[408] = "Ema";
            svatky[407] = "He�man";
            svatky[406] = "Vendula";
            svatky[405] = "Miroslava";
            svatky[404] = "Ivana";
            svatky[403] = "Richard";
            svatky[402] = "Erika";
            svatky[401] = "Hugo";
            svatky[331] = "Kv�do";
            svatky[330] = "Arno�t";
            svatky[329] = "Ta\u0165�na, T��a";
            svatky[328] = "So�a";
            svatky[327] = "Dita";
            svatky[326] = "Emanuel-a";
            svatky[325] = "Mari�n";
            svatky[324] = "Gabriel, Zbyslav";
            svatky[323] = "Ivona, Adrian";
            svatky[322] = "Leona, Leont�na";
            svatky[321] = "Radek";
            svatky[320] = "Sv�tlana";
            svatky[319] = "Josef";
            svatky[318] = "Eduard";
            svatky[317] = "Vlastimil-a";
            svatky[316] = "Elena";
            svatky[315] = "Ida";
            svatky[314] = "Matylda";
            svatky[313] = "R��ena, Roz�lie";
            svatky[312] = "\u0158eho�";
            svatky[311] = "And�la, Angelika";
            svatky[310] = "Viktorie, Melisa";
            svatky[309] = "Franti�ka, Rebeka";
            svatky[308] = "Gabriela";
            svatky[307] = "Tom�";
            svatky[306] = "Miroslav";
            svatky[305] = "Kazim�r-a";
            svatky[304] = "Stela";
            svatky[303] = "Kamil";
            svatky[302] = "Ane�ka";
            svatky[301] = "Bed�ich, Elvis";
            svatky[229] = "Horym�r-a";
            svatky[228] = "Lum�r-a";
            svatky[227] = "Alexandr";
            svatky[226] = "Dorota";
            svatky[225] = "Liliana";
            svatky[224] = "Mat�j";
            svatky[223] = "Svatopluk";
            svatky[222] = "Petr";
            svatky[221] = "Lenka, Eleonora";
            svatky[220] = "Old�ich";
            svatky[219] = "Patrik";
            svatky[218] = "Gizela";
            svatky[217] = "Miloslava";
            svatky[216] = "Ljuba";
            svatky[215] = "Ji�ina";
            svatky[214] = "Valent�n-a";
            svatky[213] = "V�nceslav-a";
            svatky[212] = "Slav�na, Sl�vka";
            svatky[211] = "Bo�ena";
            svatky[210] = "Mojm�r";
            svatky[209] = "Apolena";
            svatky[208] = "Milada, Aranka";
            svatky[207] = "Veronika";
            svatky[206] = "Vanda";
            svatky[205] = "Dobromila";
            svatky[204] = "Jarmila";
            svatky[203] = "Bla�ej";
            svatky[202] = "Nela";
            svatky[201] = "Hynek";
            svatky[131] = "Marika";
            svatky[130] = "Robin";
            svatky[129] = "Zdislav-a";
            svatky[128] = "Ot�lie, Alfons";
            svatky[127] = "Ingrid";
            svatky[126] = "Zora, Zoran";
            svatky[125] = "Milo�";
            svatky[124] = "Milena, Amanda";
            svatky[123] = "Zden�k";
            svatky[122] = "Slavom�r-a, Sl�vek";
            svatky[121] = "B�la";
            svatky[120] = "Ilona, Sebasti�n";
            svatky[119] = "Doubravka";
            svatky[118] = "Vladislav-a";
            svatky[117] = "Drahoslav";
            svatky[116] = "Ctirad";
            svatky[115] = "Alice";
            svatky[114] = "Radovan";
            svatky[113] = "Edita";
            svatky[112] = "Pravoslav-a";
            svatky[111] = "Bohdana";
            svatky[110] = "B�etislav-a";
            svatky[109] = "Vladan-a, Valtr";
            svatky[108] = "�estm�r-a, Erhard";
            svatky[107] = "Vilma, Nikita";
            svatky[106] = "T�i kr�lov�";
            svatky[105] = "Dalimil-a";
            svatky[104] = "Diana, Blahoslava";
            svatky[103] = "Radmila";
            svatky[102] = "Karina";
            svatky[101] = "Nov� rok";
        }

        public static DateTime DenDnes
        {
            get { return DateTime.Today; }
        }

        public static DateTime DenZitra
        {
            get { return DateTime.Today.AddDays(1); }
        }

        public static DateTime DenPozitri
        {
            get { return DateTime.Today.AddDays(2); }
        }

        public static DateTime DenPoPozitri
        {
            get { return DateTime.Today.AddDays(3); }
        }

        public static string Svatek(DateTime date)
        {
            return svatky[Index(date)];
        }

        public static string NazevDne(DateTime date)
        {
            return den[(int)date.DayOfWeek];
        }

        public static string NazevMesice(DateTime date)
        {
            return mesic[date.Month - 1];
        }

        private static int Index(DateTime date)
        {
            return date.Month * 100 + date.Day;
        }

        public static bool HledaniPodleJmena(string jmeno, out string nalezeneJmeno, out DateTime nalezeneDatum) {
            jmeno = jmeno.ToLower();
            for(int i = 101; i < svatky.Length; i++)
            {
                if(svatky[i].ToLower() == jmeno)
                {
                    nalezeneJmeno = svatky[i];
                    nalezeneDatum = new DateTime(DateTime.Today.Year, i / 100, i % 100);
                    return true;
                }
            }
            for(int i = 101; i < svatky.Length; i++)
            {
                if(svatky[i].ToLower().IndexOf(jmeno) > -1)
                {
                    nalezeneJmeno = svatky[i];
                    nalezeneDatum = new DateTime(DateTime.Today.Year, i / 100, i % 100);
                    return true;
                }
            }
            nalezeneJmeno = null;
            nalezeneDatum = DateTime.Today;
            return false;
        }

        public static string HledaniPodleData(int den, int mesic)
        {
            return svatky[100 * mesic + den];
        }
    }
}