using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ticket.FileManager;
using Ticket.Type;

namespace Ticket
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Ticket> Tickets = new List<Ticket>();

            String ticketFileName = AppDomain.CurrentDomain.BaseDirectory + "Tickets.txt";
            String EnhancementFileName = AppDomain.CurrentDomain.BaseDirectory + "Enhancements.txt";
            String TaskFileName = AppDomain.CurrentDomain.BaseDirectory + "Tasks.txt";
            String choice;
            TicketFile TicketFile = new TicketFile(ticketFileName);
            EnhancementFile enhancementFile = new EnhancementFile(EnhancementFileName);
            TaskFile taskFile = new TaskFile(TaskFileName);



         do
            {
                Console.WriteLine("\n");
                Console.WriteLine("1) Add Bug Ticket");
                Console.WriteLine("2) Display Bug Tickets");
                Console.WriteLine("3) Add Enhancement Ticket");
                Console.WriteLine("4) Display Enhancement Tickets");
                Console.WriteLine("5) Add Task Ticket");
                Console.WriteLine("6) Display Task Tickets");
                Console.WriteLine("Enter to quit");
                // input response
                choice = Console.ReadLine();

                switch(choice)
                {
                 case "1":
           
                        string input;
                        do
                        {
                            Bug BugTicket = new Bug();
                            // ask a question
                            Console.WriteLine("Enter a ticket? (Y/N)");
                            // input the response
                            input = Console.ReadLine().ToUpper();

                            // prompt for ticket summary
                            Console.WriteLine("Enter a summary: ");
                            // save ticket summary
                            BugTicket.TicketSummary = Console.ReadLine();

                            // prompt for ticket status
                            Console.WriteLine("Enter the status: ");
                            // save ticket status
                            BugTicket.TicketStatus = Console.ReadLine();

                            // prompt for priority
                            Console.WriteLine("Enter priority level: ");
                            // save priority
                            BugTicket.TicketPriority = Console.ReadLine();

                            // prompt for submitter name
                            Console.WriteLine("Enter name: ");
                            // save name
                            BugTicket.SubmittedBy = Console.ReadLine();

                            // prompt for assigned
                            Console.WriteLine("Enter name of person the ticket is assigned to: ");
                            // save assigned
                            BugTicket.AssignedTo = Console.ReadLine();

                            // prompt for watcher
                            Console.WriteLine("Enter name of person watching: ");
                            // save watcher
                            BugTicket.Watching = Console.ReadLine();


                            // prompt for severity
                            Console.WriteLine("Enter severity: ");
                            // save severity
                            BugTicket.Severity = Console.ReadLine();


                            TicketFile.AddTicket(BugTicket);

                        }
                        while (input != "N");
                        break;
                 case "2":
                        foreach (Bug b in TicketFile.BugTickets)
                        {
                            Console.WriteLine(b.Display());
                        }
                        break;
                 case "3":
                        Enhancement EnhancementTicket = new Enhancement();

                        // ask a question
                        Console.WriteLine("Enter a ticket? (Y/N)");
                        // input the response
                        input = Console.ReadLine().ToUpper();

                        // prompt for ticket summary
                        Console.WriteLine("Enter a summary: ");
                        // save ticket summary
                        EnhancementTicket.TicketSummary = Console.ReadLine();

                        // prompt for ticket status
                        Console.WriteLine("Enter the status: ");
                        // save ticket status
                        EnhancementTicket.TicketStatus = Console.ReadLine();

                        // prompt for priority
                        Console.WriteLine("Enter priority level: ");
                        // save priority
                        EnhancementTicket.TicketPriority = Console.ReadLine();

                        // prompt for submitter name
                        Console.WriteLine("Enter name: ");
                        // save name
                        EnhancementTicket.SubmittedBy = Console.ReadLine();

                        // prompt for assigned
                        Console.WriteLine("Enter name of person the ticket is assigned to: ");
                        // save assigned
                        EnhancementTicket.AssignedTo = Console.ReadLine();

                        // prompt for watcher
                        Console.WriteLine("Enter name of person watching: ");
                        // save watcher
                        EnhancementTicket.Watching = Console.ReadLine();

                        //prompt for software
                        Console.WriteLine("Enter name of software: ");
                        // save software
                        EnhancementTicket.Software = Console.ReadLine();

                        //prompt for cost
                        Console.WriteLine("Enter cost: ");
                        // save cost
                        EnhancementTicket.Cost = Console.ReadLine();

                        //prompt for reason
                        Console.WriteLine("Enter reason: ");
                        // save reason
                        EnhancementTicket.Reason = Console.ReadLine();

                        //prompt for estimate
                        Console.WriteLine("Enter estimate: ");
                        // save restimate
                        EnhancementTicket.Estimate = Console.ReadLine();


                        enhancementFile.AddTicket(EnhancementTicket);
                        break;

                 case "4":
                        foreach (Enhancement e in enhancementFile.EnhancementTickets)
                        {
                            Console.WriteLine(e.Display());
                        }
                        break;

                 case "5":
                        Task TaskTicket = new Task();

                        // ask a question
                        Console.WriteLine("Enter a ticket? (Y/N)");
                        // input the response
                        input = Console.ReadLine().ToUpper();

                        // prompt for ticket summary
                        Console.WriteLine("Enter a summary: ");
                        // save ticket summary
                        TaskTicket.TicketSummary = Console.ReadLine();

                        // prompt for ticket status
                        Console.WriteLine("Enter the status: ");
                        // save ticket status
                        TaskTicket.TicketStatus = Console.ReadLine();

                        // prompt for priority
                        Console.WriteLine("Enter priority level: ");
                        // save priority
                        TaskTicket.TicketPriority = Console.ReadLine();

                        // prompt for submitter name
                        Console.WriteLine("Enter name: ");
                        // save name
                        TaskTicket.SubmittedBy = Console.ReadLine();

                        // prompt for assigned
                        Console.WriteLine("Enter name of person the ticket is assigned to: ");
                        // save assigned
                       TaskTicket.AssignedTo = Console.ReadLine();

                        // prompt for watcher
                        Console.WriteLine("Enter name of person watching: ");
                        // save watcher
                        TaskTicket.Watching = Console.ReadLine();

                        //prompt for project name
                        Console.WriteLine("Enter name of project: ");
                        // save project name
                        TaskTicket.projectName = Console.ReadLine();

                        //prompt for Due Date
                        Console.WriteLine("Enter Due Date: ");
                        // save cost
                        TaskTicket.DueDate = Console.ReadLine();


                        taskFile.AddTicket(TaskTicket);
                        




                        break;


                 case "6":
           

                        foreach (Task t in taskFile.TaskTickets)
                        {
                            Console.WriteLine(t.Display());
                        }
                        break;
                }    





             /*   if(choice == "1")
                    if (File.Exists(file))
                    {
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split(',');
                            Console.WriteLine("Ticket ID: {0}, Summary: {1}," +
                                "Status: {2}, Priority: {3}, Submitter: {4}," +
                                "Assigned: {5}, Watching: {6}",
                                arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);


                            int readID = Convert.ToInt32(arr[0]);

                            var Ticket = new Ticket()
                            {
                                TicketID = readID,
                                TicketSummary = arr[1],
                                TicketStatus = arr[2],
                                TicketPriority = arr[3],
                                SubmittedBy = arr[4],
                                AssignedTo = arr[5],
                                Watching = arr[6]
                            };

                            Tickets.Add(Ticket);

                        }
                        sr.Close();
                    }
                
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                else if (choice == "2")
                {
                    // create file from data
                    
                    
                        // ask a question
                        Console.WriteLine("Enter a ticket? (Y/N)");
                        // input the response
                        string resp = Console.ReadLine().ToUpper();
                        // if the response is anything other than "Y", stop asking
                        if (resp != "Y") { break; }
                    //prompt for ticket ID
                    int currentID = Tickets.Max(m => m.TicketID);
                    ticketID = currentID + 1;
                        Console.WriteLine($"Creating new Ticket under Ticket ID {ticketID}");
                        // save ticket ID
                        Console.WriteLine();

                        // prompt for ticket summary
                        Console.WriteLine("Enter a summary: ");
                        // save ticket summary
                        string ticketSummary = Console.ReadLine();

                        // prompt for ticket status
                        Console.WriteLine("Enter the status: ");
                        // save ticket status
                        string ticketStatus = Console.ReadLine();

                        // prompt for priority
                        Console.WriteLine("Enter priority level: ");
                        // save priority
                        string ticketPriority = Console.ReadLine();

                        // prompt for submitter name
                        Console.WriteLine("Enter name: ");
                        // save name
                        string submittedBy = Console.ReadLine();

                        // prompt for assigned
                        Console.WriteLine("Enter name of person the ticket is assigned to: ");
                        // save assigned
                        string assignedTo = Console.ReadLine();

                        // prompt for watcher
                        Console.WriteLine("Enter name of person watching: ");
                        // save watcher
                        string watching = Console.ReadLine();


                        StreamWriter sw = new StreamWriter(file, append: true);

                        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}",
                            ticketID, ticketSummary, ticketStatus, ticketPriority, submittedBy, assignedTo, watching);


                    sw.Close();
                    



                }
                */
            }
            while (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6");
        }

  

        }
    }

