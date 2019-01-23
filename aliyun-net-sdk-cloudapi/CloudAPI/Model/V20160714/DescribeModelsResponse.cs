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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeModelsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeModels_ModelDetail> modelDetails;

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

		public List<DescribeModels_ModelDetail> ModelDetails
		{
			get
			{
				return modelDetails;
			}
			set	
			{
				modelDetails = value;
			}
		}

		public class DescribeModels_ModelDetail
		{

			private string groupId;

			private string modelId;

			private string modelName;

			private string schema;

			private string description;

			private string createdTime;

			private string modifiedTime;

			private string modelRef;

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string ModelId
			{
				get
				{
					return modelId;
				}
				set	
				{
					modelId = value;
				}
			}

			public string ModelName
			{
				get
				{
					return modelName;
				}
				set	
				{
					modelName = value;
				}
			}

			public string Schema
			{
				get
				{
					return schema;
				}
				set	
				{
					schema = value;
				}
			}

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

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public string ModelRef
			{
				get
				{
					return modelRef;
				}
				set	
				{
					modelRef = value;
				}
			}
		}
	}
}