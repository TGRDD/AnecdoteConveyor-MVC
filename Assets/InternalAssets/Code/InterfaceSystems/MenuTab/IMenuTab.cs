namespace WildTech.Systems.Menu
{
    public interface IMenuTab
    {
        void Hide();

        void Show();

        void SetInteractable(bool state);

        public void InizializeButtons(IMenuSystemController controller);
    }
}
