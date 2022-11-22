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
	public class ListTransitRouterRouteTablesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private List<ListTransitRouterRouteTables_TransitRouterRouteTable> transitRouterRouteTables;

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

		public List<ListTransitRouterRouteTables_TransitRouterRouteTable> TransitRouterRouteTables
		{
			get
			{
				return transitRouterRouteTables;
			}
			set	
			{
				transitRouterRouteTables = value;
			}
		}

		public class ListTransitRouterRouteTables_TransitRouterRouteTable
		{

			private string transitRouterRouteTableStatus;

			private string transitRouterRouteTableType;

			private string createTime;

			private string transitRouterRouteTableId;

			private string transitRouterRouteTableName;

			private string transitRouterRouteTableDescription;

			private List<ListTransitRouterRouteTables_Tag> tags;

			public string TransitRouterRouteTableStatus
			{
				get
				{
					return transitRouterRouteTableStatus;
				}
				set	
				{
					transitRouterRouteTableStatus = value;
				}
			}

			public string TransitRouterRouteTableType
			{
				get
				{
					return transitRouterRouteTableType;
				}
				set	
				{
					transitRouterRouteTableType = value;
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

			public string TransitRouterRouteTableId
			{
				get
				{
					return transitRouterRouteTableId;
				}
				set	
				{
					transitRouterRouteTableId = value;
				}
			}

			public string TransitRouterRouteTableName
			{
				get
				{
					return transitRouterRouteTableName;
				}
				set	
				{
					transitRouterRouteTableName = value;
				}
			}

			public string TransitRouterRouteTableDescription
			{
				get
				{
					return transitRouterRouteTableDescription;
				}
				set	
				{
					transitRouterRouteTableDescription = value;
				}
			}

			public List<ListTransitRouterRouteTables_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public class ListTransitRouterRouteTables_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
