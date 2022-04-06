using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeTile : MonoBehaviour
{
     public GameObject prizeImage;
    public GameObject prizeTxt;
    public GameObject whammy;
    public List<PrizesClass> prizeList;
    public List<GameObject> prizesInTile;
    public float timer = 0;
    public bool btnOnAndOff = true;

    //Get the game manager
    public GameObject gM;
    public GameScript gameManagerGameScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerGameScript = gM.GetComponent<GameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //allows it to run in game manager
        if (gameManagerGameScript.btnOnAndOff)
        {
            timer += Time.deltaTime;
            if (timer > .4)
            {
                shuffleBoard();
                timer = 0;
            }
        }
    }
    public void ShowSelectedImage()
    {
        prizeImage.SetActive(true);
        prizeTxt.SetActive(false);
        whammy.SetActive(false);
    }
    public void ShowPrizeTxt()
    {
        prizeImage.SetActive(false);
        prizeTxt.SetActive(true);
        whammy.SetActive(false);

    }
    public void ShowWhammy()
    {
        prizeImage.SetActive(false);
        prizeTxt.SetActive(false);
        whammy.SetActive(true);
    }

    void shuffleBoard()
    {
        //shuffle the board!
        System.Random randomPrize = new System.Random();
        //easier drag & drop
        int prizeIndex = randomPrize.Next(0, prizesInTile.Count);
        for(int i =0; i < prizesInTile.Count; i++){
            prizesInTile[i].SetActive(false);
        }
        prizesInTile[prizeIndex].SetActive(true);


        //longer way
        
        // if (prizeIndex == 0)
        // {
        //     prizeImage.SetActive(true);
        //     prizeTxt.SetActive(false);
        //     whammy.SetActive(false);
        // }
        // if (prizeIndex == 1)
        // {
        //     prizeImage.SetActive(false);
        //     prizeTxt.SetActive(true);
        //     whammy.SetActive(false);
        // }
        // if (prizeIndex == 2)
        // {
        //     prizeImage.SetActive(false);
        //     prizeTxt.SetActive(false);
        //     whammy.SetActive(true);
        // }
    }

    public void StopBtn()
    {
        //so everytime it's clicked it goes on & off
        btnOnAndOff = !btnOnAndOff;
    }

}
