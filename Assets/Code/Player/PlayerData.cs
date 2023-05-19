using UnityEngine;

namespace Code.Player
{
    public class PlayerData : MonoBehaviour
    {
        [SerializeField]
        private float moveSpeed;

        [SerializeField]
        private float jumpHeight;

        [SerializeField]
        private float breakSpeed;

        [SerializeField]
        private float gravity;

        public float _MoveSpeed
        {
            get => moveSpeed;
            private set => moveSpeed = value;
        }

        public float _JumpHeight
        {
            get => jumpHeight;
            private set => jumpHeight = value;
        }

        public float _BreakSpeed
        {
            get => breakSpeed;
            private set => breakSpeed = value;
        }

        public float _Gravity
        {
            get => gravity;
            private set => gravity = value;
        }
    }
}