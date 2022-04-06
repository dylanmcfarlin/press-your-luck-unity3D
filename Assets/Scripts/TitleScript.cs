using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{

    public GameObject prizeImage;
    public GameObject prizeTxt;
    public GameObject whammy;
    public List<PrizesClass> prizeList;
    public float timer = 0;
    public bool btnOnAndOff = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (btnOnAndOff)
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
        int prizeIndex = randomPrize.Next(0, 3);
        if (prizeIndex == 0)
        {
            prizeImage.SetActive(true);
            prizeTxt.SetActive(false);
            whammy.SetActive(false);
        }
        if (prizeIndex == 1)
        {
            prizeImage.SetActive(false);
            prizeTxt.SetActive(true);
            whammy.SetActive(false);
        }
        if (prizeIndex == 2)
        {
            prizeImage.SetActive(false);
            prizeTxt.SetActive(false);
            whammy.SetActive(true);
        }
    }

    public void StopBtn()
    {
        //so everytime it's clicked it goes on & off
        btnOnAndOff = !btnOnAndOff;
    }

}
