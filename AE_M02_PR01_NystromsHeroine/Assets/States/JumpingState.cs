using UnityEngine;

namespace Nystrom.State
{
    public class JumpingState : MonoBehaviour, ICharacterState
    {
        private CharaController _charaController;

        public void Handle(CharaController charaController)
        {
            if (!_charaController)
                _charaController = charaController;
        }

        void Update()
        {
            if (_charaController)
            {

                if (Input.GetKeyDown(KeyCode.Space) && _charaController.grounded)
                {
                    TryJump();
                    Debug.Log("Try jump");
                }
            }
        }


        void TryJump()
        {
            // create a ray facing down
            Ray ray = new Ray(transform.position, Vector3.down);
            Debug.Log("Raycast created");

            // shoot the raycast
            if (Physics.Raycast(ray, 0.5f, _charaController.whatIsGround))
            {
                _charaController.rig.AddForce(Vector3.up * _charaController.jumpForce, ForceMode.Impulse);
                Debug.Log("you should be jumping now");
            }
        }
    }
}