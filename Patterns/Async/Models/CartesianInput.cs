using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Models
{
    public class CartesianInput : IInput
    {
        CartesianPoint _point1;
        CartesianPoint _point2;

        public CartesianInput(CartesianPoint p1, CartesianPoint p2)
        {
            if (p1 == null || p2 == null)
                throw new ArgumentNullException("p1 == null || p2 == null");

            _point1 = p1;
            _point2 = p2;
        }

        public CartesianPoint P1 { get => _point1; }
        public CartesianPoint P2 { get => _point2; }
    }
}
