using SimpleUi;
using SimpleUi.Signals;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class UiInstaller : MonoInstaller
    {
        [SerializeField] private EWindowLayer windowLayer = EWindowLayer.Local;

        public override void InstallBindings()
        {
            Container.BindUiSignals(windowLayer);
            Container.BindWindowsController<WindowsController>(windowLayer);
        }
    }
}