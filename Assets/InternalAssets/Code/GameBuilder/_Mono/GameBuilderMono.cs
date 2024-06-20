using UnityEngine;
using WildTech.Systems.Data.GameConfiguration;
using WildTech.Systems.GameBuilder;

public class GameBuilderMono : MonoBehaviour
{
    [SerializeField] private GameBuildData gameBuildData;
    private void Start()
    {
        IGameBuilderModel gameBuilderModel = new GameBuilderModel(gameBuildData);
        IGameBuilderView gameBuilderView = new EmptyGameBuilderView();
        IGameBuilderController controller = new GameBuilderController(gameBuilderModel, gameBuilderView);

        controller.BuildGame();
    }
}
