using System;
using UnityEngine;

#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace UnityWebBrowser.Input
{
	/// <summary>
	///		Helper class for inputs
	/// </summary>
    public static class WebBrowserInputHelper
    {
		/// <summary>
		///		Converts a <see cref="KeyCode"/> to <see cref="WindowKeys"/>
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
	    public static WindowKeys UnityKeyCodeToWindowKey(this KeyCode key)
	    {
		    switch (key)
		    {
			    case KeyCode.None:
				    return WindowKeys.None;
			    case KeyCode.Backspace:
				    return WindowKeys.Back;
			    case KeyCode.Delete:
				    return WindowKeys.Delete;
			    case KeyCode.Tab:
				    return WindowKeys.Tab;
			    case KeyCode.Clear:
				    return WindowKeys.Clear;
			    case KeyCode.Return:
				    return WindowKeys.Return;
			    case KeyCode.Pause:
				    return WindowKeys.Pause;
			    case KeyCode.Escape:
				    return WindowKeys.Escape;
			    case KeyCode.Space:
				    return WindowKeys.Space;
			    case KeyCode.KeypadPeriod:
				    return WindowKeys.OemPeriod;
			    case KeyCode.KeypadDivide:
				    return WindowKeys.Divide;
			    case KeyCode.KeypadMultiply:
				    return WindowKeys.Multiply;
			    case KeyCode.KeypadMinus:
				    return WindowKeys.OemMinus;
			    case KeyCode.KeypadPlus:
				    return WindowKeys.Oemplus;
			    case KeyCode.KeypadEnter:
				    return WindowKeys.Enter;
			    case KeyCode.UpArrow:
				    return WindowKeys.Up;
			    case KeyCode.DownArrow:
				    return WindowKeys.Down;
			    case KeyCode.RightArrow:
				    return WindowKeys.Right;
			    case KeyCode.LeftArrow:
				    return WindowKeys.Left;
			    case KeyCode.Insert:
				    return WindowKeys.Insert;
			    case KeyCode.Home:
				    return WindowKeys.Home;
			    case KeyCode.End:
				    return WindowKeys.End;
			    case KeyCode.PageUp:
				    return WindowKeys.PageUp;
			    case KeyCode.PageDown:
				    return WindowKeys.PageDown;
			    case KeyCode.F1:
				    return WindowKeys.F1;
			    case KeyCode.F2:
				    return WindowKeys.F2;
			    case KeyCode.F3:
				    return WindowKeys.F3;
			    case KeyCode.F4:
				    return WindowKeys.F4;
			    case KeyCode.F5:
				    return WindowKeys.F5;
			    case KeyCode.F6:
				    return WindowKeys.F6;
			    case KeyCode.F7:
				    return WindowKeys.F7;
			    case KeyCode.F8:
				    return WindowKeys.F8;
			    case KeyCode.F9:
				    return WindowKeys.F9;
			    case KeyCode.F10:
				    return WindowKeys.F10;
			    case KeyCode.F11:
				    return WindowKeys.F11;
			    case KeyCode.F12:
				    return WindowKeys.F12;
			    case KeyCode.F13:
				    return WindowKeys.F13;
			    case KeyCode.F14:
				    return WindowKeys.F14;
			    case KeyCode.F15:
				    return WindowKeys.F15;
			    case KeyCode.Alpha0:
				    return WindowKeys.D0;
			    case KeyCode.Alpha1:
				    return WindowKeys.D1;
			    case KeyCode.Alpha2:
				    return WindowKeys.D2;
			    case KeyCode.Alpha3:
				    return WindowKeys.D3;
			    case KeyCode.Alpha4:
				    return WindowKeys.D4;
			    case KeyCode.Alpha5:
				    return WindowKeys.D5;
			    case KeyCode.Alpha6:
				    return WindowKeys.D6;
			    case KeyCode.Alpha7:
				    return WindowKeys.D7;
			    case KeyCode.Alpha8:
				    return WindowKeys.D8;
			    case KeyCode.Alpha9:
				    return WindowKeys.D9;
			    case KeyCode.DoubleQuote:
				    return WindowKeys.OemQuotes;
			    case KeyCode.Quote:
				    return WindowKeys.OemQuotes;
			    case KeyCode.LeftParen:
				    return WindowKeys.OemOpenBrackets;
			    case KeyCode.RightParen:
				    return WindowKeys.OemCloseBrackets;
			    case KeyCode.Plus:
				    return WindowKeys.Oemplus;
			    case KeyCode.Comma:
				    return WindowKeys.Oemcomma;
			    case KeyCode.Minus:
				    return WindowKeys.OemMinus;
			    case KeyCode.Period:
				    return WindowKeys.OemPeriod;
			    case KeyCode.Semicolon:
				    return WindowKeys.OemSemicolon;
			    case KeyCode.A:
				    return WindowKeys.A;
			    case KeyCode.B:
				    return WindowKeys.B;
			    case KeyCode.C:
				    return WindowKeys.C;
			    case KeyCode.D:
				    return WindowKeys.D;
			    case KeyCode.E:
				    return WindowKeys.E;
			    case KeyCode.F:
				    return WindowKeys.F;
			    case KeyCode.G:
				    return WindowKeys.G;
			    case KeyCode.H:
				    return WindowKeys.H;
			    case KeyCode.I:
				    return WindowKeys.I;
			    case KeyCode.J:
				    return WindowKeys.J;
			    case KeyCode.K:
				    return WindowKeys.K;
			    case KeyCode.L:
				    return WindowKeys.L;
			    case KeyCode.M:
				    return WindowKeys.M;
			    case KeyCode.N:
				    return WindowKeys.N;
			    case KeyCode.O:
				    return WindowKeys.O;
			    case KeyCode.P:
				    return WindowKeys.P;
			    case KeyCode.Q:
				    return WindowKeys.Q;
			    case KeyCode.R:
				    return WindowKeys.R;
			    case KeyCode.S:
				    return WindowKeys.S;
			    case KeyCode.T:
				    return WindowKeys.T;
			    case KeyCode.U:
				    return WindowKeys.U;
			    case KeyCode.V:
				    return WindowKeys.V;
			    case KeyCode.W:
				    return WindowKeys.W;
			    case KeyCode.X:
				    return WindowKeys.X;
			    case KeyCode.Y:
				    return WindowKeys.Y;
			    case KeyCode.Z:
				    return WindowKeys.Z;
			    case KeyCode.RightShift:
				    return WindowKeys.RShiftKey;
			    case KeyCode.LeftShift:
				    return WindowKeys.LShiftKey;
			    case KeyCode.RightControl:
				    return WindowKeys.RControlKey;
			    case KeyCode.LeftControl:
				    return WindowKeys.LControlKey;
			    case KeyCode.RightAlt:
				    return WindowKeys.Alt;
			    case KeyCode.LeftAlt:
				    return WindowKeys.Alt;
			    case KeyCode.Print:
				    return WindowKeys.Print;
			    default:
				    throw new ArgumentOutOfRangeException(nameof(key), key, null);
		    }
	    }

#if ENABLE_INPUT_SYSTEM

		/// <summary>
		///		Converts a <see cref="Key"/> to <see cref="WindowKeys"/>
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
	    public static WindowKeys UnityKeyToWindowKey(this Key key)
	    {
		    switch (key)
		    {
			    case Key.None:
				    return WindowKeys.None;
			    case Key.Space:
				    return WindowKeys.Space;
			    case Key.Enter:
				    return WindowKeys.Enter;
			    case Key.Tab:
				    return WindowKeys.Tab;
			    case Key.Quote:
				    return WindowKeys.OemQuotes;
			    case Key.Semicolon:
				    return WindowKeys.OemSemicolon;
			    case Key.Comma:
				    return WindowKeys.Oemcomma;
			    case Key.Period:
				    return WindowKeys.OemPeriod;
			    case Key.LeftBracket:
				    return WindowKeys.OemOpenBrackets;
			    case Key.RightBracket:
				    return WindowKeys.OemCloseBrackets;
			    case Key.Minus:
				    return WindowKeys.OemMinus;
			    case Key.A:
				    return WindowKeys.A;
			    case Key.B:
				    return WindowKeys.B;
			    case Key.C:
				    return WindowKeys.C;
			    case Key.D:
				    return WindowKeys.D;
			    case Key.E:
				    return WindowKeys.E;
			    case Key.F:
				    return WindowKeys.F;
			    case Key.G:
				    return WindowKeys.G;
			    case Key.H:
				    return WindowKeys.H;
			    case Key.I:
				    return WindowKeys.I;
			    case Key.J:
				    return WindowKeys.J;
			    case Key.K:
				    return WindowKeys.K;
			    case Key.L:
				    return WindowKeys.L;
			    case Key.M:
				    return WindowKeys.M;
			    case Key.N:
				    return WindowKeys.N;
			    case Key.O:
				    return WindowKeys.O;
			    case Key.P:
				    return WindowKeys.P;
			    case Key.Q:
				    return WindowKeys.Q;
			    case Key.R:
				    return WindowKeys.R;
			    case Key.S:
				    return WindowKeys.S;
			    case Key.T:
				    return WindowKeys.T;
			    case Key.U:
				    return WindowKeys.U;
			    case Key.V:
				    return WindowKeys.V;
			    case Key.W:
				    return WindowKeys.W;
			    case Key.X:
				    return WindowKeys.X;
			    case Key.Y:
				    return WindowKeys.Y;
			    case Key.Z:
				    return WindowKeys.Z;
			    case Key.LeftShift:
				    return WindowKeys.LShiftKey;
			    case Key.RightShift:
				    return WindowKeys.RShiftKey;
				case Key.RightAlt:
			    case Key.LeftAlt:
				    return WindowKeys.Alt;
			    case Key.LeftCtrl:
				    return WindowKeys.LControlKey;
			    case Key.RightCtrl:
				    return WindowKeys.RControlKey;
			    case Key.Escape:
				    return WindowKeys.Escape;
			    case Key.LeftArrow:
				    return WindowKeys.Left;
			    case Key.RightArrow:
				    return WindowKeys.Right;
			    case Key.UpArrow:
				    return WindowKeys.Up;
			    case Key.DownArrow:
				    return WindowKeys.Down;
			    case Key.Backspace:
				    return WindowKeys.Back;
			    case Key.PageDown:
				    return WindowKeys.PageDown;
			    case Key.PageUp:
				    return WindowKeys.PageUp;
			    case Key.Home:
				    return WindowKeys.Home;
			    case Key.End:
				    return WindowKeys.End;
			    case Key.Insert:
				    return WindowKeys.Insert;
			    case Key.Delete:
				    return WindowKeys.Delete;
			    case Key.PrintScreen:
				    return WindowKeys.PrintScreen;
			    case Key.Pause:
				    return WindowKeys.Pause;
			    case Key.NumpadEnter:
				    return WindowKeys.Enter;
			    case Key.NumpadDivide:
				    return WindowKeys.Divide;
			    case Key.NumpadMultiply:
				    return WindowKeys.Multiply;
			    case Key.NumpadPlus:
				    return WindowKeys.Play;
			    case Key.NumpadMinus:
				    return WindowKeys.OemMinus;
			    case Key.NumpadPeriod:
				    return WindowKeys.OemPeriod;
			    case Key.Numpad0:
				    return WindowKeys.NumPad0;
			    case Key.Numpad1:
				    return WindowKeys.NumPad1;
			    case Key.Numpad2:
				    return WindowKeys.NumPad2;
			    case Key.Numpad3:
				    return WindowKeys.NumPad3;
			    case Key.Numpad4:
				    return WindowKeys.NumPad4;
			    case Key.Numpad5:
				    return WindowKeys.NumPad5;
			    case Key.Numpad6:
				    return WindowKeys.NumPad6;
			    case Key.Numpad7:
				    return WindowKeys.NumPad7;
			    case Key.Numpad8:
				    return WindowKeys.NumPad8;
			    case Key.Numpad9:
				    return WindowKeys.NumPad9;
			    case Key.F1:
				    return WindowKeys.F1;
			    case Key.F2:
				    return WindowKeys.F2;
			    case Key.F3:
				    return WindowKeys.F3;
			    case Key.F4:
				    return WindowKeys.F4;
			    case Key.F5:
				    return WindowKeys.F5;
			    case Key.F6:
				    return WindowKeys.F6;
			    case Key.F7:
				    return WindowKeys.F7;
			    case Key.F8:
				    return WindowKeys.F8;
			    case Key.F9:
				    return WindowKeys.F9;
			    case Key.F10:
				    return WindowKeys.F10;
			    case Key.F11:
				    return WindowKeys.F11;
			    case Key.F12:
				    return WindowKeys.F12;
			    default:
				    throw new ArgumentOutOfRangeException(nameof(key), key, null);
		    }
	    }

#endif
    }
}