﻿using System;
using System.Text;

namespace HotUpdate.Code.Utility
{
	public static class StringFormat
	{
		private static StringBuilder _cacheBuilder = new(1024);

		public static string Format(string format, object arg0)
		{
			if (string.IsNullOrEmpty(format))
				throw new ArgumentNullException();

			_cacheBuilder.Length = 0;
			_cacheBuilder.AppendFormat(format, arg0);
			return _cacheBuilder.ToString();
		}

		public static string Format(string format, object arg0, object arg1)
		{
			if (string.IsNullOrEmpty(format))
				throw new ArgumentNullException();

			_cacheBuilder.Length = 0;
			_cacheBuilder.AppendFormat(format, arg0, arg1);
			return _cacheBuilder.ToString();
		}

		public static string Format(string format, object arg0, object arg1, object arg2)
		{
			if (string.IsNullOrEmpty(format))
				throw new ArgumentNullException();

			_cacheBuilder.Length = 0;
			_cacheBuilder.AppendFormat(format, arg0, arg1, arg2);
			return _cacheBuilder.ToString();
		}
		
		public static string Format(string format, object arg0, object arg1, object arg2, object arg3)
		{
			if (string.IsNullOrEmpty(format))
				throw new ArgumentNullException();

			_cacheBuilder.Length = 0;
			_cacheBuilder.AppendFormat(format, arg0, arg1, arg2, arg3);
			return _cacheBuilder.ToString();
		}

		public static string Format(string format, params object[] args)
		{
			if (string.IsNullOrEmpty(format))
				throw new ArgumentNullException();

			if (args == null)
				throw new ArgumentNullException();

			_cacheBuilder.Length = 0;
			_cacheBuilder.AppendFormat(format, args);
			return _cacheBuilder.ToString();
		}
	}
}