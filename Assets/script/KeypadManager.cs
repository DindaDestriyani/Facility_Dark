using UnityEngine;
using TMPro;

public class KeypadManager : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI inputText;

    [Header("Kode Benar")]
    public string correctCode = "317";

    private string currentInput = "";

    // Tombol angka
    public void AddNumber(string number)
    {
        if (currentInput.Length < 3)
        {
            currentInput += number;
            inputText.text = currentInput;
        }
    }

    // Tombol Hapus
    public void DeleteNumber()
    {
        if (currentInput.Length > 0)
        {
            currentInput = currentInput.Remove(currentInput.Length - 1);
            inputText.text = currentInput;
        }
    }

    // Tombol Clear
    public void ClearInput()
    {
        currentInput = "";
        inputText.text = "";
    }

    // Tombol Enter
    public void CheckCode()
    {
        if (currentInput == correctCode)
        {
            Debug.Log("Kode Benar");
        }
        else
        {
            Debug.Log("Kode Salah");
            ClearInput();
        }
    }
}