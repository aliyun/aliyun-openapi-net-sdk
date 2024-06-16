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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class ListBindDataSourcesResponse : AcsResponse
	{

		private string requestId;

		private List<ListBindDataSources_DataItem> data;

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

		public List<ListBindDataSources_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class ListBindDataSources_DataItem
		{

			private string accountName;

			private string dataSourceInstanceId;

			private string dataSourceType;

			private string dataSourceName;

			private string dataSourceRemark;

			private int? logCount;

			private int? taskCount;

			private string accountId;

			private string cloudCode;

			public string AccountName
			{
				get
				{
					return accountName;
				}
				set	
				{
					accountName = value;
				}
			}

			public string DataSourceInstanceId
			{
				get
				{
					return dataSourceInstanceId;
				}
				set	
				{
					dataSourceInstanceId = value;
				}
			}

			public string DataSourceType
			{
				get
				{
					return dataSourceType;
				}
				set	
				{
					dataSourceType = value;
				}
			}

			public string DataSourceName
			{
				get
				{
					return dataSourceName;
				}
				set	
				{
					dataSourceName = value;
				}
			}

			public string DataSourceRemark
			{
				get
				{
					return dataSourceRemark;
				}
				set	
				{
					dataSourceRemark = value;
				}
			}

			public int? LogCount
			{
				get
				{
					return logCount;
				}
				set	
				{
					logCount = value;
				}
			}

			public int? TaskCount
			{
				get
				{
					return taskCount;
				}
				set	
				{
					taskCount = value;
				}
			}

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			public string CloudCode
			{
				get
				{
					return cloudCode;
				}
				set	
				{
					cloudCode = value;
				}
			}
		}
	}
}
