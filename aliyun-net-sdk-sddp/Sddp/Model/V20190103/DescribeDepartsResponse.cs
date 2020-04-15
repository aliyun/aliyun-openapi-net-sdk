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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeDepartsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeDeparts_Depart> items;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public List<DescribeDeparts_Depart> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeDeparts_Depart
		{

			private long? id;

			private long? departId;

			private string departName;

			private string comment;

			private long? parentDepartId;

			private string parentDepartName;

			private int? level;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public long? DepartId
			{
				get
				{
					return departId;
				}
				set	
				{
					departId = value;
				}
			}

			public string DepartName
			{
				get
				{
					return departName;
				}
				set	
				{
					departName = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public long? ParentDepartId
			{
				get
				{
					return parentDepartId;
				}
				set	
				{
					parentDepartId = value;
				}
			}

			public string ParentDepartName
			{
				get
				{
					return parentDepartName;
				}
				set	
				{
					parentDepartName = value;
				}
			}

			public int? Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}
		}
	}
}
