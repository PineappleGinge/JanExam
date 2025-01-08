﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JanExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    //github repo https://github.com/PineappleGinge/JanExam
    public partial class MainWindow : Window
    {
        // List of objects to display
        private List<Event> events;
        private List<VIPTicket> vipticket;
        private List<Ticket> ticket;


        public MainWindow()
        {
            InitializeComponent();
        }

        // For adding all events to a list for eat display
        private List<Event> GetEventData()
        {
            Event e1 = new Event()
            {
                Name = "Oasis Croke Park",
                EventDate = new DateTime(2025, 06, 20),
                TypeOfEvent = EventType.Music
            };
            Event e2 = new Event()
            {
                Name = "Electric Picnic",
                EventDate = new DateTime(2025, 08, 20),
                TypeOfEvent = EventType.Music
            };

            return new List<Event>() { e1, e2 };

        }
        // Gets all the ticket objects adds to a list
        private List<Ticket> GetTicketData()
        {
            Ticket t1 = new Ticket() 
            { 
                Name = "Early Bird", 
                Price = 100m, 
                AvailableTickets = 100 
            };
            Ticket t2 = new Ticket()
            {
                Name = "Platinium",
                Price = 150m,
                AvailableTickets = 100
            };
            return new List<Ticket>() { t1, t2 };

        }

        // Gets the VIPticket objects and adds to a list for displaying 
        private List<VIPTicket> GetVIPTicketData()
        {
            VIPTicket vip1 = new VIPTicket() 
            {
                Name = "Ticket and Hotel Package",
                Price = 150m,
                AdditionalCost = 100m,
                AdditionalExtras = "4* hotel",
                AvailableTickets = 100
            };
            VIPTicket vip2 = new VIPTicket() 
            {
                Name = "Weekend Ticket",
                Price = 200m,
                AdditionalCost = 100m,
                AdditionalExtras = "with camping",
                AvailableTickets = 100
            };
            return new List<VIPTicket>() { vip1, vip2 };
        }

        




    }
}