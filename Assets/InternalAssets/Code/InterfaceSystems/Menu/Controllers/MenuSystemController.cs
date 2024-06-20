namespace WildTech.Systems.Menu
{

    public class MenuSystemController : IMenuSystemController
    {
        private IMenuSystemView _view;
        private IMenuSystemModel _model;


        public MenuSystemController(MenuTab[] menuTabs)
        {

            _model = new MenuSystemModel(menuTabs);
            _view = new ForceMenuSystemView();

            _model.OnModelChanged += _view.UpdateView;
        }


        public void OpenNewTab(int TabID)
        {
            _model.SetCurrentTabID(TabID);
        }
    }
}
