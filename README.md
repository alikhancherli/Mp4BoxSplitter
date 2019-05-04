# Mp4BoxSplitter


Mp4BoxSplitter uses Mp4Box.exe to fast split without reencoding (cuts only on frames).<br/>
It uses WindowsMediaPlayer control to play video.<br/>
It is a WinForms application written in C# and .Net 4.6.1<br/>

![snap01](https://user-images.githubusercontent.com/31509965/38378333-a3b0cca0-38fd-11e8-9945-806a2f1ede9e.jpg)

Use Scenario<br/>

1. File -  open mp4 file<br/>
    it is possible to Drag and drop file into textbox<br/>
    or type or Paste FileName into TextBox and press Enter<br/>
    It automatically plays the video.<br/>
2. click "Start time" to set Start time<br/>
3. click "End time" to set End time<br/>
    the time is in seconds<br/>
    it is possible to manually correct the time<br/>
4. click Cut+Save to cut and save <br/>
    it will be saved in the same folder as the original<br/>
    with the suffix of the start and end time.<br/>
5. read results of mp4Box processing<br/>
6. click Folder to open folder<br/>
<br/>
<br/>
Other<br/>

PlayPart - plays video between Start and End time<br/>
from -10s to +10s  -  moves position x seconds backward or forward<br/>
Start, End - moves to start or End<br/>
II - pause<br/>
+f  - moves one frame forward. <br/>
    It is not possible with this control to move one frame backward.<br/>

<br/>
TODO<br/>

Error handling is completely absent.<br/>


By Luciano 5.4.2018
