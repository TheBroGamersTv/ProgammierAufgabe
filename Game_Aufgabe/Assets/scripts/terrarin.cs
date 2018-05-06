using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrarin : MonoBehaviour {

    public int height = 256;
    public int witdh = 256;
    public int depth = 20;
    public int times = 20;

    private void Update()
    {
        Terrain terrarin = GetComponent<Terrain>();
        terrarin.terrainData = NewTErrain(terrarin.terrainData);
    }
    TerrainData NewTErrain(TerrainData terrainData)
    {
        terrainData.heightmapResolution = witdh + 1;
        terrainData.size = new Vector3(witdh, depth, height);
        terrainData.SetHeights(0, 0, GenerateMountains());
        return terrainData;
    }
    float[,] GenerateMountains()
    {
        float[,] heights = new float[witdh,height];
        for (int x = 0; x < witdh; x++)
        {
            for (int y = 0; y < height; y++)
            {
                heights[x, y] = PrilinNoise(x, y);
            }
        }
        return heights;
    }
    float PrilinNoise(int x,int y)
    {
        float xneu =(float) x / witdh * times;
        float yneu =(float) y / height * times;

        return Mathf.PerlinNoise(xneu, yneu);
    }
}
