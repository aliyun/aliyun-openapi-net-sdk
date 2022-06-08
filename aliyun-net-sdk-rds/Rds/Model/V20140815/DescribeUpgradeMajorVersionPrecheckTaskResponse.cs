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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeUpgradeMajorVersionPrecheckTaskResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageRecordCount;

		private int? totalRecordCount;

		private List<DescribeUpgradeMajorVersionPrecheckTask_Tasks> items;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "PageRecordCount")]
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

		[JsonProperty(PropertyName = "TotalRecordCount")]
		public int? TotalRecordCount
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

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeUpgradeMajorVersionPrecheckTask_Tasks> Items
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

		public class DescribeUpgradeMajorVersionPrecheckTask_Tasks
		{

			private string targetMajorVersion;

			private string effectiveTime;

			private string sourceMajorVersion;

			private string result;

			private int? taskId;

			private string detail;

			private string checkTime;

			[JsonProperty(PropertyName = "TargetMajorVersion")]
			public string TargetMajorVersion
			{
				get
				{
					return targetMajorVersion;
				}
				set	
				{
					targetMajorVersion = value;
				}
			}

			[JsonProperty(PropertyName = "EffectiveTime")]
			public string EffectiveTime
			{
				get
				{
					return effectiveTime;
				}
				set	
				{
					effectiveTime = value;
				}
			}

			[JsonProperty(PropertyName = "SourceMajorVersion")]
			public string SourceMajorVersion
			{
				get
				{
					return sourceMajorVersion;
				}
				set	
				{
					sourceMajorVersion = value;
				}
			}

			[JsonProperty(PropertyName = "Result")]
			public string Result
			{
				get
				{
					return result;
				}
				set	
				{
					result = value;
				}
			}

			[JsonProperty(PropertyName = "TaskId")]
			public int? TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			[JsonProperty(PropertyName = "Detail")]
			public string Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			[JsonProperty(PropertyName = "CheckTime")]
			public string CheckTime
			{
				get
				{
					return checkTime;
				}
				set	
				{
					checkTime = value;
				}
			}
		}
	}
}
