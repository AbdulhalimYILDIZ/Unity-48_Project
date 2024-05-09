using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

namespace mainFunctions
{

    public class hpManager 
    {
        public void hpChange(GameObject objectToChange, int value, changeType valueChangeType)
        {
            switch (valueChangeType)
            {
                case changeType.deacrese:
                    value *= -1;
                    break;
                default:
                    break;
            }
            objectToChange.GetComponent<hp>().Hp += value;
        }

        public int hpCorrection(GameObject character)
        {
            int hp;
            hp = character.GetComponent<hp>().Hp;
            switch(character.GetComponent<hp>().baseStats.attackType)
            {
                case attackType.ranged:
                case attackType.meele:
                    hp = (int)(hp * character.GetComponent<hp>().baseStats.multiplier);
                    break;
                case attackType.player:
                case attackType.breakable:
                    hp = (int)(hp*character.GetComponent<hp>().baseStats.hp);
                    break;

            }
            return hp;
        }

    }
    public class spawnManager
    {

    }

    public enum attackType
    {
        ranged,
        meele,
        player,
        breakable,
    }

    public enum changeType
    {
        increase,
        deacrese,
    }
}