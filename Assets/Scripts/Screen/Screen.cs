using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Screen : MonoBehaviour
{
    [SerializeField] TextMeshPro screenTexture;

    bool isCountDown = false;

    public void StartScreen()
    {
        if (isCountDown) { return; }
        isCountDown = true;
        StartCoroutine(CountDownCorutine(1.0f));
    }

    IEnumerator CountDownCorutine(float speed)
    {
        yield return new WaitForSeconds(speed);
        screenTexture.text = "3";
        yield return new WaitForSeconds(speed);
        screenTexture.text = "2";
        yield return new WaitForSeconds(speed);
        screenTexture.text = "1";
        yield return new WaitForSeconds(speed);
        screenTexture.text = "question";
        yield return new WaitForSeconds(speed);
        screenTexture.text = "";
        isCountDown = false;
    }
}
