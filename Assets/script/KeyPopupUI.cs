using UnityEngine;
using TMPro;
using System.Collections;

public class KeyPopupUI : MonoBehaviour
{
    public GameObject popupPanel;
    public TextMeshProUGUI popupText;

    public void ShowPopup(int currentKey, int totalKey)
    {
        popupPanel.SetActive(true);
        popupText.text = "KUNCI BERHASIL DIAMBIL\n" + currentKey + "/" + totalKey;

        StopAllCoroutines();
        StartCoroutine(HidePopup());
    }

    IEnumerator HidePopup()
    {
        yield return new WaitForSeconds(2f);
        popupPanel.SetActive(false);
    }
}