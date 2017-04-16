using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject pr1;
    public GameObject pr2;
    public GameObject pr3;
    public GameObject pr4;
    public GameObject pr5;
    public GameObject pr6;
    public GameObject pr7;
    public GameObject play;
    int rand;
    float timer;
    public float diff;
    Vector3 pos;


    // Use this for initialization
    void Start()
    {
        timer = diff;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && play.transform.position.y>-200)
        {
            rand = (int)Random.Range(0f, 15f);
            pos = new Vector3(Random.Range(-10f, 10f), play.transform.position.y - 95, Random.Range(-10f, 10f));
            if (rand>=0 && rand<5)
            {
                Instantiate(pr1, pos, Quaternion.identity);

            }
            if (rand>=5 && rand<10.05)
            {
                Instantiate(pr2, pos, Quaternion.identity);

            }
            if (rand>=10 && rand<11)
            {
                Instantiate(pr3, pos, Quaternion.identity);

            }
            if (rand>=11 && rand<12)
            {
                Instantiate(pr4, pos, Quaternion.identity);

            }
            if (rand >= 12 && rand < 13)
            {
                Instantiate(pr5, pos, Quaternion.identity);

            }
            if (rand >= 13 && rand < 14)
            {
                Instantiate(pr6, pos, Quaternion.identity);

            }
            if (rand >= 14 && rand < 15)
            {
                Instantiate(pr7, pos, Quaternion.identity);

            }
            timer = diff;
        }

    }

}