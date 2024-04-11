using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.InputSystem;

public class Wander : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    private void Start()
    {
       InvokeRepeating("moveRandomDirection", 0.5f, 0.1f);
    }
    async void Update()
    {
        if (transform.rotation.z != 0)
        {
            Quaternion target = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
        }
    }

    public void moveRandomDirection()
    {
        Vector2 direction = Random.insideUnitCircle;
        transform.Translate(Random.insideUnitCircle * speed);
    }


}
