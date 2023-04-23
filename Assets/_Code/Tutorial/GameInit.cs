using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameInit : MonoBehaviour
{
    public enum Tutorial01State
    {
        SetName,
        End
    }
    [SerializeField] public Tutorial01State State;

    [SerializeField] private TMP_InputField inputName;
    [SerializeField] private Button confirmButton;
    [SerializeField] private GameObject nameMenu;

    [SerializeField] private Button endButton;

    public void Awake()
    {
        State = Tutorial01State.SetName;
    }

    private void Update()
    {
        switch (State)
        {
            case Tutorial01State.SetName:
                // �̸� �Է�â Ȱ��ȭ
                nameMenu.SetActive(true);

                // InputField�� ����ٸ� Ȯ�� ��ư ��Ȱ��ȭ
                if (inputName.text == "")
                {
                    confirmButton.interactable = false;
                }
                else
                {
                    confirmButton.interactable = true;
                }
                break;
            case Tutorial01State.End:
                // �̸� �Է�â ��Ȱ��ȭ
                nameMenu.SetActive(false);
                // End ��ư Ȱ��ȭ
                endButton.interactable = true;
                break;
        }
    }

    public void SetPlayerName()
    {
        // Input Field �� �������� Player �̸� ����
        if (inputName != null && State == Tutorial01State.SetName)
        {
            // PartyList�� ����ִ��� Ȯ��
            if (GameManager.Instance.SaveData.partyList[0] != null)
            {
                GameManager.Instance.SaveData.partyList[0].characterName = inputName.text;
                State = Tutorial01State.End;
            }
            else
            {
                Debug.LogError("��Ƽ�� ������ϴ�!");
            }
        }
    }
}
