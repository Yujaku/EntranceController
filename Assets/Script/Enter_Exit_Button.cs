using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Slack
{
    /// <summary>
    /// ボタン入力時の処理
    /// </summary>
    public class Enter_Exit_Button : MonoBehaviour
    {
        /// <summary>
        /// テキストフィールド
        /// </summary>
        [SerializeField]
        SendingScript TextInputField = null;
        
        /// <summary>
        /// ※トグルの場合
        /// トグルのイベント
        /// </summary>
        [SerializeField]
        ActionTeamCallBack actionCallBack = null;

        /// <summary>
        /// 入室ボタン入力時の処理
        /// </summary>
        public void OnClickEnterance()
        {
            //送信するデータ
            var data = new PostMessageData
            {
                //token = "",//トークン

                //channel = "",//チャネル名

                //icon_url = "",//iconの画像url

                //username="",//botの名前

                //text = "",//メッセージテキスト

            };
            
            //コルーチンデータ
            var routine = SlackAPI.PostMessage(data);

            //コルーチンの開始(メッセージ送信の開始)
            StartCoroutine(routine);
        }
    }
}