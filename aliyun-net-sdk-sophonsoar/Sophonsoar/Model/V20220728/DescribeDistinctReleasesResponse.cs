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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribeDistinctReleasesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDistinctReleases_RecordsItem> records;

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

		public List<DescribeDistinctReleases_RecordsItem> Records
		{
			get
			{
				return records;
			}
			set	
			{
				records = value;
			}
		}

		public class DescribeDistinctReleases_RecordsItem
		{

			private string description;

			private string taskflowMd5;

			private int? flowFlag;

			private int? flowTag;

			private string taskflowType;

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string TaskflowMd5
			{
				get
				{
					return taskflowMd5;
				}
				set	
				{
					taskflowMd5 = value;
				}
			}

			public int? FlowFlag
			{
				get
				{
					return flowFlag;
				}
				set	
				{
					flowFlag = value;
				}
			}

			public int? FlowTag
			{
				get
				{
					return flowTag;
				}
				set	
				{
					flowTag = value;
				}
			}

			public string TaskflowType
			{
				get
				{
					return taskflowType;
				}
				set	
				{
					taskflowType = value;
				}
			}
		}
	}
}
