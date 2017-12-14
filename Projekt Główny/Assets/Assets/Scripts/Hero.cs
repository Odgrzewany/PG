using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Moba/Hero")]
public class Hero : ScriptableObject {

    public GameObject heroModel;
    public GameObject basicAttackBullet;
    public GameObject bulletSpawn;

    public string theName;
    [TextArea]public string description;

    public float hp;
    public float mana;

    public float movSpeed;
    public float attackSpeed;
    public float bulletSpeed;

    public float magicDamage;
    public float physicDamage;

    public float dmgResistance;
    public float armor;

    public float critChance;
    public float critDmgMultiplier;

    public float coldown;
    public float firstAbilityCD;
    public float secondAbilityCD;
    public float thirdAbilityCD;
    public float ultimateAbilityCD;
}
