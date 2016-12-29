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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDomainLogsResponse : AcsResponse
	{

		private long? totalCount;

		private long? pageNumber;

		private long? pageSize;

		private List<DomainLog> domainLogs;

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DomainLog> DomainLogs
		{
			get
			{
				return domainLogs;
			}
			set	
			{
				domainLogs = value;
			}
		}

		public class DomainLog{

			private string actionTime;

			private string domainName;

			private string action;

			private string message;

			private string clientIp;

			public string ActionTime
			{
				get
				{
					return actionTime;
				}
				set	
				{
					actionTime = value;
				}
			}

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string Action
			{
				get
				{
					return action;
				}
				set	
				{
					action = value;
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

			public string ClientIp
			{
				get
				{
					return clientIp;
				}
				set	
				{
					clientIp = value;
				}
			}
		}
	}
}