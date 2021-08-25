using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 spawntile;

    public void SpawnTile(){
        GameObject temp = Instantiate(groundTile , spawntile , Quaternion.identity);
        spawntile = temp.transform.GetChild(1).transform.position;

    }
    // Start is called before the first frame update
   private void Start()
    {
        for(int i=0 ; i<20 ; i++){
            SpawnTile();
        }
    }

   
}
