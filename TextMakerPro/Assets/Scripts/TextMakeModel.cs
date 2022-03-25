using System;
using UnityEngine;

public class TextMakeModel : MonoBehaviour
{
    private const int _addNum = 100;
    public event Action<int> AddEvent;

    public void AddNum()
    {
        AddEvent(_addNum);
    }
}
