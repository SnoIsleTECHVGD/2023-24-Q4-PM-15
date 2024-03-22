using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Chase : MonoBehaviour
{
    public GameObject target;

    public GameObject leftSensor;
    public GameObject rightSensor;
    public GameObject upSensor;
    public GameObject downSensor;

    public float isInRoom;
    public float targetInRoom;

    // Update is called once per frame
    void Update()
    {
        this.isInRoom = this.GetComponent<RoomTracker>().isInRoom;
        targetInRoom = target.GetComponent<RoomTracker>().isInRoom;

        StartCoroutine(chase(target));
    }

    public IEnumerator chase(GameObject target)
    {
        float vectorX = target.transform.position.x - transform.position.x;
        float vectorY = target.transform.position.y - transform.position.y;

        Vector3 toTarget = new Vector3(vectorX, vectorY, 0);
        toTarget = Vector3.Normalize(toTarget);
        if (target.transform.position.x != transform.position.x && target.transform.position.y != transform.position.y)
        {
            yield return new WaitForSeconds(100);
            transform.Translate(toTarget);
        }
    }
}
