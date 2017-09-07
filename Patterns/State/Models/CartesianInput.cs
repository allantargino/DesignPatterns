using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Models
{
    public class CartesianInput : IInput
    {
        CartesianPoint _point;

        public CartesianInput(float x, float y)
        {
            _point = new CartesianPoint()
            {
                X = x,
                Y = y
            };
        }

        public object Input { get => _point; }
    }
}
