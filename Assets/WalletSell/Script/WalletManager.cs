using Unity.VisualScripting;
using UnityEngine;

public class WalletManager : MonoBehaviour
{
    [SerializeField] SellManager sell;
    [SerializeField] int _wallet;
    public int Wallet { get { return _wallet; } set { _wallet += value; } }
    
    void Start()
    {
        //�������f�[�^�̍X�V�@���l�Ɠ����X�V�Ȃ̂ŉ��Z�̌`
        _wallet += PlayerPrefs.GetInt("wallet");
    }

    void Update()
    {
        TextUpdate();
    }

    /// <summary>
    /// ������UI�̃e�L�X�g���X�V���郁�\�b�h
    /// </summary>
    void TextUpdate()
    {
        //UI����Ăяo���āA_wallet��l�Ƃ��ē��͂���
    }

    /// <summary>
    /// �V�[���I�����ɌĂяo���A
    /// �������̃f�[�^��ۑ�����B
    /// </summary>
    public void DataSave()
    {
        PlayerPrefs.SetInt("wallet", _wallet);
    }
}
