using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class BulletCollision : MonoBehaviour
{
    public GameObject explosionPrefab;
    public AudioClip clip;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "enemy")
        { //print("COLLISION");

            ContactPoint contact = collision.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;
            GameObject explosion = Instantiate(explosionPrefab, pos, rot) as GameObject;
            AudioSource.PlayClipAtPoint(clip, pos, 1.0f);

            Destroy(explosion, 3.0f);

            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
    
    }


}
