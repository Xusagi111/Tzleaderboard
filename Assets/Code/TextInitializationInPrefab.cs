using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInitializationInPrefab : MonoBehaviour
{
    [SerializeField] private Text _positionText;
    public void inizializalion(string TextPos)
    {
        _positionText.text = TextPos;
    }
}
