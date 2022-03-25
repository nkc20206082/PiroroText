using UnityEngine;

public class TextMakePresenter : MonoBehaviour
{
    [SerializeField] private TextMakeModel _TextMakeModel;
    [SerializeField] private TextMakeView _TextMakeView;

    public void Awake()
    {
        _TextMakeModel.AddEvent += _TextMakeView.Attack;
    }
}
