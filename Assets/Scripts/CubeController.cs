using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    Vector3 vec = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CubeRotate());

    }
        
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vec);
    }
    /*
    戻り地の型はIEnumerator
    最低１回はyield return の記述が必要
    */
    IEnumerator CubeRotate(){
        yield return new WaitForSeconds(1f);
        vec.x=1.0f;
        yield return new WaitForSeconds(2f);
        vec.x = 0f;
        vec.y = 1.0f;
        yield return new WaitForSeconds(2f);
        vec.y = 0f;
        vec.z = 1.0f;
    }
}
