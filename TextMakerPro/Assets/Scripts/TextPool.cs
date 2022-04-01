using TMPro;
using UnityEngine;

public class TextPool : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //ダーメージテキストを格納
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
            nonActiveTextObj.gameObject.SetActive(true);//位置と回転を設定後、アクティブにする
            nonActiveTextObj.GetComponent<TextMakeModel>().SetNum(100);
        }
    }
}
