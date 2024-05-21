using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using mainFunctions;

public class hp : MonoBehaviour
{
    
    hpManager _hpManager;
    public hp_SO baseStats;
    public int Hp;
    public float speed;
    public float damageMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        //Hp = _hpManager.hpCorrection(gameObject);
        speed = baseStats.speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
