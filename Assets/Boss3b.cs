using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3b : MonoBehaviour
{
    void Start()
    {
        // �v�f��5�̔z�������������
        int[] points = new int[5];

        // �z��̊e�v�f�ɍD���Ȓl��������
        points[0] = 10;
        points[1] = 20;
        points[2] = 30;
        points[3] = 40;
        points[4] = 50;

        // �z��̗v�f�����ׂĕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);

        }

        {
            // �v�f��5�̔z�������������
            int[] array = new int[5];

            // �z��̊e�v�f�ɍD���Ȓl��������
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            // �z��̗v�f�����ׂċt�ɕ\������
            for (int a = 4; a >= 0; a--)
            {
                Debug.Log(array[a]);
            }
        }



        Magic();

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
}
