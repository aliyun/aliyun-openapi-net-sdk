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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeParametersHistoryResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeParametersHistory_Data> respond;

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

		[JsonProperty(PropertyName = "Respond")]
		public List<DescribeParametersHistory_Data> Respond
		{
			get
			{
				return respond;
			}
			set	
			{
				respond = value;
			}
		}

		public class DescribeParametersHistory_Data
		{

			private int? totalCount;

			private int? pageNumber;

			private List<DescribeParametersHistory_ParametersItem> parameters;

			[JsonProperty(PropertyName = "TotalCount")]
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

			[JsonProperty(PropertyName = "Parameters")]
			public List<DescribeParametersHistory_ParametersItem> Parameters
			{
				get
				{
					return parameters;
				}
				set	
				{
					parameters = value;
				}
			}

			public class DescribeParametersHistory_ParametersItem
			{

				private string status;

				private string oldValue;

				private string updateTime;

				private string createTime;

				private string dimensionValue;

				private string name;

				private string newValue;

				[JsonProperty(PropertyName = "Status")]
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

				[JsonProperty(PropertyName = "OldValue")]
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

				[JsonProperty(PropertyName = "UpdateTime")]
				public string UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				[JsonProperty(PropertyName = "CreateTime")]
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

				[JsonProperty(PropertyName = "DimensionValue")]
				public string DimensionValue
				{
					get
					{
						return dimensionValue;
					}
					set	
					{
						dimensionValue = value;
					}
				}

				[JsonProperty(PropertyName = "Name")]
				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				[JsonProperty(PropertyName = "NewValue")]
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
			}
		}
	}
}
