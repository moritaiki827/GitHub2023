using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float xMax;
    [SerializeField] private float xMin;
    [SerializeField] private float yMax;
    [SerializeField] private float yMin;

    //private...���̃X�N���v�g���ł��������������Ȃ�
    //public...�ǂ�����ł�������������
    //[SerializeField]...unity��ł͕ς����邯�Ǒ��̃X�N���v�g����͕ς����Ȃ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D) && this.transform.position.x< xMax)//D����������
        transform.Translate(new Vector3(MoveSpeed, 0, 0) * Time.deltaTime);//�ړ����邽�߂̃v���O����
        if(Input.GetKey(KeyCode.A) && this.transform.position.x> xMin)//A����������
        transform.Translate(new Vector3(-MoveSpeed, 0, 0) * Time.deltaTime);//���ֈړ�
        if(Input.GetKey(KeyCode.W) && this.transform.position.y < yMax)//W����������
        transform.Translate(new Vector3(0, 0, MoveSpeed) * Time.deltaTime);//��ֈړ�
        if(Input.GetKey(KeyCode.S) && this.transform.position.y > yMin)//S����������
        transform.Translate(new Vector3(0, 0, -MoveSpeed) * Time.deltaTime);//���ֈړ�
        {

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        Destroy(this.gameObject);
        Debug.Log("Enemy");
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene("End");
    }
}
