using System.Collections.Generic;
using Oqtane.Documentation;
using Oqtane.Models;
using Oqtane.Modules;
using Oqtane.Shared;

namespace Oqtane.Modules.ClubMembers
{
    [PrivateApi]
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "ClubMembers",
            Description = "List of club members",
            Version = "1.0.0",
            ServerManagerType = "Oqtane.Modules.ClubMembers.Manager.ClubMembersManager, Oqtane.Modules.ClubMembers",
            ReleaseVersions = "1.0.0",
            PackageName = "Oqtane.Modules.ClubMembers",
            Resources = new List<Resource>()
            {
                new Stylesheet("~/Module.css")
            }
        };
    }
}
