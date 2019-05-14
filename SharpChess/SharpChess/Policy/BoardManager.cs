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
        private Board board;
       
        public BoardManager()
        {
            board = new Board(BOARD_SIZE);
        }

        // Returns the instance board
        public Board getBoard()
        {
            return board;
        }

        // Sets the piece for a tile
        private void placePiece(Piece piece, int x, int y)
        {
            board.getTileMap()[x, y].setPiece(piece);          
        }

        // Tests two pieces allegiances
        private bool testSameAllegiance(Piece p1, Piece p2)
        {
            if (p1.getAllegiance() == p2.getAllegiance())
                return true;
            else
                return false;
        }

        // Returns a tile at a coordinate, if nonexistent, return null.
        public Tile findTile(int x, int y)
        {
            if (0 <= x && x < BOARD_SIZE && 0 <= y && y < BOARD_SIZE)
                return getBoard().getTileMap()[y, x];
            else
                return null;
        }

        #region -- Destination Candidacy

        // Used for testing pawn piece destinations
        public bool testPotentialPawnDestination(Tile currentTile, int newX, int newY)
        {
            Piece debatedPiece = currentTile.getCurrentPiece();
            if (findTile(newX, newY) != null)
            {
                if ((currentTile.x - newX == 0) && !findTile(newX, newY).hasPlacedPiece())
                    return true;
                if (findTile(newX, newY).hasPlacedPiece() && (currentTile.x - newX != 0))
                    if (!testSameAllegiance(findTile(newX, newY).getCurrentPiece(), debatedPiece))
                        return true;
            }
            return false;
        }

        // Used for testing simplistic piece destinations (i.e. Knight, King)
        public bool testPotentialSimplexDestination(Piece debatedPiece, int newX, int newY)
        {
            if (findTile(newX, newY) != null)
            {
                if (!findTile(newX, newY).hasPlacedPiece())
                    return true;
                else if (!testSameAllegiance(findTile(newX, newY).getCurrentPiece(), debatedPiece))
                    return true;
            }
            return false;
        }

        // Used for testing complex piece destinations (i.e. Queen, Rook, Bishop)
        public int testPotentialComplexDestination(Piece debatedPiece, int newX, int newY)
        {
            if (findTile(newX, newY) != null)
            {
                if (!findTile(newX, newY).hasPlacedPiece())
                    return 1;
                else if (!testSameAllegiance(findTile(newX, newY).getCurrentPiece(), debatedPiece))
                    return 0;
            }
            return -1;
        }

        #endregion
    }
}
