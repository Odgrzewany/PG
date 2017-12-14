using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManagment : MonoBehaviour {

    public GameObject menu;
    public GameObject options;
    public GameObject chooseMap;
    public GameObject chooseMap2;
    public GameObject chooseMap3;
    public GameObject chooseMap4;
    public GameObject chooseHero;
    public GameObject chooseHero1;
    public GameObject chooseHero2;
    public GameObject chooseHero3;
    public GameObject chooseHero4;

    private void Start()
    {
        menu.SetActive(true);
        options.SetActive(false);
        chooseHero.SetActive(false);
        chooseHero1.SetActive(false);
        chooseHero2.SetActive(false);
        chooseHero3.SetActive(false);
        chooseHero4.SetActive(false);
        chooseMap.SetActive(false);
        chooseMap2.SetActive(false);
        chooseMap3.SetActive(false);
        chooseMap4.SetActive(false);
    }

    public void ToOptions()
    {
        menu.SetActive(false);
        options.SetActive(true);
        chooseHero.SetActive(false);
        chooseHero1.SetActive(false);
        chooseHero2.SetActive(false);
        chooseHero3.SetActive(false);
        chooseMap2.SetActive(false);
        chooseMap3.SetActive(false);
        chooseMap4.SetActive(false);
        chooseHero4.SetActive(false);
    }
    public void ToExit()
    {
        Application.Quit();
    }
    public void ToChooseMap()
    {
        menu.SetActive(false);
        options.SetActive(false);
        chooseHero.SetActive(false);
        chooseHero1.SetActive(false);
        chooseHero2.SetActive(false);
        chooseHero3.SetActive(false);
        chooseHero4.SetActive(false);
        chooseMap.SetActive(true);
        chooseMap2.SetActive(true);
        chooseMap3.SetActive(true);
        chooseMap4.SetActive(true);
    }
    public void ToChooseHero()
    {
        menu.SetActive(false);
        options.SetActive(false);
        chooseHero.SetActive(true);
        chooseHero1.SetActive(true);
        chooseHero2.SetActive(true);
        chooseHero3.SetActive(true);
        chooseHero4.SetActive(true);
        chooseMap.SetActive(false);
        chooseMap2.SetActive(false);
        chooseMap3.SetActive(false);
        chooseMap4.SetActive(false);
    }
    public void BackToMenu()
    {
        menu.SetActive(true);
        options.SetActive(false);
        chooseHero.SetActive(false);
        chooseHero1.SetActive(false);
        chooseHero2.SetActive(false);
        chooseHero4.SetActive(false);
        chooseHero3.SetActive(false);
        chooseMap.SetActive(false);
        chooseMap2.SetActive(false);
        chooseMap3.SetActive(false);
        chooseMap4.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene(Manager.Instance.takenMap);
    }
    public void TakeFirstHero()
    {
        Manager.Instance.takenHero = 0;
    }
    public void TakeSeconfHero()
    {
        Manager.Instance.takenHero = 1;
    }
    public void GoFFAMap()
    {
        Manager.Instance.takenMap = 2;
    }
    public void Go5vs5Map()
    {
        Manager.Instance.takenMap = 1;
    }
}
