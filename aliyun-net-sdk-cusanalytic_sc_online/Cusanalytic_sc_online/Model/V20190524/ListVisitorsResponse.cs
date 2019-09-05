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

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
	public class ListVisitorsResponse : AcsResponse
	{

		private long? total;

		private int? pageIndex;

		private int? pageSize;

		private List<ListVisitors_VisitorItem> visitorItems;

		public long? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
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

		public List<ListVisitors_VisitorItem> VisitorItems
		{
			get
			{
				return visitorItems;
			}
			set	
			{
				visitorItems = value;
			}
		}

		public class ListVisitors_VisitorItem
		{

			private string img;

			private string pkId;

			private long? latelyTime;

			private string earliestPlace;

			private string ukId;

			private string gender;

			private long? earliestTime;

			private string latelyPlace;

			private long? age;

			private long? storeId;

			private long? enterCount;

			public string Img
			{
				get
				{
					return img;
				}
				set	
				{
					img = value;
				}
			}

			public string PkId
			{
				get
				{
					return pkId;
				}
				set	
				{
					pkId = value;
				}
			}

			public long? LatelyTime
			{
				get
				{
					return latelyTime;
				}
				set	
				{
					latelyTime = value;
				}
			}

			public string EarliestPlace
			{
				get
				{
					return earliestPlace;
				}
				set	
				{
					earliestPlace = value;
				}
			}

			public string UkId
			{
				get
				{
					return ukId;
				}
				set	
				{
					ukId = value;
				}
			}

			public string Gender
			{
				get
				{
					return gender;
				}
				set	
				{
					gender = value;
				}
			}

			public long? EarliestTime
			{
				get
				{
					return earliestTime;
				}
				set	
				{
					earliestTime = value;
				}
			}

			public string LatelyPlace
			{
				get
				{
					return latelyPlace;
				}
				set	
				{
					latelyPlace = value;
				}
			}

			public long? Age
			{
				get
				{
					return age;
				}
				set	
				{
					age = value;
				}
			}

			public long? StoreId
			{
				get
				{
					return storeId;
				}
				set	
				{
					storeId = value;
				}
			}

			public long? EnterCount
			{
				get
				{
					return enterCount;
				}
				set	
				{
					enterCount = value;
				}
			}
		}
	}
}
