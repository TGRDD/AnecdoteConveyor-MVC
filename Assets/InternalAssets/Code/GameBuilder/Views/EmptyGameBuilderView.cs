namespace WildTech.Systems.GameBuilder
{
    public class EmptyGameBuilderView : IGameBuilderView
    {
        public void UpdateView(GameBuilderViewModel model)
        {
            return;
        }

        public void UpdateView()
        {
            throw new System.NotImplementedException();
        }
    }
}
