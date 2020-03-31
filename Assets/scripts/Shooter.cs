using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class Shooter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;
    public float initialSpeed = 100.0f;
  //  public AudioClip clip;

    public float fireDelta = 1.0F;
    private float nextFire = 1.0F;
    private float myTime = 0.0F;

    // Update is called once per frame
    void Update()
    {
      

        myTime = myTime + Time.deltaTime;
        if (Input.GetButton("Fire1") && myTime > nextFire)
        {   
           

            nextFire = myTime + fireDelta;
          //  Quaternion rotationbarrel = barrel1.transform.rotation;
          //  rotationbarrel.z -= 90.0f;
         
            GameObject myPrefab1 = Instantiate(projectile, transform.position, transform.rotation);
          


            //  AudioSource.PlayClipAtPoint(clip, transform.position, 0.8f);
            // prefab.transform.position= transform.forward * initialSpeed *Time.deltaTime;
            myPrefab1.GetComponent<Rigidbody>().velocity = initialSpeed * myPrefab1.transform.up;
         //   myPrefab2.GetComponent<Rigidbody>().velocity = initialSpeed * myPrefab2.transform.forward;

            Destroy(myPrefab1, 10.0f);
          //  Destroy(myPrefab2, 10.0f);

            // create code here that animates the newProjectile

            nextFire = nextFire - myTime;
            myTime = 0.0F;
        }



        //prefab.transform.Translate(prefab.transform.forward * initialSpeed * Time.deltaTime);

        //prefab = null; 

    }
}
