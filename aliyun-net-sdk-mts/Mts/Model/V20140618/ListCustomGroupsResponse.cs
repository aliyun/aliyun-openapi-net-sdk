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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class ListCustomGroupsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private long? totalCount;

		private List<ListCustomGroups_CustomGroup> customGroups;

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

		public List<ListCustomGroups_CustomGroup> CustomGroups
		{
			get
			{
				return customGroups;
			}
			set	
			{
				customGroups = value;
			}
		}

		public class ListCustomGroups_CustomGroup
		{

			private string customGroupId;

			private string customGroupName;

			private string customGroupDescription;

			public string CustomGroupId
			{
				get
				{
					return customGroupId;
				}
				set	
				{
					customGroupId = value;
				}
			}

			public string CustomGroupName
			{
				get
				{
					return customGroupName;
				}
				set	
				{
					customGroupName = value;
				}
			}

			public string CustomGroupDescription
			{
				get
				{
					return customGroupDescription;
				}
				set	
				{
					customGroupDescription = value;
				}
			}
		}
	}
}
