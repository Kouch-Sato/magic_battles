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
            // Instantiate(magicPrefab, transform.position, Quaternion.FromToRotation(Vector3.up, transform.rotation));
            // Instantiate(magicPrefab, transform.position, transform.rotation);

            GameObject projectile = Instantiate(magicPrefab, transform.position, transform.rotation) as GameObject;
            // projectile.transform.LookAt(transform.rotation);
            projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * 1000);
            // projectile.GetComponent<MagicProjectileScript>().impactNormal = hit.normal;
        }

        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            // Instantiate(magicPrefab, transform.position, Quaternion.FromToRotation(Vector3.up, transform.rotation));
            // Instantiate(magicPrefab, transform.position, transform.rotation);

            GameObject projectile = Instantiate(magicPrefab, transform.position, transform.rotation) as GameObject;
            // projectile.transform.LookAt(transform.rotation);
            projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * 1000);
            // projectile.GetComponent<MagicProjectileScript>().impactNormal = hit.normal;
        }
    }
}
