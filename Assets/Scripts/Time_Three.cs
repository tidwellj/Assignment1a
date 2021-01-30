using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Three : MonoBehaviour
{
  void  Start()
    {
        StartCoroutine(SelfDestruct());
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(3f);
         Destroy(gameObject);
    }
}
