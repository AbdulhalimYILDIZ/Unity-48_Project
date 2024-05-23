using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Weapon Type")]
public class weapon_SO : ScriptableObject
{
    public AudioClip fxSound;
    public GameObject Vfx;
    public GameObject bullet;
    public float recoilTime;
    public float reloadTime;



}
