using System;

namespace src 
{
    class Utility{
        public void VirtualUtility(string Yfile)
        {
            string filePathg = $@"{Yfile}";
            Console.Clear();
            Console.WriteLine("Type 'sc -add' for creating a new project,\n 'sc -access' for adding the to-fo list in the project,\n 'sc --viewp' for viewing the to-do list and '/command Exit' for exiting the utility");
            Console.Write(">");
            string co = Console.ReadLine();
            if(co == "sc -add")
            {
                ProjectManager k = new ProjectManager();
                k.Manager(filePathg);
            }else if(co == "sc -access")
            {
                AccessUtlity b = new AccessUtlity();
                b.AccessProject(filePathg);
            }else if(co == "/command Exit")
            {
                Menu jmn = new Menu();
                jmn.MenuMain();
            }else if(co == "sc --viewp")
            {
                ProjectView j = new ProjectView();
                j.View(filePathg);
            }
            
        }

    }
}