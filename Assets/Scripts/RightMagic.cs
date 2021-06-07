using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMagic : MonoBehaviour
{
    public GameObject magicPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(magicPrefab, gameObject.transform.position, Quaternion.identity);
        }
    }


}
