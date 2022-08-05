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

namespace Aliyun.Acs.oos.Model.V20190601
{
	public class ListPatchBaselinesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? maxResults;

		private List<ListPatchBaselines_PatchBaseline> patchBaselines;

		[JsonProperty(PropertyName = "NextToken")]
		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

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

		[JsonProperty(PropertyName = "MaxResults")]
		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		[JsonProperty(PropertyName = "PatchBaselines")]
		public List<ListPatchBaselines_PatchBaseline> PatchBaselines
		{
			get
			{
				return patchBaselines;
			}
			set	
			{
				patchBaselines = value;
			}
		}

		public class ListPatchBaselines_PatchBaseline
		{

			private string operationSystem;

			private bool? isDefault;

			private string description;

			private string updatedDate;

			private string updatedBy;

			private string createdBy;

			private string createdDate;

			private string name;

			private string id;

			private string shareType;

			[JsonProperty(PropertyName = "OperationSystem")]
			public string OperationSystem
			{
				get
				{
					return operationSystem;
				}
				set	
				{
					operationSystem = value;
				}
			}

			[JsonProperty(PropertyName = "IsDefault")]
			public bool? IsDefault
			{
				get
				{
					return isDefault;
				}
				set	
				{
					isDefault = value;
				}
			}

			[JsonProperty(PropertyName = "Description")]
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

			[JsonProperty(PropertyName = "UpdatedDate")]
			public string UpdatedDate
			{
				get
				{
					return updatedDate;
				}
				set	
				{
					updatedDate = value;
				}
			}

			[JsonProperty(PropertyName = "UpdatedBy")]
			public string UpdatedBy
			{
				get
				{
					return updatedBy;
				}
				set	
				{
					updatedBy = value;
				}
			}

			[JsonProperty(PropertyName = "CreatedBy")]
			public string CreatedBy
			{
				get
				{
					return createdBy;
				}
				set	
				{
					createdBy = value;
				}
			}

			[JsonProperty(PropertyName = "CreatedDate")]
			public string CreatedDate
			{
				get
				{
					return createdDate;
				}
				set	
				{
					createdDate = value;
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

			[JsonProperty(PropertyName = "Id")]
			public string Id
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

			[JsonProperty(PropertyName = "ShareType")]
			public string ShareType
			{
				get
				{
					return shareType;
				}
				set	
				{
					shareType = value;
				}
			}
		}
	}
}
