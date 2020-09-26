using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Title : MonoBehaviour
{
    public static  int levelF;
    public GameObject Tuto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartB() {
        Tuto.SetActive(true);
    }

    public void EasyB() {
        levelF = 0;
        Invoke("SceneGame",0.5f);
    }
    public void NormalB() {
        levelF = 1;
        Invoke("SceneGame", 0.5f);
    }
    public void HardB() {
        levelF = 2;
        Invoke("SceneGame", 0.5f);
    }

    void SceneGame() {
        SceneManager.LoadScene ("Game");
    }
    public static int GetLevelF() {
        return levelF;
    }
}
