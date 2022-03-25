using System.Collections;
using UnityEngine;

public class InputEnter : MonoBehaviour
{
    [SerializeField] TextMakeModel _TextMakeModel;
    private bool _enterInterval = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return)&&!_enterInterval)
        {
            _TextMakeModel.AddNum();
            StartCoroutine("EnterInterval");
        }
    }
    IEnumerator EnterInterval()
    {
        _enterInterval = true;
        yield return new WaitForSeconds(0.2f);
        _enterInterval = false;
    }
}
