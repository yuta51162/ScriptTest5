using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // �v�f��5�̔z�������������
        int[] array= new int[5];

        // �z��̊e�v�f�ɍD���Ȓl��������
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        // �z��̗v�f�����ׂċt�ɕ\������
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