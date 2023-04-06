using Game.Ui.Impl;
using SimpleUi;
using UnityEngine;
using Zenject;

namespace Installers
{
    [CreateAssetMenu(menuName = "Installers/GameUiInstaller", fileName = "GameUiInstaller")]
    public class GameUiInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private Canvas canvas;
        [SerializeField] private GameHudView gameHudView;
        [SerializeField] private GameInventoryView gameInventoryView;

        public override void InstallBindings()
        {
            var canvasInstance = Container.InstantiatePrefabForComponent<Canvas>(canvas);
            var canvasTransform = canvasInstance.transform;
            
            Container.BindUiView<GameHudController, GameHudView>(gameHudView, canvasTransform);
            Container.BindUiView<GameInventoryController, GameInventoryView>(gameInventoryView, canvasTransform);
            
        }
    }
}