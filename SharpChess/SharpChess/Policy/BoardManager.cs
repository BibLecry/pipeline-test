﻿using SharpChess.Data;
using SharpChess.Data.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpChess.Policy
{
    public class BoardManager
    {
        private const int BOARD_SIZE = 8;
        public Board board { get; set; }
       
        public BoardManager()
        {
            board = new Board();
        }

        private void placePiece(Piece piece, int coordinate)
        {
            foreach(Tile t in board.getTileMap())
                if (t.coordinate == coordinate)
                    t.currentPiece = piece;           
        }

        public int calculateCoordinate(int xValue, int yValue, int tileSize)
        {
            int x = 0, y = 0;
            for (int i = 0; i < xValue; i++)
            {
                x++;
                i += tileSize;
            }
            for (int i = 0; i < yValue; i++)
            {
                y++;
                i += tileSize;
            }
            int coordinate = ((y - 1) * (BOARD_SIZE)) + x;
            return coordinate;
        }
    }
}
