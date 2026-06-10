using Unity.VisualScripting;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefeb; 
    public int count = 3;

    public float timeBetSpwanMin = 1.25f;
    public float timeBetSpwanMax = 2.25f;
    private float timeBetSpwan;
    private float loopCount = 0;
    public float difficultytimeBet = 0.05f;


    public float yMin = -3.5f;
    public float yMax = 1.5f;
    private float xPos = 20f;

    private GameObject[] platforms;
    private int currentIndex = 0;

    private Vector3 poolPosition = new Vector3(0, -25, 0);
    private float lastSpwanTime;

    private void Start()
    {
       
        platforms = new GameObject[count];

        for(int i = 0; i < count; i++)
        {
            platforms[i] = Instantiate(platformPrefeb, poolPosition, Quaternion.identity);
        }

        lastSpwanTime = 0f;
        timeBetSpwan = 0f;
    }
    
    private  void Update()
    {
        if (GameManager.instance.isGameover) return;

        if(Time.time >= lastSpwanTime + timeBetSpwan)
        {
            lastSpwanTime = Time.time; 

            timeBetSpwan = Random.Range(timeBetSpwanMin, timeBetSpwanMax);

            float yPos = Random.Range(yMin, yMax);

            platforms[currentIndex].SetActive(false);
            platforms[currentIndex].SetActive(true);

            platforms[currentIndex].transform.position = new Vector3(xPos, yPos, 0);
            currentIndex++;
            loopCount++;

            if (currentIndex >= count) currentIndex = 0;
            if(loopCount >= 5)
            {
                loopCount = 0;
                timeBetSpwanMin -= difficultytimeBet;
                timeBetSpwanMax -= difficultytimeBet;
                if (timeBetSpwanMin < 0.5f)
                {
                    timeBetSpwanMin = 0.5f;
                }

                if (timeBetSpwanMax < 1.0f)
                {
                    timeBetSpwanMax = 1.0f;
                }

            }
        }

    }



}