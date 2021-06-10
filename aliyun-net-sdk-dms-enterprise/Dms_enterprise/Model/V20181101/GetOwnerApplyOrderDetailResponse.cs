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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetOwnerApplyOrderDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetOwnerApplyOrderDetail_OwnerApplyOrderDetail ownerApplyOrderDetail;

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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "ErrorMessage")]
		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		[JsonProperty(PropertyName = "ErrorCode")]
		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		[JsonProperty(PropertyName = "OwnerApplyOrderDetail")]
		public GetOwnerApplyOrderDetail_OwnerApplyOrderDetail OwnerApplyOrderDetail
		{
			get
			{
				return ownerApplyOrderDetail;
			}
			set	
			{
				ownerApplyOrderDetail = value;
			}
		}

		public class GetOwnerApplyOrderDetail_OwnerApplyOrderDetail
		{

			private string applyType;

			private List<GetOwnerApplyOrderDetail_Resource> resources;

			[JsonProperty(PropertyName = "ApplyType")]
			public string ApplyType
			{
				get
				{
					return applyType;
				}
				set	
				{
					applyType = value;
				}
			}

			[JsonProperty(PropertyName = "Resources")]
			public List<GetOwnerApplyOrderDetail_Resource> Resources
			{
				get
				{
					return resources;
				}
				set	
				{
					resources = value;
				}
			}

			public class GetOwnerApplyOrderDetail_Resource
			{

				private bool? logic;

				private string targetId;

				private GetOwnerApplyOrderDetail_ResourceDetail resourceDetail;

				[JsonProperty(PropertyName = "Logic")]
				public bool? Logic
				{
					get
					{
						return logic;
					}
					set	
					{
						logic = value;
					}
				}

				[JsonProperty(PropertyName = "TargetId")]
				public string TargetId
				{
					get
					{
						return targetId;
					}
					set	
					{
						targetId = value;
					}
				}

				[JsonProperty(PropertyName = "ResourceDetail")]
				public GetOwnerApplyOrderDetail_ResourceDetail ResourceDetail
				{
					get
					{
						return resourceDetail;
					}
					set	
					{
						resourceDetail = value;
					}
				}

				public class GetOwnerApplyOrderDetail_ResourceDetail
				{

					private string searchName;

					private string dbType;

					private string envType;

					private string tableName;

					private List<string> ownerIds;

					private List<string> ownerNickNames;

					[JsonProperty(PropertyName = "SearchName")]
					public string SearchName
					{
						get
						{
							return searchName;
						}
						set	
						{
							searchName = value;
						}
					}

					[JsonProperty(PropertyName = "DbType")]
					public string DbType
					{
						get
						{
							return dbType;
						}
						set	
						{
							dbType = value;
						}
					}

					[JsonProperty(PropertyName = "EnvType")]
					public string EnvType
					{
						get
						{
							return envType;
						}
						set	
						{
							envType = value;
						}
					}

					[JsonProperty(PropertyName = "TableName")]
					public string TableName
					{
						get
						{
							return tableName;
						}
						set	
						{
							tableName = value;
						}
					}

					[JsonProperty(PropertyName = "OwnerIds")]
					public List<string> OwnerIds
					{
						get
						{
							return ownerIds;
						}
						set	
						{
							ownerIds = value;
						}
					}

					[JsonProperty(PropertyName = "OwnerNickNames")]
					public List<string> OwnerNickNames
					{
						get
						{
							return ownerNickNames;
						}
						set	
						{
							ownerNickNames = value;
						}
					}
				}
			}
		}
	}
}
