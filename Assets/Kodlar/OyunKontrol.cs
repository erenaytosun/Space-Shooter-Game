using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject Asteroid;
    public Vector3 randomPos;
    int score;
    public Text text;
    public Text bitistext;
    public Text yenidenbasla;
    bool oyunBittiKontrol = false;
    bool yenidenBaslaKontol = false;

    void Start()
    {
        StartCoroutine(olustur());
        score = 0;
        text.text = "Score = 0";
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && yenidenBaslaKontol == true)
        {
            SceneManager.LoadScene("level 1");
        }
    }

    IEnumerator olustur()
    {
        yield return new WaitForSeconds(2);

        while(true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(Asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(0.8f);
            }
            yield return new WaitForSeconds(6);

            if (oyunBittiKontrol)
            {
                yenidenBaslaKontol = true;
                break;
            }
        }
        
    }

    public void scoreArttir(int gelenScore)
    {
        score += gelenScore;
        text.text = "Score = " + score;
        //Debug.Log(score);
    }

    public void oyunBitti()
    {
        bitistext.text = "Game Over";
        oyunBittiKontrol = true;
    }
}
