using System;
using UnityEngine;

namespace Code.Player
{
    public class PlayerPhysics : MonoBehaviour
    {
        public BoxCollider2D _Collider { get; private set; }
        public Rigidbody2D _Rigidbody2D { get; private set; }
        public Vector2 velocity;


        private void Awake()
        {
            _Collider = GetComponent<BoxCollider2D>();
            _Rigidbody2D = GetComponent<Rigidbody2D>();
            velocity = Vector2.zero;
        }

        private void FixedUpdate()
        {
            _Rigidbody2D.MovePosition(_Rigidbody2D.position + velocity);
        }
    }
}