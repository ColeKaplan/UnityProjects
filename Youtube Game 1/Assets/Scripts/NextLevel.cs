using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField]
    public string strTag;
    [SerializeField]
    public string strSceneName;
    // Start is called before the first frame update


    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.collider.tag == strTag)
            SceneManager.LoadSceneAsync(strSceneName);
    }
}
