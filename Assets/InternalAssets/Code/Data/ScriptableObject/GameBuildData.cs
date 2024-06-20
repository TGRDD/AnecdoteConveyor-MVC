using AYellowpaper;
using UnityEngine;
using WildTech.Systems.Menu;
namespace WildTech.Systems.Data.GameConfiguration
{
    [CreateAssetMenu(fileName = "NewBuildData", menuName = "BuildData")]
    public class GameBuildData : ScriptableObject
    {
        [Header("UI Prefabs")]
        public Canvas CanvasPrefab;

        public InterfaceReference<IMenuTab> EntryMenuTabPrefab;

        public InterfaceReference<IMenuTab> FullAnecdoteTabPrefab;
        public InterfaceReference<IMenuTab> NoTextAnecdoteTabPrefab;
        public InterfaceReference<IMenuTab> NoSpriteAnecdoteTabPrefab;

        [Header("Anecdote Data")]
        public AnecdoteGroupData[] Groups;
    }
}
