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
        /// test機能
        /// ゆかりさん話す
        /// </summary>
        public void OnclickYukarin()
        {
            
            var yukarinData = new PostMessageData
            {
                token = "",//トークン
                channel = "unity",
                icon_url = "http://img.atwikiimg.com/www65.atwiki.jp/kindaidensan/attach/33/36/yukarisan.PNG",
                username = "yukari",
                text = "Hello Master",
            };

            //コルーチンデータ
            var yukariRoutine = SlackAPI.PostMessage(yukarinData);

            //コルーチンの開始(メッセージ送信の開始)
            StartCoroutine(yukariRoutine);
        }

        /// <summary>
        /// 入室ボタン入力時の処理
        /// </summary>
        public void OnClickEnterance()
        {
            //送信するデータ
            var messageData = new PostMessageData
            {
                token = "",//トークン

                channel = "entry_and_exit",//actionCallBack.OnClickAction(),//チャネル名

                //icon_url = "",//iconの画像url

                username = "background",//botの名前

                text = "入室:現在時刻は" + DateTime.Now
                + ". 入室した班は" + actionCallBack.OnClickAction()
                + "\n追加メッセージ:" + TextInputField.SaveMessage()
                ,//メッセージテキスト

            };
            /*
            var yukarinData = new PostMessageData
            {
                token = "",//トークン
                channel = "unity",
                icon_url = "http://img.atwikiimg.com/www65.atwiki.jp/kindaidensan/attach/33/36/yukarisan.PNG",
                username = "yukari",
                text = "Hello Master",
            };*/
            
            //コルーチンデータ
            var routine = SlackAPI.PostMessage(messageData);

            //コルーチンの開始(メッセージ送信の開始)
            StartCoroutine(routine);
        }

        /// <summary>
        /// 退室ボタン入力時の処理
        /// </summary>
        public void OnClickExit()
        {
            //送信するデータ
            var messageData = new PostMessageData
            {
                token = "",//トークン

                channel = "entry_and_exit",//actionCallBack.OnClickAction(),//チャネル名

                //icon_url = "",//iconの画像url

                username = "background",//botの名前

                text = "退室:現在時刻は" + DateTime.Now
                + ". 退室した班は" + actionCallBack.OnClickAction()
                + "\n追加メッセージ:" + TextInputField.SaveMessage()
                ,//メッセージテキスト

            };
            /*
            var yukarinData = new PostMessageData
            {
                token = "",//トークン
                channel = "unity",
                icon_url = "http://img.atwikiimg.com/www65.atwiki.jp/kindaidensan/attach/33/36/yukarisan.PNG",
                username = "yukari",
                text = "Hello Master",
            };*/

            //コルーチンデータ
            var routine = SlackAPI.PostMessage(messageData);

            //コルーチンの開始(メッセージ送信の開始)
            StartCoroutine(routine);
        }
    }
}