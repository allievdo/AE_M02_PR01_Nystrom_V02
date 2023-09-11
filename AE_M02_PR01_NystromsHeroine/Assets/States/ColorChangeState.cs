using UnityEngine;

namespace Nystrom.State
{
    public class ColorChangeState : MonoBehaviour, ICharacterState
    {
        private CharaController _charaController;

        public void Handle(CharaController charaController)
        {
            if (!_charaController)
                _charaController = charaController;

            _charaController.ren.material.color = Color.white;

        }

        void Update ()
        {
            if (Input.GetKeyUp(KeyCode.C))
            _charaController.ren.material.color = Color.red;
        } 
    }
}