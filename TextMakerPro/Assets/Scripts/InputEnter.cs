using System.Collections;
using UnityEngine;

public class InputEnter : MonoBehaviour
{
    [SerializeField] TextPool _TextPool;
    private bool _enterInterval = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return)&&!_enterInterval)
        {
            _TextPool.MakeTextObj();
            StartCoroutine("EnterInterval");
        }
    }
    IEnumerator EnterInterval()
    {
        const float INTERVAL = 0.2f;
        _enterInterval = true;
        yield return new WaitForSeconds(INTERVAL);
        _enterInterval = false;
    }
}
