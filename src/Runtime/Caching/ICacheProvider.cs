﻿/*
 * Authors:
 *   钟峰(Popeye Zhong) <zongsoft@gmail.com>
 *
 * Copyright (C) 2013-2015 Zongsoft Corporation <http://www.zongsoft.com>
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

namespace Zongsoft.Runtime.Caching
{
	/// <summary>
	/// 表示缓存容器的提供程序的接口。
	/// </summary>
	public interface ICacheProvider
	{
		/// <summary>
		/// 获取指定名称的缓存容器。
		/// </summary>
		/// <param name="name">指定要获取的缓存容器的名称，如果为空(null)或空字符串则返回默认缓存容器。</param>
		/// <param name="createNotExists">指示如果指定名称的缓存容器不存在时是否要自动创建它。</param>
		/// <returns>
		///		<para>返回指定名称的缓存容。</para>
		///		<para>如果指定名称的缓存容器不存在并且<paramref name="createNotExists"/>参数为假(False)则返回空(null)；</para>
		///		<para>如果指定名称的缓存容器不存在并且<paramref name="createNotExists"/>参数为真(True)则创建一个指定名称的缓存容器并返回它。</para>
		///	</returns>
		ICache GetCache(string name, bool createNotExists = false);
	}
}
