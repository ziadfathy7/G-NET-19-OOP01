using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP01.Struct
{
    internal struct Seats
    {
        public char Row;
        public int Number;

        public Seats(char _row, int _Number)
        {
            Row = _row;
            Number = _Number;
        }

        public override string ToString()
        {
            return $"{Row}{Number}";
        }
    }
}
