using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    internal class Program
    {
        public static int[,] chessPieces = new int[8, 8];
        static void Main(string[] args)
        {
            Distribute(chessPieces);
        }

        public void Distribute(ChessPiece[,] chessPieces)
        {
            _coordinatePiece = chessPieces;
            for (byte x = 0; x < _coordinatePiece.GetLength(0); x++)
                for (byte y = 0; y < _coordinatePiece.GetLength(1); y++)
                    if (_coordinatePiece[x, y] != null)
                        SetOnPlace(x, y);
        }
        private void SetOnPlace(byte x, byte y)
        {
            _coordinatePiece[x, y].currentPositionX = x;
            _coordinatePiece[x, y].currentPositionY = y;
            _coordinatePiece[x, y].transform.position = new Vector3(x, y, -5);
        }
    }
}
