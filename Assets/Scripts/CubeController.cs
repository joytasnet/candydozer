using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    Vector3 vec = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CubeMove());
        StartCoroutine(CubeRotate());
        Debug.Log("hoge");

    }
        
    

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(vec);
        if(Input.GetButtonDown("Fire1")){
            
        }
    }
    /*
    戻り地の型はIEnumerator
    最低１回はyield return の記述が必要
    複数 yeild returnの記述可能
    yeild return後ろでnew WaitForSeconds(秒数)
    するとその時間処理を止めることができる
    通信をする際にも利用される
    StartCoroutineで起動
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
    IEnumerator CubeMove(){
        while(true){
            transform.Rotate(vec);
            yield return null;
        }
    }
}
