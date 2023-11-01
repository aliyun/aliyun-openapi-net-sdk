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
	public class DescribeCloudSiemAssetsResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private DescribeCloudSiemAssets_Data data;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public DescribeCloudSiemAssets_Data Data
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

		public class DescribeCloudSiemAssets_Data
		{

			private List<DescribeCloudSiemAssets_ResponseDataItem> responseData;

			private DescribeCloudSiemAssets_PageInfo pageInfo;

			public List<DescribeCloudSiemAssets_ResponseDataItem> ResponseData
			{
				get
				{
					return responseData;
				}
				set	
				{
					responseData = value;
				}
			}

			public DescribeCloudSiemAssets_PageInfo PageInfo
			{
				get
				{
					return pageInfo;
				}
				set	
				{
					pageInfo = value;
				}
			}

			public class DescribeCloudSiemAssets_ResponseDataItem
			{

				private long? id;

				private string gmtCreate;

				private string gmtModified;

				private long? aliuid;

				private long? subUserId;

				private string incidentUuid;

				private string alertUuid;

				private string assetName;

				private string assetType;

				private string assetId;

				private string cloudCode;

				private List<DescribeCloudSiemAssets_AssetInfoItem> assetInfo;

				public long? Id
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

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public long? Aliuid
				{
					get
					{
						return aliuid;
					}
					set	
					{
						aliuid = value;
					}
				}

				public long? SubUserId
				{
					get
					{
						return subUserId;
					}
					set	
					{
						subUserId = value;
					}
				}

				public string IncidentUuid
				{
					get
					{
						return incidentUuid;
					}
					set	
					{
						incidentUuid = value;
					}
				}

				public string AlertUuid
				{
					get
					{
						return alertUuid;
					}
					set	
					{
						alertUuid = value;
					}
				}

				public string AssetName
				{
					get
					{
						return assetName;
					}
					set	
					{
						assetName = value;
					}
				}

				public string AssetType
				{
					get
					{
						return assetType;
					}
					set	
					{
						assetType = value;
					}
				}

				public string AssetId
				{
					get
					{
						return assetId;
					}
					set	
					{
						assetId = value;
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

				public List<DescribeCloudSiemAssets_AssetInfoItem> AssetInfo
				{
					get
					{
						return assetInfo;
					}
					set	
					{
						assetInfo = value;
					}
				}

				public class DescribeCloudSiemAssets_AssetInfoItem
				{

					private string key;

					private string keyName;

					private string values;

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}

					public string KeyName
					{
						get
						{
							return keyName;
						}
						set	
						{
							keyName = value;
						}
					}

					public string Values
					{
						get
						{
							return values;
						}
						set	
						{
							values = value;
						}
					}
				}
			}

			public class DescribeCloudSiemAssets_PageInfo
			{

				private int? currentPage;

				private int? pageSize;

				private long? totalCount;

				public int? CurrentPage
				{
					get
					{
						return currentPage;
					}
					set	
					{
						currentPage = value;
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

				public long? TotalCount
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
			}
		}
	}
}
