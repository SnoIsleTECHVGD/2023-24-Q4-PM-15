using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public List<string> lines;
    public int onLine;
    public string name;
    public GameObject text;
    public GameObject nameText;
    public GameObject activationCircle;


    // Update is called once per frame
    void Update()
    {
        if (activationCircle.GetComponent<PuzzleActivation>().canOpenPuzzle)
        {
            text.GetComponent<TextMeshProUGUI>().text = lines[onLine];
            nameText.GetComponent<TextMeshProUGUI>().text = name;
            if (Input.GetKeyDown(KeyCode.Space) && onLine < lines.Count - 1)
            {
                onLine++;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && onLine >= lines.Count - 1)
            {
                activationCircle.GetComponent<PuzzleActivation>().canOpenPuzzle = false;
                activationCircle.GetComponent<PuzzleActivation>().puzzleScreen.SetActive(false);
            }
        }
    }

    public void resetDialogue(List<string> newLines)
    {
        lines = newLines;
        onLine = 0;
    }
}
