using TMPro;
using UnityEngine;

public class TextPool : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //�_�[���[�W�e�L�X�g���i�[
    private GameObject _getTextObj;

    public void MakeTextObj()
    {
        GameObject nonActiveTextObj = null;

        for (int i = 0; i < transform.childCount; i++)
        {
            if (!transform.GetChild(i).gameObject.activeSelf)
            {
                nonActiveTextObj = transform.GetChild(i).gameObject;
                break;
            }
        }
        if (nonActiveTextObj == null)
        {
            _getTextObj = Instantiate(_damageTextObj, Vector3.zero, Quaternion.identity, this.transform);
            _getTextObj.GetComponent<TextMakeModel>().SetNum(100);
        }
        else
        {
            nonActiveTextObj.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            nonActiveTextObj.gameObject.SetActive(true);//�ʒu�Ɖ�]��ݒ��A�A�N�e�B�u�ɂ���
            nonActiveTextObj.GetComponent<TextMakeModel>().SetNum(100);
        }
    }
}
