using UnityEngine;
using System.Collections;
/******************************************************************************/
/*! @file   Test.cs
********************************************************************************
@brief      コーティング規約説明用ファイル
********************************************************************************
@author     橋本 航
*******************************************************************************/
// クラス名はアッパーキャメル
/*! 
@brief  クラスの説明
*/
public class Test
{
    // メンバ定数名はアッパーキャメル
    // アクセス指定子は必ず記述
    // 接頭にはmkを必ずつける
    private const int mkPrivateConst = 1;
    private const int mkProtectedConst = 1;
    private const int mkPublicConst = 1;

    // Unityのインスペクター上で参照を設定できるようにする変数は
    // 基本的に[SerializeField]をつけアクセスレベルをprivateにすること
    [SerializeField]
    private GameObject m_gameObject;

    //変数のコメントのつけ方
    /*! 
    @brief  変数の説明
    */
    // 接頭には必ず
    // メンバ変数名はローワーキャメル
    // アクセス指定子は必ず明記すること
    // 通常何も書かない場合はprivateになるが、privateの場合でも必ず記述をする
    // 接頭にはm_を必ずつける
    private int m_privateData;
    protected int m_protectedData;
    public int m_publicData;

    //アクセサー（プロパティ）のコメントのつけ方
    /*! 
    @briefアクセサー（プロパティ）の説明 
    @get  ゲットアクセサーの説明
    @set  セットアクセサーの説明
    */
    // メンバ変数のアクセサー(プロパティ)はアッパーキャメル
    // メンバ変数と同様指定子は必ず明記
    // 接頭にはmを必ずつける
    private int mPrivateAccessor { get; set; }
    protected int mProtectedAccessor { get; set; }
    public int mPublicAccessor { get; set; }

    // 関数のコメントのつけ方
    /*! 
    @brief                関数の説明 
    @param[in]  引数名    その引数の説明
    @param[out]
    @param[int/out]
    @return         返り値（戻り値）の説明
    */
    // メンバ関数はアッパーキャメル
    // メンバ変数と同様指定子は必ず明記
    // 接頭にはmを必ずつける
    private void mPrivateFunction() {/* 処理内容記述*/  }
    protected void mProtectedFunction() {/* 処理内容記述*/  }
    public void mPublicFunction() { /* 処理内容記述*/ }
}
