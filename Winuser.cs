using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsphodelusNative;

/// <summary>
/// WINUSER.h
/// </summary>
unsafe public static partial class WINUSER {

	/// <summary>
	/// CALLBACK <b>LRESULT WndProc (HWND, UINT, WPARAM, LPARAM)</b><br/>
	/// WINUSER.h
	/// </summary>
	/// <param name="hWnd"><b>HWND</b></param>
	/// <param name="uMsg"><b>UINT</b></param>
	/// <param name="wParam"><b>WPARAM</b></param>
	/// <param name="lParam"><b>LPARAM</b></param>
	public delegate nuint WndProc (IntPtr hWnd, uint uMsg, nuint wParam, nuint lParam);

	#region Message Function Templates

	/// <summary>
	/// <b>Window Messages</b><br/>
	/// WINUSER.h
	/// </summary>
	public enum WindowMessage : uint {
		/// <summary>
		/// <b>#define WM_NULL 0x0000</b>
		/// </summary>
		Null = 0x0000,
		/// <summary>
		/// <b>#define WM_CREATE 0x0001</b>
		/// </summary>
		Create = 0x0001,
		/// <summary>
		/// <b>#define WM_DESTROY 0x0002</b>
		/// </summary>
		Destroy = 0x0002,
		/// <summary>
		/// <b>#define WM_MOVE 0x0003</b>
		/// </summary>
		Move = 0x0003,
		/// <summary>
		/// <b>#define WM_SIZE 0x0005</b>
		/// </summary>
		Size = 0x0005,
		/// <summary>
		/// <b>#define WM_ACTIVATE 0x0006</b>
		/// </summary>
		Activate = 0x0006,
		/// <summary>
		/// <b>#define WM_SETFOCUS 0x0007</b>
		/// </summary>
		Setfocus = 0x0007,
		/// <summary>
		/// <b>#define WM_KILLFOCUS 0x0008</b>
		/// </summary>
		Killfocus = 0x0008,
		/// <summary>
		/// <b>#define WM_ENABLE 0x000A</b>
		/// </summary>
		Enable = 0x000A,
		/// <summary>
		/// <b>#define WM_SETREDRAW 0x000B</b>
		/// </summary>
		Setredraw = 0x000B,
		/// <summary>
		/// <b>#define WM_SETTEXT 0x000C</b>
		/// </summary>
		Settext = 0x000C,
		/// <summary>
		/// <b>#define WM_GETTEXT 0x000D</b>
		/// </summary>
		Gettext = 0x000D,
		/// <summary>
		/// <b>#define WM_GETTEXTLENGTH 0x000E</b>
		/// </summary>
		Gettextlength = 0x000E,
		/// <summary>
		/// <b>#define WM_PAINT 0x000F</b>
		/// </summary>
		Paint = 0x000F,
		/// <summary>
		/// <b>#define WM_CLOSE 0x0010</b>
		/// </summary>
		Close = 0x0010,
		/// <summary>
		/// <b>#define WM_QUERYENDSESSION 0x0011</b>
		/// </summary>
		Queryendsession = 0x0011,
		/// <summary>
		/// <b>#define WM_QUERYOPEN 0x0013</b>
		/// </summary>
		Queryopen = 0x0013,
		/// <summary>
		/// <b>#define WM_ENDSESSION 0x0016</b>
		/// </summary>
		Endsession = 0x0016,
		/// <summary>
		/// <b>#define WM_QUIT 0x0012</b>
		/// </summary>
		Quit = 0x0012,
		/// <summary>
		/// <b>#define WM_ERASEBKGND 0x0014</b>
		/// </summary>
		Erasebkgnd = 0x0014,
		/// <summary>
		/// <b>#define WM_SYSCOLORCHANGE 0x0015</b>
		/// </summary>
		Syscolorchange = 0x0015,
		/// <summary>
		/// <b>#define WM_SHOWWINDOW 0x0018</b>
		/// </summary>
		Showwindow = 0x0018,
		/// <summary>
		/// <b>#define WM_WININICHANGE 0x001A</b>
		/// </summary>
		Wininichange = 0x001A,
		/// <summary>
		/// <b>#define WM_SETTINGCHANGE WM_WININICHANGE</b>
		/// </summary>
		Settingchange = Wininichange,
		/// <summary>
		/// <b>#define WM_DEVMODECHANGE 0x001B</b>
		/// </summary>
		Devmodechange = 0x001B,
		/// <summary>
		/// <b>#define WM_ACTIVATEAPP 0x001C</b>
		/// </summary>
		Activateapp = 0x001C,
		/// <summary>
		/// <b>#define WM_FONTCHANGE 0x001D</b>
		/// </summary>
		Fontchange = 0x001D,
		/// <summary>
		/// <b>#define WM_TIMECHANGE 0x001E</b>
		/// </summary>
		Timechange = 0x001E,
		/// <summary>
		/// <b>#define WM_CANCELMODE 0x001F</b>
		/// </summary>
		Cancelmode = 0x001F,
		/// <summary>
		/// <b>#define WM_SETCURSOR 0x0020</b>
		/// </summary>
		Setcursor = 0x0020,
		/// <summary>
		/// <b>#define WM_MOUSEACTIVATE 0x0021</b>
		/// </summary>
		Mouseactivate = 0x0021,
		/// <summary>
		/// <b>#define WM_CHILDACTIVATE 0x0022</b>
		/// </summary>
		Childactivate = 0x0022,
		/// <summary>
		/// <b>#define WM_QUEUESYNC 0x0023</b>
		/// </summary>
		Queuesync = 0x0023,
		/// <summary>
		/// <b>#define WM_GETMINMAXINFO 0x0024</b>
		/// </summary>
		Getminmaxinfo = 0x0024,
		/// <summary>
		/// <b>#define WM_PAINTICON 0x0026</b>
		/// </summary>
		Painticon = 0x0026,
		/// <summary>
		/// <b>#define WM_ICONERASEBKGND 0x0027</b>
		/// </summary>
		Iconerasebkgnd = 0x0027,
		/// <summary>
		/// <b>#define WM_NEXTDLGCTL 0x0028</b>
		/// </summary>
		Nextdlgctl = 0x0028,
		/// <summary>
		/// <b>#define WM_SPOOLERSTATUS 0x002A</b>
		/// </summary>
		Spoolerstatus = 0x002A,
		/// <summary>
		/// <b>#define WM_DRAWITEM 0x002B</b>
		/// </summary>
		Drawitem = 0x002B,
		/// <summary>
		/// <b>#define WM_MEASUREITEM 0x002C</b>
		/// </summary>
		Measureitem = 0x002C,
		/// <summary>
		/// <b>#define WM_DELETEITEM 0x002D</b>
		/// </summary>
		Deleteitem = 0x002D,
		/// <summary>
		/// <b>#define WM_VKEYTOITEM 0x002E</b>
		/// </summary>
		Vkeytoitem = 0x002E,
		/// <summary>
		/// <b>#define WM_CHARTOITEM 0x002F</b>
		/// </summary>
		Chartoitem = 0x002F,
		/// <summary>
		/// <b>#define WM_SETFONT 0x0030</b>
		/// </summary>
		Setfont = 0x0030,
		/// <summary>
		/// <b>#define WM_GETFONT 0x0031</b>
		/// </summary>
		Getfont = 0x0031,
		/// <summary>
		/// <b>#define WM_SETHOTKEY 0x0032</b>
		/// </summary>
		Sethotkey = 0x0032,
		/// <summary>
		/// <b>#define WM_GETHOTKEY 0x0033</b>
		/// </summary>
		Gethotkey = 0x0033,
		/// <summary>
		/// <b>#define WM_QUERYDRAGICON 0x0037</b>
		/// </summary>
		Querydragicon = 0x0037,
		/// <summary>
		/// <b>#define WM_COMPAREITEM 0x0039</b>
		/// </summary>
		Compareitem = 0x0039,
		/// <summary>
		/// <b>#define WM_GETOBJECT 0x003D</b>
		/// </summary>
		Getobject = 0x003D,
		/// <summary>
		/// <b>#define WM_COMPACTING 0x0041</b>
		/// </summary>
		Compacting = 0x0041,
		/// <summary>
		/// <b>#define WM_COMMNOTIFY 0x0044</b>
		/// </summary>
		Commnotify = 0x0044,
		/// <summary>
		/// <b>#define WM_WINDOWPOSCHANGING 0x0046</b>
		/// </summary>
		Windowposchanging = 0x0046,
		/// <summary>
		/// <b>#define WM_WINDOWPOSCHANGED 0x0047</b>
		/// </summary>
		Windowposchanged = 0x0047,
		/// <summary>
		/// <b>#define WM_POWER 0x0048</b>
		/// </summary>
		Power = 0x0048,
		/// <summary>
		/// <b>#define WM_COPYDATA 0x004A</b>
		/// </summary>
		Copydata = 0x004A,
		/// <summary>
		/// <b>#define WM_CANCELJOURNAL 0x004B</b>
		/// </summary>
		Canceljournal = 0x004B,
		/// <summary>
		/// <b>#define WM_NOTIFY 0x004E</b>
		/// </summary>
		Notify = 0x004E,
		/// <summary>
		/// <b>#define WM_INPUTLANGCHANGEREQUEST 0x0050</b>
		/// </summary>
		Inputlangchangerequest = 0x0050,
		/// <summary>
		/// <b>#define WM_INPUTLANGCHANGE 0x0051</b>
		/// </summary>
		Inputlangchange = 0x0051,
		/// <summary>
		/// <b>#define WM_TCARD 0x0052</b>
		/// </summary>
		Tcard = 0x0052,
		/// <summary>
		/// <b>#define WM_HELP 0x0053</b>
		/// </summary>
		Help = 0x0053,
		/// <summary>
		/// <b>#define WM_USERCHANGED 0x0054</b>
		/// </summary>
		Userchanged = 0x0054,
		/// <summary>
		/// <b>#define WM_NOTIFYFORMAT 0x0055</b>
		/// </summary>
		Notifyformat = 0x0055,
		/// <summary>
		/// <b>#define WM_CONTEXTMENU 0x007B</b>
		/// </summary>
		Contextmenu = 0x007B,
		/// <summary>
		/// <b>#define WM_STYLECHANGING 0x007C</b>
		/// </summary>
		Stylechanging = 0x007C,
		/// <summary>
		/// <b>#define WM_STYLECHANGED 0x007D</b>
		/// </summary>
		Stylechanged = 0x007D,
		/// <summary>
		/// <b>#define WM_DISPLAYCHANGE 0x007E</b>
		/// </summary>
		Displaychange = 0x007E,
		/// <summary>
		/// <b>#define WM_GETICON 0x007F</b>
		/// </summary>
		Geticon = 0x007F,
		/// <summary>
		/// <b>#define WM_SETICON 0x0080</b>
		/// </summary>
		Seticon = 0x0080,
		/// <summary>
		/// <b>#define WM_NCCREATE 0x0081</b>
		/// </summary>
		Nccreate = 0x0081,
		/// <summary>
		/// <b>#define WM_NCDESTROY 0x0082</b>
		/// </summary>
		Ncdestroy = 0x0082,
		/// <summary>
		/// <b>#define WM_NCCALCSIZE 0x0083</b>
		/// </summary>
		Nccalcsize = 0x0083,
		/// <summary>
		/// <b>#define WM_NCHITTEST 0x0084</b>
		/// </summary>
		Nchittest = 0x0084,
		/// <summary>
		/// <b>#define WM_NCPAINT 0x0085</b>
		/// </summary>
		Ncpaint = 0x0085,
		/// <summary>
		/// <b>#define WM_NCACTIVATE 0x0086</b>
		/// </summary>
		Ncactivate = 0x0086,
		/// <summary>
		/// <b>#define WM_GETDLGCODE 0x0087</b>
		/// </summary>
		Getdlgcode = 0x0087,
		/// <summary>
		/// <b>#define WM_SYNCPAINT 0x0088</b>
		/// </summary>
		Syncpaint = 0x0088,
		/// <summary>
		/// <b>#define WM_NCMOUSEMOVE 0x00A0</b>
		/// </summary>
		Ncmousemove = 0x00A0,
		/// <summary>
		/// <b>#define WM_NCLBUTTONDOWN 0x00A1</b>
		/// </summary>
		Nclbuttondown = 0x00A1,
		/// <summary>
		/// <b>#define WM_NCLBUTTONUP 0x00A2</b>
		/// </summary>
		Nclbuttonup = 0x00A2,
		/// <summary>
		/// <b>#define WM_NCLBUTTONDBLCLK 0x00A3</b>
		/// </summary>
		Nclbuttondblclk = 0x00A3,
		/// <summary>
		/// <b>#define WM_NCRBUTTONDOWN 0x00A4</b>
		/// </summary>
		Ncrbuttondown = 0x00A4,
		/// <summary>
		/// <b>#define WM_NCRBUTTONUP 0x00A5</b>
		/// </summary>
		Ncrbuttonup = 0x00A5,
		/// <summary>
		/// <b>#define WM_NCRBUTTONDBLCLK 0x00A6</b>
		/// </summary>
		Ncrbuttondblclk = 0x00A6,
		/// <summary>
		/// <b>#define WM_NCMBUTTONDOWN 0x00A7</b>
		/// </summary>
		Ncmbuttondown = 0x00A7,
		/// <summary>
		/// <b>#define WM_NCMBUTTONUP 0x00A8</b>
		/// </summary>
		Ncmbuttonup = 0x00A8,
		/// <summary>
		/// <b>#define WM_NCMBUTTONDBLCLK 0x00A9</b>
		/// </summary>
		Ncmbuttondblclk = 0x00A9,
		/// <summary>
		/// <b>#define WM_NCXBUTTONDOWN 0x00AB</b>
		/// </summary>
		Ncxbuttondown = 0x00AB,
		/// <summary>
		/// <b>#define WM_NCXBUTTONUP 0x00AC</b>
		/// </summary>
		Ncxbuttonup = 0x00AC,
		/// <summary>
		/// <b>#define WM_NCXBUTTONDBLCLK 0x00AD</b>
		/// </summary>
		Ncxbuttondblclk = 0x00AD,
		/// <summary>
		/// <b>#define WM_INPUT_DEVICE_CHANGE 0x00FE</b>
		/// </summary>
		Input_device_change = 0x00FE,
		/// <summary>
		/// <b>#define WM_INPUT 0x00FF</b>
		/// </summary>
		Input = 0x00FF,
		/// <summary>
		/// <b>#define WM_KEYFIRST 0x0100</b>
		/// </summary>
		Keyfirst = 0x0100,
		/// <summary>
		/// <b>#define WM_KEYDOWN 0x0100</b>
		/// </summary>
		Keydown = 0x0100,
		/// <summary>
		/// <b>#define WM_KEYUP 0x0101</b>
		/// </summary>
		Keyup = 0x0101,
		/// <summary>
		/// <b>#define WM_CHAR 0x0102</b>
		/// </summary>
		Char = 0x0102,
		/// <summary>
		/// <b>#define WM_DEADCHAR 0x0103</b>
		/// </summary>
		Deadchar = 0x0103,
		/// <summary>
		/// <b>#define WM_SYSKEYDOWN 0x0104</b>
		/// </summary>
		Syskeydown = 0x0104,
		/// <summary>
		/// <b>#define WM_SYSKEYUP 0x0105</b>
		/// </summary>
		Syskeyup = 0x0105,
		/// <summary>
		/// <b>#define WM_SYSCHAR 0x0106</b>
		/// </summary>
		Syschar = 0x0106,
		/// <summary>
		/// <b>#define WM_SYSDEADCHAR 0x0107</b>
		/// </summary>
		Sysdeadchar = 0x0107,
		/// <summary>
		/// <b>#define WM_UNICHAR 0x0109</b> (_WIN32_WINNT >= 0x0501)
		/// </summary>
		Unichar = 0x0109,
		/// <summary>
		/// <b>#define WM_KEYLAST 0x0109</b> (_WIN32_WINNT >= 0x0501)
		/// </summary>
		Keylast = 0x0109,
		/// <summary>
		/// <b>#define WM_IME_STARTCOMPOSITION 0x010D</b>
		/// </summary>
		Ime_startcomposition = 0x010D,
		/// <summary>
		/// <b>#define WM_IME_ENDCOMPOSITION 0x010E</b>
		/// </summary>
		Ime_endcomposition = 0x010E,
		/// <summary>
		/// <b>#define WM_IME_COMPOSITION 0x010F</b>
		/// </summary>
		Ime_composition = 0x010F,
		/// <summary>
		/// <b>#define WM_IME_KEYLAST 0x010F</b>
		/// </summary>
		Ime_keylast = 0x010F,
		/// <summary>
		/// <b>#define WM_INITDIALOG 0x0110</b>
		/// </summary>
		Initdialog = 0x0110,
		/// <summary>
		/// <b>#define WM_COMMAND 0x0111</b>
		/// </summary>
		Command = 0x0111,
		/// <summary>
		/// <b>#define WM_SYSCOMMAND 0x0112</b>
		/// </summary>
		Syscommand = 0x0112,
		/// <summary>
		/// <b>#define WM_TIMER 0x0113</b>
		/// </summary>
		Timer = 0x0113,
		/// <summary>
		/// <b>#define WM_HSCROLL 0x0114</b>
		/// </summary>
		Hscroll = 0x0114,
		/// <summary>
		/// <b>#define WM_VSCROLL 0x0115</b>
		/// </summary>
		Vscroll = 0x0115,
		/// <summary>
		/// <b>#define WM_INITMENU 0x0116</b>
		/// </summary>
		Initmenu = 0x0116,
		/// <summary>
		/// <b>#define WM_INITMENUPOPUP 0x0117</b>
		/// </summary>
		Initmenupopup = 0x0117,
		/// <summary>
		/// <b>#define WM_GESTURE 0x0119</b>
		/// </summary>
		Gesture = 0x0119,
		/// <summary>
		/// <b>#define WM_GESTURENOTIFY 0x011A</b>
		/// </summary>
		Gesturenotify = 0x011A,
		/// <summary>
		/// <b>#define WM_MENUSELECT 0x011F</b>
		/// </summary>
		Menuselect = 0x011F,
		/// <summary>
		/// <b>#define WM_MENUCHAR 0x0120</b>
		/// </summary>
		Menuchar = 0x0120,
		/// <summary>
		/// <b>#define WM_ENTERIDLE 0x0121</b>
		/// </summary>
		Enteridle = 0x0121,
		/// <summary>
		/// <b>#define WM_MENURBUTTONUP 0x0122</b>
		/// </summary>
		Menurbuttonup = 0x0122,
		/// <summary>
		/// <b>#define WM_MENUDRAG 0x0123</b>
		/// </summary>
		Menudrag = 0x0123,
		/// <summary>
		/// <b>#define WM_MENUGETOBJECT 0x0124</b>
		/// </summary>
		Menugetobject = 0x0124,
		/// <summary>
		/// <b>#define WM_UNINITMENUPOPUP 0x0125</b>
		/// </summary>
		Uninitmenupopup = 0x0125,
		/// <summary>
		/// <b>#define WM_MENUCOMMAND 0x0126</b>
		/// </summary>
		Menucommand = 0x0126,
		/// <summary>
		/// <b>#define WM_CHANGEUISTATE 0x0127</b>
		/// </summary>
		Changeuistate = 0x0127,
		/// <summary>
		/// <b>#define WM_UPDATEUISTATE 0x0128</b>
		/// </summary>
		Updateuistate = 0x0128,
		/// <summary>
		/// <b>#define WM_QUERYUISTATE 0x0129</b>
		/// </summary>
		Queryuistate = 0x0129,
		/// <summary>
		/// <b>#define WM_CTLCOLORMSGBOX 0x0132</b>
		/// </summary>
		Ctlcolormsgbox = 0x0132,
		/// <summary>
		/// <b>#define WM_CTLCOLOREDIT 0x0133</b>
		/// </summary>
		Ctlcoloredit = 0x0133,
		/// <summary>
		/// <b>#define WM_CTLCOLORLISTBOX 0x0134</b>
		/// </summary>
		Ctlcolorlistbox = 0x0134,
		/// <summary>
		/// <b>#define WM_CTLCOLORBTN 0x0135</b>
		/// </summary>
		Ctlcolorbtn = 0x0135,
		/// <summary>
		/// <b>#define WM_CTLCOLORDLG 0x0136</b>
		/// </summary>
		Ctlcolordlg = 0x0136,
		/// <summary>
		/// <b>#define WM_CTLCOLORSCROLLBAR 0x0137</b>
		/// </summary>
		Ctlcolorscrollbar = 0x0137,
		/// <summary>
		/// <b>#define WM_CTLCOLORSTATIC 0x0138</b>
		/// </summary>
		Ctlcolorstatic = 0x0138,
		/// <summary>
		/// <b>#define WM_MOUSEFIRST 0x0200</b>
		/// </summary>
		Mousefirst = 0x0200,
		/// <summary>
		/// <b>#define WM_MOUSEMOVE 0x0200</b>
		/// </summary>
		Mousemove = 0x0200,
		/// <summary>
		/// <b>#define WM_LBUTTONDOWN 0x0201</b>
		/// </summary>
		Lbuttondown = 0x0201,
		/// <summary>
		/// <b>#define WM_LBUTTONUP 0x0202</b>
		/// </summary>
		Lbuttonup = 0x0202,
		/// <summary>
		/// <b>#define WM_LBUTTONDBLCLK 0x0203</b>
		/// </summary>
		Lbuttondblclk = 0x0203,
		/// <summary>
		/// <b>#define WM_RBUTTONDOWN 0x0204</b>
		/// </summary>
		Rbuttondown = 0x0204,
		/// <summary>
		/// <b>#define WM_RBUTTONUP 0x0205</b>
		/// </summary>
		Rbuttonup = 0x0205,
		/// <summary>
		/// <b>#define WM_RBUTTONDBLCLK 0x0206</b>
		/// </summary>
		Rbuttondblclk = 0x0206,
		/// <summary>
		/// <b>#define WM_MBUTTONDOWN 0x0207</b>
		/// </summary>
		Mbuttondown = 0x0207,
		/// <summary>
		/// <b>#define WM_MBUTTONUP 0x0208</b>
		/// </summary>
		Mbuttonup = 0x0208,
		/// <summary>
		/// <b>#define WM_MBUTTONDBLCLK 0x0209</b>
		/// </summary>
		Mbuttondblclk = 0x0209,
		/// <summary>
		/// <b>#define WM_MOUSEWHEEL 0x020A</b>
		/// </summary>
		Mousewheel = 0x020A,
		/// <summary>
		/// <b>#define WM_XBUTTONDOWN 0x020B</b>
		/// </summary>
		Xbuttondown = 0x020B,
		/// <summary>
		/// <b>#define WM_XBUTTONUP 0x020C</b>
		/// </summary>
		Xbuttonup = 0x020C,
		/// <summary>
		/// <b>#define WM_XBUTTONDBLCLK 0x020D</b>
		/// </summary>
		Xbuttondblclk = 0x020D,
		/// <summary>
		/// <b>#define WM_MOUSEHWHEEL 0x020E</b>
		/// </summary>
		Mousehwheel = 0x020E,
		/// <summary>
		/// <b>#define WM_MOUSELAST 0x020E</b> (_WIN32_WINNT >= 0x0600)
		/// </summary>
		Mouselast = 0x020E,
		/// <summary>
		/// <b>#define WM_PARENTNOTIFY 0x0210</b>
		/// </summary>
		Parentnotify = 0x0210,
		/// <summary>
		/// <b>#define WM_ENTERMENULOOP 0x0211</b>
		/// </summary>
		Entermenuloop = 0x0211,
		/// <summary>
		/// <b>#define WM_EXITMENULOOP 0x0212</b>
		/// </summary>
		Exitmenuloop = 0x0212,
		/// <summary>
		/// <b>#define WM_NEXTMENU 0x0213</b>
		/// </summary>
		Nextmenu = 0x0213,
		/// <summary>
		/// <b>#define WM_SIZING 0x0214</b>
		/// </summary>
		Sizing = 0x0214,
		/// <summary>
		/// <b>#define WM_CAPTURECHANGED 0x0215</b>
		/// </summary>
		Capturechanged = 0x0215,
		/// <summary>
		/// <b>#define WM_MOVING 0x0216</b>
		/// </summary>
		Moving = 0x0216,
		/// <summary>
		/// <b>#define WM_POWERBROADCAST 0x0218</b>
		/// </summary>
		Powerbroadcast = 0x0218,
		/// <summary>
		/// <b>#define WM_DEVICECHANGE 0x0219</b>
		/// </summary>
		Devicechange = 0x0219,
		/// <summary>
		/// <b>#define WM_MDICREATE 0x0220</b>
		/// </summary>
		Mdicreate = 0x0220,
		/// <summary>
		/// <b>#define WM_MDIDESTROY 0x0221</b>
		/// </summary>
		Mdidestroy = 0x0221,
		/// <summary>
		/// <b>#define WM_MDIACTIVATE 0x0222</b>
		/// </summary>
		Mdiactivate = 0x0222,
		/// <summary>
		/// <b>#define WM_MDIRESTORE 0x0223</b>
		/// </summary>
		Mdirestore = 0x0223,
		/// <summary>
		/// <b>#define WM_MDINEXT 0x0224</b>
		/// </summary>
		Mdinext = 0x0224,
		/// <summary>
		/// <b>#define WM_MDIMAXIMIZE 0x0225</b>
		/// </summary>
		Mdimaximize = 0x0225,
		/// <summary>
		/// <b>#define WM_MDITILE 0x0226</b>
		/// </summary>
		Mditile = 0x0226,
		/// <summary>
		/// <b>#define WM_MDICASCADE 0x0227</b>
		/// </summary>
		Mdicascade = 0x0227,
		/// <summary>
		/// <b>#define WM_MDIICONARRANGE 0x0228</b>
		/// </summary>
		Mdiiconarrange = 0x0228,
		/// <summary>
		/// <b>#define WM_MDIGETACTIVE 0x0229</b>
		/// </summary>
		Mdigetactive = 0x0229,
		/// <summary>
		/// <b>#define WM_MDISETMENU 0x0230</b>
		/// </summary>
		Mdisetmenu = 0x0230,
		/// <summary>
		/// <b>#define WM_ENTERSIZEMOVE 0x0231</b>
		/// </summary>
		Entersizemove = 0x0231,
		/// <summary>
		/// <b>#define WM_EXITSIZEMOVE 0x0232</b>
		/// </summary>
		Exitsizemove = 0x0232,
		/// <summary>
		/// <b>#define WM_DROPFILES 0x0233</b>
		/// </summary>
		Dropfiles = 0x0233,
		/// <summary>
		/// <b>#define WM_MDIREFRESHMENU 0x0234</b>
		/// </summary>
		Mdirefreshmenu = 0x0234,
		/// <summary>
		/// <b>#define WM_POINTERDEVICECHANGE 0x238</b>
		/// </summary>
		Pointerdevicechange = 0x238,
		/// <summary>
		/// <b>#define WM_POINTERDEVICEINRANGE 0x239</b>
		/// </summary>
		Pointerdeviceinrange = 0x239,
		/// <summary>
		/// <b>#define WM_POINTERDEVICEOUTOFRANGE 0x23A</b>
		/// </summary>
		Pointerdeviceoutofrange = 0x23A,
		/// <summary>
		/// <b>#define WM_TOUCH 0x0240</b>
		/// </summary>
		Touch = 0x0240,
		/// <summary>
		/// <b>#define WM_NCPOINTERUPDATE 0x0241</b>
		/// </summary>
		Ncpointerupdate = 0x0241,
		/// <summary>
		/// <b>#define WM_NCPOINTERDOWN 0x0242</b>
		/// </summary>
		Ncpointerdown = 0x0242,
		/// <summary>
		/// <b>#define WM_NCPOINTERUP 0x0243</b>
		/// </summary>
		Ncpointerup = 0x0243,
		/// <summary>
		/// <b>#define WM_POINTERUPDATE 0x0245</b>
		/// </summary>
		Pointerupdate = 0x0245,
		/// <summary>
		/// <b>#define WM_POINTERDOWN 0x0246</b>
		/// </summary>
		Pointerdown = 0x0246,
		/// <summary>
		/// <b>#define WM_POINTERUP 0x0247</b>
		/// </summary>
		Pointerup = 0x0247,
		/// <summary>
		/// <b>#define WM_POINTERENTER 0x0249</b>
		/// </summary>
		Pointerenter = 0x0249,
		/// <summary>
		/// <b>#define WM_POINTERLEAVE 0x024A</b>
		/// </summary>
		Pointerleave = 0x024A,
		/// <summary>
		/// <b>#define WM_POINTERACTIVATE 0x024B</b>
		/// </summary>
		Pointeractivate = 0x024B,
		/// <summary>
		/// <b>#define WM_POINTERCAPTURECHANGED 0x024C</b>
		/// </summary>
		Pointercapturechanged = 0x024C,
		/// <summary>
		/// <b>#define WM_TOUCHHITTESTING 0x024D</b>
		/// </summary>
		Touchhittesting = 0x024D,
		/// <summary>
		/// <b>#define WM_POINTERWHEEL 0x024E</b>
		/// </summary>
		Pointerwheel = 0x024E,
		/// <summary>
		/// <b>#define WM_POINTERHWHEEL 0x024F</b>
		/// </summary>
		Pointerhwheel = 0x024F,
		/// <summary>
		/// <b>#define WM_POINTERROUTEDTO 0x0251</b>
		/// </summary>
		Pointerroutedto = 0x0251,
		/// <summary>
		/// <b>#define WM_POINTERROUTEDAWAY 0x0252</b>
		/// </summary>
		Pointerroutedaway = 0x0252,
		/// <summary>
		/// <b>#define WM_POINTERROUTEDRELEASED 0x0253</b>
		/// </summary>
		Pointerroutedreleased = 0x0253,
		/// <summary>
		/// <b>#define WM_IME_SETCONTEXT 0x0281</b>
		/// </summary>
		Ime_setcontext = 0x0281,
		/// <summary>
		/// <b>#define WM_IME_NOTIFY 0x0282</b>
		/// </summary>
		Ime_notify = 0x0282,
		/// <summary>
		/// <b>#define WM_IME_CONTROL 0x0283</b>
		/// </summary>
		Ime_control = 0x0283,
		/// <summary>
		/// <b>#define WM_IME_COMPOSITIONFULL 0x0284</b>
		/// </summary>
		Ime_compositionfull = 0x0284,
		/// <summary>
		/// <b>#define WM_IME_SELECT 0x0285</b>
		/// </summary>
		Ime_select = 0x0285,
		/// <summary>
		/// <b>#define WM_IME_CHAR 0x0286</b>
		/// </summary>
		Ime_char = 0x0286,
		/// <summary>
		/// <b>#define WM_IME_REQUEST 0x0288</b>
		/// </summary>
		Ime_request = 0x0288,
		/// <summary>
		/// <b>#define WM_IME_KEYDOWN 0x0290</b>
		/// </summary>
		Ime_keydown = 0x0290,
		/// <summary>
		/// <b>#define WM_IME_KEYUP 0x0291</b>
		/// </summary>
		Ime_keyup = 0x0291,
		/// <summary>
		/// <b>#define WM_MOUSEHOVER 0x02A1</b>
		/// </summary>
		Mousehover = 0x02A1,
		/// <summary>
		/// <b>#define WM_MOUSELEAVE 0x02A3</b>
		/// </summary>
		Mouseleave = 0x02A3,
		/// <summary>
		/// <b>#define WM_NCMOUSEHOVER 0x02A0</b>
		/// </summary>
		Ncmousehover = 0x02A0,
		/// <summary>
		/// <b>#define WM_NCMOUSELEAVE 0x02A2</b>
		/// </summary>
		Ncmouseleave = 0x02A2,
		/// <summary>
		/// <b>#define WM_WTSSESSION_CHANGE 0x02B1</b>
		/// </summary>
		Wtssession_change = 0x02B1,
		/// <summary>
		/// <b>#define WM_TABLET_FIRST 0x02c0</b>
		/// </summary>
		Tablet_first = 0x02c0,
		/// <summary>
		/// <b>#define WM_TABLET_LAST 0x02df</b>
		/// </summary>
		Tablet_last = 0x02df,
		/// <summary>
		/// <b>#define WM_DPICHANGED 0x02E0</b>
		/// </summary>
		Dpichanged = 0x02E0,
		/// <summary>
		/// <b>#define WM_DPICHANGED_BEFOREPARENT 0x02E2</b>
		/// </summary>
		Dpichanged_beforeparent = 0x02E2,
		/// <summary>
		/// <b>#define WM_DPICHANGED_AFTERPARENT 0x02E3</b>
		/// </summary>
		Dpichanged_afterparent = 0x02E3,
		/// <summary>
		/// <b>#define WM_GETDPISCALEDSIZE 0x02E4</b>
		/// </summary>
		Getdpiscaledsize = 0x02E4,
		/// <summary>
		/// <b>#define WM_CUT 0x0300</b>
		/// </summary>
		Cut = 0x0300,
		/// <summary>
		/// <b>#define WM_COPY 0x0301</b>
		/// </summary>
		Copy = 0x0301,
		/// <summary>
		/// <b>#define WM_PASTE 0x0302</b>
		/// </summary>
		Paste = 0x0302,
		/// <summary>
		/// <b>#define WM_CLEAR 0x0303</b>
		/// </summary>
		Clear = 0x0303,
		/// <summary>
		/// <b>#define WM_UNDO 0x0304</b>
		/// </summary>
		Undo = 0x0304,
		/// <summary>
		/// <b>#define WM_RENDERFORMAT 0x0305</b>
		/// </summary>
		Renderformat = 0x0305,
		/// <summary>
		/// <b>#define WM_RENDERALLFORMATS 0x0306</b>
		/// </summary>
		Renderallformats = 0x0306,
		/// <summary>
		/// <b>#define WM_DESTROYCLIPBOARD 0x0307</b>
		/// </summary>
		Destroyclipboard = 0x0307,
		/// <summary>
		/// <b>#define WM_DRAWCLIPBOARD 0x0308</b>
		/// </summary>
		Drawclipboard = 0x0308,
		/// <summary>
		/// <b>#define WM_PAINTCLIPBOARD 0x0309</b>
		/// </summary>
		Paintclipboard = 0x0309,
		/// <summary>
		/// <b>#define WM_VSCROLLCLIPBOARD 0x030A</b>
		/// </summary>
		Vscrollclipboard = 0x030A,
		/// <summary>
		/// <b>#define WM_SIZECLIPBOARD 0x030B</b>
		/// </summary>
		Sizeclipboard = 0x030B,
		/// <summary>
		/// <b>#define WM_ASKCBFORMATNAME 0x030C</b>
		/// </summary>
		Askcbformatname = 0x030C,
		/// <summary>
		/// <b>#define WM_CHANGECBCHAIN 0x030D</b>
		/// </summary>
		Changecbchain = 0x030D,
		/// <summary>
		/// <b>#define WM_HSCROLLCLIPBOARD 0x030E</b>
		/// </summary>
		Hscrollclipboard = 0x030E,
		/// <summary>
		/// <b>#define WM_QUERYNEWPALETTE 0x030F</b>
		/// </summary>
		Querynewpalette = 0x030F,
		/// <summary>
		/// <b>#define WM_PALETTEISCHANGING 0x0310</b>
		/// </summary>
		Paletteischanging = 0x0310,
		/// <summary>
		/// <b>#define WM_PALETTECHANGED 0x0311</b>
		/// </summary>
		Palettechanged = 0x0311,
		/// <summary>
		/// <b>#define WM_HOTKEY 0x0312</b>
		/// </summary>
		Hotkey = 0x0312,
		/// <summary>
		/// <b>#define WM_PRINT 0x0317</b>
		/// </summary>
		Print = 0x0317,
		/// <summary>
		/// <b>#define WM_PRINTCLIENT 0x0318</b>
		/// </summary>
		Printclient = 0x0318,
		/// <summary>
		/// <b>#define WM_APPCOMMAND 0x0319</b>
		/// </summary>
		Appcommand = 0x0319,
		/// <summary>
		/// <b>#define WM_THEMECHANGED 0x031A</b>
		/// </summary>
		Themechanged = 0x031A,
		/// <summary>
		/// <b>#define WM_CLIPBOARDUPDATE 0x031D</b>
		/// </summary>
		Clipboardupdate = 0x031D,
		/// <summary>
		/// <b>#define WM_DWMCOMPOSITIONCHANGED 0x031E</b>
		/// </summary>
		Dwmcompositionchanged = 0x031E,
		/// <summary>
		/// <b>#define WM_DWMNCRENDERINGCHANGED 0x031F</b>
		/// </summary>
		Dwmncrenderingchanged = 0x031F,
		/// <summary>
		/// <b>#define WM_DWMCOLORIZATIONCOLORCHANGED 0x0320</b>
		/// </summary>
		Dwmcolorizationcolorchanged = 0x0320,
		/// <summary>
		/// <b>#define WM_DWMWINDOWMAXIMIZEDCHANGE 0x0321</b>
		/// </summary>
		Dwmwindowmaximizedchange = 0x0321,
		/// <summary>
		/// <b>#define WM_DWMSENDICONICTHUMBNAIL 0x0323</b>
		/// </summary>
		Dwmsendiconicthumbnail = 0x0323,
		/// <summary>
		/// <b>#define WM_DWMSENDICONICLIVEPREVIEWBITMAP 0x0326</b>
		/// </summary>
		Dwmsendiconiclivepreviewbitmap = 0x0326,
		/// <summary>
		/// <b>#define WM_GETTITLEBARINFOEX 0x033F</b>
		/// </summary>
		Gettitlebarinfoex = 0x033F,
		/// <summary>
		/// <b>#define WM_HANDHELDFIRST 0x0358</b>
		/// </summary>
		Handheldfirst = 0x0358,
		/// <summary>
		/// <b>#define WM_HANDHELDLAST 0x035F</b>
		/// </summary>
		Handheldlast = 0x035F,
		/// <summary>
		/// <b>#define WM_AFXFIRST 0x0360</b>
		/// </summary>
		Afxfirst = 0x0360,
		/// <summary>
		/// <b>#define WM_AFXLAST 0x037F</b>
		/// </summary>
		Afxlast = 0x037F,
		/// <summary>
		/// <b>#define WM_PENWINFIRST 0x0380</b>
		/// </summary>
		Penwinfirst = 0x0380,
		/// <summary>
		/// <b>#define WM_PENWINLAST 0x038F</b>
		/// </summary>
		Penwinlast = 0x038F,
		/// <summary>
		/// <b>#define WM_APP 0x8000</b>
		/// </summary>
		App = 0x8000,
		/// <summary>
		/// <b>#define WM_USER 0x0400</b>
		/// </summary>
		User = 0x0400,
		/// <summary>
		/// <b>#define WM_TOOLTIPDISMISS 0x0345</b>
		/// </summary>
		Tooltipdismiss = 0x0345,
	}

	/// <summary>
	/// WINAPI <b>BOOL GetMessageA (LPMSG lpMsg, HWND hWnd, UINT wMsgFilterMin, UINT wMsgFilterMax)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpMsg">_Out_ <b>LPMSG lpMsg</b></param>
	/// <param name="hWmd">_In_opt_ <b>HWND hWnd</b></param>
	/// <param name="wMsgFilterMin">_In_ <b>UINT wMsgFilterMin</b></param>
	/// <param name="wMsgFilterMax">_In_ <b>UINT wMsgFilterMax</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool GetMessageA (MSG* lpMsg, IntPtr hWmd, uint wMsgFilterMin, uint wMsgFilterMax);

	/// <summary>
	/// WINAPI <b>BOOL GetMessageA (LPMSG lpMsg, HWND hWnd, UINT wMsgFilterMin, UINT wMsgFilterMax)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpMsg">_Out_ <b>LPMSG lpMsg</b></param>
	/// <param name="hWmd">_In_opt_ <b>HWND hWnd</b></param>
	/// <param name="wMsgFilterMin">_In_ <b>UINT wMsgFilterMin</b></param>
	/// <param name="wMsgFilterMax">_In_ <b>UINT wMsgFilterMax</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool GetMessageA (out MSG lpMsg, IntPtr hWmd, uint wMsgFilterMin, uint wMsgFilterMax) {
		fixed (MSG* _lpMsg = &lpMsg)
			return GetMessageA (_lpMsg, hWmd, wMsgFilterMin, wMsgFilterMax);
	}

	/// <summary>
	/// WINAPI <b>BOOL GetMessageW (LPMSG lpMsg, HWND hWnd, UINT wMsgFilterMin, UINT wMsgFilterMax)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpMsg">_Out_ <b>LPMSG lpMsg</b></param>
	/// <param name="hWmd">_In_opt_ <b>HWND hWnd</b></param>
	/// <param name="wMsgFilterMin">_In_ <b>UINT wMsgFilterMin</b></param>
	/// <param name="wMsgFilterMax">_In_ <b>UINT wMsgFilterMax</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool GetMessageW (MSG* lpMsg, IntPtr hWmd, uint wMsgFilterMin, uint wMsgFilterMax);

	/// <summary>
	/// WINAPI <b>BOOL GetMessageW (LPMSG lpMsg, HWND hWnd, UINT wMsgFilterMin, UINT wMsgFilterMax)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpMsg">_Out_ <b>LPMSG lpMsg</b></param>
	/// <param name="hWmd">_In_opt_ <b>HWND hWnd</b></param>
	/// <param name="wMsgFilterMin">_In_ <b>UINT wMsgFilterMin</b></param>
	/// <param name="wMsgFilterMax">_In_ <b>UINT wMsgFilterMax</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool GetMessageW (out MSG lpMsg, IntPtr hWmd, uint wMsgFilterMin, uint wMsgFilterMax) {
		fixed (MSG* _lpMsg = &lpMsg)
			return GetMessageW (_lpMsg, hWmd, wMsgFilterMin, wMsgFilterMax);
	}

	/// <summary>
	/// WINAPI <b>BOOL TranslateMessage (MSG *lpMsg)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpMsg">_In_ <b>MSG *lpMsg</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool TranslateMessage (MSG* lpMsg);

	/// <summary>
	/// WINAPI <b>LRESULT DispatchMessageA (MSG *lpMsg)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpMsg">_In_ <b>MSG *lpMsg</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial nuint DispatchMessageA (MSG* lpMsg);

	/// <summary>
	/// WINAPI <b>LRESULT DispatchMessageW (MSG *lpMsg)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpMsg">_In_ <b>MSG *lpMsg</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial nuint DispatchMessageW (MSG* lpMsg);

	/// <summary>
	/// <b>PeekMessageOptions</b><br/>
	/// WINUSER.h
	/// </summary>
	[Flags]
	public enum PeekMessageOptions : uint {
		/// <summary>
		/// <b>#define PM_NOREMOVE         0x0000</b>
		/// </summary>
		Noremove = 0x0000,
		/// <summary>
		/// <b>#define PM_REMOVE           0x0001</b>
		/// </summary>
		Remove = 0x0001,
		/// <summary>
		/// <b>#define PM_NOYIELD          0x0002</b>
		/// </summary>
		Noyield = 0x0002,
		/// <summary>
		/// <b>#define PM_QS_INPUT         (QS_INPUT &lt;&lt; 16)</b>
		/// </summary>
		QsInput = 0x0000,
		/// <summary>
		/// <b>#define PM_QS_POSTMESSAGE   ((QS_POSTMESSAGE | QS_HOTKEY | QS_TIMER) &lt;&lt; 16)</b>
		/// </summary>
		QsPostmessage = 0x0000,
		/// <summary>
		/// <b>#define PM_QS_PAINT         (QS_PAINT &lt;&lt; 16)</b>
		/// </summary>
		QsPaint = 0x0000,
		/// <summary>
		/// <b>#define PM_QS_SENDMESSAGE   (QS_SENDMESSAGE &lt;&lt; 16)</b>
		/// </summary>
		QsSendmessage = 0x0000,
	}

	/// <summary>
	/// WINAPI <b>BOOL PeekMessageA (LPMSG lpMsg, HWND hWnd, UINT wMsgFilterMin, UINT wMsgFilterMax, UINT wRemoveMsg)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpMsg">_Out_ <b>LPMSG lpMsg</b></param>
	/// <param name="hWnd">_In_opt_ <b>HWND hWnd</b></param>
	/// <param name="wMsgFilterMin">_In_ <b>UINT wMsgFilterMin</b></param>
	/// <param name="wMsgFilterMax">_In_ <b>UINT wMsgFilterMax</b></param>
	/// <param name="wRemoveMsg">_In_ <b>UINT wRemoveMsg</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool PeekMessageA (MSG* lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, PeekMessageOptions wRemoveMsg);

	/// <summary>
	/// WINAPI <b>BOOL PeekMessageA (LPMSG lpMsg, HWND hWnd, UINT wMsgFilterMin, UINT wMsgFilterMax, UINT wRemoveMsg)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpMsg">_Out_ <b>LPMSG lpMsg</b></param>
	/// <param name="hWnd">_In_opt_ <b>HWND hWnd</b></param>
	/// <param name="wMsgFilterMin">_In_ <b>UINT wMsgFilterMin</b></param>
	/// <param name="wMsgFilterMax">_In_ <b>UINT wMsgFilterMax</b></param>
	/// <param name="wRemoveMsg">_In_ <b>UINT wRemoveMsg</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool PeekMessageA (out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, PeekMessageOptions wRemoveMsg) {
		fixed (MSG* _lpMsg = &lpMsg) {
			return PeekMessageA (_lpMsg, hWnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg);
		}
	}

	/// <summary>
	/// WINAPI <b>BOOL PeekMessageW (LPMSG lpMsg, HWND hWnd, UINT wMsgFilterMin, UINT wMsgFilterMax, UINT wRemoveMsg)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpMsg">_Out_ <b>LPMSG lpMsg</b></param>
	/// <param name="hWnd">_In_opt_ <b>HWND hWnd</b></param>
	/// <param name="wMsgFilterMin">_In_ <b>UINT wMsgFilterMin</b></param>
	/// <param name="wMsgFilterMax">_In_ <b>UINT wMsgFilterMax</b></param>
	/// <param name="wRemoveMsg">_In_ <b>UINT wRemoveMsg</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool PeekMessageW (MSG* lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, PeekMessageOptions wRemoveMsg);

	/// <summary>
	/// WINAPI <b>BOOL PeekMessageW (LPMSG lpMsg, HWND hWnd, UINT wMsgFilterMin, UINT wMsgFilterMax, UINT wRemoveMsg)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpMsg">_Out_ <b>LPMSG lpMsg</b></param>
	/// <param name="hWnd">_In_opt_ <b>HWND hWnd</b></param>
	/// <param name="wMsgFilterMin">_In_ <b>UINT wMsgFilterMin</b></param>
	/// <param name="wMsgFilterMax">_In_ <b>UINT wMsgFilterMax</b></param>
	/// <param name="wRemoveMsg">_In_ <b>UINT wRemoveMsg</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool PeekMessageW (out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, PeekMessageOptions wRemoveMsg) {
		fixed (MSG* _lpMsg = &lpMsg) {
			return PeekMessageW (_lpMsg, hWnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg);
		}
	}

#endregion

	/// <summary>
	/// WINAPI <b>LRESULT DefWindowProcA (HWND hWnd, UINT Msg, WPARAM wParam, LPARAM lParam)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="hWnd">_In_ <b>HWND hWnd</b></param>
	/// <param name="uMsg">_In_ <b>UINT Msg</b></param>
	/// <param name="wParam">_In_ <b>WPARAM wParam</b></param>
	/// <param name="lParam">_In_ <b>LPARAM lParam</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial nuint DefWindowProcA (IntPtr hWnd, uint uMsg, nuint wParam, nuint lParam);

	/// <summary>
	/// WINAPI <b>LRESULT DefWindowProcW (HWND hWnd, UINT Msg, WPARAM wParam, LPARAM lParam)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="hWnd">_In_ <b>HWND hWnd</b></param>
	/// <param name="uMsg">_In_ <b>UINT Msg</b></param>
	/// <param name="wParam">_In_ <b>WPARAM wParam</b></param>
	/// <param name="lParam">_In_ <b>LPARAM lParam</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial nuint DefWindowProcW (IntPtr hWnd, uint uMsg, nuint wParam, nuint lParam);

	/// <summary>
	/// WINAPI <b>VOID PostQuitMessage (int nExitCode)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="nExitCode">_In_ <b>int nExitCode</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial void PostQuitMessage (int nExitCode);

	/// <summary>
	/// WINAPI <b>ATOM RegisterClassA (WNDCLASSA *lpWndClass)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpWndClass">_In_ <b>WNDCLASSA *lpWndClass</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial ushort RegisterClassA (WndClassA* lpWndClass);

	/// <summary>
	/// WINAPI <b>ATOM RegisterClassW (WNDCLASSW *lpWndClass)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpWndClass">_In_ <b>WNDCLASSW *lpWndClass</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial ushort RegisterClassW (WndClassW* lpWndClass);

	/// <summary>
	/// WINAPI <b>ATOM UnregisterClassA (LPCSTR lpClassName, HINSTANCE hInstance)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpWndClass">_In_ <b>LPCSTR lpClassName</b></param>
	/// <param name="hInstance">_In_opt_ <b>HINSTANCE hInstance</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool UnregisterClassA (char* lpWndClass, IntPtr hInstance);

	/// <summary>
	/// WINAPI <b>ATOM UnregisterClassW (LPCWSTR lpClassName, HINSTANCE hInstance)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpWndClass">_In_ <b>LPCWSTR lpClassName</b></param>
	/// <param name="hInstance">_In_opt_ <b>HINSTANCE hInstance</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool UnregisterClassW (WndClassW* lpWndClass, IntPtr hInstance);

	/// <summary>
	/// WINAPI <b>ATOM RegisterClassExA (WNDCLASSEXA *)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpWndClassEx">_In_ <b>WNDCLASSEXA *</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial ushort RegisterClassExA (WndClassExA* lpWndClassEx);

	/// <summary>
	/// WINAPI <b>ATOM RegisterClassExW (WNDCLASSEXW *)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpWndClassEx">_In_ <b>WNDCLASSEXW *</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial ushort RegisterClassExW (WndClassExW* lpWndClassEx);

	/// <summary>
	/// <b>Window Styles</b><br/>
	/// WINUSER.h
	/// </summary>
	[Flags]
	public enum WindowStyle : uint {
		/// <summary>
		/// <b>#define WS_OVERLAPPED 0x00000000L</b>
		/// </summary>
		Overlapped = 0x00000000,
		/// <summary>
		/// <b>#define WS_POPUP 0x80000000L</b>
		/// </summary>
		Popup = 0x80000000,
		/// <summary>
		/// <b>#define WS_CHILD 0x40000000L</b>
		/// </summary>
		Child = 0x40000000,
		/// <summary>
		/// <b>#define WS_MINIMIZE 0x20000000L</b>
		/// </summary>
		Minimize = 0x20000000,
		/// <summary>
		/// <b>#define WS_VISIBLE 0x10000000L</b>
		/// </summary>
		Visible = 0x10000000,
		/// <summary>
		/// <b>#define WS_DISABLED 0x08000000L</b>
		/// </summary>
		Disabled = 0x08000000,
		/// <summary>
		/// <b>#define WS_CLIPSIBLINGS 0x04000000L</b>
		/// </summary>
		Clipsiblings = 0x04000000,
		/// <summary>
		/// <b>#define WS_CLIPCHILDREN 0x02000000L</b>
		/// </summary>
		Clipchildren = 0x02000000,
		/// <summary>
		/// <b>#define WS_MAXIMIZE 0x01000000L</b>
		/// </summary>
		Maximize = 0x01000000,
		/// <summary>
		/// <b>#define WS_CAPTION 0x00C00000L</b>
		/// </summary>
		Caption = 0x00C00000,
		/// <summary>
		/// <b>#define WS_BORDER 0x00800000L</b>
		/// </summary>
		Border = 0x00800000,
		/// <summary>
		/// <b>#define WS_DLGFRAME 0x00400000L</b>
		/// </summary>
		Dlgframe = 0x00400000,
		/// <summary>
		/// <b>#define WS_VSCROLL 0x00200000L</b>
		/// </summary>
		Vscroll = 0x00200000,
		/// <summary>
		/// <b>#define WS_HSCROLL 0x00100000L</b>
		/// </summary>
		Hscroll = 0x00100000,
		/// <summary>
		/// <b>#define WS_SYSMENU 0x00080000L</b>
		/// </summary>
		Sysmenu = 0x00080000,
		/// <summary>
		/// <b>#define WS_THICKFRAME 0x00040000L</b>
		/// </summary>
		Thickframe = 0x00040000,
		/// <summary>
		/// <b>#define WS_GROUP 0x00020000L</b>
		/// </summary>
		Group = 0x00020000,
		/// <summary>
		/// <b>#define WS_TABSTOP 0x00010000L</b>
		/// </summary>
		Tabstop = 0x00010000,
		/// <summary>
		/// <b>#define WS_MINIMIZEBOX 0x00020000L</b>
		/// </summary>
		Minimizebox = 0x00020000,
		/// <summary>
		/// <b>#define WS_MAXIMIZEBOX 0x00010000L</b>
		/// </summary>
		Maximizebox = 0x00010000,
		/// <summary>
		/// <b>#define WS_TILED WS_OVERLAPPED</b>
		/// </summary>
		Tiled = Overlapped,
		/// <summary>
		/// <b>#define WS_ICONIC WS_MINIMIZE</b>
		/// </summary>
		Iconic = Minimize,
		/// <summary>
		/// <b>#define WS_SIZEBOX WS_THICKFRAME</b>
		/// </summary>
		Sizebox = Thickframe,
		/// <summary>
		/// <b>#define WS_TILEDWINDOW WS_OVERLAPPEDWINDOW</b>
		/// </summary>
		Tiledwindow = Overlappedwindow,
		/// <summary>
		/// <b>#define WS_OVERLAPPEDWINDOW WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX</b>
		/// </summary>
		Overlappedwindow = Overlapped | Caption | Sysmenu | Thickframe | Minimizebox | Maximizebox,
		/// <summary>
		/// <b>#define WS_POPUPWINDOW WS_POPUP | WS_BORDER | WS_SYSMENU</b>
		/// </summary>
		Popupwindow = Popup | Border | Sysmenu,
		/// <summary>
		/// <b>#define WS_CHILDWINDOW (WS_CHILD)</b>
		/// </summary>
		Childwindow = Child,
	}

	/// <summary>
	/// <b>Extended Window Styles</b><br/>
	/// WINUSER.h
	/// </summary>
	[Flags]
	public enum WindowExtendedStyles : uint {
		/// <summary>
		/// <b>#define WS_EX_DLGMODALFRAME 0x00000001L</b>
		/// </summary>
		Dlgmodalframe = 0x00000001,
		/// <summary>
		/// <b>#define WS_EX_NOPARENTNOTIFY 0x00000004L</b>
		/// </summary>
		Noparentnotify = 0x00000004,
		/// <summary>
		/// <b>#define WS_EX_TOPMOST 0x00000008L</b>
		/// </summary>
		Topmost = 0x00000008,
		/// <summary>
		/// <b>#define WS_EX_ACCEPTFILES 0x00000010L</b>
		/// </summary>
		Acceptfiles = 0x00000010,
		/// <summary>
		/// <b>#define WS_EX_TRANSPARENT 0x00000020L</b>
		/// </summary>
		Transparent = 0x00000020,
		/// <summary>
		/// <b>#define WS_EX_MDICHILD 0x00000040L</b>
		/// </summary>
		Mdichild = 0x00000040,
		/// <summary>
		/// <b>#define WS_EX_TOOLWINDOW 0x00000080L</b>
		/// </summary>
		Toolwindow = 0x00000080,
		/// <summary>
		/// <b>#define WS_EX_WINDOWEDGE 0x00000100L</b>
		/// </summary>
		Windowedge = 0x00000100,
		/// <summary>
		/// <b>#define WS_EX_CLIENTEDGE 0x00000200L</b>
		/// </summary>
		Clientedge = 0x00000200,
		/// <summary>
		/// <b>#define WS_EX_CONTEXTHELP 0x00000400L</b>
		/// </summary>
		Contexthelp = 0x00000400,
		/// <summary>
		/// <b>#define WS_EX_RIGHT 0x00001000L</b>
		/// </summary>
		Right = 0x00001000,
		/// <summary>
		/// <b>#define WS_EX_LEFT 0x00000000L</b>
		/// </summary>
		Left = 0x00000000,
		/// <summary>
		/// <b>#define WS_EX_RTLREADING 0x00002000L</b>
		/// </summary>
		Rtlreading = 0x00002000,
		/// <summary>
		/// <b>#define WS_EX_LTRREADING 0x00000000L</b>
		/// </summary>
		Ltrreading = 0x00000000,
		/// <summary>
		/// <b>#define WS_EX_LEFTSCROLLBAR 0x00004000L</b>
		/// </summary>
		Leftscrollbar = 0x00004000,
		/// <summary>
		/// <b>#define WS_EX_RIGHTSCROLLBAR 0x00000000L</b>
		/// </summary>
		Rightscrollbar = 0x00000000,
		/// <summary>
		/// <b>#define WS_EX_CONTROLPARENT 0x00010000L</b>
		/// </summary>
		Controlparent = 0x00010000,
		/// <summary>
		/// <b>#define WS_EX_STATICEDGE 0x00020000L</b>
		/// </summary>
		Staticedge = 0x00020000,
		/// <summary>
		/// <b>#define WS_EX_APPWINDOW 0x00040000L</b>
		/// </summary>
		Appwindow = 0x00040000,
		/// <summary>
		/// <b>#define WS_EX_OVERLAPPEDWINDOW WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE</b>
		/// </summary>
		Overlappedwindow = Windowedge | Clientedge,
		/// <summary>
		/// <b>#define WS_EX_PALETTEWINDOW WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST</b>
		/// </summary>
		palettewindow = Windowedge | Toolwindow | Topmost,
		/// <summary>
		/// <b>#define WS_EX_LAYERED 0x00080000</b>
		/// </summary>
		Layered = 0x00080000,
		/// <summary>
		/// <b>#define WS_EX_NOINHERITLAYOUT 0x00100000L</b>
		/// </summary>
		Noinheritlayout = 0x00100000,
		/// <summary>
		/// <b>#define WS_EX_NOREDIRECTIONBITMAP 0x00200000L</b>
		/// </summary>
		Noredirectionbitmap = 0x00200000,
		/// <summary>
		/// <b>#define WS_EX_LAYOUTRTL 0x00400000L</b>
		/// </summary>
		Layoutrtl = 0x00400000,
		/// <summary>
		/// <b>#define WS_EX_COMPOSITED 0x02000000L</b>
		/// </summary>
		Composited = 0x02000000,
		/// <summary>
		/// <b>#define WS_EX_NOACTIVATE 0x08000000L</b>
		/// </summary>
		Noactivate = 0x08000000,
	}

	/// <summary>
	/// WINAPI <b>HWND CreateWindowExA (DWORD dwExStyle, LPCSTR lpClassName, LPCSTR lpWindowName, DWORD dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, LPVOID lpParam)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="dwExStyle">_In_ <b>DWORD dwExStyle</b></param>
	/// <param name="lpClassName">_In_opt_ <b>LPCSTR lpClassName</b></param>
	/// <param name="lpWindowName">_In_opt_ <b>LPCSTR lpWindowName</b></param>
	/// <param name="dwStyle">_In_ <b>DWORD dwStyle</b></param>
	/// <param name="x">_In_ <b>int X</b></param>
	/// <param name="y">_In_ <b>int Y</b></param>
	/// <param name="nWidth">_In_ <b>int nWidth</b></param>
	/// <param name="nHeight">_In_ <b>int nHeight</b></param>
	/// <param name="hWndParent">_In_opt_ <b>HWND hWndParent</b></param>
	/// <param name="hMenu">_In_opt_ <b>HMENU hMenu</b></param>
	/// <param name="hInstance">_In_opt_ <b>HINSTANCE hInstance</b></param>
	/// <param name="lpParam">_In_opt_ <b>LPVOID lpParam</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial IntPtr CreateWindowExA (WindowExtendedStyles dwExStyle, char* lpClassName, char* lpWindowName, WindowStyle dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, void* lpParam);

	/// <summary>
	/// WINAPI <b>HWND CreateWindowExW (DWORD dwExStyle, LPCWSTR lpClassName, LPCWSTR lpWindowName, DWORD dwStyle, int X, int Y, int nWidth, int nHeight, HWND hWndParent, HMENU hMenu, HINSTANCE hInstance, LPVOID lpParam)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="dwExStyle">_In_ <b>DWORD dwExStyle</b></param>
	/// <param name="lpClassName">_In_opt_ <b>LPCWSTR lpClassName</b></param>
	/// <param name="lpWindowName">_In_opt_ <b>LPCWSTR lpWindowName</b></param>
	/// <param name="dwStyle">_In_ <b>DWORD dwStyle</b></param>
	/// <param name="x">_In_ <b>int X</b></param>
	/// <param name="y">_In_ <b>int Y</b></param>
	/// <param name="nWidth">_In_ <b>int nWidth</b></param>
	/// <param name="nHeight">_In_ <b>int nHeight</b></param>
	/// <param name="hWndParent">_In_opt_ <b>HWND hWndParent</b></param>
	/// <param name="hMenu">_In_opt_ <b>HMENU hMenu</b></param>
	/// <param name="hInstance">_In_opt_ <b>HINSTANCE hInstance</b></param>
	/// <param name="lpParam">_In_opt_ <b>LPVOID lpParam</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial IntPtr CreateWindowExW (WindowExtendedStyles dwExStyle, char* lpClassName, char* lpWindowName, WindowStyle dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, void* lpParam);

	/// <summary>
	/// WINAPI <b>BOOL DestroyWindow (HWND hWnd)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="hWnd">_In_ <b>HWND hWnd</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool DestroyWindow (IntPtr hWnd);

	/// <summary>
	/// <b>ShowWindow() Commands</b><br/>
	/// WINUSER.h
	/// </summary>
	public enum ShowWindowCommand : int {
		/// <summary>
		/// <b>#define SW_HIDE             0</b>
		/// </summary>
		Hide = 0,
		/// <summary>
		/// <b>#define SW_SHOWNORMAL       1</b>
		/// </summary>
		Shownormal = 1,
		/// <summary>
		/// <b>#define SW_NORMAL           1</b>
		/// </summary>
		Normal = 1,
		/// <summary>
		/// <b>#define SW_SHOWMINIMIZED    2</b>
		/// </summary>
		Showminimized = 2,
		/// <summary>
		/// <b>#define SW_SHOWMAXIMIZED    3</b>
		/// </summary>
		Showmaximized = 3,
		/// <summary>
		/// <b>#define SW_MAXIMIZE         3</b>
		/// </summary>
		Maximize = 3,
		/// <summary>
		/// <b>#define SW_SHOWNOACTIVATE   4</b>
		/// </summary>
		Shownoactivate = 4,
		/// <summary>
		/// <b>#define SW_SHOW             5</b>
		/// </summary>
		Show = 5,
		/// <summary>
		/// <b>#define SW_MINIMIZE         6</b>
		/// </summary>
		Minimize = 6,
		/// <summary>
		/// <b>#define SW_SHOWMINNOACTIVE  7</b>
		/// </summary>
		Showminnoactive = 7,
		/// <summary>
		/// <b>#define SW_SHOWNA           8</b>
		/// </summary>
		Showna = 8,
		/// <summary>
		/// <b>#define SW_RESTORE          9</b>
		/// </summary>
		Restore = 9,
		/// <summary>
		/// <b>#define SW_SHOWDEFAULT      10</b>
		/// </summary>
		Showdefault = 10,
		/// <summary>
		/// <b>#define SW_FORCEMINIMIZE    11</b>
		/// </summary>
		Forceminimize = 11,
		/// <summary>
		/// <b>#define SW_MAX              11</b>
		/// </summary>
		Max = 11,
	}

	/// <summary>
	/// WINAPI <b>BOOL ShowWindow (HWND hWnd, int nCmdShow)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="hWnd">_In_ <b>HWND hWnd</b></param>
	/// <param name="nCmdShow">_In_ <b>int nCmdShow</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool ShowWindow (IntPtr hWnd, ShowWindowCommand nCmdShow);

	#region Clipboard Manager Functions

	/// <summary>
	/// WINAPI <b>BOOL OpenClipboard (HWND hWndNewOwner)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="hWndNewOwner">_In_opt_ <b>HWND hWndNewOwner</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool OpenClipboard (IntPtr hWndNewOwner);

	/// <summary>
	/// WINAPI <b>BOOL CloseClipboard ()</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool CloseClipboard ();

	/// <summary>
	/// WINAPI <b>DWORD GetClipboardSequenceNumber ()</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	[LibraryImport ("USER32.dll")]
	public static partial uint GetClipboardSequenceNumber ();

	/// <summary>
	/// WINAPI <b>HWND GetClipboardOwner ()</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	[LibraryImport ("USER32.dll")]
	public static partial IntPtr GetClipboardOwner ();

	/// <summary>
	/// WINAPI <b>HANDLE SetClipboardViewer (HWND hWndNewViewer)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="hWndNewViewer">_In_ <b>HWND hWndNewViewer</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial IntPtr SetClipboardViewer (IntPtr hWndNewViewer);

	/// <summary>
	/// WINAPI <b>HWND GetClipboardViewer ()</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	[LibraryImport ("USER32.dll")]
	public static partial IntPtr GetClipboardViewer ();

	/// <summary>
	/// WINAPI <b>BOOL ChangeClipboardChain (HWND hWndRemove, HWND hWndNewNext)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="hWndRemove">_In_ <b>HWND hWndRemove</b></param>
	/// <param name="hWndNewNext">_In_ <b>HWND hWndNewNext</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool ChangeClipboardChain (IntPtr hWndRemove, IntPtr hWndNewNext);

	/// <summary>
	/// WINAPI <b>HANDLE SetClipboardData (UINT uFormat, HANDLE hMem)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="uFormat">_In_ <b>UINT uFormat</b></param>
	/// <param name="hMem">_In_opt_ <b>HANDLE hMem</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial IntPtr SetClipboardData (uint uFormat, IntPtr hMem);

	/// <summary>
	/// WINAPI <b>HANDLE SetClipboardData (UINT uFormat, HANDLE hMem)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="uFormat">_In_ <b>UINT uFormat</b></param>
	/// <param name="hMem">_In_opt_ <b>HANDLE hMem</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static IntPtr SetClipboardData (ClipboardFormat uFormat, IntPtr hMem) => SetClipboardData ((uint) uFormat, hMem);

	/// <summary>
	/// WINAPI <b>HANDLE GetClipboardData (UINT uFormat)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="uFormat">_In_ <b>UINT uFormat</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial IntPtr GetClipboardData (uint uFormat);

	/// <summary>
	/// WINAPI <b>HANDLE GetClipboardData (UINT uFormat)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="uFormat">_In_ <b>UINT uFormat</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static IntPtr GetClipboardData (ClipboardFormat uFormat) => GetClipboardData ((uint) uFormat);

	/// <summary>
	/// WINAPI <b>BOOL GetClipboardMetadata (UINT format, PGETCLIPBMETADATA metadata)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format"><b>UINT format</b></param>
	/// <param name="metadata">_Inout_ <b>PGETCLIPBMETADATA metadata</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool GetClipboardMetadata (uint format, GetClipBMetaData* metadata);

	/// <summary>
	/// WINAPI <b>BOOL GetClipboardMetadata (UINT format, PGETCLIPBMETADATA metadata)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format"><b>UINT format</b></param>
	/// <param name="metadata">_Inout_ <b>PGETCLIPBMETADATA metadata</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool GetClipboardMetadata (uint format, ref GetClipBMetaData metadata) {
		fixed (GetClipBMetaData* _metadata = &metadata) {
			return GetClipboardMetadata (format, _metadata);
		}
	}

	/// <summary>
	/// WINAPI <b>BOOL GetClipboardMetadata (UINT format, PGETCLIPBMETADATA metadata)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format"><b>UINT format</b></param>
	/// <param name="metadata">_Inout_ <b>PGETCLIPBMETADATA metadata</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool GetClipboardMetadata (ClipboardFormat format, GetClipBMetaData* metadata) => GetClipboardMetadata ((uint) format, metadata);

	/// <summary>
	/// WINAPI <b>BOOL GetClipboardMetadata (UINT format, PGETCLIPBMETADATA metadata)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format"><b>UINT format</b></param>
	/// <param name="metadata">_Inout_ <b>PGETCLIPBMETADATA metadata</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool GetClipboardMetadata (ClipboardFormat format, ref GetClipBMetaData metadata) {
		fixed (GetClipBMetaData* _metadata = &metadata) {
			return GetClipboardMetadata ((uint) format, _metadata);
		}
	}

	/// <summary>
	/// WINAPI <b>UINT RegisterClipboardFormatA (LPCSTR lpszFormat)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpszFormat">_In_ <b>LPCSTR lpszFormat</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial uint RegisterClipboardFormatA (char* lpszFormat);

	/// <summary>
	/// WINAPI <b>UINT RegisterClipboardFormatW (LPCWSTR lpszFormat)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpszFormat">_In_ <b>LPCWSTR lpszFormat</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial uint RegisterClipboardFormatW (char* lpszFormat);

	/// <summary>
	/// WINAPI <b>int CountClipboardFormats ()</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	[LibraryImport ("USER32.dll")]
	public static partial int CountClipboardFormats ();

	/// <summary>
	/// WINAPI <b>UINT EnumClipboardFormats (UINT format)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format">_In_ <b>UINT format</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial uint EnumClipboardFormats (uint format);

	/// <summary>
	/// WINAPI <b>UINT EnumClipboardFormats (UINT format)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format">_In_ <b>UINT format</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static ClipboardFormat EnumClipboardFormats (ClipboardFormat format) => (ClipboardFormat) EnumClipboardFormats ((uint) format);

	/// <summary>
	/// WINAPI <b>int GetClipboardFormatNameA (UINT format, LPSTR lpszFormatName, int cchMaxCount)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format">_In_ <b>UINT format</b></param>
	/// <param name="lpszFormatName">_Out_writes_(cchMaxCount) <b>LPSTR lpszFormatName</b></param>
	/// <param name="cchMaxCount">_In_ <b>int cchMaxCount</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial int GetClipboardFormatNameA (uint format, char* lpszFormatName, int cchMaxCount);

	/// <summary>
	/// WINAPI <b>int GetClipboardFormatNameA (UINT format, LPSTR lpszFormatName, int cchMaxCount)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format">_In_ <b>UINT format</b></param>
	/// <param name="lpszFormatName">_Out_writes_(cchMaxCount) <b>LPSTR lpszFormatName</b></param>
	/// <param name="cchMaxCount">_In_ <b>int cchMaxCount</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int GetClipboardFormatNameA (ClipboardFormat format, char* lpszFormatName, int cchMaxCount) => GetClipboardFormatNameA ((uint) format, lpszFormatName, cchMaxCount);

	/// <summary>
	/// WINAPI <b>int GetClipboardFormatNameW (UINT format, LPWSTR lpszFormatName, int cchMaxCount)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format">_In_ <b>UINT format</b></param>
	/// <param name="lpszFormatName">_Out_writes_(cchMaxCount) <b>LPWSTR lpszFormatName</b></param>
	/// <param name="cchMaxCount">_In_ <b>int cchMaxCount</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial int GetClipboardFormatNameW (uint format, char* lpszFormatName, int cchMaxCount);

	/// <summary>
	/// WINAPI <b>int GetClipboardFormatNameW (UINT format, LPSTR lpszFormatName, int cchMaxCount)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format">_In_ <b>UINT format</b></param>
	/// <param name="lpszFormatName">_Out_writes_(cchMaxCount) <b>LPWSTR lpszFormatName</b></param>
	/// <param name="cchMaxCount">_In_ <b>int cchMaxCount</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int GetClipboardFormatNameW (ClipboardFormat format, char* lpszFormatName, int cchMaxCount) => GetClipboardFormatNameW ((uint) format, lpszFormatName, cchMaxCount);

	/// <summary>
	/// WINAPI <b>BOOL EmptyClipboard ()</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool EmptyClipboard ();

	/// <summary>
	/// WINAPI <b>BOOL IsClipboardFormatAvailable (UINT format)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format">_In_ <b>UINT format</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool IsClipboardFormatAvailable (uint format);

	/// <summary>
	/// WINAPI <b>BOOL IsClipboardFormatAvailable (UINT format)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="format">_In_ <b>UINT format</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool IsClipboardFormatAvailable (ClipboardFormat format) => IsClipboardFormatAvailable ((uint) format);

	/// <summary>
	/// WINAPI <b>int GetPriorityClipboardFormat (UINT *paFormatPriorityList, int cFormats)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="paFormatPriorityList">_In_reads_(cFormats) <b>UINT *paFormatPriorityList</b></param>
	/// <param name="cFormats">_In_ <b>int cFormats</b></param>
	[LibraryImport ("USER32.dll")]
	public static partial int GetPriorityClipboardFormat (uint* paFormatPriorityList, int cFormats);

	/// <summary>
	/// WINAPI <b>int GetPriorityClipboardFormat (UINT *paFormatPriorityList, int cFormats)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="paFormatPriorityList">_In_reads_(cFormats) <b>UINT *paFormatPriorityList</b></param>
	/// <param name="cFormats">_In_ <b>int cFormats</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static int GetPriorityClipboardFormat (ClipboardFormat* paFormatPriorityList, int cFormats) => GetPriorityClipboardFormat ((uint*) paFormatPriorityList, cFormats);

	/// <summary>
	/// WINAPI <b>HWND GetOpenClipboardWindow ()</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	[LibraryImport ("USER32.dll")]
	public static partial IntPtr GetOpenClipboardWindow ();

	/// <summary>
	/// WINAPI <b>BOOL AddClipboardFormatListener (HWND hwnd)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="hwnd">_In_ <b>HWND hwnd</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool AddClipboardFormatListener (IntPtr hwnd);

	/// <summary>
	/// WINAPI <b>BOOL RemoveClipboardFormatListener (HWND hwnd)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="hwnd">_In_ <b>HWND hwnd</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool RemoveClipboardFormatListener (IntPtr hwnd);

	/// <summary>
	/// WINAPI <b>BOOL GetUpdatedClipboardFormats (PUINT lpuiFormats, UINT cFormats, PUINT pcFormatsOut)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpuiFormats">_Out_writes_(cFormats) <b>PUINT lpuiFormats</b></param>
	/// <param name="cFormats">_In_<b>UINT cFormats</b></param>
	/// <param name="pcFormatsOut">_Out_ <b>PUINT pcFormatsOut</b></param>
	[LibraryImport ("USER32.dll")]
	[return: MarshalAs (UnmanagedType.Bool)]
	public static partial bool GetUpdatedClipboardFormats (uint* lpuiFormats, uint cFormats, uint* pcFormatsOut);

	/// <summary>
	/// WINAPI <b>BOOL GetUpdatedClipboardFormats (PUINT lpuiFormats, UINT cFormats, PUINT pcFormatsOut)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpuiFormats">_Out_writes_(cFormats) <b>PUINT lpuiFormats</b></param>
	/// <param name="cFormats">_In_<b>UINT cFormats</b></param>
	/// <param name="pcFormatsOut">_Out_ <b>PUINT pcFormatsOut</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool GetUpdatedClipboardFormats (uint* lpuiFormats, uint cFormats, out uint pcFormatsOut) {
		fixed (uint* _pcFormatsOut = &pcFormatsOut) {
			return GetUpdatedClipboardFormats (lpuiFormats, cFormats, _pcFormatsOut);
		}
	}

	/// <summary>
	/// WINAPI <b>BOOL GetUpdatedClipboardFormats (PUINT lpuiFormats, UINT cFormats, PUINT pcFormatsOut)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpuiFormats">_Out_writes_(cFormats) <b>PUINT lpuiFormats</b></param>
	/// <param name="cFormats">_In_<b>UINT cFormats</b></param>
	/// <param name="pcFormatsOut">_Out_ <b>PUINT pcFormatsOut</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool GetUpdatedClipboardFormats (ClipboardFormat* lpuiFormats, uint cFormats, ClipboardFormat* pcFormatsOut) => GetUpdatedClipboardFormats ((uint*) lpuiFormats, cFormats, (uint*) pcFormatsOut);

	/// <summary>
	/// WINAPI <b>BOOL GetUpdatedClipboardFormats (PUINT lpuiFormats, UINT cFormats, PUINT pcFormatsOut)</b><br/>
	/// WINUSER.h<br/>
	/// USER32.dll
	/// </summary>
	/// <param name="lpuiFormats">_Out_writes_(cFormats) <b>PUINT lpuiFormats</b></param>
	/// <param name="cFormats">_In_<b>UINT cFormats</b></param>
	/// <param name="pcFormatsOut">_Out_ <b>PUINT pcFormatsOut</b></param>
	[MethodImpl (MethodImplOptions.AggressiveInlining)]
	public static bool GetUpdatedClipboardFormats (ClipboardFormat* lpuiFormats, uint cFormats, out ClipboardFormat pcFormatsOut) {
		fixed (ClipboardFormat* _pcFormatsOut = &pcFormatsOut) {
			return GetUpdatedClipboardFormats ((uint*) lpuiFormats, cFormats, (uint*) _pcFormatsOut);
		}
	}

	#endregion
}
