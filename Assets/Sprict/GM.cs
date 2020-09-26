using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GM : MonoBehaviour {
    bool playF;
     float speed;
    float time = 10;

    public GameObject GirlOb;
    public Sprite Girl02;

    public Text logT;
    public GameObject button;

    // Start is called before the first frame update
    void Start() {
        int levelF = Title.GetLevelF();
        StartCoroutine("StartCo");
        switch (levelF) {
            case 0:
            speed = 0.4f;
            break;
            case 1:
            speed = 0.55f;
            break;
            case 2:
            speed = 0.7f;
            break;
            default:
            break;
        }
    }

    IEnumerator StartCo() {
        SpriteRenderer GirlRen = GirlOb.GetComponent<SpriteRenderer>();
        logT.text = "よーい";
        yield return new WaitForSeconds(1.5f);
        logT.text = "はじめ !";
        yield return new WaitForSeconds(1f);
        GirlRen.sprite = Girl02;
        playF = true;
    }

    // Update is called once per frame
    void Update() {
        if (playF) {
            time -= 1 * Time.deltaTime;
            logT.text = ((int)time).ToString();

            Vector2 pos = GirlOb.transform.position;
            pos.x -= speed * Time.deltaTime;
            if (Input.GetMouseButtonDown(0)) {
                pos.x += 0.2f;
            }
            GirlOb.transform.position = pos;
            if (pos.x >= 3.2f) {
                logT.text = "勝ち !";
                playF = false;
                button.SetActive(true);
            } else if (pos.x <= -3.2f) {
                logT.text = "負け !";
                playF = false;
                button.SetActive(true);
            } else if (time < 1) {
                logT.text = "引き分け";
                playF = false;
                button.SetActive(true);
            }
        }
    }

  public   void RetryB() {
        SceneManager.LoadScene("Game");
    }
    public void TitleB() {
        SceneManager.LoadScene("Title");
    }
}
