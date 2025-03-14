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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class VerifyPythonFileResponse : AcsResponse
	{

		private string requestId;

		private List<VerifyPythonFile_SyntaxItem> syntax;

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

		public List<VerifyPythonFile_SyntaxItem> Syntax
		{
			get
			{
				return syntax;
			}
			set	
			{
				syntax = value;
			}
		}

		public class VerifyPythonFile_SyntaxItem
		{

			private int? startLineNumber;

			private int? startColumn;

			private int? endLineNumber;

			private int? endColumn;

			private string message;

			private int? severity;

			public int? StartLineNumber
			{
				get
				{
					return startLineNumber;
				}
				set	
				{
					startLineNumber = value;
				}
			}

			public int? StartColumn
			{
				get
				{
					return startColumn;
				}
				set	
				{
					startColumn = value;
				}
			}

			public int? EndLineNumber
			{
				get
				{
					return endLineNumber;
				}
				set	
				{
					endLineNumber = value;
				}
			}

			public int? EndColumn
			{
				get
				{
					return endColumn;
				}
				set	
				{
					endColumn = value;
				}
			}

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
				}
			}

			public int? Severity
			{
				get
				{
					return severity;
				}
				set	
				{
					severity = value;
				}
			}
		}
	}
}
