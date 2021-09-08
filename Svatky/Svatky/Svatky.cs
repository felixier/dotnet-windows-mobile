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
            den[0] = "nedìle";
            den[1] = "pondìlí";
            den[2] = "úterý";
            den[3] = "støeda";
            den[4] = "ètvrtek";
            den[5] = "pátek";
            den[6] = "sobota";
            mesic[0] = "ledna";
            mesic[1] = "února";
            mesic[2] = "bøezna";
            mesic[3] = "dubna";
            mesic[4] = "kvìtna";
            mesic[5] = "èervna";
            mesic[6] = "èervence";
            mesic[7] = "srpna";
            mesic[8] = "záøí";
            mesic[9] = "øíjna";
            mesic[10] = "listopadu";
            mesic[11] = "prosince";
            svatky[1231] = "Silvestr";
            svatky[1230] = "David";
            svatky[1229] = "Judita";
            svatky[1228] = "Bohumila";
            svatky[1227] = "Žaneta";
            svatky[1226] = "Štìpán";
            svatky[1225] = "1. svátek vánoèní";
            svatky[1224] = "Adam, Eva";
            svatky[1223] = "Vlasta";
            svatky[1222] = "Šimon";
            svatky[1221] = "Natálie";
            svatky[1220] = "Dagmar";
            svatky[1219] = "Ester";
            svatky[1218] = "Miloslav";
            svatky[1217] = "Daniel, Dan";
            svatky[1216] = "Albína";
            svatky[1215] = "Radana";
            svatky[1214] = "Lýdie, Livie";
            svatky[1213] = "Lucie";
            svatky[1212] = "Simona";
            svatky[1211] = "Dana";
            svatky[1210] = "Julie, Liana";
            svatky[1209] = "Vratislav-a";
            svatky[1208] = "Kvìtoslava";
            svatky[1207] = "Benjamín";
            svatky[1206] = "Mikuláš";
            svatky[1205] = "Jitka";
            svatky[1204] = "Barbora";
            svatky[1203] = "Svatoslav";
            svatky[1202] = "Blanka";
            svatky[1201] = "Iva";
            svatky[1130] = "Ondøej";
            svatky[1129] = "Zina";
            svatky[1128] = "René";
            svatky[1127] = "Xénie, Oxana";
            svatky[1126] = "Artur";
            svatky[1125] = "Kateøina";
            svatky[1124] = "Emílie";
            svatky[1123] = "Klement";
            svatky[1122] = "Cecílie";
            svatky[1121] = "Albert";
            svatky[1120] = "Nikola";
            svatky[1119] = "Alžbìta";
            svatky[1118] = "Romana";
            svatky[1117] = "Mahulena";
            svatky[1116] = "Otmar";
            svatky[1115] = "Leopold";
            svatky[1114] = "Sáva";
            svatky[1113] = "Tibor";
            svatky[1112] = "Benedikt";
            svatky[1111] = "Martin";
            svatky[1110] = "Evžen";
            svatky[1109] = "Bohdan";
            svatky[1108] = "Bohumír-a";
            svatky[1107] = "Saskie";
            svatky[1106] = "Libìna";
            svatky[1105] = "Miriam";
            svatky[1104] = "Karel";
            svatky[1103] = "Hubert";
            svatky[1102] = "Památka zesnulých";
            svatky[1101] = "Felix";
            svatky[1031] = "Štìpánka";
            svatky[1030] = "Tadeáš";
            svatky[1029] = "Silvie, Sylva";
            svatky[1028] = "Státní svátek - Den vzniku samostatného èeskoslovenského státu";
            svatky[1027] = "Šarlota, Sabrina";
            svatky[1026] = "Erik";
            svatky[1025] = "Beáta";
            svatky[1024] = "Nina";
            svatky[1023] = "Teodor";
            svatky[1022] = "Sabina";
            svatky[1021] = "Brigita, Uršula";
            svatky[1020] = "Vendelín";
            svatky[1019] = "Michaela";
            svatky[1018] = "Lukáš";
            svatky[1017] = "Hedvika";
            svatky[1016] = "Havel";
            svatky[1015] = "Tereza";
            svatky[1014] = "Agáta";
            svatky[1013] = "Renáta, Edvard";
            svatky[1012] = "Marcel";
            svatky[1011] = "Andrej";
            svatky[1010] = "Marina";
            svatky[1009] = "Štefan, Sára";
            svatky[1008] = "Vìra, Vìroslava";
            svatky[1007] = "Justýna, Sergej";
            svatky[1006] = "Hanuš";
            svatky[1005] = "Eliška";
            svatky[1004] = "František";
            svatky[1003] = "Bohumil";
            svatky[1002] = "Olívie, Oliver";
            svatky[1001] = "Igor";
            svatky[930] = "Jeroným";
            svatky[929] = "Michal";
            svatky[928] = "Václav";
            svatky[927] = "Jonáš";
            svatky[926] = "Andrea";
            svatky[925] = "Zlata";
            svatky[924] = "Jaromír-a";
            svatky[923] = "Berta";
            svatky[922] = "Darina";
            svatky[921] = "Matouš";
            svatky[920] = "Oleg";
            svatky[919] = "Zita";
            svatky[918] = "Kryštof";
            svatky[917] = "Nadìžda";
            svatky[916] = "Ludmila, Lola";
            svatky[915] = "Jolana";
            svatky[914] = "Radka, Radoslava";
            svatky[913] = "Lubor";
            svatky[912] = "Marie, Mája";
            svatky[911] = "Denisa, Denis";
            svatky[910] = "Irma";
            svatky[909] = "Daniela";
            svatky[908] = "Mariana";
            svatky[907] = "Regína";
            svatky[906] = "Boleslav";
            svatky[905] = "Boris, Larisa";
            svatky[904] = "Jindriška";
            svatky[903] = "Bronislav-a";
            svatky[902] = "Adéla";
            svatky[901] = "Linda, Samuel";
            svatky[831] = "Pavlína";
            svatky[830] = "Vladìna";
            svatky[829] = "Evelína";
            svatky[828] = "Augustýn";
            svatky[827] = "Otakar";
            svatky[826] = "Ludìk, Luïka";
            svatky[825] = "Radim";
            svatky[824] = "Bartolomìj";
            svatky[823] = "Sandra";
            svatky[822] = "Bohuslav";
            svatky[821] = "Johana";
            svatky[820] = "Bernard";
            svatky[819] = "Ludvík, Ludvika";
            svatky[818] = "Helena";
            svatky[817] = "Petra";
            svatky[816] = "Jáchym, Abrahám";
            svatky[815] = "Hana";
            svatky[814] = "Alan";
            svatky[813] = "Alena";
            svatky[812] = "Klára";
            svatky[811] = "Zuzana";
            svatky[810] = "Vavøinec";
            svatky[809] = "Roman";
            svatky[808] = "Sobìslav-a";
            svatky[807] = "Lada";
            svatky[806] = "Oldøiška";
            svatky[805] = "Kristián";
            svatky[804] = "Dominik-a";
            svatky[803] = "Miluše";
            svatky[802] = "Gustav";
            svatky[801] = "Oskar";
            svatky[731] = "Ignác";
            svatky[730] = "Boøivoj";
            svatky[729] = "Marta";
            svatky[728] = "Viktor";
            svatky[727] = "Vìroslav";
            svatky[726] = "Anna";
            svatky[725] = "Jakub";
            svatky[724] = "Kristýna";
            svatky[723] = "Libor";
            svatky[722] = "Magdaléna, Magda";
            svatky[721] = "Vítìzslav-a";
            svatky[720] = "Ilja";
            svatky[719] = "Èenìk";
            svatky[718] = "Drahomír-a";
            svatky[717] = "Martina";
            svatky[716] = "Luboš";
            svatky[715] = "Jindøich";
            svatky[714] = "Karolína, Karla";
            svatky[713] = "Markéta";
            svatky[712] = "Boøek";
            svatky[711] = "Olga";
            svatky[710] = "Libuše";
            svatky[709] = "Drahoslava";
            svatky[708] = "Nora";
            svatky[707] = "Bohuslava";
            svatky[706] = "Státní svátek - Den upálení Mistra Jana Husa";
            svatky[705] = "Státní svátek - Cyril a Metodìj";
            svatky[704] = "Prokop";
            svatky[703] = "Radomír-a";
            svatky[702] = "Patricie";
            svatky[701] = "Jaroslava";
            svatky[630] = "Šárka";
            svatky[629] = "Petr, Pavel";
            svatky[628] = "Lubomír-a";
            svatky[627] = "Ladislav-a";
            svatky[626] = "Adriana";
            svatky[625] = "Ivan";
            svatky[624] = "Jan";
            svatky[623] = "Zdeòka";
            svatky[622] = "Pavla";
            svatky[621] = "Alois";
            svatky[620] = "Kvìta";
            svatky[619] = "Leoš, Alfréd";
            svatky[618] = "Milan, Sedrik";
            svatky[617] = "Adolf, Adina";
            svatky[616] = "Zbynìk";
            svatky[615] = "Vít";
            svatky[614] = "Roland";
            svatky[613] = "Antonín, Antal";
            svatky[612] = "Antonie, Izák";
            svatky[611] = "Bruno";
            svatky[610] = "Gita";
            svatky[609] = "Stanislava, Morgan";
            svatky[608] = "Medard";
            svatky[607] = "Iveta";
            svatky[606] = "Norbert";
            svatky[605] = "Dobroslav-a, Dobromír-a";
            svatky[604] = "Dalibor";
            svatky[603] = "Tamara, Lešek";
            svatky[602] = "Jarmil";
            svatky[601] = "Laura";
            svatky[531] = "Kamila";
            svatky[530] = "Ferdinand";
            svatky[529] = "Maxmilián, Maxim";
            svatky[528] = "Vilém";
            svatky[527] = "Valdemar";
            svatky[526] = "Filip";
            svatky[525] = "Viola";
            svatky[524] = "Jana";
            svatky[523] = "Vladimír-a";
            svatky[522] = "Emil, Rita";
            svatky[521] = "Monika";
            svatky[520] = "Zbyšek";
            svatky[519] = "Ivo";
            svatky[518] = "Nataša";
            svatky[517] = "Aneta";
            svatky[516] = "Pøemysl";
            svatky[515] = "Žofie";
            svatky[514] = "Bonifác";
            svatky[513] = "Servác";
            svatky[512] = "Pankrác";
            svatky[511] = "Svatava, Miranda";
            svatky[510] = "Blažena";
            svatky[509] = "Ctibor";
            svatky[508] = "Státní svátek - Den osvobození";
            svatky[507] = "Stanislav";
            svatky[506] = "Radoslav";
            svatky[505] = "Klaudie";
            svatky[504] = "Kvìtoslav";
            svatky[503] = "Alexej";
            svatky[502] = "Zikmund";
            svatky[501] = "Státní svátek - Svátek práce";
            svatky[430] = "Blahoslav";
            svatky[429] = "Robert";
            svatky[428] = "Vlastislav-a";
            svatky[427] = "Jaroslav";
            svatky[426] = "Oto";
            svatky[425] = "Marek";
            svatky[424] = "Jiøí, Debora";
            svatky[423] = "Vojtìch";
            svatky[422] = "Evženie";
            svatky[421] = "Alexandra, Saskia";
            svatky[420] = "Marcela";
            svatky[419] = "Rostislav-a";
            svatky[418] = "Valérie";
            svatky[417] = "Rudolf";
            svatky[416] = "Irena";
            svatky[415] = "Anastázie";
            svatky[414] = "Vincenc";
            svatky[413] = "Aleš";
            svatky[412] = "Julius, Julián";
            svatky[411] = "Izabela";
            svatky[410] = "Darja";
            svatky[409] = "Dušan";
            svatky[408] = "Ema";
            svatky[407] = "Heøman";
            svatky[406] = "Vendula";
            svatky[405] = "Miroslava";
            svatky[404] = "Ivana";
            svatky[403] = "Richard";
            svatky[402] = "Erika";
            svatky[401] = "Hugo";
            svatky[331] = "Kvído";
            svatky[330] = "Arnošt";
            svatky[329] = "Ta\u0165ána, Táòa";
            svatky[328] = "Soòa";
            svatky[327] = "Dita";
            svatky[326] = "Emanuel-a";
            svatky[325] = "Marián";
            svatky[324] = "Gabriel, Zbyslav";
            svatky[323] = "Ivona, Adrian";
            svatky[322] = "Leona, Leontýna";
            svatky[321] = "Radek";
            svatky[320] = "Svìtlana";
            svatky[319] = "Josef";
            svatky[318] = "Eduard";
            svatky[317] = "Vlastimil-a";
            svatky[316] = "Elena";
            svatky[315] = "Ida";
            svatky[314] = "Matylda";
            svatky[313] = "Rùžena, Rozálie";
            svatky[312] = "\u0158ehoø";
            svatky[311] = "Andìla, Angelika";
            svatky[310] = "Viktorie, Melisa";
            svatky[309] = "Františka, Rebeka";
            svatky[308] = "Gabriela";
            svatky[307] = "Tomáš";
            svatky[306] = "Miroslav";
            svatky[305] = "Kazimír-a";
            svatky[304] = "Stela";
            svatky[303] = "Kamil";
            svatky[302] = "Anežka";
            svatky[301] = "Bedøich, Elvis";
            svatky[229] = "Horymír-a";
            svatky[228] = "Lumír-a";
            svatky[227] = "Alexandr";
            svatky[226] = "Dorota";
            svatky[225] = "Liliana";
            svatky[224] = "Matìj";
            svatky[223] = "Svatopluk";
            svatky[222] = "Petr";
            svatky[221] = "Lenka, Eleonora";
            svatky[220] = "Oldøich";
            svatky[219] = "Patrik";
            svatky[218] = "Gizela";
            svatky[217] = "Miloslava";
            svatky[216] = "Ljuba";
            svatky[215] = "Jiøina";
            svatky[214] = "Valentýn-a";
            svatky[213] = "Vìnceslav-a";
            svatky[212] = "Slavìna, Slávka";
            svatky[211] = "Božena";
            svatky[210] = "Mojmír";
            svatky[209] = "Apolena";
            svatky[208] = "Milada, Aranka";
            svatky[207] = "Veronika";
            svatky[206] = "Vanda";
            svatky[205] = "Dobromila";
            svatky[204] = "Jarmila";
            svatky[203] = "Blažej";
            svatky[202] = "Nela";
            svatky[201] = "Hynek";
            svatky[131] = "Marika";
            svatky[130] = "Robin";
            svatky[129] = "Zdislav-a";
            svatky[128] = "Otýlie, Alfons";
            svatky[127] = "Ingrid";
            svatky[126] = "Zora, Zoran";
            svatky[125] = "Miloš";
            svatky[124] = "Milena, Amanda";
            svatky[123] = "Zdenìk";
            svatky[122] = "Slavomír-a, Slávek";
            svatky[121] = "Bìla";
            svatky[120] = "Ilona, Sebastián";
            svatky[119] = "Doubravka";
            svatky[118] = "Vladislav-a";
            svatky[117] = "Drahoslav";
            svatky[116] = "Ctirad";
            svatky[115] = "Alice";
            svatky[114] = "Radovan";
            svatky[113] = "Edita";
            svatky[112] = "Pravoslav-a";
            svatky[111] = "Bohdana";
            svatky[110] = "Bøetislav-a";
            svatky[109] = "Vladan-a, Valtr";
            svatky[108] = "Èestmír-a, Erhard";
            svatky[107] = "Vilma, Nikita";
            svatky[106] = "Tøi králové";
            svatky[105] = "Dalimil-a";
            svatky[104] = "Diana, Blahoslava";
            svatky[103] = "Radmila";
            svatky[102] = "Karina";
            svatky[101] = "Nový rok";
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