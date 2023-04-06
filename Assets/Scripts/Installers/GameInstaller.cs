using Game.Windows;
using Zenject;

namespace Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<GameWindowManager>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<GameHudWindow>().AsSingle();
        }
    }
}