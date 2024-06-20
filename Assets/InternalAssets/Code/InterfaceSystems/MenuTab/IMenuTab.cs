using System;

namespace WildTech.Systems.Menu
{
    public interface IMenuTab
    {
        public event Action OnMenuButtonClicked;

        void Hide();

        void Show();

        void SetInteractable(bool state);

        public void InizializeButtons(IMenuSystemController controller);
    }
}
