using TMPro;
using UnityEngine;

public class TextMakeView : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //�_�[���[�W�e�L�X�g���i�[

    public void SetText(int num)
    {
        this.gameObject.GetComponent<TextMeshPro>().text = "+" + num.ToString();
    }
}
