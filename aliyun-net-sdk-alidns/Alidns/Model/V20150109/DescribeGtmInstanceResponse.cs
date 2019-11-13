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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeGtmInstanceResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private string instanceName;

		private string versionCode;

		private string expireTime;

		private long? expireTimestamp;

		private string cname;

		private string userDomainName;

		private int? ttl;

		private string lbaStrategy;

		private string createTime;

		private long? createTimestamp;

		private string alertGroup;

		private string cnameMode;

		private int? accessStrategyNum;

		private int? addressPoolNum;

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

		public string InstanceId
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

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
			}
		}

		public string VersionCode
		{
			get
			{
				return versionCode;
			}
			set	
			{
				versionCode = value;
			}
		}

		public string ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
			}
		}

		public long? ExpireTimestamp
		{
			get
			{
				return expireTimestamp;
			}
			set	
			{
				expireTimestamp = value;
			}
		}

		public string Cname
		{
			get
			{
				return cname;
			}
			set	
			{
				cname = value;
			}
		}

		public string UserDomainName
		{
			get
			{
				return userDomainName;
			}
			set	
			{
				userDomainName = value;
			}
		}

		public int? Ttl
		{
			get
			{
				return ttl;
			}
			set	
			{
				ttl = value;
			}
		}

		public string LbaStrategy
		{
			get
			{
				return lbaStrategy;
			}
			set	
			{
				lbaStrategy = value;
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public long? CreateTimestamp
		{
			get
			{
				return createTimestamp;
			}
			set	
			{
				createTimestamp = value;
			}
		}

		public string AlertGroup
		{
			get
			{
				return alertGroup;
			}
			set	
			{
				alertGroup = value;
			}
		}

		public string CnameMode
		{
			get
			{
				return cnameMode;
			}
			set	
			{
				cnameMode = value;
			}
		}

		public int? AccessStrategyNum
		{
			get
			{
				return accessStrategyNum;
			}
			set	
			{
				accessStrategyNum = value;
			}
		}

		public int? AddressPoolNum
		{
			get
			{
				return addressPoolNum;
			}
			set	
			{
				addressPoolNum = value;
			}
		}
	}
}
