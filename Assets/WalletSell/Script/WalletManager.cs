using Unity.VisualScripting;
using UnityEngine;

public class WalletManager : MonoBehaviour
{
    [SerializeField] SellManager sell;
    [SerializeField] int _wallet;
    public int Wallet { get { return _wallet; } set { _wallet += value; } }
    
    void Start()
    {
        //所持金データの更新　売値と同時更新なので加算の形
        _wallet += PlayerPrefs.GetInt("wallet");
    }

    void Update()
    {
        TextUpdate();
    }

    /// <summary>
    /// 所持金UIのテキストを更新するメソッド
    /// </summary>
    void TextUpdate()
    {
        //UI先を呼び出して、_walletを値として入力する
    }

    /// <summary>
    /// シーン終了時に呼び出し、
    /// 所持金のデータを保存する。
    /// </summary>
    public void DataSave()
    {
        PlayerPrefs.SetInt("wallet", _wallet);
    }
}
