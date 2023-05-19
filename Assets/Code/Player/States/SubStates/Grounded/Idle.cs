using UnityEngine;

namespace Code.Player.States.SubStates.Grounded
{
    public class Idle : SuperStates.Grounded
    {
        public override void OnStateEnter()
        {
            base.OnStateEnter();
            m_playerPhysics.velocity = Vector2.zero;
        }

        public override void OnReceiveMovementInput(Vector2 direction)
        {
            base.OnReceiveMovementInput(direction);
            m_stateMachine.ChangeState(m_stateMachine._Running);
        }

        public override void OnHoldMovementInput(Vector2 direction)
        {
            base.OnHoldMovementInput(direction);
            OnReceiveMovementInput(direction);
        }

        public override void OnReceiveButtonInput(InputButton button)
        {
            if (button == InputButton.JUMP)
            {
                m_stateMachine.ChangeState(m_stateMachine._Jumping);
            }
        }

        public Idle(PlayerData data, PlayerPhysics playerPhysics, PlayerStateMachine stateMachine) : base(data, playerPhysics, stateMachine) { }
    }
}