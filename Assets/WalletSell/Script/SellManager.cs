using UnityEngine;

public class SellManager : MonoBehaviour
{
	//List<Inventory> _porridges;
    //売値のScritabulobjectから参照して、計算する。

    //完成度のデータをどう受け取るか？

	void Start()
    {
        int sellPrice = 0;
        //お粥のインベントリから参照して計算する(出来高のenumがあるからそれも参照して計算？)

        //お粥インベントリから所持数の取得　か　インベントリが値段保持していてそこから計算？
        //foreach()
        
        //合計の売値をWalletManagerに渡す
        WalletManager wallet = gameObject.GetComponent<WalletManager>();

    }

    public int 
}
