public class GameBuilderViewModel
{
    public float BuildProgress;
    public GameBuilderViewModel(IGameBuilderModel gameBuilderModel)
    {
        BuildProgress = gameBuilderModel.BuildProgress;
    }
}
