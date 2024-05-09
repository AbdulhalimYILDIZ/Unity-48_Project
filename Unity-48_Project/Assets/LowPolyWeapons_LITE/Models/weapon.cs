using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using mainFunctions;

public class weapon : MonoBehaviour
{
    spawnManager _spawnManager=new spawnManager();
    public weapon_SO _weapon;
    public GameObject bullet1;
    public Transform bulletPosObject; 
    // Start is called before the first frame update
    void Start()
    {
        bulletPosObject = GameObject.FindWithTag("weapon").transform.Find("rifle").transform.Find("bulletPos").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            _spawnManager.spawnObject(bullet1,bulletPosObject.position);

        }
    }
}
