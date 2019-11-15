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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeDomainTopClientIpVisitResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDomainTopClientIpVisit_ClientIp> clientIpList;

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

		public List<DescribeDomainTopClientIpVisit_ClientIp> ClientIpList
		{
			get
			{
				return clientIpList;
			}
			set	
			{
				clientIpList = value;
			}
		}

		public class DescribeDomainTopClientIpVisit_ClientIp
		{

			private int? rank;

			private string clientIp;

			private long? traffic;

			private long? acc;

			public int? Rank
			{
				get
				{
					return rank;
				}
				set	
				{
					rank = value;
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

			public long? Traffic
			{
				get
				{
					return traffic;
				}
				set	
				{
					traffic = value;
				}
			}

			public long? Acc
			{
				get
				{
					return acc;
				}
				set	
				{
					acc = value;
				}
			}
		}
	}
}
