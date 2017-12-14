using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HeroCaller : MonoBehaviour {

    public Transform spawn;
    Hero hero;
    public HeroList hl;

    public GameObject player;

    GameObject bullet;
    public int maxBullets;
    int actualBullet;

    public GameObject bulletSpawn;
    public Vector3 spawnOffset;

    float timeToFire;

    NavMeshAgent nma;
    PlayerMovement pm;

    List<GameObject> bullets = new List<GameObject>();

    public string theName;
    public float hp;
    public float mana;
    public float movSpeed;
    public float magicDamage;
    public float physicDamage;
    public float dmgResistance;
    public float armor;
    public float attackSpeed;
    public float bulletSpeed;

    private void Start()
    {
        hero = hl.takenOne;
        CallHeroUp();
        spawnOffset = new Vector3(-0.55f, 1.5f, 0f);
    }

    private void Update()
    {
        bulletSpawn.transform.position = player.transform.position + spawnOffset;
    }

    void CallHeroUp()
    {
        bulletSpawn = hero.bulletSpawn;
        player = Instantiate(hl.takenOne.heroModel,spawn.transform.position, Quaternion.identity);
        pm = player.AddComponent<PlayerMovement>();
        //Rigidbody rb =  player.AddComponent<Rigidbody>();
        nma = player.AddComponent<NavMeshAgent>();
        theName = hero.theName;
        hp = hero.hp;
        mana = hero.mana;
        movSpeed = hero.movSpeed;
        magicDamage = hero.magicDamage;
        physicDamage = hero.physicDamage;
        dmgResistance = hero.dmgResistance;
        armor = hero.armor;
        attackSpeed = hero.attackSpeed;
        bulletSpeed = hero.bulletSpeed;
        nma.angularSpeed = 5000;
        nma.acceleration = 500;
        nma.speed = hero.movSpeed;
        //rb.useGravity = false;

        for (int x = 0; x < maxBullets; x++)
        {
            bullet = Instantiate(hero.basicAttackBullet, bulletSpawn.transform.position, Quaternion.identity);
            bullet.SetActive(false);
            bullets.Add(bullet);
        }
    }
    public void Shooting()
    {
        {
            if (Time.time >= timeToFire)
            {
                timeToFire = Time.time + 1f / attackSpeed;
                Bullet bul = bullets[actualBullet].GetComponent<Bullet>();
                bul.target = pm.markedObject;

                if (actualBullet < maxBullets - 1)
                {
                    bullets[actualBullet].transform.position = bulletSpawn.transform.position;
                    bullets[actualBullet].SetActive(true);
                    actualBullet++;
                    bul.speed = bulletSpeed;
                    bul.dmg = physicDamage;
                }
                else if (actualBullet == maxBullets - 1)
                {
                    bullets[actualBullet].transform.position = bulletSpawn.transform.position;
                    bullets[actualBullet].SetActive(true);
                    actualBullet = 0;
                    bul.speed = bulletSpeed;
                    bul.dmg = physicDamage;
                }
                Debug.Log("Strzał!");
            }
        }
    }  
}
