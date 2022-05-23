using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocherMove : MonoBehaviour
{
    [SerializeField] private float RocherSpeed;         //��̑��x
    [SerializeField] private float RocherLimitSpeed;          //��̏�����x



    private void Update()
    {
        Debug.Log(GetComponent<Rigidbody2D>().velocity);        //��̑��x�\��
    }
    private void FixedUpdate()
    {
        Rocher();       //Rocher�̌Ăяo��
    }
    private void Rocher()
    {
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();      //rigidbody���擾
        //Vector2 rocherforce = new Vector2( RocherSpeed * rb.velocity.x, rb.velocity.y);      //�͂�ݒ�
        if (rb.velocity.magnitude > RocherLimitSpeed)       //���߂�ꂽ����𒴂�����������~�߂�
        {
            rb.velocity = new Vector2(rb.velocity.x /1.1f, rb.velocity.y);
        }

        //rb.AddForce(rocherforce);       //�͂�������
    }
}
