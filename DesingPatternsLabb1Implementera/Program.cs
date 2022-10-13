using DesingPatternsLabb1Implementera.Factory;
using DesingPatternsLabb1Implementera.Handlers;
using DesingPatternsLabb1Implementera.Observer;
using System.Dynamic;

namespace DesingPatternsLabb1Implementera
{
    public class Program
    {
        // Design Patterns used in this program:
        // Observer
        // Factory
        // Singleton
        private static string Option = "option";

        static void Main(string[] args)
        {
            var PoliceOfficer = "policeOfficer";
            var unitId = 0;
            var unit1 = new UnitManager("Nearby Units");
            var unit2 = new UnitManager("Dispatcher");
            var provider = new UnitHandler();
            List<UnitManager> unitManagers = new List<UnitManager>();
            unitManagers.Add(unit1);
            unitManagers.Add(unit2);

            // Factory
            IUnit policeUnits = UnitFactory.GetUnit("Police Units");
            IUnit medics = UnitFactory.GetUnit("Medics");
            IUnit allUnits = UnitFactory.GetUnit("All Units");
            IUnit k9Unit = UnitFactory.GetUnit("K-9 Unit");
            IUnit airSupport = UnitFactory.GetUnit("Air Support");
            IUnit swat = UnitFactory.GetUnit("S.W.A.T-Team");

            Menu loginMenu = new Menu();

            LoginMenu();

            // Login Menu.. First menu where you choose an officer to use in the app, uses singleton
            void LoginMenu()
            {
                string prompt = "Choose Officer for Squad Car #666";
                string[] options =
                {
                    "╟── Cpl.Chris Munson",
                    "╟── PO.Jason Voorhees",
                    "╟── Exit"
                };
                
                loginMenu.SetIndex(prompt, options);
                int selectedIndex = loginMenu.Run();

                // Police Officers assigned using Singleton
                switch (selectedIndex)
                {
                    case 0:
                        loginMenu.Indexo(0);
                        PoliceOfficer = PoliceOfficers.GetInstance().GetOfficer("Cpl. Chris Munson");
                        MainMenu();
                        break;
                    case 1:
                        loginMenu.Indexo(0);
                        PoliceOfficer = PoliceOfficers.GetInstance().GetOfficer("PO. Jason Voorhees");
                        MainMenu();
                        break;
                    case 2:
                        ExitApp();
                        break;
                }
            }

            // Main Menu
            void MainMenu()
            {
                string prompt = $"Main Menu - {PoliceOfficer} - Squad Car #666";
                string[] options =
                {
                    "╟── Write Ticket",
                    "╟── Send an APB out",
                    "╟── Request Backup to My Location",
                    "╟── Change Officer",
                    "╟── Exit"
                };

                loginMenu.SetIndex(prompt, options);
                int selectedIndex = loginMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        loginMenu.Indexo(0);
                        WriteTicketMenu();
                        break;
                    case 1:
                        loginMenu.Indexo(1);
                        APBMenu();
                        break;
                    case 2:
                        loginMenu.Indexo(2);
                        BackupMenu();
                        break;
                    case 3:
                        loginMenu.Indexo(0);
                        LoginMenu();
                        break;
                    case 4:
                        ExitApp();
                        break;
                }
            }

            // Write Ticket Menu
            void WriteTicketMenu()
            {
                string prompt = $"Ticket Menu - {PoliceOfficer} - Squad Car #666";
                string[] options =
                {
                    "╟─┐ Write Ticket",
                    "║ ├── Speeding Ticket",
                    "║ └── Littering Ticket",
                    "╟── Send an APB out",
                    "╟── Request Backup to My Location",
                    "╟── Change Officer",
                    "╟── Exit"
                };
                
                loginMenu.SetIndex(prompt, options);
                int selectedIndex = loginMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        loginMenu.Indexo(0);
                        MainMenu();
                        break;
                    case 1:
                        loginMenu.Indexo(1);
                        Option = Options.GetInstance().GetOption("Speeding Ticket");
                        SpeedingTicket();
                        break;
                    case 2:
                        loginMenu.Indexo(2);
                        Option = Options.GetInstance().GetOption("Littering Ticket");
                        LitteringTicket();
                        break;
                    case 3:
                        loginMenu.Indexo(1);
                        APBMenu();
                        break;
                    case 4:
                        loginMenu.Indexo(2);
                        BackupMenu();
                        break;
                    case 5:
                        loginMenu.Indexo(0);
                        LoginMenu();
                        break;
                    case 6:
                        ExitApp();
                        break;
                }
            }

            // Create a Speeding Ticket
            void SpeedingTicket()
            {
                Console.Clear();
                string prompt = $"{Option} - {PoliceOfficer} - Squad Car #666";
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                    Police Buddie 2.0 - LAPD                     ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════╣");
                Console.WriteLine($"║ {prompt,-63} ║");
                Console.WriteLine("║                                                                 ║");
                Console.WriteLine("║ Name:                                                           ║");
                Console.WriteLine("║ Email:                                                          ║");
                Console.WriteLine("║ Registration Nr:                                                ║");
                Console.WriteLine("║ Speeding Violation:                                             ║");
                Console.WriteLine("║ Amount: $                                                       ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(8, 5);
                string input1 = $"Name: {Console.ReadLine()}";
                Console.SetCursorPosition(9, 6);
                string input2 = $"Email: {Console.ReadLine()}";
                Console.SetCursorPosition(19, 7);
                string input3 = $"Registration Nr: {Console.ReadLine()}";
                Console.SetCursorPosition(22, 8);
                string input4 = $"Speeding Violation: {Console.ReadLine()}";
                Console.SetCursorPosition(11, 9);
                string input5 = $"Amount: $: {Convert.ToInt32(Console.ReadLine())}";
                TicketReceipt(input1, input2, input3, input4, input5);
            }

            // Create a Littering Ticket
            void LitteringTicket()
            {
                Console.Clear();
                string prompt = $"{Option} - {PoliceOfficer} - Squad Car #666";
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                    Police Buddie 2.0 - LAPD                     ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════╣");
                Console.WriteLine($"║ {prompt,-63} ║");
                Console.WriteLine("║                                                                 ║");
                Console.WriteLine("║ Name:                                                           ║");
                Console.WriteLine("║ Email:                                                          ║");
                Console.WriteLine("║ Amount: $                                                       ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(8, 5);
                string input1 = $"Name: {Console.ReadLine()}";
                Console.SetCursorPosition(9, 6);
                string input2 = $"Email: {Console.ReadLine()}";
                Console.SetCursorPosition(11, 7);
                string input3 = $"Amount: $: {Convert.ToInt32(Console.ReadLine())}";
                TicketReceipt(input1, input2, input3);
            }

            // Receipt For Tickets
            void TicketReceipt(string input1, string input2, string input3, string input4 = "", string input5 = "")
            {
                Console.Clear();
                string prompt = $"{Option} - {PoliceOfficer} - Squad Car #666";
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                    Police Buddie 2.0 - LAPD                     ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════╣");
                Console.WriteLine($"║ {prompt, -63} ║");
                Console.WriteLine("║                                                                 ║");
                Console.WriteLine($"║ Ticket created: {DateTime.Now,-47} ║");
                Console.WriteLine("║                                                                 ║");
                Console.WriteLine($"║ {input1,-63} ║");
                Console.WriteLine($"║ {input2,-63} ║");
                if (input3 != "")
                {
                    Console.WriteLine($"║ {input3,-63} ║");
                }
                if (input4 != "")
                {
                    Console.WriteLine($"║ {input4,-63} ║");
                }
                if (input5 != "")
                {
                    Console.WriteLine($"║ {input5,-63} ║");
                }
                Console.WriteLine("║                                                                 ║");
                Console.WriteLine("║ Ticket sent to email                                            ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
                Console.ReadKey();
                loginMenu.Indexo(0);
                MainMenu();
            }

            // APB Menu
            void APBMenu()
            {
                string prompt = $"APB Menu - {PoliceOfficer} - Squad Car #666";
                string[] options =
                {
                    "╟── Write Ticket",
                    "╟─┐ Send an APB out",
                    "║ ├── APB Suspect",
                    "║ └── APB Vehicle",
                    "╟── Request Backup to My Location",
                    "╟── Change Officer",
                    "╟── Exit"
                };
                
                loginMenu.SetIndex(prompt, options);
                int selectedIndex = loginMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        loginMenu.Indexo(0);
                        WriteTicketMenu();
                        break;
                    case 1:
                        loginMenu.Indexo(1);
                        MainMenu();
                        break;
                    case 2:
                        loginMenu.Indexo(2);
                        APBSuspectMenu();
                        break;
                    case 3:
                        loginMenu.Indexo(3);
                        APBVehicleMenu();
                        break;
                    case 4:
                        loginMenu.Indexo(2);
                        BackupMenu();
                        break;
                    case 5:
                        loginMenu.Indexo(0);
                        LoginMenu();
                        break;
                    case 6:
                        ExitApp();
                        break;
                }
            }

            // APB Suspect Menu
            void APBSuspectMenu()
            {
                string prompt = $"APB Suspect Menu - {PoliceOfficer} - Squad Car #666";
                string[] options =
                {
                    "╟── Write Ticket",
                    "╟─┐ Send an APB out",
                    "║ ├─┐ APB Suspect",
                    "║ │ ├── Nearby Units",
                    "║ │ └── Dispatcher",
                    "║ └── APB Vehicle",
                    "╟── Request Backup to My Location",
                    "╟── Change Officer",
                    "╟── Exit"
                };
                
                loginMenu.SetIndex(prompt, options);
                int selectedIndex = loginMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        loginMenu.Indexo(0);
                        WriteTicketMenu();
                        break;
                    case 1:
                        loginMenu.Indexo(1);
                        APBMenu();
                        break;
                    case 2:
                        loginMenu.Indexo(2);
                        APBMenu();
                        break;
                    case 3: // Nearby Units
                        Option = Options.GetInstance().GetOption("APB Suspect");
                        unit1.Subscribe(provider);
                        unitId = 1;
                        provider.AddUnit(new Unit($"{policeUnits.GetUnitName()}", $"{unit1}", DateTime.Now));
                        APBSuspect();
                        break;
                    case 4: // Dispatcher
                        Option = Options.GetInstance().GetOption("APB Suspect");
                        unit2.Subscribe(provider);
                        unitId = 2;
                        provider.AddUnit(new Unit($"{allUnits.GetUnitName()}", $"{unit2}", DateTime.Now));
                        APBSuspect();
                        break;
                    case 5:
                        loginMenu.Indexo(3);
                        APBVehicleMenu();
                        break;
                    case 6:
                        loginMenu.Indexo(2);
                        BackupMenu();
                        break;
                    case 7:
                        loginMenu.Indexo(0);
                        LoginMenu();
                        break;
                    case 8:
                        ExitApp();
                        break;
                }
            }

            // Create APB Suspect
            void APBSuspect()
            {
                Console.Clear();
                string prompt = $"{Option} - {PoliceOfficer} - Squad Car #666";
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                    Police Buddie 2.0 - LAPD                     ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════╣");
                Console.WriteLine($"║ {prompt,-63} ║");
                BroadCast();
                Console.WriteLine("║                                                                 ║");
                Console.WriteLine("║ Name:                                                           ║");
                Console.WriteLine("║ Gender:                                                         ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(8, 6);
                string input1 = $"Name: {Console.ReadLine()}";
                Console.SetCursorPosition(10, 7);
                string input2 = $"Gender: {Console.ReadLine()}";
                APBReceipt(input1, input2);
            }

            // APB Vehicle Menu
            void APBVehicleMenu()
            {
                string prompt = $"APB Vehicle Menu - {PoliceOfficer} - Squad Car #666";
                string[] options =
                {
                    "╟── Write Ticket",
                    "╟─┐ Send an APB out",
                    "║ ├── APB Suspect",
                    "║ └─┐ APB Vehicle",
                    "║   ├── Nearby Units",
                    "║   └── Dispatcher",
                    "╟── Request Backup to My Location",
                    "╟── Change Officer",
                    "╟── Exit"
                };
                
                loginMenu.SetIndex(prompt, options);
                int selectedIndex = loginMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        loginMenu.Indexo(0);
                        WriteTicketMenu();
                        break;
                    case 1:
                        loginMenu.Indexo(1);
                        MainMenu();
                        break;
                    case 2:
                        loginMenu.Indexo(2);
                        APBSuspectMenu();
                        break;
                    case 3:
                        loginMenu.Indexo(3);
                        APBMenu();
                        break;
                    case 4: // Nearby Units
                        Option = Options.GetInstance().GetOption("APB Vehicle");
                        unit1.Subscribe(provider);
                        unitId = 1;
                        provider.AddUnit(new Unit($"{policeUnits.GetUnitName()}", $"{unit1}", DateTime.Now));
                        APBVehicle();
                        break;
                    case 5: // Dispatcher
                        Option = Options.GetInstance().GetOption("APB Vehicle");
                        unit2.Subscribe(provider);
                        unitId = 2;
                        provider.AddUnit(new Unit($"{allUnits.GetUnitName()}", $"{unit2}", DateTime.Now));
                        APBVehicle();
                        break;
                    case 6:
                        loginMenu.Indexo(2);
                        BackupMenu();
                        break;
                    case 7:
                        loginMenu.Indexo(0);
                        LoginMenu();
                        break;
                    case 8:
                        ExitApp();
                        break;
                }
            }

            // Create APB Vehicle 
            void APBVehicle()
            {
                Console.Clear();
                string prompt = $"{Option} - {PoliceOfficer} - Squad Car #666";
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                    Police Buddie 2.0 - LAPD                     ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════╣");
                Console.WriteLine($"║ {prompt,-63} ║");
                BroadCast();
                Console.WriteLine("║                                                                 ║");
                Console.WriteLine("║ Brand:                                                          ║");
                Console.WriteLine("║ Color:                                                          ║");
                Console.WriteLine("║ Registration Nr:                                                ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(9, 6);
                string input1 = $"Brand: {Console.ReadLine()}";
                Console.SetCursorPosition(9, 7);
                string input2 = $"Color: {Console.ReadLine()}";
                Console.SetCursorPosition(19, 8);
                string input3 = $"Registration Nr: {Console.ReadLine()}";
                APBReceipt(input1, input2, input3);
            }

            // Receipt For APB
            void APBReceipt(string input1, string input2, string input3 = "")
            {
                Console.Clear();
                string prompt = $"{Option} - {PoliceOfficer} - Squad Car #666";
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                    Police Buddie 2.0 - LAPD                     ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════╣");
                Console.WriteLine($"║ {prompt,-63} ║");
                Console.WriteLine("║                                                                 ║");
                Message();
                Console.WriteLine("║                                                                 ║");
                Console.WriteLine("║ Description                                                    ║");
                Console.WriteLine($"║ {input1, -63} ║");
                Console.WriteLine($"║ {input2, -63} ║");
                if (input3 != "")
                {
                    Console.WriteLine($"║ {input3,-63} ║");
                }
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
                Console.ReadKey();
                
                if (unitId == 1)
                {
                    unit1.Unsubscribe();
                }
                else if (unitId == 2)
                {
                    unit2.Unsubscribe();
                }
                
                provider.ClearUnits();
                loginMenu.Indexo(0);
                MainMenu();
            }


            // Backup Menu
            void BackupMenu()
            {
                string prompt = $"Backup Menu - {PoliceOfficer} - Squad Car #666";
                string[] options =
                {
                    "╟── Write Ticket",
                    "╟── Send an APB out",
                    "╟─┐ Request Backup to My Location",
                    "║ ├── Shots Fired",
                    "║ ├── K-9 Unit",
                    "║ ├── Air Support",
                    "║ └── S.W.A.T-Team",
                    "╟── Change Officer",
                    "╟── Exit"
                };
                
                loginMenu.SetIndex(prompt, options);
                int selectedIndex = loginMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        loginMenu.Indexo(0);
                        WriteTicketMenu();
                        break;
                    case 1:
                        loginMenu.Indexo(1);
                        APBMenu();
                        break;
                    case 2:
                        loginMenu.Indexo(2);
                        MainMenu();
                        break;
                    case 3:
                        loginMenu.Indexo(3);
                        Option = Options.GetInstance().GetOption("Shots Fired");
                        ShotsFiredMenu();
                        break;
                    case 4:
                        loginMenu.Indexo(4);
                        Option = Options.GetInstance().GetOption("K-9 Unit");
                        K9UnitMenu();
                        break;
                    case 5:
                        Option = Options.GetInstance().GetOption("Air Support");
                        provider.AddUnit(new Unit($"{airSupport.GetUnitName()}", $"{unit2}", DateTime.Now));
                        unit2.Subscribe(provider);
                        unitId = 2;
                        BackupReceipt();
                        break;
                    case 6:
                        Option = Options.GetInstance().GetOption("S.W.A.T-Team");
                        provider.AddUnit(new Unit($"{swat.GetUnitName()}", $"{unit2}", DateTime.Now));
                        unit2.Subscribe(provider);
                        unitId = 2;
                        BackupReceipt();
                        break;
                    case 7:
                        loginMenu.Indexo(0);
                        LoginMenu();
                        break;
                    case 8:
                        ExitApp();
                        break;
                }
            }

            // Shots Fired Menu
            void ShotsFiredMenu()
            {
                string prompt = $"{Option} - {PoliceOfficer} - Squad Car #666";
                string[] options =
                {
                    "╟── Write Ticket",
                    "╟── Send an APB out",
                    "╟─┐ Request Backup to My Location",
                    "║ ├─┐ Shots Fired",
                    "║ │ ├── Nearby Units",
                    "║ │ ├── Medic",
                    "║ │ └── Dispatcher",
                    "║ ├── K-9 Unit",
                    "║ ├── Air Support",
                    "║ └── S.W.A.T-Team",
                    "╟── Change Officer",
                    "╟── Exit"
                };

                loginMenu.SetIndex(prompt, options);
                int selectedIndex = loginMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        loginMenu.Indexo(0);
                        WriteTicketMenu();
                        break;
                    case 1:
                        loginMenu.Indexo(1);
                        APBMenu();
                        break;
                    case 2:
                        loginMenu.Indexo(2);
                        MainMenu();
                        break;
                    case 3:
                        loginMenu.Indexo(3);
                        BackupMenu();
                        break;
                    case 4: // Nearby Units
                        Option = Options.GetInstance().GetOption("Shots Fired");
                        provider.AddUnit(new Unit($"{policeUnits.GetUnitName()}", $"{unit1}", DateTime.Now));
                        unit1.Subscribe(provider);
                        unitId = 1;
                        BackupReceipt();
                        break;
                    case 5: // Medic
                        Option = Options.GetInstance().GetOption("Shots Fired");
                        provider.AddUnit(new Unit($"{medics.GetUnitName()}", $"{unit2}", DateTime.Now));
                        unit2.Subscribe(provider);
                        unitId = 2;
                        BackupReceipt();
                        break;
                    case 6: // Dispatcher
                        Option = Options.GetInstance().GetOption("Shots Fired");
                        provider.AddUnit(new Unit($"{allUnits.GetUnitName()}", $"{unit2}", DateTime.Now));
                        unit2.Subscribe(provider);
                        unitId = 2;
                        BackupReceipt();
                        break;
                    case 7:
                        loginMenu.Indexo(4);
                        K9UnitMenu();
                        break;
                    case 8:
                        Option = Options.GetInstance().GetOption("Air Support");
                        provider.AddUnit(new Unit($"{airSupport.GetUnitName()}", $"{unit2}", DateTime.Now));
                        unit2.Subscribe(provider);
                        unitId = 2;
                        BackupReceipt();
                        break;
                    case 9:
                        Option = Options.GetInstance().GetOption("S.W.A.T-Team");
                        provider.AddUnit(new Unit($"{swat.GetUnitName()}", $"{unit2}", DateTime.Now));
                        unit2.Subscribe(provider);
                        unitId = 2;
                        BackupReceipt();
                        break;
                    case 10:
                        loginMenu.Indexo(0);
                        LoginMenu();
                        break;
                    case 11:
                        ExitApp();
                        break;
                }
            }

            // K-9 Unit Menu
            void K9UnitMenu()
            {
                string prompt = $"{Option} - {PoliceOfficer} - Squad Car #666";
                string[] options =
                {
                    "╟── Write Ticket",
                    "╟── Send an APB out",
                    "╟─┐ Request Backup to My Location",
                    "║ ├── Shots Fired",
                    "║ ├─┐ K-9 Unit",
                    "║ │ ├── Nearby Units",
                    "║ │ └── Dispatcher",
                    "║ ├── Air Support",
                    "║ └── S.W.A.T-Team",
                    "╟── Change Officer",
                    "╟── Exit"
                };

                loginMenu.SetIndex(prompt, options);
                int selectedIndex = loginMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        loginMenu.Indexo(0);
                        WriteTicketMenu();
                        break;
                    case 1:
                        loginMenu.Indexo(1);
                        APBMenu();
                        break;
                    case 2:
                        loginMenu.Indexo(2);
                        MainMenu();
                        break;
                    case 3:
                        loginMenu.Indexo(3);
                        ShotsFiredMenu();
                        break;
                    case 4:
                        loginMenu.Indexo(4);
                        BackupMenu();
                        break;
                    case 5: // Nearby Units
                        Option = Options.GetInstance().GetOption("K-9 Unit");
                        provider.AddUnit(new Unit($"{k9Unit.GetUnitName()}", $"{unit2}", DateTime.Now));
                        unit1.Subscribe(provider);
                        unitId = 1;
                        BackupReceipt();
                        break;
                    case 6: // Dispatcher
                        Option = Options.GetInstance().GetOption("K-9 Unit");
                        provider.AddUnit(new Unit($"{k9Unit.GetUnitName()}", $"{unit2}", DateTime.Now));
                        unit2.Subscribe(provider);
                        unitId = 2;
                        BackupReceipt();
                        break;
                    case 7:
                        Option = Options.GetInstance().GetOption("Air Support");
                        provider.AddUnit(new Unit($"{airSupport.GetUnitName()}", $"{unit2}", DateTime.Now));
                        unit2.Subscribe(provider);
                        unitId = 2;
                        BackupReceipt();
                        break;
                    case 8:
                        Option = Options.GetInstance().GetOption("S.W.A.T-Team");
                        provider.AddUnit(new Unit($"{swat.GetUnitName()}", $"{unit2}", DateTime.Now));
                        unit2.Subscribe(provider);
                        unitId = 2;
                        BackupReceipt();
                        break;
                    case 9:
                        loginMenu.Indexo(0);
                        LoginMenu();
                        break;
                    case 10:
                        ExitApp();
                        break;
                }
            }
            
            // Receipt For Backup
            void BackupReceipt()
            {
                Console.Clear();
                string prompt = $"{Option} - {PoliceOfficer} - Squad Car #666";
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                    Police Buddie 2.0 - LAPD                     ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════╣");
                Console.WriteLine($"║ {prompt,-63} ║");
                Console.WriteLine("║                                                                 ║");
                Message();
                Console.WriteLine("║                                                                 ║");
                Console.WriteLine($"║ Backup will arrive shortly                                      ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
                Console.ReadKey();

                if (unitId == 1)
                {
                    unit1.Unsubscribe();
                }
                else if (unitId == 2)
                {
                    unit2.Unsubscribe();
                }

                provider.ClearUnits();
                loginMenu.Indexo(0);
                MainMenu();
            }

            // Exits the program
            void ExitApp()
            {
                Console.Clear();
                Environment.Exit(0);
            }

            // Where to broadcast while creating a new APB
            void BroadCast()
            {
                foreach (var unit in unitManagers)
                {
                    unit.BroadCastTo();
                }
            }
            
            // Broadcasting what units that's requested
            void Message()
            {
                foreach (var unit in unitManagers)
                {
                    unit.ListUnits();
                }
            }
            
            Console.ReadKey();
        }
    }
}