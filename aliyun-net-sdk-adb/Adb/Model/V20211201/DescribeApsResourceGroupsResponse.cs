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

namespace Aliyun.Acs.adb.Model.V20211201
{
	public class DescribeApsResourceGroupsResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private long? httpStatusCode;

		private bool? success;

		private DescribeApsResourceGroups_Data data;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public long? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public DescribeApsResourceGroups_Data Data
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

		public class DescribeApsResourceGroups_Data
		{

			private long? step;

			private List<DescribeApsResourceGroups_ValidPoolsInfo> resourceGroups;

			public long? Step
			{
				get
				{
					return step;
				}
				set	
				{
					step = value;
				}
			}

			public List<DescribeApsResourceGroups_ValidPoolsInfo> ResourceGroups
			{
				get
				{
					return resourceGroups;
				}
				set	
				{
					resourceGroups = value;
				}
			}

			public class DescribeApsResourceGroups_ValidPoolsInfo
			{

				private int? maxComputeResource;

				private int? minComputeResource;

				private string groupName;

				private string groupType;

				private bool? available;

				private List<string> cuOptions;

				public int? MaxComputeResource
				{
					get
					{
						return maxComputeResource;
					}
					set	
					{
						maxComputeResource = value;
					}
				}

				public int? MinComputeResource
				{
					get
					{
						return minComputeResource;
					}
					set	
					{
						minComputeResource = value;
					}
				}

				public string GroupName
				{
					get
					{
						return groupName;
					}
					set	
					{
						groupName = value;
					}
				}

				public string GroupType
				{
					get
					{
						return groupType;
					}
					set	
					{
						groupType = value;
					}
				}

				public bool? Available
				{
					get
					{
						return available;
					}
					set	
					{
						available = value;
					}
				}

				public List<string> CuOptions
				{
					get
					{
						return cuOptions;
					}
					set	
					{
						cuOptions = value;
					}
				}
			}
		}
	}
}
