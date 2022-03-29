using TMPro;
using UnityEngine;

public class TextMakeView : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //ダーメージテキストを格納

    public void SetText(int num)
    {
        this.gameObject.GetComponent<TextMeshPro>().text = "+" + num.ToString();
    }
}
