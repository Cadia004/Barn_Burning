using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimer : MonoBehaviour
{
public float time = 5;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
Destroy(gameObject);
    }

   
}
