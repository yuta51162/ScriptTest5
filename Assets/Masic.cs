using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masic : MonoBehaviour
{
    // Use this for initialization
    void Magic()
    {
        // 11�񏈗����J��Ԃ�
        for (int i = 0; i < 12; i++)
            if (i < 10)
            {
                Debug.Log("���@�U���������B");
            }

            else if (i > 10)


            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }
    }

    // Update is called once per frame
    void Update()
    {

    }
}