using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class dialogueScriptLast : MonoBehaviour
{
    public float delay = 0.1f;
    public float speed = 0.1f;
    public string fullText;
    private string currentText = "";
    public TextMeshProUGUI targetText;
    public int Time = 0;
    void Start()
    {
        StartCoroutine(ShowText());
    }
    void Update()
    {
        Time++;
        Debug.Log(Time);
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("00Menu");
        }
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
    public void nextScene()
    {
                SceneManager.LoadScene("00Menu");
    }

}
