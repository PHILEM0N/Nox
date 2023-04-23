using UnityEngine;

public class DaytimeManager : MonoBehaviour
{
    [SerializeField] private ErrorDialog errorDialog;

    // Texts
    private const string SkillTreeText = "��ų Ʈ���� �۾� ���Դϴ�.";
    private const string TownEditText = "���� ��� �۾� ���Դϴ�.";

    public void SkillTree()
    {
        // Debug.Log("Skill Tree");
        errorDialog.SetErrorText(SkillTreeText);
        errorDialog.Show();
    }

    public void TownEdit()
    {
        // Debug.Log("Town Edit");
        errorDialog.SetErrorText(TownEditText);
        errorDialog.Show();
    }

    private void OnDialogHiddenHandler()
    {
        errorDialog.OnDialogHidden -= OnDialogHiddenHandler;
    }
}
