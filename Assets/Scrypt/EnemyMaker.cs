using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float makeTime;
    private float waitTime;
    [SerializeField] private float enemyZ;
    [SerializeField] private float enemyX;
    private float ranX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime < makeTime)//敵が画面に現れるまでの時間を数える
        {
            waitTime = waitTime + Time.deltaTime;//waitTimeにフレーム間の数字を足しこみ続けタイマーの役割を担う
        }

        else
        {
            ranX = Random.Range(enemyX * -1, enemyX);//ranXには-enemyXまでのどれかの値が入る
            Instantiate(enemyPrefab, new Vector3(ranX, 0, enemyZ), enemyPrefab.transform.rotation);
            //オブジェクトを出現させる（enemyPrefabをVector３の座標でenemyPrefabのrotationで）
            waitTime = 0;//waitTimeを０にすることでもう一回
        }
    }
}
