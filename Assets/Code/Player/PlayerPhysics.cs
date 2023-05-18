using System;
using UnityEngine;

namespace Code.Player
{
    public class PlayerPhysics : MonoBehaviour
    {
        public BoxCollider2D Collider { get; private set; }
        public Rigidbody2D Rigidbody2D { get; private set; }

        private void Awake()
        {
            Collider = GetComponent<BoxCollider2D>();
            Rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                Rigidbody2D.velocity = Vector2.right  * 2;
            }
            
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            Debug.Log("In");
        }
    }
}