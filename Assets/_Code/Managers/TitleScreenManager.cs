using UnityEngine;

public class TitleScreenManager : MonoBehaviour
{
    [SerializeField] private BoolDialog @bool;
    [SerializeField] private ErrorDialog @error;

    public void NewGame()
    {
        GameManager.Instance.state = GameManager.GameState.NewGame;
        SceneManager.Instance.LoadScene("SaveLoadMenu");
    }

    public void QuitGame()
    {
        @bool.InfoText.text = "������ �����Ͻðڽ��ϱ�?";
        @bool.Show();
    }

    public void LoadGame()
    {
        GameManager.Instance.state = GameManager.GameState.LoadGame;
        SceneManager.Instance.LoadScene("SaveLoadMenu");
    }

    public void Options()
    {
        Debug.Log("Option Ready Yet");
        @error.errorText.text = "�ɼ��� �۾� ���Դϴ�.";
        @error.Show();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
