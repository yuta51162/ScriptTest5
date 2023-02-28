using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] points = new int[5];

        // 配列の各要素に好きな値を代入する
        points[0] = 10;
        points[1] = 20;
        points[2] = 30;
        points[3] = 40;
        points[4] = 50;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);

        }

        {
            // 要素数5の配列を初期化する
            int[] array = new int[5];

            // 配列の各要素に好きな値を代入する
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            // 配列の要素をすべて逆に表示する
            for (int a = 4; a >= 0; a--)
            {
                Debug.Log(array[a]);
            }
        }

        Magic();

        void Magic()
        {
            int mp = 53;

            if (mp >= 5)
            {
                int a;       //
                a = mp - 5;
                // mpが5以上だった場合
                Debug.Log("魔法攻撃をした。残りMPは" + a);
            }
            else
            {
                // MPが5未満だった場合
                Debug.Log("MPが足りないため、魔法が使えない。");
            }


            {
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
}

