**原本以MATLAB語言完成PTU Contoller，但MATLAB產生的執行檔無法在沒有安裝MATLAB相關套件的電腦上執行，因此改用C#完成PTU Controller，只要是Windows作業系統都有內建.Net可以運行C#的執行檔。因此C#的GUI在功能上與MATLAB的GUI沒有太大不同。**
### Enveironment: Visual Studio 2013, Windows10 x64.
### **目前GUI功能**
1. 可由GUI直接找到IP並連線、斷線。  
2. 可由GUI指令位置轉至定點。  
3. 在GUI上可以看到範圍限制，若輸入超出範圍則不會動作，若輸入不為數字也不會動作。  
4. 可在移動時，從GUI上看到現在位置、速度。  
5. 能直接在GUI上定義轉台轉動範圍，讓使用者使用前先定義範圍，避免不小心輸入錯誤，使轉台超過環境的物理限制損壞。  
### **目前的名稱空間(namespace)**  
1. PTU  
### **目前Class與其屬性與方法**
1. PTUfinder  
    1. methods  
        1. GetLocalIP：抓本地端IP。  
        2. GetPTUIP：抓PTU的IP。  
2. PTUfunction  
    1. properties  
        1. ptu { get; private set; }：與PTU連線的套接字。  
        2. Pan_Resolution { get; private set; }：Pan的解析度。  
        3. Tilt_Resolution { get; private set; }：Tilt的解析度。  
        4. Pan_Minimum { get; private set; }：Pan的最小值。  
        5. Pan_Maximum { get; private set; }：Pan的最大值。  
        6. Tilt_Minimum { get; private set; }：Tilt的最小值。  
        7. Tilt_Maximum { get; private set; }：Tilt的最大值。  
    2. methods  
        1. Connect：連到PTU。  
        2. cmd：在C#裡也可與teraterm一樣的下指令。  
        3. Initialize：在C#內要能與PTU正常通訊需要先初始化。  
        4. TrimReply：從PTU收到的訊息，刪除前後不必要的資訊{‘ ’, ‘*’, ‘\n’, ‘\r’}。  
        5. PTResolution：得知PTU的解析度(unit : degree)。  
        6. PTLimit：得知PTU的轉動範圍(unit ： PTLimit)。  
        7. deg2pos：degree轉為PTU內部單位position。  
        8. gotoPT：轉至指定角度。  
        9. getPS：得到當前的位置與速度。  
        10. SetUserLimit：使用者定義範圍。  
        11. Close：關閉Socket。  
