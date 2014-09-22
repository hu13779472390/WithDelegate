﻿/**
WithDelegate

Copyright (c) 2012 Masahiko SHOJI

This software is released under the MIT License.

http://opensource.org/licenses/mit-license.php

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WithDelegate
{
	public class WdDateTimePicker : System.Windows.Forms.DateTimePicker
	{
		////////////////////////////////////////////////////////////////
		delegate void ThisEnableCallback(bool flg);
		public void Enable(bool flg)
		{
			if (this.InvokeRequired)
			{
				ThisEnableCallback d = new ThisEnableCallback(Enable);
				this.Invoke(d, new object[] { flg });
			}
			else
			{
				this.Enabled = flg;
			}
		}

		////////////////////////////////////////////////////////////////
		delegate void SetTextCallback(string str);
		public void SetText(string str)
		{
			if (this.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				this.Invoke(d, new object[] { str });
			}
			else
			{
				this.Text= str;
			}
		}
	}
}
