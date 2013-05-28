ILMerge command line:
ILMerge /internalize /targetplatform:4.0 /out:Path\To\Target\Tools\Weaver.Fody.dll Path\To\Target\Weaver.Fody\bin\Debug\Weaver.Fody.dll Path\To\Target\Weaver.Fody\bin\Debug\Shared.dll

Expected Build Output:
Target.exe main module has:

```
.custom instance void [Shared]Shared.DemoAttribute::.ctor()
```

Actual Build Output:
Target.exe main module has:

```
.custom instance void [Weaver.Fody]Shared.DemoAttribute::.ctor()
```

Verified with Reflector.

Binaries are checked in as well.
