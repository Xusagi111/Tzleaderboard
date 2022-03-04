
using UnityEngine;

public interface IFactoryUI
{
    void GreateImage(int[] DataPlayers, int CountEntites);
    GameObject Player { get; }
}

