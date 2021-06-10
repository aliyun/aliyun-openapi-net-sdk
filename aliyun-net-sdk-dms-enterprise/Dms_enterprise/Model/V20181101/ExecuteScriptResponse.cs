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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ExecuteScriptResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ExecuteScript_Result> results;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "ErrorCode")]
		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		[JsonProperty(PropertyName = "ErrorMessage")]
		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "Results")]
		public List<ExecuteScript_Result> Results
		{
			get
			{
				return results;
			}
			set	
			{
				results = value;
			}
		}

		public class ExecuteScript_Result
		{

			private bool? success;

			private string message;

			private long? rowCount;

			private List<string> columnNames;

			private List<Dictionary<string, string>> rows;

			[JsonProperty(PropertyName = "Success")]
			public bool? Success
			{
				get
				{
					return success;
				}
				set	
				{
					success = value;
				}
			}

			[JsonProperty(PropertyName = "Message")]
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

			[JsonProperty(PropertyName = "RowCount")]
			public long? RowCount
			{
				get
				{
					return rowCount;
				}
				set	
				{
					rowCount = value;
				}
			}

			[JsonProperty(PropertyName = "ColumnNames")]
			public List<string> ColumnNames
			{
				get
				{
					return columnNames;
				}
				set	
				{
					columnNames = value;
				}
			}

			[JsonProperty(PropertyName = "Rows")]
			public List<Dictionary<string, string>> Rows
			{
				get
				{
					return rows;
				}
				set	
				{
					rows = value;
				}
			}
		}
	}
}
