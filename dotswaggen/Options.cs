﻿using System.Net.Cache;
using CommandLine;
using CommandLine.Text;

namespace dotswaggen
{
    public class Options 
    {
        [Option('s', "swagger", Required = true,
            HelpText = "Input files to be processed.")]
        public string InputFile { get; set; }

        [Option('n', "namespace", Required = true,
            HelpText = "The namespace to use for generated code")]
        public string Namespace { get; set; }

        [Option('o', "output", Required = true,
            HelpText = "The folder to output rendered code to")]
        public string OutputFolder { get; set; }

        [Option("t-prefix", Required = false,
            HelpText = "Prefix the template filename for each template type")]
        public string TemapltePrefix { get; set; }

        [Option("o-prefix", Required = false,
            HelpText = "Prefix the output filename for each file generated")]
        public string OutputPrefix { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            var help = new HelpText
            {
                Heading = new HeadingInfo("DotSwagGen", "0.0.1"),
                AdditionalNewLineAfterOption = true,
                AddDashesToOption = true
            };
            // help.AddPreOptionsLine("<>");
            help.AddPreOptionsLine("Usage: dotswaggen -s <filename.json> -n test.namespace -o <directory>");
            help.AddOptions(this);
            return help;
        }
    }
}