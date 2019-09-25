using System;

namespace Tasks
{
    public static class Task2
    {
        /// <summary>
        /// Демонстрация работы
        /// </summary>
        public static void Demo()
        {
            Console.WriteLine("Задача 2");

            Console.WriteLine(Decode(
                "eflohgcpkgjpegaapahapboajbfbdbmbhedcbekcgfbdkphdlepdgegekdnepcefhdlfiobggcjgadahd" +
                "chhmnnhncfiobmiibdjanjjcoakkmhklapkfaglkbnloldmcalmkacngpinfppnepgomknojpeplolpf" +
                "pcajojamoabonhbhjobmnfccnmcboddlikdnmbedniegmpeemgfamnfhiegghlghkchiljhglainlhih" +
                "goififjdkmjnkdkalkkmkblffilehplojgmeknmjeennjlnmicomijojiapkdhpihopaifaiimapgdbe" +
                "ikblhbcfcicegpceggdmbndmgeeoflecgcfhgjflfagkahgicogcdfhfcmhopcipekiaebjkdijeepje" +
                "dgkmomkaeelpcllpccmmcjmnnpmmbhnmboneneocbmoomcppakpnababbiadapaibgbmlmbiaecmpkcd" +
                "lbddmidnkpdnpgemonehoefaplfmocgpnjgloahfjhhdnohdofimimimndjknkjembkcnikbnpkpmglh" +
                "mnlciemlflmifcnekjnhlaoklhocgoomkfpblmpmkdakkkadfbbakibckpbmjgckincmiedcildbjcea" +
                "ijeidafbihflhofchfgbhmghhdhjhkhigbidhiinbpioggjggnjebekfflkhfclofjljeamhehmoeome" +
                "efnmplnnedoodkoidbpaphpbeppmdgaadnafcebnclbonbcacjcgcadmbhdlbodnbfebbmejmcfhakfb" +
                "bbgeaignlognpfhganhcaeifalihpbjjpijnppjkogkcknkepelpollcocmeojmknanajhnbooncnfom" +
                "mmoeidpemkpnmbajmiammpahmgbbmnbllecpllcjgcdpkjdblaeaghegloejkffmkmfgkdgbfkgcjbha" +
                "jihojphkigioinioiejmiljgicklhjkbialeihlncolkhfmjhmmdhdnlgkndgboofiomgpoiggpacnpp" +
                "aeabelamfcblejbdaacefhcfeocpdfdhpldaedekdkemdbfgdifldpffofgecngecehiclhiccincjid" +
                "npiechjmbojkmekoamkjadlfbklolamhaimbapmipfnhpmnnpdoppkooobpgkipdpppcpgagonanneba" +
                "olbcoccinjcoiadmmhdgnodjmfecimeomdfomkfnlbglligfmpgjlghllnhbleihglinkcjpkjjekakk" +
                "khkkkokckfldjmldkdmfjkmijbnejinbfpnaegoggnoaiephdlpnicaaijadiablchbphobggfcahmcd" +
                "hddmbkdkfbeegiedbpeffgffgnfofegmelgcfchefjhheaikehigeoifpejidmjoddkodkkjoallcilj" +
                "dplbcgmjcnmpceniblniccokbjonbapjbhpennpfmeacbmaladbbakbkpacjaicipocalfdapmdjpdef" +
                "pkeipbfcoifbopfpoggijngkoehfolhpicibojimnajpmhjbnojhmfknhmkomdlplkljlbmbhimklpme" +
                "lgnglnnaleofllopfcpojjpojaackhackoahkfblfmb", 7400187));
        }


        /// <summary>
        /// _xaacba899487bce8c
        /// </summary>
        /// <param name="s">x5e99b576d2530d13</param>
        /// <param name="sht">x2710752c36f2d14b</param>
        /// <returns></returns>
        private static string Decode(string s, int sht)
        {
            var usht = (ushort) sht;
            var arrch = new char[s.Length / 4];

            for (var i = 0; i < s.Length / 4; i++)
            {
                var usht1 = (ushort) ((((s[4 * i] - 'a') + ((s[(4 * i) + 1] - 'a') << '\u0004')) +
                                          ((s[(4 * i) + 2] - 'a') << '\u0008')) +
                                         ((s[(4 * i) + 3] - 'a') << '\u000c'));
                usht1 -= usht;
                arrch[i] = (char) usht1;
                usht += 1789;
            }

            return new string(arrch);
        }

        /// <summary>
        /// Эталонный декодированный код
        /// </summary>
        /// <returns></returns>
        // private static string _xaacba899487bce8c(string x5e99b576d2530d13, int x2710752c36f2d14b)
        // {
        //     ushort usht;
        //     char[] arrch;
        //     int i;
        //     ushort usht1;
        //     string str;
        //     usht = (ushort)x2710752c36f2d14b;
        //     goto ILO_007f;
        //     while (true)
        //     {
        //         i++;
        //     ILO_000c:
        //         if (i < (x5e99b576d2530d13.Length / 4))
        //         {
        //             break;
        //         }
        //         str = new string(arrch);
        //         if (!0.Equals(0))
        //         {
        //             goto ILO_008d;
        //         }
        //         return str;
        //     ILO_0027:
        //         arrch[i] = (short)usht1;
        //         usht += 1789;
        //     }
        //     usht1 = (ushort)((((x5e99b576d2530d13[4 * i] - 'a') + ((x5e99b576d2530d13[(4 * i) + 1] - 'a') << '\u0004')) + ((x5e99b576d2530d13[(4 * i) + 2] - 'a') << '\u0008')) + ((x5e99b576d2530d13[(4 * i) + 3] - 'a') << '\u000c'));
        //     usht1 -= usht;
        //     goto ILO_0027;
        //     ILO_007f:
        //         arrch = new char[x5e99b576d2530d13.Length / 4];
        //     ILO_008d:
        //         i = 0;
        //     if ((((((uint)usht)) + (((uint)usht1))) > -1))
        //     {
        //         goto ILO_008d;
        //     }
        //     goto ILO_000c;
        //     return str;
        // }

    }
}