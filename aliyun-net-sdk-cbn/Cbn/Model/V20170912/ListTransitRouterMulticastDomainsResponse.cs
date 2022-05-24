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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class ListTransitRouterMulticastDomainsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private string nextToken;

		private List<ListTransitRouterMulticastDomains_TransitRouterMulticastDomain> transitRouterMulticastDomains;

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

		public int? TotalCount
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

		public List<ListTransitRouterMulticastDomains_TransitRouterMulticastDomain> TransitRouterMulticastDomains
		{
			get
			{
				return transitRouterMulticastDomains;
			}
			set	
			{
				transitRouterMulticastDomains = value;
			}
		}

		public class ListTransitRouterMulticastDomains_TransitRouterMulticastDomain
		{

			private string transitRouterMulticastDomainId;

			private string transitRouterMulticastDomainName;

			private string transitRouterMulticastDomainDescription;

			private string status;

			public string TransitRouterMulticastDomainId
			{
				get
				{
					return transitRouterMulticastDomainId;
				}
				set	
				{
					transitRouterMulticastDomainId = value;
				}
			}

			public string TransitRouterMulticastDomainName
			{
				get
				{
					return transitRouterMulticastDomainName;
				}
				set	
				{
					transitRouterMulticastDomainName = value;
				}
			}

			public string TransitRouterMulticastDomainDescription
			{
				get
				{
					return transitRouterMulticastDomainDescription;
				}
				set	
				{
					transitRouterMulticastDomainDescription = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}
		}
	}
}
