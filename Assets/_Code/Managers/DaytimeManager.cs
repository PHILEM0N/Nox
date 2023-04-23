using UnityEngine;

public class DaytimeManager : MonoBehaviour
{
    [SerializeField] private ErrorDialog errorDialog;

    public void SkillTree()
    {
        Debug.Log("Skill Tree");
        errorDialog.errorText.text = "��ų Ʈ���� �۾� ���Դϴ�.";
        errorDialog.Show();
    }

    public void TownEdit()
    {
        Debug.Log("Town Edit");
        errorDialog.errorText.text = "���� ��� �۾� ���Դϴ�.";
        errorDialog.Show();
    }

    private void OnDialogHiddenHandler()
    {
        errorDialog.OnDialogHidden -= OnDialogHiddenHandler;
    }
}
