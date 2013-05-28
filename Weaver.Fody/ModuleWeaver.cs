using System;
using System.Linq;
using Mono.Cecil;

namespace Weaver.Fody
{
    public class ModuleWeaver
    {
        public ModuleDefinition ModuleDefinition { get; set; }

        public void Execute()
        {
            var demoAttributeCtor = ModuleDefinition.Import(typeof (Shared.DemoAttribute).GetConstructor(new Type[0]));
            ModuleDefinition.Types.First().CustomAttributes.Add(new CustomAttribute(demoAttributeCtor));
        }
    }
}
