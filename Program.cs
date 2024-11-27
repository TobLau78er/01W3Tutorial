namespace _01W3Tutorial
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Übung: User welcher Zauberwort kennt kann damit die Konsolen-Schriftfarbe in rot und Konsolen-Hintegrundfarbe gelb ändern.
            //Bei Falscheingabe des Zauberwort erhält User keinen Zugriff und ein "Gesperrt"-ASCII-Kunst" wird zusätzlich zum Text "Zugriff verweigert" angezeigt.
            string zauberwort;
            zauberwort = "Bitte";
            Console.WriteLine("Bitte gib das geheime Zauberwort ein!");
            zauberwort = Console.ReadLine();
            if (zauberwort == "Bitte")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{zauberwort} ist das richtige Zauberwort. Zugriff gewährt!");
                Console.WriteLine();
                Console.WriteLine("      _.-'''''-._\r\n    .'  _     _  '.\r\n   /   (_)   (_)   \\\r\n  |  ,           ,  |\r\n  |  \\`.       .`/  |\r\n   \\  '.`'\"\"'\"`.'  /\r\n    '.  `'---'`  .'\r\njgs   '-._____.-'");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Zugriff verweigert!");
                Console.WriteLine();
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$'               `$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$  \r\n$$$$$$$$$$$$$$$$$$$$$$$$$$$$'                   `$$$$$$$$$$$$$$$$$$$$$$$$$$$$\r\n$$$'`$$$$$$$$$$$$$'`$$$$$$!                       !$$$$$$'`$$$$$$$$$$$$$'`$$$\r\n$$$$  $$$$$$$$$$$  $$$$$$$                         $$$$$$$  $$$$$$$$$$$  $$$$\r\n$$$$. `$' \\' \\$`  $$$$$$$!                         !$$$$$$$  '$/ `/ `$' .$$$$\r\n$$$$$. !\\  i  i .$$$$$$$$                           $$$$$$$$. i  i  /! .$$$$$\r\n$$$$$$   `--`--.$$$$$$$$$                           $$$$$$$$$.--'--'   $$$$$$\r\n$$$$$$L        `$$$$$^^$$                           $$^^$$$$$'        J$$$$$$\r\n$$$$$$$.   .'   \"\"~   $$$    $.                 .$  $$$   ~\"\"   `.   .$$$$$$$\r\n$$$$$$$$.  ;      .e$$$$$!    $$.             .$$  !$$$$$e,      ;  .$$$$$$$$\r\n$$$$$$$$$   `.$$$$$$$$$$$$     $$$.         .$$$   $$$$$$$$$$$$.'   $$$$$$$$$\r\n$$$$$$$$    .$$$$$$$$$$$$$!     $$`$$$$$$$$'$$    !$$$$$$$$$$$$$.    $$$$$$$$\r\n$JT&yd$     $$$$$$$$$$$$$$$$.    $    $$    $   .$$$$$$$$$$$$$$$$     $by&TL$\r\n                                 $    $$    $\r\n                                 $.   $$   .$\r\n                                 `$        $'\r\n                                  `$$$$$$$$'");
            }
        }
    }
}
