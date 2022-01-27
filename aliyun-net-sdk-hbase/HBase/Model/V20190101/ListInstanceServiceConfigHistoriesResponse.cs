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

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class ListInstanceServiceConfigHistoriesResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageRecordCount;

		private long? totalRecordCount;

		private List<ListInstanceServiceConfigHistories_Config> configureHistoryList;

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

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public long? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public List<ListInstanceServiceConfigHistories_Config> ConfigureHistoryList
		{
			get
			{
				return configureHistoryList;
			}
			set	
			{
				configureHistoryList = value;
			}
		}

		public class ListInstanceServiceConfigHistories_Config
		{

			private string configureName;

			private string oldValue;

			private string newValue;

			private string effective;

			private string createTime;

			public string ConfigureName
			{
				get
				{
					return configureName;
				}
				set	
				{
					configureName = value;
				}
			}

			public string OldValue
			{
				get
				{
					return oldValue;
				}
				set	
				{
					oldValue = value;
				}
			}

			public string NewValue
			{
				get
				{
					return newValue;
				}
				set	
				{
					newValue = value;
				}
			}

			public string Effective
			{
				get
				{
					return effective;
				}
				set	
				{
					effective = value;
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
		}
	}
}
