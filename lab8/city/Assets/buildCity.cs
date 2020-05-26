using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildCity : MonoBehaviour
{
    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;
    int buildingFootprint = 15;
    // Start is called before the first frame update
    void Start()
    {
        float seed = Random.Range(0, 100);
        for(int h = 0; h < mapHeight; h++)
        {
            for(int w = 0; w < mapWidth; w++)
            {
                int result = (int) (Mathf.PerlinNoise(w/10.0f + seed, h/10.0f + seed) * 10);
                Vector3 posG = new Vector3(w * buildingFootprint, 1, h * buildingFootprint);
                if(result < 2)
                {
                    float randomx = Random.Range(-7, 7);
                    float randomz = Random.Range(-7, 7);
                    Vector3 pos2 = new Vector3((w * buildingFootprint) + randomx, 2, (h * buildingFootprint) + randomz);
                    Instantiate(buildings[0], pos2, Quaternion.identity);//bench
                    Instantiate(buildings[1], posG, Quaternion.identity);//grass
                }
                else if(result < 3)
                {
                    Instantiate(buildings[1], posG, Quaternion.identity);//grass
                }
                else if(result < 4)
                {
                    Vector3 posW = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                    Instantiate(buildings[2], posW, Quaternion.identity);//water
                }
                else if(result < 6)
                {
                    float randomx = Random.Range(-7, 7);
                    float randomz = Random.Range(-7, 7);
                    Vector3 pos2 = new Vector3((w * buildingFootprint) + randomx, 2, (h * buildingFootprint) + randomz);
                    Instantiate(buildings[3], pos2, Quaternion.identity);//tree
                    Instantiate(buildings[1], posG, Quaternion.identity);//grass
                }
                else if(result < 8)
                {
                    Vector3 pos3 = new Vector3(w * buildingFootprint, 2, h * buildingFootprint);
                    Instantiate(buildings[4], pos3, Quaternion.identity);//small house
                    Instantiate(buildings[1], posG, Quaternion.identity);//grass
                }
                else if(result < 10)
                {
                    Vector3 pos3 = new Vector3(w * buildingFootprint, 2, h * buildingFootprint);
                    Instantiate(buildings[5], pos3, Quaternion.identity);//big house
                    Instantiate(buildings[1], posG, Quaternion.identity);//grass
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
