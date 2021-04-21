using System;
using System.Collections;
using System.Collections.Generic;
using Ball;
using UnityEngine;

namespace Ball
{
    public class PlayerBall : Player
    {
        private void FixedUpdate()
        {
            Move();
        }
    } 
}

