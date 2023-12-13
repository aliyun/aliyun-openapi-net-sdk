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
	public class DescribeAlertsResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private DescribeAlerts_Data data;

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

		public DescribeAlerts_Data Data
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

		public class DescribeAlerts_Data
		{

			private List<DescribeAlerts_ResponseDataItem> responseData;

			private DescribeAlerts_PageInfo pageInfo;

			public List<DescribeAlerts_ResponseDataItem> ResponseData
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

			public DescribeAlerts_PageInfo PageInfo
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

			public class DescribeAlerts_ResponseDataItem
			{

				private long? id;

				private string gmtCreate;

				private string gmtModified;

				private long? mainUserId;

				private string incidentUuid;

				private string alertUuid;

				private string logTime;

				private string alertSrcProd;

				private string alertTitle;

				private string alertTitleEn;

				private string alertType;

				private string alertTypeEn;

				private string alertTypeCode;

				private string alertName;

				private string alertNameEn;

				private string alertNameCode;

				private string alertLevel;

				private string assetList;

				private string occurTime;

				private string startTime;

				private string endTime;

				private string alertSrcProdModule;

				private string alertDesc;

				private string alertDescEn;

				private string alertDescCode;

				private string alertDetail;

				private string logUuid;

				private string attCk;

				private long? subUserId;

				private string cloudCode;

				private string isDefend;

				private List<DescribeAlerts_AlertInfoListItem> alertInfoList;

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

				public long? MainUserId
				{
					get
					{
						return mainUserId;
					}
					set	
					{
						mainUserId = value;
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

				public string LogTime
				{
					get
					{
						return logTime;
					}
					set	
					{
						logTime = value;
					}
				}

				public string AlertSrcProd
				{
					get
					{
						return alertSrcProd;
					}
					set	
					{
						alertSrcProd = value;
					}
				}

				public string AlertTitle
				{
					get
					{
						return alertTitle;
					}
					set	
					{
						alertTitle = value;
					}
				}

				public string AlertTitleEn
				{
					get
					{
						return alertTitleEn;
					}
					set	
					{
						alertTitleEn = value;
					}
				}

				public string AlertType
				{
					get
					{
						return alertType;
					}
					set	
					{
						alertType = value;
					}
				}

				public string AlertTypeEn
				{
					get
					{
						return alertTypeEn;
					}
					set	
					{
						alertTypeEn = value;
					}
				}

				public string AlertTypeCode
				{
					get
					{
						return alertTypeCode;
					}
					set	
					{
						alertTypeCode = value;
					}
				}

				public string AlertName
				{
					get
					{
						return alertName;
					}
					set	
					{
						alertName = value;
					}
				}

				public string AlertNameEn
				{
					get
					{
						return alertNameEn;
					}
					set	
					{
						alertNameEn = value;
					}
				}

				public string AlertNameCode
				{
					get
					{
						return alertNameCode;
					}
					set	
					{
						alertNameCode = value;
					}
				}

				public string AlertLevel
				{
					get
					{
						return alertLevel;
					}
					set	
					{
						alertLevel = value;
					}
				}

				public string AssetList
				{
					get
					{
						return assetList;
					}
					set	
					{
						assetList = value;
					}
				}

				public string OccurTime
				{
					get
					{
						return occurTime;
					}
					set	
					{
						occurTime = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public string AlertSrcProdModule
				{
					get
					{
						return alertSrcProdModule;
					}
					set	
					{
						alertSrcProdModule = value;
					}
				}

				public string AlertDesc
				{
					get
					{
						return alertDesc;
					}
					set	
					{
						alertDesc = value;
					}
				}

				public string AlertDescEn
				{
					get
					{
						return alertDescEn;
					}
					set	
					{
						alertDescEn = value;
					}
				}

				public string AlertDescCode
				{
					get
					{
						return alertDescCode;
					}
					set	
					{
						alertDescCode = value;
					}
				}

				public string AlertDetail
				{
					get
					{
						return alertDetail;
					}
					set	
					{
						alertDetail = value;
					}
				}

				public string LogUuid
				{
					get
					{
						return logUuid;
					}
					set	
					{
						logUuid = value;
					}
				}

				public string AttCk
				{
					get
					{
						return attCk;
					}
					set	
					{
						attCk = value;
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

				public string IsDefend
				{
					get
					{
						return isDefend;
					}
					set	
					{
						isDefend = value;
					}
				}

				public List<DescribeAlerts_AlertInfoListItem> AlertInfoList
				{
					get
					{
						return alertInfoList;
					}
					set	
					{
						alertInfoList = value;
					}
				}

				public class DescribeAlerts_AlertInfoListItem
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

			public class DescribeAlerts_PageInfo
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
