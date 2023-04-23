using UnityEngine;

public class TitleScreenManager : MonoBehaviour
{
    [SerializeField] private BoolDialog @bool;
    [SerializeField] private ErrorDialog @error;

    // Texts
    private const string NewGameText = "���ο� ������ �����մϴ�.";
    private const string LoadGameText = "������ ������ ������ �ҷ��ɴϴ�.";
    private const string QuitGameText = "������ ������ �����մϴ�.";

    public void NewGame()
    {
        GameManager.Instance.state = GameManager.GameState.NewGame;
        SceneManager.Instance.LoadScene("SaveLoadMenu");
    }

    public void QuitGame()
    {
        @bool.SetInfoText(QuitGameText);
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
        @error.SetErrorText("�ɼ��� �۾� ���Դϴ�.");
        @error.Show();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
