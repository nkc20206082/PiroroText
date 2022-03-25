using UnityEngine;
using DG.Tweening;
using TMPro;

public class DamageTextController : MonoBehaviour
{
    private const float _Duration=0.6f;
    private TextMeshPro _TextMeshPro;
    private void Awake()
    {
        _TextMeshPro = gameObject.GetComponent<TextMeshPro>();
    }
    //テキストの動き
    void OnEnable()
    {
        DOTween.ToAlpha(() => _TextMeshPro.color, a => _TextMeshPro.color = a, 0.0f, _Duration).OnComplete(() => { _TextMeshPro.color = Color.white; }) ;
        this.transform.DOMove(new Vector2(transform.position.x, transform.position.y+1f), _Duration)
                            .OnComplete(() => {gameObject.SetActive(false); });
    }
}
