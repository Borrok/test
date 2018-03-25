using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ASCII Text and Logos
namespace ASCIIText
{
    class ASCII
    {
        public static void TALogo()
        {
            //no resetWindow necessary (not an own screen; part of the MainScreen)
            String qm = "\"";

            String r1 = "    ______  ______  __  __   ______  ______   _____    __   __ ______   __   __   ______  __  __   ______   ______    ";
            String r2 = @"   /\__  _\/\  ___\/\_\_\_\ /\__  _\/\  __ \ /\  __-. /\ \ / //\  ___\ /\ " + qm + @"-.\ \ /\__  _\/\ \/\ \ /\  == \ /\  ___\   ";
            String r3 = @"   \/_/\ \/\ \  __\\/_/\_\/_\/_/\ \/\ \  __ \\ \ \/\ \\ \ \'/ \ \  __\ \ \ \-.  \\/_/\ \/\ \ \_\ \\ \  __< \ \  __\   ";
            String r4 = @"      \ \_\ \ \_____\/\_\/\_\  \ \_\ \ \_\ \_\\ \____- \ \__|  \ \_____\\ \_\\" + qm + @"\_\  \ \_\ \ \_____\\ \_\ \_\\ \_____\ ";
            String r5 = @"       \/_/  \/_____/\/_/\/_/   \/_/  \/_/\/_/ \/____/  \/_/    \/_____/ \/_/ \/_/   \/_/  \/_____/ \/_/ /_/ \/_____/ ";


            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, Console.CursorTop);
            Console.WriteLine(r1);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, Console.CursorTop);
            Console.WriteLine(r2);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, Console.CursorTop);
            Console.WriteLine(r3);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, Console.CursorTop);
            Console.WriteLine(r4);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, Console.CursorTop);
            Console.WriteLine(r5);

        }

        public static void StartLogo()
        {
            String r1 = " @@@@@@   @@@@@@@   @@@@@@   @@@@@@@   @@@@@@@  ";
            String r2 = "@@@@@@@   @@@@@@@  @@@@@@@@  @@@@@@@@  @@@@@@@  ";
            String r3 = "!@@         @@!    @@!  @@@  @@!  @@@    @@!    ";
            String r4 = "!@!         !@!    !@!  @!@  !@!  @!@    !@!    ";
            String r5 = "!!@@!!      @!!    @!@!@!@!  @!@!!@!     @!!    ";
            String r6 = " !!@!!!     !!!    !!!@!!!!  !!@!@!      !!!    ";
            String r7 = "     !:!    !!:    !!:  !!!  !!: :!!     !!:    ";
            String r8 = "    !:!     :!:    :!:  !:!  :!:  !:!    :!:    ";
            String r9 = ":::: ::      ::    ::   :::  ::   :::     ::    ";
            String r0 = ":: : :       :      :   : :   :   : :     :     ";

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, (Console.WindowHeight - 10) / 2); //10 is the height of the whole Start-String
            Console.WriteLine(r1);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, (Console.WindowHeight - 10) / 2 + 1);
            Console.WriteLine(r2);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, (Console.WindowHeight - 10) / 2 + 2);
            Console.WriteLine(r3);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, (Console.WindowHeight - 10) / 2 + 3);
            Console.WriteLine(r4);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, (Console.WindowHeight - 10) / 2 + 4);
            Console.WriteLine(r5);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, (Console.WindowHeight - 10) / 2 + 5);
            Console.WriteLine(r6);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, (Console.WindowHeight - 10) / 2 + 6);
            Console.WriteLine(r7);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, (Console.WindowHeight - 10) / 2 + 7);
            Console.WriteLine(r8);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, (Console.WindowHeight - 10) / 2 + 8);
            Console.WriteLine(r9);

            Console.SetCursorPosition((Console.WindowWidth - r1.Length) / 2, (Console.WindowHeight - 10) / 2 + 9);
            Console.Write(r0);

            System.Threading.Thread.Sleep(3000);

        }

        //CharacterEditLogo display
        //currently unused due to complexity issues
        /*
        public static void CharEditLogo()
        {
            Form.ResetWindow();

            //width 118
            String r01 = "  sSSs   .S_sSSs      sSSs   .S_SSSs    sdSS_SSSSSSbs    sSSs         .S S.     sSSs_sSSs     .S       S.    .S_sSSs  ";
            String r02 = " d%%SP  .SS~YS%%b    d%%SP  .SS~SSSSS   YSSS~S%SSSSSP   d%%SP        .SS SS.   d%%SP~YS%%b   .SS       SS.  .SS~YS%%b ";
            String r03 = "d%S'    S%S   `S%b  d%S'    S%S   SSSS       S%S       d%S'          S%S S%S  d%S'     `S%b  S%S       S%S  S%S   `S%b";
            String r04 = "S%S     S%S    S%S  S%S     S%S    S%S       S%S       S%S           S%S S%S  S%S       S%S  S%S       S%S  S%S    S%S";
            String r05 = "S&S     S%S    d*S  S&S     S%S SSSS%S       S&S       S&S           S%S S%S  S&S       S&S  S&S       S&S  S%S    d*S";
            String r06 = "S&S     S&S   .S*S  S&S_Ss  S&S  SSS%S       S&S       S&S_Ss         SS SS   S&S       S&S  S&S       S&S  S&S   .S*S";
            String r07 = "S&S     S&S_sdSSS   S&S~SP  S&S    S&S       S&S       S&S~SP          S S    S&S       S&S  S&S       S&S  S&S_sdSSS ";
            String r08 = "S&S     S&S~YSY%b   S&S     S&S    S&S       S&S       S&S             SSS    S&S       S&S  S&S       S&S  S&S~YSY%b ";
            String r09 = "S*b     S*S   `S%b  S*b     S*S    S&S       S*S       S*b             S*S    S*b       d*S  S*b       d*S  S*S   `S%b";
            String r10 = "S*S.    S*S    S%S  S*S.    S*S    S*S       S*S       S*S.            S*S    S*S.     .S*S  S*S.     .S*S  S*S    S%S";
            String r11 = " SSSbs  S*S    S&S   SSSbs  S*S    S*S       S*S        SSSbs          S*S     SSSbs_sdSSS    SSSbs_sdSSS   S*S    S&S";
            String r12 = "  YSSP  S*S    SSS    YSSP  SSS    S*S       S*S         YSSP          S*S      YSSP~YSSY      YSSP~YSSY    S*S    SSS";
            String r13 = "        SP                         SP        SP                        SP                                   SP        ";
            String r14 = "        Y                          Y         Y                         Y                                    Y         ";

            //width 97
            String s01 = "  sSSs   .S    S.    .S_SSSs     .S_sSSs     .S_SSSs      sSSs  sdSS_SSSSSSbs    sSSs   .S_sSSs  ";
            String s02 = " d%%SP  .SS    SS.  .SS~SSSSS   .SS~YS%%b   .SS~SSSSS    d%%SP  YSSS~S%SSSSSP   d%%SP  .SS~YS%%b ";
            String s03 = "d%S'    S%S    S%S  S%S   SSSS  S%S   `S%b  S%S   SSSS  d%S'         S%S       d%S'    S%S   `S%b";
            String s04 = "S%S     S%S    S%S  S%S    S%S  S%S    S%S  S%S    S%S  S%S          S%S       S%S     S%S    S%S";
            String s05 = "S&S     S%S SSSS%S  S%S SSSS%S  S%S    d*S  S%S SSSS%S  S&S          S&S       S&S     S%S    d*S";
            String s06 = "S&S     S&S  SSS&S  S&S  SSS%S  S&S   .S*S  S&S  SSS%S  S&S          S&S       S&S_Ss  S&S   .S*S";
            String s07 = "S&S     S&S    S&S  S&S    S&S  S&S_sdSSS   S&S    S&S  S&S          S&S       S&S~SP  S&S_sdSSS ";
            String s08 = "S&S     S&S    S&S  S&S    S&S  S&S~YSY%b   S&S    S&S  S&S          S&S       S&S     S&S~YSY%b ";
            String s09 = "S*b     S*S    S*S  S*S    S&S  S*S   `S%b  S*S    S&S  S*b          S*S       S*b     S*S   `S%b";
            String s10 = "S*S.    S*S    S*S  S*S    S*S  S*S    S%S  S*S    S*S  S*S.         S*S       S*S.    S*S    S%S";
            String s11 = " SSSbs  S*S    S*S  S*S    S*S  S*S    S&S  S*S    S*S   SSSbs       S*S        SSSbs  S*S    S&S";
            String s12 = "  YSSP  SSS    S*S  SSS    S*S  S*S    SSS  SSS    S*S    YSSP       S*S         YSSP  S*S    SSS";
            String s13 = "               SP          SP   SP                 SP                SP                SP        ";
            String s14 = "               Y           Y    Y                  Y                 Y                 Y         ";

            //total height: 28 = 14 + 14

            //upper part "Create Your"
            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2);
            Console.WriteLine(r01);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 1);
            Console.WriteLine(r02);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 2);
            Console.WriteLine(r03);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 3);
            Console.WriteLine(r04);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 4);
            Console.WriteLine(r05);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 5);
            Console.WriteLine(r06);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 6);
            Console.WriteLine(r07);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 7);
            Console.WriteLine(r08);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 8);
            Console.WriteLine(r09);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 9);
            Console.WriteLine(r10);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 10);
            Console.WriteLine(r11);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 11);
            Console.WriteLine(r12);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 12);
            Console.WriteLine(r13);

            Console.SetCursorPosition((Console.WindowWidth - 118) / 2, (Console.WindowHeight - 28) / 2 + 13);
            Console.WriteLine(r14);

            //lower part "Character"
            //remember width only 97
            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 14);
            Console.WriteLine(s01);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 15);
            Console.WriteLine(s02);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 16);
            Console.WriteLine(s03);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 17);
            Console.WriteLine(s04);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 18);
            Console.WriteLine(s05);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 19);
            Console.WriteLine(s06);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 20);
            Console.WriteLine(s07);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 21);
            Console.WriteLine(s08);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 22);
            Console.WriteLine(s09);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 23);
            Console.WriteLine(s10);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 24);
            Console.WriteLine(s11);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 25);
            Console.WriteLine(s12);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 26);
            Console.WriteLine(s13);

            Console.SetCursorPosition((Console.WindowWidth - 97) / 2, (Console.WindowHeight - 28) / 2 + 27);
            Console.WriteLine(s14);

            //System.Threading.Thread.Sleep(3000);

            //CharacterEditingScreen();
        }
        */

    }
}
