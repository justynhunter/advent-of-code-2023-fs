#! dotnet fsi
open System.Text.RegularExpressions
open System.IO

let extractNumber (line:string) =
  line
  |> _.Replace("zero", "z0o")
  |> _.Replace("one", "o1e")
  |> _.Replace("two", "t2o")
  |> _.Replace("three", "t3e")
  |> _.Replace("four", "f4r")
  |> _.Replace("five", "f5e")
  |> _.Replace("six", "s6x")
  |> _.Replace("seven", "s7n")
  |> _.Replace("eight", "e8t")
  |> _.Replace("nine", "n9e")
  |> fun l -> Regex.Replace(l, @"[^\d]", "")
  |> fun l -> $"{Seq.head l}{Seq.last l}"
  |> int


File.ReadAllLines("./input.txt")
|> Seq.map extractNumber
|> Seq.sum
|> printfn "%d"
