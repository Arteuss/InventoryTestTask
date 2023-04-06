using Core.Constants;
using Game.Ui.Impl;
using SimpleUi;

namespace Game.Windows
{
    public class GameHudWindow : WindowBase
    {
        public override string Name => WindowNames.GameHUD;
        
        protected override void AddControllers()
        {
            AddController<GameHudController>();
            AddController<GameInventoryController>();
        }
    }
}