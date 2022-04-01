using TMPro;
using UnityEngine;
using DG.Tweening;


public class TextMakeView : MonoBehaviour
{
    private const float _Duration = 0.6f;
    private TextMeshPro _TextMeshPro;
    [SerializeField] private GameObject _damageTextObj; //ダーメージテキストを格納

    private void Awake()
    {
        _TextMeshPro = gameObject.GetComponent<TextMeshPro>();
    }

    void OnEnable()
    {
        DOTween.ToAlpha(() => _TextMeshPro.color, alpha => _TextMeshPro.color = alpha, 0.0f, _Duration).OnComplete(() => { _TextMeshPro.color = Color.white; });
        this.transform.DOMove(new Vector2(transform.position.x, transform.position.y + 1f), _Duration)
                            .OnComplete(() => { gameObject.SetActive(false); });
    }

    public void SetText(int num)
    {
        this.gameObject.GetComponent<TextMeshPro>().text = "+" + num.ToString();
    }

}
