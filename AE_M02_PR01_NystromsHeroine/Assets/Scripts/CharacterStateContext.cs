using UnityEngine;

namespace Nystrom.State
{
    public class CharacterStateContext
    {
        public ICharacterState CurrentState
        {
            get; set;
        }

        private readonly CharaController _charaController;

        public CharacterStateContext (CharaController charaController)
        {
            _charaController = charaController;
        }

        public void Transition ()
        {
            CurrentState.Handle(_charaController);
        }

        public void Transition (ICharacterState state)
        {
            CurrentState = state;
            _charaController.ren.material.color = Color.red;
            _charaController.filter.mesh = _charaController.cube;
            CurrentState.Handle(_charaController);
        }
    }
}
