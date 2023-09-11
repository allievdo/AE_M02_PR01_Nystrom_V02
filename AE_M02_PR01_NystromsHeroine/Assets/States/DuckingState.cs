using UnityEngine;

namespace Nystrom.State
{
    public class DuckingState : MonoBehaviour, ICharacterState
    {
        private CharaController _charaController;

        public void Handle(CharaController charaController)
        {
            if (!_charaController)
                _charaController = charaController;

            transform.localScale = new Vector3(1, 0.4f, 1);
        }
    }
}

