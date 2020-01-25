using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private static Score instance = null;
    private static int score = 0;
    public Text scoreText;
    [SerializeField]
    string strTag;


    // Start is called before the first frame update
    void Start()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            scoreText.text = "Green: " + score.ToString();
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
            score += 1;
        scoreText.text = "Green: " + score.ToString();
    }

}
