using UnityEngine;

namespace Code.Player.States.SubStates.Airborne
{
    public class Jumping : SuperStates.Airborne
    {
        private Vector2 _startingPosition;
        private float _endingHeight;

        public override void OnStateEnter()
        {
            base.OnStateEnter();
            _startingPosition = m_playerPhysics.gameObject.transform.position;
            _endingHeight = _startingPosition.y + m_data._JumpHeight;
            m_playerPhysics.velocity += (Vector2.up * m_data._Gravity);
        }

        public override void OnStateExit()
        {
            base.OnStateExit();
            _startingPosition = Vector2.zero;
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
            Vector2 currentPosition = m_playerPhysics.gameObject.transform.position;
            if (currentPosition.y >= _endingHeight)
            {
                m_stateMachine.ChangeState(m_stateMachine._Falling);
            }
        }

        public Jumping(PlayerData data, PlayerPhysics playerPhysics, PlayerStateMachine stateMachine) : base(data, playerPhysics, stateMachine) { }
    }
}