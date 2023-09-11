using UnityEngine;

namespace Nystrom.State
{
    public class StartState : MonoBehaviour, ICharacterState
    {
        private CharaController _charaController;

        public void Handle(CharaController bikeController)
        {
            if (!_charaController)
                _charaController = bikeController;

            _charaController.CurrentSpeed = _charaController.maxSpeed;
        }

        void Update()
        {
            if (_charaController)
            {
                if (_charaController.CurrentSpeed > 0)
                {
                    _charaController.transform.Translate(Vector3.forward * (_charaController.CurrentSpeed * Time.deltaTime));
                }
            }
        }
    }
}