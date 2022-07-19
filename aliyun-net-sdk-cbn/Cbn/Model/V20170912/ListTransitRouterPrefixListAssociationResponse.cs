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
	public class ListTransitRouterPrefixListAssociationResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<ListTransitRouterPrefixListAssociation_PrefixList> prefixLists;

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

		public List<ListTransitRouterPrefixListAssociation_PrefixList> PrefixLists
		{
			get
			{
				return prefixLists;
			}
			set	
			{
				prefixLists = value;
			}
		}

		public class ListTransitRouterPrefixListAssociation_PrefixList
		{

			private string prefixListId;

			private long? ownerUid;

			private string status;

			private string nextHop;

			private string nextHopInstanceId;

			private string nextHopType;

			private string transitRouterTableId;

			public string PrefixListId
			{
				get
				{
					return prefixListId;
				}
				set	
				{
					prefixListId = value;
				}
			}

			public long? OwnerUid
			{
				get
				{
					return ownerUid;
				}
				set	
				{
					ownerUid = value;
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

			public string NextHop
			{
				get
				{
					return nextHop;
				}
				set	
				{
					nextHop = value;
				}
			}

			public string NextHopInstanceId
			{
				get
				{
					return nextHopInstanceId;
				}
				set	
				{
					nextHopInstanceId = value;
				}
			}

			public string NextHopType
			{
				get
				{
					return nextHopType;
				}
				set	
				{
					nextHopType = value;
				}
			}

			public string TransitRouterTableId
			{
				get
				{
					return transitRouterTableId;
				}
				set	
				{
					transitRouterTableId = value;
				}
			}
		}
	}
}
