### 研究理論:
當資訊在通道(圖一)中傳遞時，會受到不同形式的干擾，而導致傳送出的資訊有錯誤。

![](https://i.imgur.com/3Ca01sI.jpg)
>
>錯誤更正碼的目的就是利用一種數學的模型能解決資訊在通道中發生錯誤時能將資訊更正回來的編碼方式。
>
>其中，利用(8,4) Extended Hamming code，比7-4 Hamming code多加了一個parity bit，使資訊本身形成一種數學結構，並使其擁有能更正一個錯誤和發現兩個錯誤的能力。 
---
>
>### 數學模型
>* 講解主要遊戲所用到的數學原理
>
>![](https://i.imgur.com/shNGsFM.png)
>
>![](https://i.imgur.com/XOES9Y4.png)
>
>![](https://i.imgur.com/OkLezzK.png)
>
>![](https://i.imgur.com/5t7amaI.png)
>
>![](https://i.imgur.com/VeuBkGm.png)
---

>### 目的:
>* 以進行遊戲的方式，包裝hamming code理論，希望能有達到寓教於樂的作用。
>### 遊戲過程:
>* 玩家和server進到一個Game Lobby，由server開好一個線上空間後，玩家便可進入。，等待八位玩家都準備好後，會一同進入遊戲畫面。
>* 8個玩家自己選好地圖(16選一)與決定好間諜(故意回答錯)，接下來會輪流問八位參與者各一個問題，且間諜必須說謊。在流程結束後，server利用玩家回答的結果結合hamming code理論找出間諜與地圖，遊戲到此結束。 
