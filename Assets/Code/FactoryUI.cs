using UnityEngine;
using UnityEngine.UI;

public class FactoryUI : MonoBehaviour, IFactoryUI
{
    private GameObject _prefabUi;
    private GameObject _reactController;
    private int _playerPosition;
    private GameObject _player;
    public GameObject Player { get => _player; }
    
    public FactoryUI(Data data, ControllerCellPlayer controllerCellPlayer)
    {
        _prefabUi = data.GetCellPrefab;
        _reactController = controllerCellPlayer.gameObject;
        _playerPosition = data.PlayerPosition;
    }
    public void GreateImage(int[] DataPlayers, int CountEntites) //Возможность подгрузки данных с помощью передаваемого массива.
    {
        for (int i = 0; i < CountEntites; i++)
        {
            var currentCellPlayers = Instantiate(_prefabUi, Vector3.zero, Quaternion.identity);
            currentCellPlayers.transform.SetParent(_reactController.transform);
            currentCellPlayers.GetComponentInChildren<TextInitializationInPrefab>().inizializalion(i.ToString());
            if (i == _playerPosition)
            {
                currentCellPlayers.GetComponent<Image>().color = Color.green;
                currentCellPlayers.name = "Player";
                _player = currentCellPlayers;
            }
        }
    }
}
