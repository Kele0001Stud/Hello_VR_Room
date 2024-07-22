using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PuzzleSolver : MonoBehaviour
{
    public GameObject btnLeft, btnRight;

    public void SetSelectable()
    {
        Debug.Log(btnLeft.name + " " + btnRight.name);
    }


}
