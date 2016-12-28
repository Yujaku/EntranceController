using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Slack
{

    [SerializeField]

    /// <summary>
    /// PostMessageのデータbox
    /// </summary>
    public class PostMessageData
    {
        /// <summary>
        /// token
        /// </summary>
        public string token = string.Empty;

        /// <summary>
        /// channel
        /// </summary>
        public string channel = string.Empty;

        /// <summary>
        /// text
        /// </summary>
        public string text = string.Empty;

        /// <summary>
        /// parse
        /// </summary>
        public string parse = string.Empty;

        /// <summary>
        /// linkname
        /// </summary>
        public string link_names = string.Empty;
        
        /// <summary>
        /// ユーザーネーム
        /// </summary>
        public string username = string.Empty;

        /// <summary>
        /// iconurl
        /// </summary>
        public string icon_url = string.Empty;

        /// <summary>
        /// emoji
        /// </summary>
        public string icon_emoji = string.Empty;
    }

    /// <summary>
    /// API処理本体
    /// </summary>
    public  static class SlackAPI
    {
        /// <summary>
        /// メッセージ送信
        /// </summary>
        /// <param name="data">メッセージデータ</param>
        /// <param name="onSuccess">成功</param>
        /// <param name="onError">失敗</param>
        /// <returns>送信するもの</returns>
        public static IEnumerator PostMessage(PostMessageData data,Action onSuccess = null,Action<string> onError =null )
        {
            
            var form = new WWWForm();
            form.AddField("token",data.token);
            form.AddField("channel", data.channel);
            form.AddField("text", data.text);
            form.AddField("parse", data.parse);
            form.AddField("link_names", data.link_names);
            form.AddField("username", data.username);
            form.AddField("icon_url", data.icon_url);
            form.AddField("icon_emoji", data.icon_emoji);
            
            var url = "https://slack.com/api/chat.postMessage";
            var www = new WWW(url, form);
            yield return www;

            
            //エラー
            var error = www.error;
            if (!string.IsNullOrEmpty(error))
            {
                if (onError != null)
                {
                    onError(error);
                }
                yield break;
            }

            //成功
            if (onSuccess != null)
            {
                onSuccess();
            }            
        }


    }


    
}