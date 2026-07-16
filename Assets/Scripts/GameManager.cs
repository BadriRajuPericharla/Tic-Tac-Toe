using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("There is another GameManager");
        }
        instance = this;
    }
    public void OnClickGridPosition(int x,int y)
    {
        Debug.Log("Click" + x + "," + y);
    }
}
