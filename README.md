>### 目的:
>* 以進行遊戲的方式，包裝hamming code理論，希望能有達到寓教於樂的作用。
>### 遊戲過程:
>* 玩家和server進到一個Game Lobby，由server開好一個線上空間後，玩家便可進入。，等待八位玩家都準備好後，會一同進入遊戲畫面。
>* 8個玩家自己選好地圖(16選一)與決定好間諜(故意回答錯)，接下來會輪流問八位參與者各一個問題，且間諜必須說謊。在流程結束後，server利用玩家回答的結果結合hamming code理論找出間諜與地圖，遊戲到此結束。
>### 遊戲畫面介紹:
>a.
>
>Game Lobby畫面
>
>![system software](https://i.imgur.com/mdwQKOy.jpg)
>
>b.
>
>玩家搜尋server所創空間
>
>![system software](https://i.imgur.com/ZSP0wpK.jpg)
>
>c.
>
>等所有玩家登入後，要按join按鈕，按鈕會顯示成ready狀態，等所有玩家和server準備好，一同倒數三秒後進入遊戲畫面
>
>![system software](https://i.imgur.com/3FV1Cj1.jpg)
>
>d.
>
>進入遊戲畫面，按鈕代表不同的畫面。八位玩家自己決定好地圖，點選同一個並決定誰要當間諜(故意回答錯)，便開始遊戲。當畫面出現問題，為該玩家回合，其他玩家不用動作(動作也不會有所反應)。
>
>
>![](https://i.imgur.com/Nb58tXX.png)
>(server端畫面)
>
>![](https://i.imgur.com/MF7EAz9.png)
>(server端資訊)
>
>![](https://i.imgur.com/VtPak2s.png)
>(玩家畫面)
>
>![](https://i.imgur.com/KUSZVwz.jpg)
>(玩家畫面功能介紹)
>
>e.
>
>最後server會判斷結果，此遊戲是8-4 hamming code，結果分三種討論:
>* 1
>
>一個間諜(一個說錯)，此時server端會知道誰是間諜，並且知道玩家們所選擇的圖片。
>![](https://i.imgur.com/xXA5fGK.png)
>
>(server端資訊)
>
>![](https://i.imgur.com/Y8vzM6O.png)
>(其餘玩家 & spy)
>
>* 2
>
>兩個間諜(兩個說錯)，server端能知道不只有一個犯人，但無法確定是誰，也無法得知玩家們所選擇的圖片。(表示我們設定題目和圖片上可能有瑕疵，造成玩家誤判/或者是玩家串通好。這個方面與遊戲進行所想要呈現的結果還要再討論)
>
>![](https://i.imgur.com/rTX5Mez.png)
>
>(server端資訊)
>
>![](https://i.imgur.com/tYSwqXO.png)
>
>(所有玩家端資訊)
>
>
>* 3
>
>都沒有間諜(沒有人說錯)，server端會知道玩家們之中沒有人說謊，並能知道玩家們所選擇的圖片。(表示我們設定題目和圖片上可能有瑕疵，造成玩家誤判/或者是玩家串通好。這個方面與遊戲進行所想要呈現的結果還要再討論)
>
>![](https://i.imgur.com/Ow3dcHu.png)
>
>(server端資訊)
>
>![](https://i.imgur.com/D5JnBog.png)
>
>(所有玩家端資訊)
---
### 程式碼簡介:
>間諜其實就是錯誤向量，以8-4 hamming code程式為底，syndrome來判斷間諜是誰，最後以根據玩家所回答的資料(codeword)經過decode讓server知道玩家所選圖表。
>
>程式主要分server和player，按鈕點擊出現圖片寫在player端，yes代表傳的值是0;no代表傳的值是1。
>
>遊戲流程判斷由server決定，server和玩家所溝通的部份兩邊都要寫。這次是用unity作為開發，其他設定也要配合c#程式碼。
>
>這次server和client之間傳遞訊息主要是靠以下介紹
>
>* SyncVar:
>server端的值會和clients同步，雙方保持一樣的值。(用來傳遞hamming code的bit)
>
>* Command :
>clients端叫用，server端執行，函式前要有Cmd辨識。(賦予輪到的玩家輸入值，也就是bit 1 or 0。 還有檢查玩家們的圖片是否一致。)

>* ClientRpc :
>server端叫用，client端執行，函式前要有Rpc辨識。
