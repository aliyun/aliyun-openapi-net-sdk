/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DownloadLogResponse : AcsResponse
	{

		private string requestId;

		private List<DownloadLog_StackTraceItem> stackTrace;

		private List<string> suppressed;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<DownloadLog_StackTraceItem> StackTrace
		{
			get
			{
				return stackTrace;
			}
			set	
			{
				stackTrace = value;
			}
		}

		public List<string> Suppressed
		{
			get
			{
				return suppressed;
			}
			set	
			{
				suppressed = value;
			}
		}

		public class DownloadLog_StackTraceItem
		{

			private string fileName;

			private bool? nativeMethod;

			private string methodName;

			private string className;

			private int? lineNumber;

			public string FileName
			{
				get
				{
					return fileName;
				}
				set	
				{
					fileName = value;
				}
			}

			public bool? NativeMethod
			{
				get
				{
					return nativeMethod;
				}
				set	
				{
					nativeMethod = value;
				}
			}

			public string MethodName
			{
				get
				{
					return methodName;
				}
				set	
				{
					methodName = value;
				}
			}

			public string ClassName
			{
				get
				{
					return className;
				}
				set	
				{
					className = value;
				}
			}

			public int? LineNumber
			{
				get
				{
					return lineNumber;
				}
				set	
				{
					lineNumber = value;
				}
			}
		}
	}
}
