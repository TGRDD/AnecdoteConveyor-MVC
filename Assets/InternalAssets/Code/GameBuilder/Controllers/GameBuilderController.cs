namespace WildTech.Systems.GameBuilder
{
    public class GameBuilderController : IGameBuilderController
    {
        private IGameBuilderModel gameBuilderModel;
        private IGameBuilderView gameBuilderView;

        public GameBuilderController(IGameBuilderModel model, IGameBuilderView view)
        {
            gameBuilderModel = model;
            gameBuilderView = view;
        }
        public void BuildGame()
        {
            gameBuilderModel.OnModelChanged += gameBuilderView.UpdateView;

            AnecdoteTabPrefabFactory tabPrefabFactory = new AnecdoteTabPrefabFactory(gameBuilderModel.BuildData);
        }
    }
}
