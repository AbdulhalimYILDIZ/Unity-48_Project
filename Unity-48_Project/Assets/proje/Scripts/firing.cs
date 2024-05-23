using mainFunctions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing : MonoBehaviour
{
    public Animator anim;
    public weapon_SO weapon;
    public GameObject activeWeapon;
    public int firingMode;
    // Start is called before the first frame update
    void Start()
    {
     anim= GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            StartCoroutine(isFiring());
        }
        
    }
    IEnumerator isFiring()
    {        
        switch (firingMode)
        {            
            case 1:
                shoot();
                yield return new WaitForSeconds(activeWeapon.GetComponent<weapon>()._weapon.recoilTime);
                break;
            case 2:
                shoot();
                yield return new WaitForSeconds(activeWeapon.GetComponent<weapon>()._weapon.recoilTime);
                shoot();
                yield return new WaitForSeconds(activeWeapon.GetComponent<weapon>()._weapon.recoilTime);
                shoot();
                yield return new WaitForSeconds(activeWeapon.GetComponent<weapon>()._weapon.recoilTime);
                break;
            case 3:
                while(Input.GetKey(KeyCode.Mouse0))
                {
                    shoot();
                    yield return new WaitForSeconds(activeWeapon.GetComponent<weapon>()._weapon.recoilTime);
                }
                break;
            default:
                break;
        }
        anim.SetBool("attack", false);
    }
    public void shoot()
    {
        
        activeWeapon = transform.GetComponentInChildren<Animator>().gameObject;
        activeWeapon.transform.GetComponentInChildren<Animator>().gameObject.transform.Find("bulletPos");
        anim = activeWeapon.GetComponentInChildren<Animator>();
        anim.SetBool("attack", true);
        
        Instantiate(activeWeapon.GetComponent<weapon>()._weapon.bullet, activeWeapon.transform.Find("bulletPos").position, activeWeapon.transform.Find("bulletPos").rotation);
        
        GetComponent<AudioSource>().PlayOneShot(activeWeapon.transform.GetComponent<weapon>()._weapon.fxSound);
        Instantiate(activeWeapon.GetComponent<weapon>()._weapon.Vfx, activeWeapon.transform.Find("bulletPos").position, Quaternion.identity);
        
    }
}
