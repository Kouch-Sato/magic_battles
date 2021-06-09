using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicParticle : MonoBehaviour
{
    public int damage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.name);
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyManager>().GetDamage(damage);
        }
    }
}
