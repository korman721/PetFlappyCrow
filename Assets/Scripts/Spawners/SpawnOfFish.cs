using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOfFish : MonoBehaviour
{

    public GameObject FishPref;
    public float MaxYPos, MinYPos;

    private float ToSpawnFish, TimerFish;

    private void Start()
    {
        ToSpawnFish = RandomTime();
    }

    private void Update()
    {
        if (TimerFish <= 0)
        {
            ToSpawnFish = RandomTime();
            TimerFish = ToSpawnFish;
            GameObject Fish = Instantiate(FishPref, transform.position, Quaternion.identity);
            float rand = Random.Range(MinYPos, MaxYPos);
            Fish.transform.position = new Vector3(transform.position.x, rand, 0);
        }
        else
        {
            TimerFish -= Time.deltaTime;
        }
    }
    private float RandomTime()
    {
        return Random.Range(1, 5);
    }
}
