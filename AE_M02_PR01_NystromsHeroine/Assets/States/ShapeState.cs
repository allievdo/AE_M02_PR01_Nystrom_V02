using UnityEngine;

namespace Nystrom.State
{
    public class ShapeState : MonoBehaviour, ICharacterState
    {
        private CharaController _charaController;

        public void Handle(CharaController charaController)
        {
            if (!_charaController)
                _charaController = charaController;

            _charaController.filter.mesh = _charaController.cylinder;
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.E))
                _charaController.filter.mesh = _charaController.cube;
        }
    }
}

