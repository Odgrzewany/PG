using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroList : MonoBehaviour {

    public List<Hero> heroesList = new List<Hero>();
    public Hero takenOne;
    private void Awake()
    {
        takenOne = heroesList[Manager.Instance.takenHero];
    }
}
