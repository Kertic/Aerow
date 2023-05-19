using UnityEngine;

namespace Code.Player.States.SubStates.Airborne
{
    public class Falling : SuperStates.Airborne
    {
        public override void OnStateEnter()
        {
            base.OnStateEnter();
            m_playerPhysics.velocity.y = -m_data._Gravity;
        }

        public override void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.CompareTag("Ground"))
            {
                m_stateMachine.ChangeState(m_stateMachine._Idle);
            }
        }

        public Falling(PlayerData data, PlayerPhysics playerPhysics, PlayerStateMachine stateMachine) : base(data, playerPhysics, stateMachine) { }
    }
}