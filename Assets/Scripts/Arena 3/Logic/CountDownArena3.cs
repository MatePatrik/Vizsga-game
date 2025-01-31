using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownArena3 : MonoBehaviour
{
    public float countDown;
    public float min;
    public Text minutes;
    public Text seconds;

    // Update is called once per frame
    void Update()
    {
        if (countDown >= 0.5)
        {
            countDown -= Time.deltaTime;
        }
        else
        {
            this.gameObject.SetActive(false);
        }
        min = Mathf.FloorToInt(countDown / 60);
        float sec = Mathf.FloorToInt(countDown % 60);
        minutes.text = min.ToString();
        seconds.text = sec.ToString();
    }
}
