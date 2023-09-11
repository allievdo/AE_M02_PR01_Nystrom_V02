using UnityEngine;

namespace Nystrom.State
{
    public class ClientState : MonoBehaviour
    {
        private CharaController _charaController;

        void Start()
        {
            _charaController = 
                (CharaController)
                FindObjectOfType(typeof(CharaController));
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
                _charaController.CharaStart();


            //RIGHT
            if (Input.GetKeyDown(KeyCode.D))
                _charaController.CharaSideRight();


            //LEFT
            if (Input.GetKeyDown(KeyCode.A))
                _charaController.CharaSideLeft();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("JUMP PLEASE");
                _charaController.CharaJump();
            }
            if (Input.GetKey("s") && _charaController.grounded)
                _charaController.CharaDuck();

            if (Input.GetKeyUp("s"))
                _charaController.CharaStand();

            if (Input.GetKey("c") && _charaController.grounded)
                _charaController.CharaColorChange();

            if (Input.GetKey("s") && !_charaController.grounded)
                _charaController.CharaDive();

            if (Input.GetKey("e") && _charaController.grounded)
                _charaController.CharaChange();
        }
    }
}
