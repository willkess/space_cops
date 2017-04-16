using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rotaterUI : MonoBehaviour {
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;
    public GameObject s6;
    public GameObject s7;
    public GameObject s8;
    public GameObject s9;
    public GameObject s10;
    public GameObject s11;
    public GameObject s12;
    public GameObject s13;
    public GameObject te;
    public GameObject te2;
    public GameObject te3;
    public GameObject te4;
    public GameObject pr;
    public GameObject pr1;
    public GameObject pr2;
    public GameObject pr3;
    public GameObject prTotl;
    int p1;
    int p2;
    int p3;
    int p4;
    int pT;
    int CurPit;
    int CurCore;
    int CurStor;
    int CurEng;
    float speed;
    float move;
    int life;
    float supplies;
    float fuel;
    int score;
	// Use this for initialization
	void Start () {
        CurPit = 1;
        CurCore = 1;
        CurStor = 1;
        CurEng = 1;
        pT = 1;
	}
	
	// Update is called once per frame
	void Update () {
        speed = 1;
        move = 1;
        life = 2;
        supplies = 1;
        fuel = 1;
        score = 1000 / pT;
        if (CurPit == 1)
        {
            pr.GetComponent<Text>().text = "$3B";
            te.GetComponent<Text>().text = "-Aerodynamic cockpit; 50% less air resistance";
            s1.SetActive(true);
            s2.SetActive(false);
            s3.SetActive(false);
            p1 = 3;
        }
        if (CurPit == 2)
        {
            pr.GetComponent<Text>().text = "$4B";
            te.GetComponent<Text>().text = "-Assisted Piloting cockpit; Routes path for 10% less astroids";
            s1.SetActive(false);
            s2.SetActive(true);
            s3.SetActive(false);
            p1 = 4;
            speed = speed * 1.1f;
        }
        if (CurPit == 3)
        {
            pr.GetComponent<Text>().text = "$2B";
            te.GetComponent<Text>().text = "-Agile cockpit; 10% faster turning";
            s1.SetActive(false);
            s2.SetActive(false);
            s3.SetActive(true);
            p1 = 2;
            move = move * 1.1f;
        }
        if (CurCore == 1)
        {
            pr1.GetComponent<Text>().text = "$4B";
            te2.GetComponent<Text>().text = "-Nuclear Core; Cheap powerful energy, but weaker";
            s4.SetActive(true);
            s5.SetActive(false);
            s6.SetActive(false);
            p2 = 4;
            fuel *= 2;
            life -= 1;
        }
        if (CurCore == 2)
        {
            pr1.GetComponent<Text>().text = "$4B";
            te2.GetComponent<Text>().text = "-Electric Core; cheap, but has slightly less mobility";
            s4.SetActive(false);
            s5.SetActive(true);
            s6.SetActive(false);
            p2 = 4;
            fuel *= .8f;
            move *= .8f;
        }
        if (CurCore == 3)
        {
            pr1.GetComponent<Text>().text = "$7B";
            te2.GetComponent<Text>().text = "-Liquid Core; Heavy but reliable, your standard source";
            s4.SetActive(false);
            s5.SetActive(false);
            s6.SetActive(true);
            p2 = 7;
        }
        
        if (CurStor == 1)
        {
            pr2.GetComponent<Text>().text = "$1B";
            te3.GetComponent<Text>().text = "Light Storage; Contains few resources";
            s7.SetActive(true);
            s8.SetActive(false);
            s9.SetActive(false);
            s10.SetActive(false);
            p3 = 1;
            supplies *= .5f;
        }
        if (CurStor == 2)
        {
            pr2.GetComponent<Text>().text = "$2B";
            te3.GetComponent<Text>().text = "Medium Storage; Contains better resources";
            s7.SetActive(false);
            s8.SetActive(true);
            s9.SetActive(false);
            s10.SetActive(false);
            p3 = 2;
            supplies *= .8f;
        }
        if (CurStor == 3)
        {
            pr2.GetComponent<Text>().text = "$3B";
            te3.GetComponent<Text>().text = "Large Storage; Heavier than first 2, more resources";
            s7.SetActive(false);
            s8.SetActive(false);
            s9.SetActive(true);
            s10.SetActive(false);
            p3 = 3;
            supplies *= 1.2f;
        }
        if (CurStor == 4)
        {
            pr2.GetComponent<Text>().text = "$4B";
            te3.GetComponent<Text>().text = "XL Storage; Contains most resources";
            s7.SetActive(false);
            s8.SetActive(false);
            s9.SetActive(false);
            s10.SetActive(true);
            p3 = 4;
            supplies *= 1.5f;
        }
        if (CurEng == 1)
        {
            pr3.GetComponent<Text>().text = "$12B";
            te4.GetComponent<Text>().text = "Electromagnetic Engine; Very lightweight but slow";
            s11.SetActive(true);
            s12.SetActive(false);
            s13.SetActive(false);
            p4 = 12;
            speed *= .8f;
        }
        if (CurEng == 2)
        {
            pr3.GetComponent<Text>().text = "$15B";
            te4.GetComponent<Text>().text = "Liquid Fuel Engine; Sandard price and speed";
            s11.SetActive(false);
            s12.SetActive(true);
            s13.SetActive(false);
            p4 = 15;

        }
        if (CurEng == 3)
        {
            pr3.GetComponent<Text>().text = "$20B";
            te4.GetComponent<Text>().text = "Solid Fuel Engine; Very fast and powerful, but expensive";
            s11.SetActive(false);
            s12.SetActive(false);
            s13.SetActive(true);
            p4 = 20;
            speed *= 1.2f;
        }
        
        pT = p1 + p2 + p3 + p4;
        prTotl.GetComponent<Text>().text = "$" + pT.ToString() + "B";
    }

    public void Go()
    {
        PlayerPrefs.SetFloat("For_Speed", speed);
        PlayerPrefs.SetFloat("Fuel", fuel);
        PlayerPrefs.SetFloat("Move", move);
        PlayerPrefs.SetFloat("Supplies", supplies);
        PlayerPrefs.SetInt("Life", life);
        PlayerPrefs.SetInt("Score", score);
        SceneManager.LoadScene(1);
    }

    public void RotaterCockpit()
    {
        CurPit++;
        if (CurPit > 3)
        {
            CurPit = CurPit % 3;
        }
    }
    public void RotaterCore()
    {
        CurCore++;
        if (CurCore > 3)
        {
            CurCore = CurCore % 3;
        }
    }
    public void RotaterStorage()
    {
        CurStor++;
        if (CurStor > 4)
        {
            CurStor = CurStor % 4;
        }
    }
    public void RotaterEngine()
    {
        CurEng++;
        if (CurEng > 3)
        {
            CurEng = CurEng % 3;
        }
    }
}
