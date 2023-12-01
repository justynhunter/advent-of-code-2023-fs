#! dotnet fsi
open System
open System.IO

File.ReadAllLines("./input.txt")
|> Seq.map (String.collect (fun c -> if Char.IsDigit(c) then c.ToString() else "" ))
|> Seq.map (fun l -> $"{Seq.head l}{Seq.last l}")
|> Seq.map int
|> Seq.sum
|> printfn "%d"
