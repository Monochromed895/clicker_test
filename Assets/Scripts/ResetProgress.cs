using UnityEngine;

public class ResetProgress : MonoBehaviour
{
    public Clicker clicker;

    public void ResetProgressData()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        
        if (clicker != null)
        {
            clicker.totalClicks = 0;
            clicker.clickModifier = 1;
            clicker.UpdateClickText();
        }

        Debug.Log("progress reset");
    }
}