using System;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int bits = 0;
    public TextMeshProUGUI bitsText;

    void Start()
    {
        UpdateBitsUI();
    }

    void UpdateBitsUI()
    {
        string binaryRepresentation = Convert.ToString(bits, 2).PadLeft(8, '0');
        if (binaryRepresentation.Length > 8)
        {
            int bytes = bits / 256;
            int remainingBits = bits % 256;
            binaryRepresentation = Convert.ToString(remainingBits, 2).PadLeft(8, '0');
            bitsText.text = bytes.ToString() + " byte(s) " + binaryRepresentation + " bit(s)";
        }
        else
        {
            bitsText.text = "Bits: " + binaryRepresentation;
        }
    }

    public void IncreaseBits()
    {
        bits++;
        UpdateBitsUI();
    }
}
