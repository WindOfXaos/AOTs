using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adv : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = StartingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var NextStates = state.GetNextStates();

        for (int index = 0; index < NextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = NextStates[index];
            }
        }
        textComponent.text = state.GetStateStory();
        

    }
}
