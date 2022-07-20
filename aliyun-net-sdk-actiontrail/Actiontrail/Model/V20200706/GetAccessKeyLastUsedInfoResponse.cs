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

namespace Aliyun.Acs.Actiontrail.Model.V20200706
{
	public class GetAccessKeyLastUsedInfoResponse : AcsResponse
	{

		private string requestId;

		private string accessKeyId;

		private string accountId;

		private string ownerId;

		private string userName;

		private string accountType;

		private long? usedTimestamp;

		private string detail;

		private string source;

		private string serviceName;

		private string serviceNameCn;

		private string serviceNameEn;

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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
			}
		}

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
			}
		}

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

		public string AccountType
		{
			get
			{
				return accountType;
			}
			set	
			{
				accountType = value;
			}
		}

		public long? UsedTimestamp
		{
			get
			{
				return usedTimestamp;
			}
			set	
			{
				usedTimestamp = value;
			}
		}

		public string Detail
		{
			get
			{
				return detail;
			}
			set	
			{
				detail = value;
			}
		}

		public string Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
			}
		}

		public string ServiceNameCn
		{
			get
			{
				return serviceNameCn;
			}
			set	
			{
				serviceNameCn = value;
			}
		}

		public string ServiceNameEn
		{
			get
			{
				return serviceNameEn;
			}
			set	
			{
				serviceNameEn = value;
			}
		}
	}
}
