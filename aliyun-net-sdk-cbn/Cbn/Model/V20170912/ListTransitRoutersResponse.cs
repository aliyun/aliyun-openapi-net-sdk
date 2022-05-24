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
	public class ListTransitRoutersResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<ListTransitRouters_TransitRouter> transitRouters;

		public int? PageSize
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

		public int? PageNumber
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

		public List<ListTransitRouters_TransitRouter> TransitRouters
		{
			get
			{
				return transitRouters;
			}
			set	
			{
				transitRouters = value;
			}
		}

		public class ListTransitRouters_TransitRouter
		{

			private string creationTime;

			private string type;

			private string status;

			private string transitRouterId;

			private string transitRouterDescription;

			private string transitRouterName;

			private string cenId;

			private long? aliUid;

			private string regionId;

			private string serviceMode;

			private bool? supportMulticast;

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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

			public string TransitRouterId
			{
				get
				{
					return transitRouterId;
				}
				set	
				{
					transitRouterId = value;
				}
			}

			public string TransitRouterDescription
			{
				get
				{
					return transitRouterDescription;
				}
				set	
				{
					transitRouterDescription = value;
				}
			}

			public string TransitRouterName
			{
				get
				{
					return transitRouterName;
				}
				set	
				{
					transitRouterName = value;
				}
			}

			public string CenId
			{
				get
				{
					return cenId;
				}
				set	
				{
					cenId = value;
				}
			}

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string ServiceMode
			{
				get
				{
					return serviceMode;
				}
				set	
				{
					serviceMode = value;
				}
			}

			public bool? SupportMulticast
			{
				get
				{
					return supportMulticast;
				}
				set	
				{
					supportMulticast = value;
				}
			}
		}
	}
}
