using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public List<string> lines = new List<string>();
    public int onLine;
    public GameObject text;
    public GameObject activationCircle;
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<TextMeshProUGUI>().text = lines[onLine];
    }

    // Update is called once per frame
    void Update()
    {
        if (activationCircle.GetComponent<PuzzleActivation>().canOpenPuzzle && text.activeInHierarchy)
        {
            text.GetComponent<TextMeshProUGUI>().text = lines[onLine];
            if (Input.GetKeyDown(KeyCode.Space) && onLine < lines.Count - 1)
            {
                onLine++;
            }
        }

    }
}
