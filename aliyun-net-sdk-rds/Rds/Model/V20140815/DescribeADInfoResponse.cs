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
	public class DescribeADInfoResponse : AcsResponse
	{

		private string aDStatus;

		private string requestId;

		private string aDDNS;

		private string aDServerIpAddress;

		private string abnormalReason;

		private string userName;

		[JsonProperty(PropertyName = "ADStatus")]
		public string ADStatus
		{
			get
			{
				return aDStatus;
			}
			set	
			{
				aDStatus = value;
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

		[JsonProperty(PropertyName = "ADDNS")]
		public string ADDNS
		{
			get
			{
				return aDDNS;
			}
			set	
			{
				aDDNS = value;
			}
		}

		[JsonProperty(PropertyName = "ADServerIpAddress")]
		public string ADServerIpAddress
		{
			get
			{
				return aDServerIpAddress;
			}
			set	
			{
				aDServerIpAddress = value;
			}
		}

		[JsonProperty(PropertyName = "AbnormalReason")]
		public string AbnormalReason
		{
			get
			{
				return abnormalReason;
			}
			set	
			{
				abnormalReason = value;
			}
		}

		[JsonProperty(PropertyName = "UserName")]
		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
			}
		}
	}
}
