## Simple clicker Windows Forms application

### In addition to the C# syntax, text box supports following commands:

* click(int x, int y) or left_click(int x, int y) - left click at coordinates
* right_click(int x, int y) - right click at coordinates
* mouse_move(int x, int y) - move cursor to position
* hold_left() - hold left mouse button
* release_left() - release left mouse button
* hold_right() - hold right mouse button
* release_right() - release right mouse button
* mouse_scroll(int delta) - scroll mouse wheel by delta
* press(string key) - press key
* hold(string key) - hold key
* release(string key) - release key
* await ms(int milliseconds) - wait milliseconds

### Supported keys:

* Latin letters (A-Z)
* Digits (0-9)
* F1 - F12
* Arrows:
	* LeftArrow or Left
	* UpArrow or Up
	* RightArrow or Right
	* DownArrow or Down
* Control buttons:
	* Escape or Esc
	* Tab
	* CapsLock
	* Shift
	* Control or Ctrl
	* Alt
	* Space or Spacebar
	* Enter
	* Backspace
	* Delete or Del
	* Insert or Ins
	* Home
	* End
	* PageUp or PgUp
	* PageDown or PgDown
	* LeftShift
	* RightShift
	* LeftControl or LeftCtrl
	* RightControl or RightCtrl
	* LeftAlt
	* RightAlt
	* LeftWindows or LeftWin
	* RightWindows or RightWin
	* Applications or App
* Special symbols:
	* Minus
	* Plus
	* OpenBracket
	* CloseBracket
	* Semicolon
	* Quote
	* Comma
	* Period
	* Dot
	* Slash
	* Backslash
	* Tilde
	* Grave

### Script example:

```
await ms(1000);
left_click(100,200);
hold("shift");
press("h");
release("shift");
press("e");
press("l");
press("l");
press("o");
press("space");
press("w");
press("o");
press("r");
press("l");
press("d");
hold("shift");
for (int i = 0; i < 3; i++)
{
  press("1");
}
release("shift");
press("ctrl", "a");
press("ctrl", "c");
press("right");
press("enter");
press("ctrl", "v");
press("enter");
press("ctrl", "v");
```