using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing : MonoBehaviour
{
    weapon_SO weapon;
    public int firingMode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {

        }
    }
    IEnumerator isFiring()
    {
        switch(firingMode)
        {
            case 1:
                shoot();
                yield return new WaitForSeconds(weapon.recoilTime);
                break;
            case 2:
                shoot();
                yield return new WaitForSeconds(weapon.recoilTime);
                shoot();
                yield return new WaitForSeconds(weapon.recoilTime);
                shoot();
                yield return new WaitForSeconds(weapon.recoilTime);
                break;
            case 3:
                while(Input.GetKey(KeyCode.Mouse0))
                {
                    shoot();
                    yield return new WaitForSeconds(weapon.recoilTime);
                }
                break;
            default:
                break;
        }
    }
    public void shoot()
    {
        Instantiate(weapon.bullet, transform.Find("bulletPos").position, Quaternion.identity);
        GetComponent<AudioSource>().PlayOneShot(weapon.fxSound);
        Instantiate(weapon.Vfx, transform.Find("bulletPos").position, Quaternion.identity);
    }
}
