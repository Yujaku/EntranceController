# EntranceController
Unityをクライアントとし、Slackに入退室状況を反映する入退室管理アプリ  
developブランチにpusuしてください   
<!--  水平線  -->
  
---   

<!--  大まかでいいから書いて   -->
## 現在できていること
* Slackへのメッセージ送信機能
* 入力したテキストデータのデバック表示.(string型メソッドで取得可能にしています)  


## 未実装の範囲(必須)
* Toggleを使った班ごとの入退室状況の反映.  
  - toggleでなくてもいいかも。もっといい方法あったらご連絡お願いします.  
* アプリそのもののデザイン  
  - 誰でもいいのでもう少しデザインを...
* Slackのアイコンとかデザイン回り.   
  - なんでもいい。ただし全体で使うので無難なものor流行らせたいアニメのアイコンとかでいいと思う.
  - アイコンはサイズに注意すること.    
  
## 未実装の範囲(努力目標)
* 入室をサーバーにアクセスすることで判別する  
  - 学内サーバか自前のサーバ必要
* GPSで近くにいる部員を判別
  - 個人情報駄々漏れなりそう
* twitterでの部員の入退室確認垢(鍵)
  - 同上に加え、そもそも需要がない

## その他備考
* このコードを使ってその他のbot実装もokです。むしろ滅茶苦茶作れ。

---

## 最終的な機能詳細
SlackAPIをたたいて物理で回す.  
slackへ入室、および退室した班、時間、その他メッセージデータを専用channelに送信する.  
