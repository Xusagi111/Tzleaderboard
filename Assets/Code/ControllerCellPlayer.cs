using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerCellPlayer : MonoBehaviour 
{
    private GameObject _player;
    private int _posPlayer;
    private GameObject _topPointe;
    private GameObject _lowPointe;
    public void Inizialization(Data data, GameObject player, InizializationsParametrPlayer[] inizializationsParametrPlayer)
    {
        _posPlayer = data.PlayerPosition;
        _player = player;
        for (int i = 0; i < inizializationsParametrPlayer.Length; i++)
        {
            if (inizializationsParametrPlayer[i].location == Location.LowPoint)
            {
                _lowPointe = inizializationsParametrPlayer[i].gameObject;
                _lowPointe.GetComponent<Image>().color = _player.GetComponent<Image>().color;
            }
            else
            {
                _topPointe = inizializationsParametrPlayer[i].gameObject;
                _topPointe.GetComponent<Image>().color = _player.GetComponent<Image>().color;
            }
            inizializationsParametrPlayer[i].GetComponentInChildren<TextInitializationInPrefab>().inizializalion(_posPlayer.ToString());
            
        }
        DinamicCellPlayer();
    }
    public void DinamicCellPlayer()
    {
        if (_player.transform.position.y > _topPointe.transform.position.y)
        {
            _topPointe.SetActive(true);
        }
        if (_player.transform.position.y < _lowPointe.transform.position.y)
        {
            _lowPointe.SetActive(true);
        }
        if (_player.transform.position.y < _topPointe.transform.position.y)
        {
            _topPointe.SetActive(false);
        }
        if (_player.transform.position.y > _lowPointe.transform.position.y)
        {
            _lowPointe.SetActive(false);
        }

    }
}
