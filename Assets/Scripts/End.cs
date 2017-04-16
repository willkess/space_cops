using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour {

    public GameObject player;
    public GameObject background;
    public GameObject endText;
    public GameObject endButt;
    public GameObject reason;
    public GameObject o2;
    public GameObject o2text;
    public GameObject ohrats;
    public GameObject oxy;
    public GameObject col;
    public GameObject cop;
    public int lose;
    public int life;
    public int win;
    public int deplete;
    float time;
    int done;
    public int done2;
    int score;

    private Color c;

    // Use this for initialization
	void Start () {
        cop.GetComponent<AudioSource>().Play();
        endButt.SetActive(false);
        endText.GetComponent<Text>().text = "";
        reason.GetComponent<Text>().text = "";
        Color c = background.GetComponent<Image>().color;
        c.a = 0;
        lose = 0;
        win = 0;
        life = PlayerPrefs.GetInt("Life");
        score = PlayerPrefs.GetInt("Score");
        done = 0;
        done2 = 0;
        deplete = 0;
        time = -2;
    }

    // Update is called once per frame
    void Update () {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        if (time<=0&&time>-1)
        {
            if (deplete == 1)
            {
                oxy.GetComponent<AudioSource>().Play();
                time = -2;
            }
        }
        if (deplete == 1)
        {
            o2.transform.localScale = o2.transform.localScale-new Vector3(Time.deltaTime/10,0,0);
        }
        if(done2==1)
        {
            if (deplete == 1)
            {
                time = 2;
            }
            ohrats.GetComponent<AudioSource>().Play();
            done2 = 0;
        }
        if (life<=0)
        {
            lose = 1;
        }
        if (o2.transform.localScale.x <= 0)
        {
            lose = 1;
        }


        if (player.transform.position.y <= -265)
            win = 1;

		if(lose==1 || win==1)
        {
            o2.SetActive(false);
            o2text.SetActive(false);
            while(c.a < 100)
            {
                background.GetComponent<Image>().color = c;
                c.a += .1f*Time.deltaTime;
            }
        }

        if(lose==1&&done==0)
        {
            
            endButt.SetActive(true);
            endText.GetComponent<Text>().text = "You Lose";
            if(life <= 0)
            {
                done = 1;
                score -= (int)player.transform.position.y;
                reason.GetComponent<Text>().text = "Space Ship Crash Score: " + score;
            }
            else if(o2.transform.localScale.x<=0)
            {
                done = 1;
                score -= (int)player.transform.position.y;
                reason.GetComponent<Text>().text = "Oxygen Depleted\nScore: " + score;
            }
        }

        if(win==1&&done==0)
        {
            col.GetComponent<AudioSource>().Play();
            endButt.SetActive(true);
            done = 1;
            score += 300;
            endText.GetComponent<Text>().text = "You Win";
            reason.GetComponent<Text>().text = "Score: "+score;

        }
    }
}
