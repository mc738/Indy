// Learn more about F# at http://fsharp.org

open System
open Indy.Core

[<EntryPoint>]
let main argv =
    
    let path = "/home/max/Data/_dummy"
    let output = sprintf "/home/max/Data/_dummy_%s.artifact" (DateTime.Now.ToString("yyyyMMddHHmmss"))
    let extractPath = "/home/max/Data/_dummy_clone"
    
    let archive = Archive.Create(path, output)
    
    archive.Extract extractPath
    
    0 // return an integer exit code
