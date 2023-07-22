using ChessChallenge.API;
using System;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        Move[] moves = board.GetLegalMoves();

        Random rng = new Random();        
        return moves[rng.Next(moves.Length)];
    }
}