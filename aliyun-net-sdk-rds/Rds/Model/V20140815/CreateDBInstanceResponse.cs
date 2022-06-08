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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class CreateDBInstanceResponse : AcsResponse
	{

		private bool? dryRunResult;

		private bool? tagResult;

		private string requestId;

		private string connectionString;

		private string message;

		private string dBInstanceId;

		private string port;

		private string taskId;

		private bool? dryRun;

		private string orderId;

		[JsonProperty(PropertyName = "DryRunResult")]
		public bool? DryRunResult
		{
			get
			{
				return dryRunResult;
			}
			set	
			{
				dryRunResult = value;
			}
		}

		[JsonProperty(PropertyName = "TagResult")]
		public bool? TagResult
		{
			get
			{
				return tagResult;
			}
			set	
			{
				tagResult = value;
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

		[JsonProperty(PropertyName = "ConnectionString")]
		public string ConnectionString
		{
			get
			{
				return connectionString;
			}
			set	
			{
				connectionString = value;
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

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
			}
		}

		[JsonProperty(PropertyName = "Port")]
		public string Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
			}
		}

		[JsonProperty(PropertyName = "TaskId")]
		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
			}
		}

		[JsonProperty(PropertyName = "DryRun")]
		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
			}
		}

		[JsonProperty(PropertyName = "OrderId")]
		public string OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
			}
		}
	}
}
