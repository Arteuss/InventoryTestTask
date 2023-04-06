using SimpleUi.Signals;
using Zenject;

namespace Game.Windows
{
    public class GameWindowManager: IInitializable
    {
        private readonly SignalBus _signalBus;

        public GameWindowManager(SignalBus signalBus)
        {
            _signalBus = signalBus;
        }

        public void Initialize()
        {
            _signalBus.OpenWindow<GameHudWindow>();
        }
    }
}