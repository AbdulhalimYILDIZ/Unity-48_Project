using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using mainFunctions;

[CreateAssetMenu(menuName ="Character Type")]
public class hp_SO : ScriptableObject
{
    public attackType attackType;
    public int hp;
    public float speed;
    public float damage;
    [Tooltip("These are minimum and maximum ranges of 'Random Value' and will divided by 100")]
    public int randomMin, randomMax;
    public float multiplier { get { return (Random.Range(randomMin, randomMax) / 100); } set { } }

    
    public void damaging()
    {
       
    }

    public void getingHit()
    {

    }

}
