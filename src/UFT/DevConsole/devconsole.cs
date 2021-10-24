using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace dev
{
    class DevConsole
    {
         public void MainConsole()
         {
             Console.Clear();
             Console.ForegroundColor = ConsoleColor.White;
     		 Console.WriteLine(Environment.CurrentDirectory);
             Console.WriteLine("devconsole :: Ignore debug for now, all debug messages are for when inputstream will be implemented");
             Console.WriteLine("Input :: ????");
             Console.WriteLine("InputStream Chosen : readonly-edit::");
             Console.WriteLine("Done :: Opened Console:Dev, Console:Input, Receive:Input");
             Thread.Sleep(2000);
             Console.Clear();
             Console.Write(">> ");
	     string consoleread = Console.ReadLine();
	     if(consoleread == "view @" || consoleread == "view news")
	     {
             List<string> commandslist = new List<string>();


             commandslist.Add("/c \"cat mainnews.md\"");
               var startinfo = new ProcessStartInfo();
               startinfo.WorkingDirectory = $"{Environment.CurrentDirectory}/Dashboard";
               startinfo.Arguments = commandslist[0];

               	startinfo.FileName = "powershell.exe";

                   var read = Process.Start(startinfo);

                   read.Close();

                   Console.ReadKey();
                  NonStartConsole();

	     }else if(consoleread == "::exit" || consoleread == "exit" || consoleread == "devconsole::exit")
         {
              var Mainc = new src.Main();
              Mainc.MainStart();
         }else if(consoleread == "config")
         {
               var configvar = new config.configc();
               configvar.MainConfig(true);
         }else if(consoleread == "write::input" || consoleread == "write=to=input")
         {
		 string readfirst = Console.ReadLine();
		 if(readfirst == "alter .sh --start")
     {
			 string[] a = {
			        "#!powershell.exe",

				 "echo FalconXOS-GNU/Linux Version.21.19-Falcon",
			         "dotnet run --project .."
			 };
			 File.WriteAllLines($"{Environment.CurrentDirectory}/scripts/start.sh", a);
             Environment.Exit(0);
     }
	     else
	     {
             var inputStream = new Inputstream.InputStream();
             Console.WriteLine("Console start :: dev");
             Console.WriteLine("Debug log : clean");
             Console.WriteLine("String input, only");
             Console.Write("$");
             string inputstream = Console.ReadLine();
             inputStream.InputNon(inputstream);

	     }
             Console.WriteLine("Written::to path");
             Console.WriteLine("Exiting");
             NonStartConsole();
         }else if(string.IsNullOrWhiteSpace(consoleread))
         {
             var gray = new src.Errortunnel();
             gray.CheckInfo("/", 100, "None");
             Console.Clear();
             NonStartConsole();
         }else if(consoleread == "--open in" ||consoleread == "--md=reader in")
         {
                var mdreader = new TermLibs.markdownreader();
                Console.WriteLine("Provide a filename according to FalconXOS/(default = FalconXOS/VersionOverview.md");
                Console.Write("$ ");
                string read = Console.ReadLine();
                if(read == "default")
                {
                    var fileadd = new TermLibs.fileadd();
                     fileadd.AddToString("VersionOverview.md", "None");    
                }else
                {
                     var fileadd = new TermLibs.fileadd();
                     fileadd.AddToString(read, "None");
                }
               
         }else if(consoleread == "--open exit" ||consoleread == "--md=reader exit" )
         {
              var mdreader = new TermLibs.markdownreader();
                Console.WriteLine("Provide a filename");
                Console.Write("$ ");
                string read = Console.ReadLine();
                mdreader.read(read, "None");
                
                
                     
                
         }
         else
         {
             var gray = new src.Errortunnel();
             gray.CheckInfo("/", 900, "None");
             Console.Clear();
             NonStartConsole();
         }

         }
         public void NonStartConsole()
         {
             Console.Clear();
             Console.ForegroundColor = ConsoleColor.White;
              Console.Write(">> ");
	     string consoleread = Console.ReadLine();
	     if(consoleread == "view @" || consoleread == "view news")
	     {
             List<string> commandslist = new List<string>();

             commandslist.Add("/c \"cat mainnews.md\"");
               var startinfo = new ProcessStartInfo();
               startinfo.WorkingDirectory = $"{Environment.CurrentDirectory}/Dashboard";
               startinfo.Arguments = commandslist[0];


               	startinfo.FileName = "powershell.exe";
                   var read = Process.Start(startinfo);

                   read.Close();

                   Console.ReadKey();
                   MainConsole();

	     }else if(consoleread == "::exit" || consoleread == "exit" || consoleread == "devconsole::exit")
         {
              var Mainc = new src.Main();
              Mainc.MainStart();
         }else if(consoleread == "config")
         {
               var configvar = new config.configc();
               configvar.MainConfig(true);
         }else if(consoleread == "write::input" || consoleread == "write=to=input")
         {
             var inputStream = new Inputstream.InputStream();
             Console.WriteLine("Console start :: dev");
             Console.WriteLine("Debug log : clean");
             Console.WriteLine("String input, only");
             Console.Write("$");
             string inputstream = Console.ReadLine();
             inputStream.InputNon(inputstream);
             Console.WriteLine("Written::to path");
             Console.WriteLine("Exiting");
             NonStartConsole();
         }else if(string.IsNullOrWhiteSpace(consoleread))
         {
             var gray = new src.Errortunnel();
             gray.CheckInfo("/", 100, "None");
             Console.Clear();
             NonStartConsole();
         }else if(consoleread == "--open in" ||consoleread == "--md=reader in")
         {
                var mdreader = new TermLibs.markdownreader();
                Console.WriteLine("Provide a filename according to FalconXOS/(default = FalconXOS/VersionOverview.md");
                Console.Write("$ ");
                string read = Console.ReadLine();
                if(read == "default")
                {
                    var fileadd = new TermLibs.fileadd();
                     fileadd.AddToString("VersionOverview.md", "None");    
                }else
                {
                     var fileadd = new TermLibs.fileadd();
                     fileadd.AddToString("VersionOverview.md", "None");
                }
               
         }else if(consoleread == "--open exit" ||consoleread == "--md=reader exit" )
         {
              var mdreader = new TermLibs.markdownreader();
                Console.WriteLine("Provide a filename");
                Console.Write("$ ");
                string read = Console.ReadLine();
                mdreader.read(read, "None");
                
                
                     
                
         }
         else
         {
             var gray = new src.Errortunnel();
             gray.CheckInfo("/", 900, "None");
             NonStartConsole();
         }
         }
    }
}
