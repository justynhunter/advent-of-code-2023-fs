#! dotnet fsi
open System
open System.IO

let getDigits (line:string) =
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
  |> String.collect (fun c -> if Char.IsDigit(c) then c.ToString() else "" )
  |> (fun l -> $"{Seq.head l}{Seq.last l}")
  |> int


File.ReadAllLines("./input.txt")
|> Seq.map getDigits
|> Seq.sum
|> printfn "%d"
