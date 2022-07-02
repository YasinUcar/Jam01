using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class dialogueScript : MonoBehaviour
{
    public float delay = 0.1f;
    public float speed = 0.1f;
    public string fullText;
    private string currentText = "";
    public TextMeshProUGUI targetText;
    void Start()
    {
        StartCoroutine(ShowText());
    }
    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            targetText.text = currentText;
            yield return new WaitForSeconds(delay);

        }
    }
}
