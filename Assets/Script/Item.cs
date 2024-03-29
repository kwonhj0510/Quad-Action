using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum Type { Ammo, Coin, Grenad, Heart, Weapon };
    public Type type;
    public int value;


    Rigidbody rigid;
    SphereCollider sphereColider;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        sphereColider = GetComponent<SphereCollider>();
    }
    private void Update()
    {
        transform.Rotate(Vector3.up * 20 *  Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            rigid.isKinematic = true;
            sphereColider.enabled = false;
        }
    }
}
