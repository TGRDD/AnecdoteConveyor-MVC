using WildTech.Systems.Data.GameConfiguration;
using WildTech.Systems.Menu;

public class AnecdoteTabPrefabFactory
{
    private GameBuildData _gameBuildData;

    public AnecdoteTabPrefabFactory(GameBuildData gameBuildData)
    {
        _gameBuildData = gameBuildData;
    }

    public IMenuTab Create(AnecdoteTabData data)
    {
        switch (data.Type)
        {
            case AnecdoteTabType.NoText:
                return (IMenuTab)_gameBuildData.NoTextAnecdoteTabPrefab;

            case AnecdoteTabType.NoSprite:
                return (IMenuTab)_gameBuildData.NoSpriteAnecdoteTabPrefab;

            case AnecdoteTabType.Full:
                return (IMenuTab)_gameBuildData.FullAnecdoteTabPrefab;

            default:
                throw new System.NotImplementedException();
        }
    }
}
