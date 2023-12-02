#! dotnet fsi
open System.Text.RegularExpressions
open System.IO

File.ReadAllLines("./input.txt")
|> Seq.map (fun l -> Regex.Replace(l, @"[^\d]", ""))
|> Seq.map (fun l -> $"{Seq.head l}{Seq.last l}")
|> Seq.map int
|> Seq.sum
|> printfn "%d"
