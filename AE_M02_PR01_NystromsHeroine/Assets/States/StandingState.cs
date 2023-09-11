using UnityEngine;

namespace Nystrom.State
{
    public class StandingState : MonoBehaviour, ICharacterState
    {
        private CharaController _charaController;

        public void Handle(CharaController charaController)
        {
            if (!_charaController)
                _charaController = charaController;

            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}

