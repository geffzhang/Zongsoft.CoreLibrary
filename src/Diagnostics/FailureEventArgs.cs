﻿/*
 * Authors:
 *   钟峰(Popeye Zhong) <zongsoft@gmail.com>
 *
 * Copyright (C) 2010-2013 Zongsoft Corporation <http://www.zongsoft.com>
 *
 * This file is part of Zongsoft.CoreLibrary.
 *
 * Zongsoft.CoreLibrary is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * Zongsoft.CoreLibrary is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with Zongsoft.CoreLibrary; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Zongsoft.Diagnostics
{
	[Serializable]
	public class FailureEventArgs : EventArgs
	{
		#region 成员变量
		private Exception _exception;
		private string _message;
		private object _state;
		#endregion

		#region 构造函数
		public FailureEventArgs(string message) : this(message, null)
		{
		}

		public FailureEventArgs(string message, object state)
		{
			_exception = null;
			_message = message;
			_state = state;
		}

		public FailureEventArgs(Exception exception) : this(exception, null)
		{
		}

		public FailureEventArgs(Exception exception, object state)
		{
			_exception = exception;
			_state = state;
		}
		#endregion

		#region 公共属性
		public Exception Exception
		{
			get
			{
				return _exception;
			}
		}

		public string Message
		{
			get
			{
				if(string.IsNullOrEmpty(_message))
					return _exception == null ? string.Empty : _exception.Message;

				return _message ?? string.Empty;
			}
		}

		public object State
		{
			get
			{
				return _state;
			}
		}
		#endregion
	}
}
