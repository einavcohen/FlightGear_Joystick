﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSimulator.Model.Interface;
using FlightSimulator.ViewModels;

namespace FlightSimulator.Model
{
    public class FlightPropModel : BaseNotify
    {       
        // the path to the componants in the xml
        private string AileronPath = "set controls/flight/aileron ";
        private double aileronVal = 0;

        public double Aileron
        {
            get
            {
                return Aileron;
            }
            set
            {
                Aileron = Math.Round(value, 2);
                NotifyPropertyChanged("Aileron");
                string setAileron = AileronPath + aileronVal + " " + "\r\n";
                CommandServer.Instance.Send(setAileron);
            }
        }

        // the path to the componants in the xml
        private string rudderPath = "set controls/flight/rudder ";
        private double rudderVal = 0;

        public double Rudder
        {
            get
            {
                return Rudder;
            }

            set
            {
                Rudder = Math.Round(value, 2);
                NotifyPropertyChanged("Rudder");
                string setRudder = rudderPath + rudderVal + " " + "\r\n";
                CommandServer.Instance.Send(setRudder);
            }
        }

        // the path to the componants in the xml
        private string elevatorPath = "set controls/flight/elevator ";
        private double elevatorVal = 0;

        public double Elevator
        {
            get
            {
                return elevatorVal;
            }
            set
            {
                elevatorVal = Math.Round(value, 2);
                NotifyPropertyChanged("Elevator");
                string setElevator = elevatorPath + elevatorVal + " " + "\r\n";
                CommandServer.Instance.Send(setElevator);
            }
        }

        // the path to the componants in the xml
        private string throttlePath = "set controls/engines/current-engine/throttle ";
        private double throttleVal = 0;

        public double Throttle
        {
            get
            {
                return throttleVal;
            }
            set
            {
                throttleVal = Math.Round(value, 2);
                NotifyPropertyChanged("Throttle");
                string setThrottle = throttlePath + throttleVal + " " + "\r\n";
                CommandServer.Instance.Send(setThrottle);
            }
        }
    }
}