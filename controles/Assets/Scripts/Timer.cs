using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject Contador;
    public int secondsLeft = 30;
    public bool takingAway = false;
    public int min = 0;

    void Start ()
    {
        Contador.GetComponent<Text>().text = min + ":" + secondsLeft;
    }

    void Update ()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true; 
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
              Contador.GetComponent<Text>().text = min + ":0" + secondsLeft;
        }else
        {
             Contador.GetComponent<Text>().text = min + ":" + secondsLeft;
        }
        takingAway = false;

        if (secondsLeft >= 60 ){
            min ++;
            secondsLeft -= 60;

        }
        if (min > 0 && secondsLeft == 0)
        {
            min --;
            secondsLeft = 60;
        }
        if (min == 0 && secondsLeft == 0 )
        {
            Debug.Log ("gameover");
        }


    }

}
