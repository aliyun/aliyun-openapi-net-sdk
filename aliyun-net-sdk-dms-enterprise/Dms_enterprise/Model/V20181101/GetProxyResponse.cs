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
	public class GetProxyResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private long? proxyId;

		private long? creatorId;

		private string creatorName;

		private long? instanceId;

		private bool? privateEnable;

		private string privateHost;

		private bool? publicEnable;

		private string publicHost;

		private int? mysqlPort;

		private int? httpsPort;

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

		[JsonProperty(PropertyName = "ProxyId")]
		public long? ProxyId
		{
			get
			{
				return proxyId;
			}
			set	
			{
				proxyId = value;
			}
		}

		[JsonProperty(PropertyName = "CreatorId")]
		public long? CreatorId
		{
			get
			{
				return creatorId;
			}
			set	
			{
				creatorId = value;
			}
		}

		[JsonProperty(PropertyName = "CreatorName")]
		public string CreatorName
		{
			get
			{
				return creatorName;
			}
			set	
			{
				creatorName = value;
			}
		}

		[JsonProperty(PropertyName = "InstanceId")]
		public long? InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
			}
		}

		[JsonProperty(PropertyName = "PrivateEnable")]
		public bool? PrivateEnable
		{
			get
			{
				return privateEnable;
			}
			set	
			{
				privateEnable = value;
			}
		}

		[JsonProperty(PropertyName = "PrivateHost")]
		public string PrivateHost
		{
			get
			{
				return privateHost;
			}
			set	
			{
				privateHost = value;
			}
		}

		[JsonProperty(PropertyName = "PublicEnable")]
		public bool? PublicEnable
		{
			get
			{
				return publicEnable;
			}
			set	
			{
				publicEnable = value;
			}
		}

		[JsonProperty(PropertyName = "PublicHost")]
		public string PublicHost
		{
			get
			{
				return publicHost;
			}
			set	
			{
				publicHost = value;
			}
		}

		[JsonProperty(PropertyName = "MysqlPort")]
		public int? MysqlPort
		{
			get
			{
				return mysqlPort;
			}
			set	
			{
				mysqlPort = value;
			}
		}

		[JsonProperty(PropertyName = "HttpsPort")]
		public int? HttpsPort
		{
			get
			{
				return httpsPort;
			}
			set	
			{
				httpsPort = value;
			}
		}
	}
}
