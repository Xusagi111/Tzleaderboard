using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
public class Data : ScriptableObject
{
    [SerializeField] private GameObject _cellPrefab;
    [SerializeField] private int[] _dataPlayers;
    [SerializeField] private int _playerPosition; 
    public GameObject GetCellPrefab { get => _cellPrefab; }
    public int[] GetDataPlayers { get => _dataPlayers; }
    public int PlayerPosition { get => _playerPosition; }

}
