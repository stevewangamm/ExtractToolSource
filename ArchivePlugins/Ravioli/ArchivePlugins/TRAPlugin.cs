﻿namespace Ravioli.ArchivePlugins
{
    using Ravioli.PluginHelpers;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class TRAPlugin : TRFSPlugin
    {
        public override string[] DefaultDirectories
        {
            get
            {
                List<string> list = new List<string>();
                list.AddRange(SystemSearcher.Combine3264ProgramFiles("Tomb Raider - Anniversary"));
                list.Add(Path.Combine(SystemSearcher.SteamAppsCommonDirectory, "tomb raider anniversary"));
                return list.ToArray();
            }
        }

        public override string DisplayFileName
        {
            get
            {
                return "Tomb Raider: Anniversary";
            }
        }

        public override string TypeName
        {
            get
            {
                return "Tomb Raider: Anniversary";
            }
        }
    }
}

