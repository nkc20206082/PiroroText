using System;
using UnityEngine;

public class TextMakeModel : MonoBehaviour
{
    public event Action<int> SetEvent;

    public void SetNum(int _SetNum)
    {
        SetEvent(_SetNum);
    }
}
