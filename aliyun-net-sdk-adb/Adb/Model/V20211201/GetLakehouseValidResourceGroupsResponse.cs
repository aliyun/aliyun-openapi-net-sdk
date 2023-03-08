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
	public class GetLakehouseValidResourceGroupsResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private long? httpStatusCode;

		private bool? success;

		private GetLakehouseValidResourceGroups_Data data;

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

		public GetLakehouseValidResourceGroups_Data Data
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

		public class GetLakehouseValidResourceGroups_Data
		{

			private long? lakehouseMinComputeResource;

			private List<GetLakehouseValidResourceGroups_ValidPoolsInfoItem> validPoolsInfo;

			public long? LakehouseMinComputeResource
			{
				get
				{
					return lakehouseMinComputeResource;
				}
				set	
				{
					lakehouseMinComputeResource = value;
				}
			}

			public List<GetLakehouseValidResourceGroups_ValidPoolsInfoItem> ValidPoolsInfo
			{
				get
				{
					return validPoolsInfo;
				}
				set	
				{
					validPoolsInfo = value;
				}
			}

			public class GetLakehouseValidResourceGroups_ValidPoolsInfoItem
			{

				private string maxComputeResource;

				private string minComputeResource;

				private string groupName;

				private string groupType;

				private bool? available;

				private List<string> cuOptions;

				public string MaxComputeResource
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

				public string MinComputeResource
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
