using UnityEngine;

public class TextMakePresenter : MonoBehaviour
{
    [SerializeField] private TextMakeModel _TextMakeModel;
    [SerializeField] private TextMakeView _TextMakeView;

    private void Awake()
    {
        _TextMakeModel.SetEvent += _TextMakeView.SetText;
    }
}
