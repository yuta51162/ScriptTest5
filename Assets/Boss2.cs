using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2 : MonoBehaviour
{
    void Start()
    {
        Magic();




        

    }
    void Magic() 
    {
        {
            int mp = 53;
            // 11回処理を繰り返す
            for (int b = 0; b < 11; b++)


            {
                int a;
                a = mp - 5 * b;
                //MPを5消費する
                Debug.Log("魔法攻撃をした。残りMPは" + a);

                //MPが5以下の場合、魔法を発動出来ない
                if (a < 5)
                {
                    Debug.Log("MPが足りないため、魔法が使えない。");
                }
            }



        }
    }

}

