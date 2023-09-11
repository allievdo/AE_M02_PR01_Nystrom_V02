using UnityEngine;

namespace Nystrom.State
{
    public class DivingState : MonoBehaviour, ICharacterState
    {
        private CharaController _charaController;

        public void Handle(CharaController charaController)
        {
            if (!_charaController)
                _charaController = charaController;

            _charaController.rig.AddForce(Vector3.down * _charaController.diveForce, ForceMode.Impulse);


        }
    }
}