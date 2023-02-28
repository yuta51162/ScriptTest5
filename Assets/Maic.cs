using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maic : MonoBehaviour
{

    // Use this for initialization
    void Magic()
    {
        // 11回処理を繰り返す
        for (int i = 0; i < 12; i++)
            if (i < 10)
            {
            Debug.Log("魔法攻撃をした。" );
            }

        else if(i > 10)


            {
                Debug.Log("MPが足りないため、魔法が使えない。");
            }
    }

    // Update is called once per frame
    void Update()
    {

    }
}