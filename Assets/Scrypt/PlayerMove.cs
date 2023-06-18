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

    //private...このスクリプト内でしか書き換えられない
    //public...どこからでも書き換えられる
    //[SerializeField]...unity上では変えられるけど他のスクリプトからは変えられない

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D) && this.transform.position.x< xMax)//Dを押したら
        transform.Translate(new Vector3(MoveSpeed, 0, 0) * Time.deltaTime);//移動するためのプログラム
        if(Input.GetKey(KeyCode.A) && this.transform.position.x> xMin)//Aを押したら
        transform.Translate(new Vector3(-MoveSpeed, 0, 0) * Time.deltaTime);//左へ移動
        if(Input.GetKey(KeyCode.W) && this.transform.position.y < yMax)//Wを押したら
        transform.Translate(new Vector3(0, 0, MoveSpeed) * Time.deltaTime);//上へ移動
        if(Input.GetKey(KeyCode.S) && this.transform.position.y > yMin)//Sを押したら
        transform.Translate(new Vector3(0, 0, -MoveSpeed) * Time.deltaTime);//下へ移動
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
