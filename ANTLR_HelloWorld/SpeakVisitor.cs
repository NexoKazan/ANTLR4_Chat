﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr;
using Antlr4;
using Antlr4.Runtime;
using static ANTLR_HelloWorld.SpeakParser;

namespace ANTLR_HelloWorld
{
    class SpeakVisitor : SpeakBaseVisitor<object>
    {
        public List<SpeakLine> Lines = new List<SpeakLine>();

        public override object VisitLine(SpeakParser.LineContext context)
        {
            NameContext name = context.name();
            OpinionContext opinion = context.opinion();

            SpeakLine line = new SpeakLine() { Person = name.GetText(), Text = opinion.GetText().Trim('"') };
            Lines.Add(line);

            return line;
        }
    }
}
