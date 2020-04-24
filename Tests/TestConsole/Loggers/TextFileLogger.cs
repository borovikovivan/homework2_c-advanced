﻿using System;
using System.IO;

namespace TestConsole.Loggers
{
    internal class TextFileLogger : Logger, ILogger, IDisposable
    {
        private readonly TextWriter _Writer;

        public TextFileLogger(string FileName)
        {
            _Writer = File.CreateText(FileName);
            ((StreamWriter) _Writer).AutoFlush = true;
        }

        private int _Counter;
        public override void Log(string Message)
        {
            _Writer.WriteLine("{0}>{1}", _Counter++, Message);
        }

        public override void Flush() { _Writer.Flush(); }

        public void Dispose()
        {
            _Writer.Dispose();
        }
    }
}