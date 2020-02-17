using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ticket
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Ticket> Tickets = new List<Ticket>();

            String file = AppDomain.CurrentDomain.BaseDirectory + "Tickets.txt";
            String choice;
            int ticketID;

         do
            {
                Console.WriteLine("1.) Read data from file");
                Console.WriteLine("2.) Add data to file");
                Console.WriteLine("3.) Enter any other key to exit.");
                // input response
                choice = Console.ReadLine();

                if(choice == "1")
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
                
            } while (choice == "1" || choice == "2");
        }


        }
    }

