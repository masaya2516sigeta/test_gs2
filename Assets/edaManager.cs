using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edaManager : MonoBehaviour
{
    Rigidbody2D rb;         //  rigidbody
    bool rotateFlg = false; //  ��]�t���O
    [SerializeField]float rotate;   //  ��]�̋���
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();       //  �R���|�[�l���g�擾
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateFlg)                          //  rotateFlg��true�̎����s����
        {
                transform.Rotate(0, 0, rotate);     //  ��]������
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "rocher")                  //  �ڐG�����I�u�W�F�N�g��tag��"rocher"����������s����
        {
            rb.bodyType = RigidbodyType2D.Dynamic;      //  Dynamic�ɐ؂�ւ�
            rotateFlg = true;
        }

    }


}
