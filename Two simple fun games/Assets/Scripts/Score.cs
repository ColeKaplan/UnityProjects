using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private static Score instance = null;
    private static int score = 0;
    private static int score2 = 0;
    public Text scoreText;
    public Text scoreText3;
    [SerializeField]
    string strTag;
    [SerializeField]
    string strTag2;

// Start is called before the first frame update
void Start()
    {

         if (instance == null)
         {
             instance = this;
             DontDestroyOnLoad(gameObject);
            scoreText.text = "Green: " + score.ToString();
            scoreText3.text = "Blue: " + score2.ToString(); 
            Debug.Log("hi");
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
        if (collision.collider.tag == strTag2)
            score2 += 1;
            scoreText3.text = "Blue: " + score2.ToString();
    }

}
