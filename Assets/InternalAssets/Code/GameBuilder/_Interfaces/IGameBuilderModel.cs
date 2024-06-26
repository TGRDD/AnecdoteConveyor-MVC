using System;
using WildTech.Systems.Data.GameConfiguration;
namespace WildTech.Systems.GameBuilder
{
    public interface IGameBuilderModel
    {
        public event Action<GameBuilderViewModel> OnModelChanged;
        public float BuildProgress { get; set; }
        public GameBuildData BuildData { get; set; }
    }
}
