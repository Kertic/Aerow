using UnityEngine;

namespace Code.Player.States
{
    public abstract class PlayerState : MonoBehaviour
    {
        private PlayerData _data;

        public PlayerState(PlayerData data)
        {
            _data = data;
        }

        public abstract void OnStateEnter();
        public abstract void OnStateExit();
        public abstract void ReceiveMovementInput(Vector2 direction);
        public abstract void ReceiveButtonInputDown(string buttonName);
    }
}