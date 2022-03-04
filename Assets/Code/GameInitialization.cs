using UnityEngine;
using UnityEngine.UI;

public class GameInitialization
{
    public GameInitialization(Data data)
    {
        var _controllerCellPlayer = ControllerCellPlayer.FindObjectOfType<ControllerCellPlayer>();
        var ListDinamicPlayer = InizializationsParametrPlayer.FindObjectsOfType<InizializationsParametrPlayer>();
        var _factoryUI = new FactoryUI(data, _controllerCellPlayer);
        _factoryUI.GreateImage(data.GetDataPlayers, 11);
        _controllerCellPlayer.Inizialization(data, _factoryUI.Player, ListDinamicPlayer);
    }
}


