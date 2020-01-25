using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class MapPulse : MonoBehaviour
{
    public float pulse = 0.1f;
    public Vector3 vec = new Vector3(0, .1f, 0);
    public Vector3 newvec = new Vector3(0, .1f, 0);

    private void Update()
    {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(transform.position.x, transform.position.y + .1f, transform.position.z), 1.0f);

        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, transform.position.z), new Vector3(transform.position.x, transform.position.y - .1f, transform.position.z), 1.0f);
        /* transform.Translate(Vector3.up * Time.deltaTime, Space.World);
         for (int i = 0; i < 10000; i++)
         {
         }
         transform.Translate(Vector3.down * Time.deltaTime, Space.World);
     }
     // Start is called before the first frame update
     void Start()
      {
          StartCoroutine(Waiter());
      }

      // Update is called once per frame
      IEnumerator Waiter()
      {
          gameObject.transform.position += vec;
          yield return new WaitForSeconds(1);
          gameObject.transform.position -= vec;
          yield return new WaitForSeconds(1);
          vec += newvec;

      }
      */
    }

}
