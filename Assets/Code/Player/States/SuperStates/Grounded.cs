using UnityEngine;

namespace Code.Player.States.SuperStates
{
    public abstract class Grounded : PlayerState
    {
        public override void OnStateEnter()
        {
            base.OnStateEnter();
        }

        public override void OnStateExit() { }
        public override void OnReceiveMovementInput(Vector2 direction) { }
        public override void OnReceiveButtonInput(InputButton button) { }

        public override void OnHoldMovementInput(Vector2 direction) { }

        public override void OnHoldButtonInput(InputButton button) { }

        public override void OnReleaseMovementInput() { }

        public override void OnReleaseButtonInput(InputButton button) { }

        public override void OnCollisionEnter2D(Collision2D collision) { }

        public override void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Ground"))
            {
                m_stateMachine.ChangeState(m_stateMachine._Falling);
            }
        }

        public override void OnCollisionStay2D(Collision2D collision) { }
        public override void PhysicsUpdate() { }
        public Grounded(PlayerData data, PlayerPhysics playerPhysics, PlayerStateMachine stateMachine) : base(data, playerPhysics, stateMachine) { }
    }
}