using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunMechanics : MonoBehaviour
{
   public GameObject bulletObject;
   public float bulletSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            GameObject firedBullet = Instantiate(bulletObject);
            firedBullet.AddComponent<bullet>();//adds the bullets functionality
            firedBullet.GetComponent<bullet>().bulletSpeed = bulletSpeed;//sets the bullet speed 
            firedBullet.transform.rotation = gameObject.transform.rotation;//set the rotation
            firedBullet.transform.position = gameObject.transform.GetChild(0).position; //moves the bullet to the mussel
        }
    }

}
