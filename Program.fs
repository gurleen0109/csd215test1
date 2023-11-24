//For more information see https://aka.ms/fsharp-console-apps
// Records: NBA Basketball Statistics

type Coach = {
    Name: string
    FormerPlayer: bool
}

type Stats = {
    Wins: int
    Losses:int
}

type Team = {
    Name: string
    Coach: Coach
    Stats: stats
}
