using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrash : MonoBehaviour
{
    [SerializeField] private AudioClip CA;
    public GameObject trashPrefab;
    public Transform parent;
    public bool canSpawn;
    // Start is called before the first frame update
    void Start()
    {
        SFXmanager.instance.PlaySFX(CA, transform, 1f);
        InvokeRepeating("spawn", 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawn()
    {
        if (canSpawn)
        {
            Instantiate(trashPrefab, this.transform.position, Quaternion.identity, parent);
        }
    }

}
