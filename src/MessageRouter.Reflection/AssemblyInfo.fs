﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("MessageRouter.Reflection")>]
[<assembly: AssemblyProductAttribute("MessageRouter")>]
[<assembly: AssemblyDescriptionAttribute("A CQRS (event driven) message router in F#")>]
[<assembly: AssemblyVersionAttribute("1.4.0")>]
[<assembly: AssemblyFileVersionAttribute("1.4.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.4.0"
