﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoGUI.GoManager.Models
{
    public enum LoggerTypes { Debug, Info, Warning, Exception, PokemonEscape, PokemonFlee, LocationUpdate, Transfer, Evolve, Incubate, Recycle, Success };

    public class Log
    {
        public LoggerTypes LoggerType { get; private set; }
        public DateTime Date { get; private set; }
        public string Message { get; private set; }
        //public Exception Exception { get; private set; }
        public string ExceptionMessage { get; private set; }

        /*
        public string ExceptionMessage
        {
            get
            {
                if(Exception == null)
                {
                    return String.Empty;

                }

                return Exception.Message;
            }
        }*/

        public Log(LoggerTypes type, string message, string exceptionMessage = null)
        {
            this.LoggerType = type;
            this.Message = message;
            this.Date = DateTime.Now;
            this.ExceptionMessage = exceptionMessage;
        }

        public Color GetLogColor()
        {
            switch (this.LoggerType)
            {
                case LoggerTypes.Exception:
                    return Color.Red;
                case LoggerTypes.Success:
                    return Color.Green;
                case LoggerTypes.Warning:
                    return Color.Yellow;
                case LoggerTypes.PokemonFlee:
                    return Color.Salmon;
                case LoggerTypes.PokemonEscape:
                    return Color.DarkGoldenrod;
                case LoggerTypes.Transfer:
                    return Color.MediumAquamarine;
                case LoggerTypes.Evolve:
                    return Color.MediumAquamarine;
                case LoggerTypes.Incubate:
                    return Color.MediumAquamarine;
                case LoggerTypes.Recycle:
                    return Color.MediumAquamarine;
                case LoggerTypes.Info:
                    return Color.Teal;
                case LoggerTypes.Debug:
                    return Color.DarkGray;
                case LoggerTypes.LocationUpdate:
                    return Color.DarkGray;
            }

            return SystemColors.WindowText;
        }
    }
}
