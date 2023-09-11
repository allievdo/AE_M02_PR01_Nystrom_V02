using UnityEngine;

namespace Nystrom.State
{
    public class SideStateRight : MonoBehaviour, ICharacterState
    {
        private Vector3 _sideDirection;
        private CharaController _charaController;

        public void Handle(CharaController charaController)
        {
            if (!_charaController)
                _charaController = charaController;

            _sideDirection.x = (float)_charaController.CurrentSideDirection;

            if (_charaController.CurrentSpeed > 0)
            {
                //transform.Translate(_sideDirection * _charaController.sideDistance);
                    _charaController.rig.AddForce(_charaController.sidewaysForce, 0, 0, ForceMode.VelocityChange);
            }
        }
    }
}