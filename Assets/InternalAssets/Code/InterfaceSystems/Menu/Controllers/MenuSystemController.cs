namespace WildTech.Systems.Menu
{

    public class MenuSystemController : IMenuSystemController
    {
        private IMenuSystemView _view;
        private IMenuSystemModel _model;


        public MenuSystemController(IMenuSystemModel modelSystem, IMenuSystemView viewSystem)
        {

            _model = modelSystem;
            _view = viewSystem;

            _model.OnModelChanged += _view.UpdateView;

        }


        public void OpenNewTab(int TabID)
        {
            _model.SetCurrentTabID(TabID);
        }

    }
}
