using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour {

    public GameObject ocean;
    public GameObject Hittile;
    public GameObject misstile;
    public int size;
    private Tiles[,] maps;

	// Use this for initialization
	void Start () {
        Creatingmap();
        display();
    }
	
	// Update is called once per frame
	void Update () {

        

	}
    void Creatingmap()
    {
        maps = new Tiles[size, size];
        for (int x = 0; x < size; x++)
        {
            for (int z = 0; z < size; z++)
            {
                Tiles t = new Tiles();
                if (Random.Range(0, 100) > 80)
                {
                    t.tiletype = Tiletype.Hit;

                }
                else
                {
                    t.tiletype = Tiletype.Ocean;

                }
                maps[x, z] = t;

            }
        }
    }
    void display()
    {

        for (int x = 0; x < size; x++)
        {
            for (int z = 0; z < size; z++)
            {
                switch (maps[x, z].tiletype)
                {
                    case Tiletype.Ocean:
                        Instantiate(ocean, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                    case Tiletype.Hit:
                        Instantiate(Hittile, new Vector3(x, 0, z), Quaternion.identity);
                        break;
                    case Tiletype.Miss:
                        Instantiate(misstile, new Vector3(x, 0, z), Quaternion.identity);
                        break;

                }


            }
        }
    }

}
