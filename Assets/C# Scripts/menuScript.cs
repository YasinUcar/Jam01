using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuScript : MonoBehaviour
{
    [SerializeField] GameObject startPanel;
    [SerializeField] GameObject optionalPanel;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
        
    }
}
