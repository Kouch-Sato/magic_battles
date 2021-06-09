using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int maxHp = 100;
    int hp;

    public EnemyUIManager enemyUIManager;

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
        enemyUIManager.init(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetDamage(int damage)
    {
        hp -= damage;
        Debug.Log(hp);
        enemyUIManager.UpdateHP(hp);
    }
}
