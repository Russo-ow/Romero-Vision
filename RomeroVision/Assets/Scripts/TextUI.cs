using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour {

    public Text textToAnimate;

    void Start() {
        StartCoroutine(ShowText(textToAnimate, "WAKE UP!", 8));
    }

    private IEnumerator ShowText(Text text, string phrase, int showTime) {
        text.text = phrase;
        text.gameObject.SetActive(true);

        Color defaultTextColor = text.color;
        Color invisibleTextColor = text.color;
        invisibleTextColor.a = 0;

        float textBlinkTime = 0.3f;
        WaitForSeconds waitTime = new WaitForSeconds(textBlinkTime);
        for (int i = 0; i < showTime; i++) {
            text.color = invisibleTextColor;

            yield return waitTime;

            text.color = defaultTextColor;

            yield return waitTime;
        }

        text.gameObject.SetActive(false);
        text.color = defaultTextColor;
    }

}
