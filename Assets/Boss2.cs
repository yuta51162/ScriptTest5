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
            // 11�񏈗����J��Ԃ�
            for (int b = 0; b < 11; b++)


            {
                int a;
                a = mp - 5 * b;
                //MP��5�����
                Debug.Log("���@�U���������B�c��MP��" + a);

                //MP��5�ȉ��̏ꍇ�A���@�𔭓��o���Ȃ�
                if (a < 5)
                {
                    Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
                }
            }



        }
    }

}

