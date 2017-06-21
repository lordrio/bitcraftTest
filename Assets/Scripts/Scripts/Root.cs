using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Root : MonoBehaviour
{
    [SerializeField]
    private GameObject generateColorSection;
    [SerializeField]
    private GameObject validateColorSection;
    [SerializeField]
    private GameObject showColorSection;
    
    private BitcraftTestStateMachine stateMachine;
	// Use this for initialization
	void Start ()
    {
        stateMachine = new BitcraftTestStateMachine (new ColorGenData() { root = this });
        stateMachine.StateChanged += SetupGUI;
	}

    /// <summary>
    /// UI Setups
    /// </summary>
    public void SetupGUI(object sender, Bitcraft.StateMachine.StateChangedEventArgs e)
    {
        generateColorSection.gameObject.SetActive (e.NewState.Token == BitcraftTestStateTokens.GenerateColor);
        validateColorSection.gameObject.SetActive (e.NewState.Token == BitcraftTestStateTokens.ValidateColor);
        showColorSection.gameObject.SetActive (e.NewState.Token == BitcraftTestStateTokens.DisplayColor);
    }
        
    /// <summary>
    /// Buttons
    /// </summary>
    public void GenerateColor()
    {
        stateMachine.PerformAction(BitcraftTestActionTokens.Next, ColorItems.Colors[Random.Range(0, ColorItems.Colors.Length-1)]);
    }

    public IEnumerator WaitThenRun(System.Action callback, float seconds = 1.0f)
    {
        yield return new WaitForSeconds (seconds);

        callback ();
    }

    /// <summary>
    /// Performs the color check.
    /// </summary>
    /// <param name="data">Data.</param>
    public void PerformColorCheck(ColorGenData data)
    {
        var valid = true;
        if (data.currentColor == data.previousColor) {
            // invalid
            valid = false;

            // revert data
            data.currentColor = data.previousColor;
        }

        var format = "Color is {0}\nPrevious Color : <color=\"#{4}\">{3}</color>\nNew Color : <color=\"#{2}\">{1}</color>";

        validateColorSection.GetComponentInChildren<Text> ().text = string.Format (format,
            valid ? "valid" : "invalid",
            data.currentColor.Convert().ToString("X8"),
            data.currentColor.Convert().ToString("X8"),
            data.previousColor.Convert().ToString("X8"),
            data.previousColor.Convert().ToString("X8"));

        StartCoroutine (WaitThenRun (() => {
            stateMachine.PerformAction (valid ? BitcraftTestActionTokens.Next : BitcraftTestActionTokens.Invalid);
        }, 3.0f));
    }

    /// <summary>
    /// Performs the color of the show.
    /// </summary>
    /// <param name="data">Data.</param>
    public void PerformShowColor(ColorGenData data)
    {
        var img = showColorSection.GetComponent<Image> ();

        img.material.SetColor ("_ComponentColor", data.currentColor);

        StartCoroutine (WaitThenRun (() => {
            stateMachine.PerformAction (BitcraftTestActionTokens.GenerateColor);
        }, 3.0f));
    }
}