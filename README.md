# Mp4BoxSplitter


Mp4BoxSplitter uses Mp4Box.exe to fast split without reencoding (only on frames).
It uses WindowsMediaPlayer control to play video.
It is a WinForms application written in C# and .Net 4.6.1

![snap01](https://user-images.githubusercontent.com/31509965/38378333-a3b0cca0-38fd-11e8-9945-806a2f1ede9e.jpg)

Use Scenario

1. File -  open mp4 file
		it is possible to Drag and drop file into textbox
		or type or Paste FileName into TextBox and press Enter
		It automaticly plays the video.
2. click "Start time" to set Start time
3. click "End time" to set End time
		the time is in seconds
		it is possible to manually correct the time
4. click Cut+Save to cut and save 
		it will be saved in the same folder as the original
		with the suffix of the start and end time.
5. read results of mp4Box processing
6. click Explore to open folder



Other

PlayPart - plays video between Start and End time
from -10s to +10s  -  moves position x seconds backward or forward
Start, End - moves to start or End
II - pause
+f  - moves one frame forward. 
		It is not possible with this control to move one frame backward.


TODO

Error handling is completely absent.


By Luciano 5.4.2018
