using UnityEngine;

namespace Nystrom.State
{
    public class CharaController : MonoBehaviour
    {
        public Renderer ren;

        public MeshFilter filter;
        public Mesh cube;
        public Mesh cylinder;

        public float maxSpeed = 2.0f;
        public float sideDistance = 2.0f;
        public LayerMask whatIsGround;

        public float sidewaysForce = 500f;

        public Rigidbody rig;

        public float jumpForce;
        public float diveForce;
        public bool grounded = false;

        public float CurrentSpeed {  get; set; }

        public Direction CurrentSideDirection
        {
            get; private set;
        }

        private ICharacterState
            _standingState, _jumpingState, _divingState, _duckingState, _sideStateL, _sideStateR, _startState, _colorChangeState, _changeShapeState;

        private CharacterStateContext _characterStateContext;


        private void Start()
        {
            _characterStateContext = 
                new CharacterStateContext(this);

            _standingState = gameObject.AddComponent<StandingState>();
            _jumpingState = gameObject.AddComponent<JumpingState>();
            _divingState = gameObject.AddComponent<DivingState>();
            _duckingState = gameObject.AddComponent<DuckingState>();
            _startState = gameObject.AddComponent<StartState>();
            _sideStateL = gameObject.AddComponent<SideStateLeft>();
            _sideStateR = gameObject.AddComponent<SideStateRight>();
            _colorChangeState = gameObject.AddComponent <ColorChangeState>();
            _changeShapeState = gameObject.AddComponent<ShapeState>();

           // _characterStateContext.Transition(_standingState);
        }

        public void CharaStand ()
        {
            _characterStateContext.Transition(_standingState);
        } 
       public void CharaStart ()
        {
            _characterStateContext.Transition(_startState);
        }

       public void CharaSideLeft ()
        {
            _characterStateContext.Transition(_sideStateL);
        }

        public void CharaSideRight()
        {
            _characterStateContext.Transition(_sideStateR);
        }

        public void CharaJump ()
        {
            _characterStateContext.Transition(_jumpingState);
        }

        public void CharaDuck ()
        {
            _characterStateContext.Transition(_duckingState);
        }

        public void CharaColorChange ()
        {
            _characterStateContext.Transition(_colorChangeState);
        }

        public void CharaDive ()
        {
            _characterStateContext.Transition(_divingState);
        }

        public void CharaChange ()
        {
            _characterStateContext.Transition(_changeShapeState);
        }


        //Jump
        public void OnCollisionEnter(Collision collision)
        {
            grounded = true;
        }

        public void OnCollisionExit(Collision collision)
        {
            grounded = false;
        }
    }
}
