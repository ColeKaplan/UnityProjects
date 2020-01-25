using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;
    bool DestroySelf = true;
    bool DestroyOther = true;    // Start is called before the first frame update


    // Update is called once per frame
    private void OnCollision(Collision collision)

    {
        if (collision.collider.tag == strTag)
            if (DestroySelf)
                Destroy(this.gameObject);
                Debug.Log("destroyed self");
            if (DestroyOther)
                Destroy(collision.gameObject);
                Debug.Log("destroyed other");

    }
}
