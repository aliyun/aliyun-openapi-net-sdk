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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListExecutionLogsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private bool? isTruncated;

		private int? maxResults;

		private List<ListExecutionLogs_ExecutionLog> executionLogs;

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

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

		[JsonProperty(PropertyName = "IsTruncated")]
		public bool? IsTruncated
		{
			get
			{
				return isTruncated;
			}
			set	
			{
				isTruncated = value;
			}
		}

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		[JsonProperty(PropertyName = "ExecutionLogs")]
		public List<ListExecutionLogs_ExecutionLog> ExecutionLogs
		{
			get
			{
				return executionLogs;
			}
			set	
			{
				executionLogs = value;
			}
		}

		public class ListExecutionLogs_ExecutionLog
		{

			private string taskExecutionId;

			private string message;

			private string logType;

			private string timestamp;

			[JsonProperty(PropertyName = "TaskExecutionId")]
			public string TaskExecutionId
			{
				get
				{
					return taskExecutionId;
				}
				set	
				{
					taskExecutionId = value;
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

			[JsonProperty(PropertyName = "LogType")]
			public string LogType
			{
				get
				{
					return logType;
				}
				set	
				{
					logType = value;
				}
			}

			[JsonProperty(PropertyName = "Timestamp")]
			public string Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}
		}
	}
}
