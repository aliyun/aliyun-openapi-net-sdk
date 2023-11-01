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
	public class DescribeCloudSiemEventsResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private DescribeCloudSiemEvents_Data data;

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

		public DescribeCloudSiemEvents_Data Data
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

		public class DescribeCloudSiemEvents_Data
		{

			private List<DescribeCloudSiemEvents_ResponseDataItem> responseData;

			private DescribeCloudSiemEvents_PageInfo pageInfo;

			public List<DescribeCloudSiemEvents_ResponseDataItem> ResponseData
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

			public DescribeCloudSiemEvents_PageInfo PageInfo
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

			public class DescribeCloudSiemEvents_ResponseDataItem
			{

				private string gmtCreate;

				private string gmtModified;

				private long? aliuid;

				private int? alertNum;

				private int? assetNum;

				private string incidentUuid;

				private string incidentName;

				private string incidentNameEn;

				private string description;

				private string descriptionEn;

				private string threatLevel;

				private float? threatScore;

				private string extContent;

				private int? status;

				private string remark;

				private List<string> dataSources;

				private List<string> attCkLabels;

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

				public int? AlertNum
				{
					get
					{
						return alertNum;
					}
					set	
					{
						alertNum = value;
					}
				}

				public int? AssetNum
				{
					get
					{
						return assetNum;
					}
					set	
					{
						assetNum = value;
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

				public string IncidentName
				{
					get
					{
						return incidentName;
					}
					set	
					{
						incidentName = value;
					}
				}

				public string IncidentNameEn
				{
					get
					{
						return incidentNameEn;
					}
					set	
					{
						incidentNameEn = value;
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

				public string DescriptionEn
				{
					get
					{
						return descriptionEn;
					}
					set	
					{
						descriptionEn = value;
					}
				}

				public string ThreatLevel
				{
					get
					{
						return threatLevel;
					}
					set	
					{
						threatLevel = value;
					}
				}

				public float? ThreatScore
				{
					get
					{
						return threatScore;
					}
					set	
					{
						threatScore = value;
					}
				}

				public string ExtContent
				{
					get
					{
						return extContent;
					}
					set	
					{
						extContent = value;
					}
				}

				public int? Status
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

				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
					}
				}

				public List<string> DataSources
				{
					get
					{
						return dataSources;
					}
					set	
					{
						dataSources = value;
					}
				}

				public List<string> AttCkLabels
				{
					get
					{
						return attCkLabels;
					}
					set	
					{
						attCkLabels = value;
					}
				}
			}

			public class DescribeCloudSiemEvents_PageInfo
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
