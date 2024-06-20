namespace WildTech.Systems.Menu
{
    public class MenuSystemViewModel
    {
        public IMenuTab PreviousTabObject { get; private set; } = null;
        public IMenuTab CurrentTabObject { get; private set; } = null;

        public MenuSystemViewModel(MenuSystemModel model)
        {
            PreviousTabObject = model.PreviousTabObject;
            CurrentTabObject = model.CurrentTabObject;
        }
    }
}
