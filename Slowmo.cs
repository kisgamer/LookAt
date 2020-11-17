using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slowmo : MonoBehaviour
{
    public Text text;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            StartCoroutine(WaitSlowMo());
        }
    }
    IEnumerator WaitSlowMo()
    {
        text.enabled = true;
        Time.timeScale = 0.5f;

        text.text = "3";
        yield return new WaitForSecondsRealtime(1);
        text.text = "2";
        yield return new WaitForSecondsRealtime(1);
        text.text = "1";
        yield return new WaitForSecondsRealtime(1);

        Time.timeScale = 1f;
        text.enabled = false;


        Time.timeScale = 1f;
    }
}
