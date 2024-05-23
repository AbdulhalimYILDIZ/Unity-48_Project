using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Bullet Type")]
public class bullet_SO : ScriptableObject
{
    public float bulletSpeed;
    public GameObject impactVfx;
    public int damage;
    public Sprite impactImage;
}
