using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] array= new int[5];

        // 配列の各要素に好きな値を代入する
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        // 配列の要素をすべて逆に表示する
        for (int a = 4; a>= 0;a--)
        {
            Debug.Log(array[a]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}