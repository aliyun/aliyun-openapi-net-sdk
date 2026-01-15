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

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
	public class ListAppInstancesResponse : AcsResponse
	{

		private string requestId;

		private string dynamicCode;

		private string dynamicMessage;

		private bool? synchro;

		private string accessDeniedDetail;

		private string rootErrorMsg;

		private string rootErrorCode;

		private int? currentPageNum;

		private int? pageSize;

		private int? totalPageNum;

		private bool? prePage;

		private bool? nextPage;

		private bool? resultLimit;

		private bool? allowRetry;

		private string appName;

		private string nextToken;

		private int? maxResults;

		private List<ListAppInstances_DataItem> data;

		private List<string> errorArgs;

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

		[JsonProperty(PropertyName = "DynamicCode")]
		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		[JsonProperty(PropertyName = "DynamicMessage")]
		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		[JsonProperty(PropertyName = "Synchro")]
		public bool? Synchro
		{
			get
			{
				return synchro;
			}
			set	
			{
				synchro = value;
			}
		}

		[JsonProperty(PropertyName = "AccessDeniedDetail")]
		public string AccessDeniedDetail
		{
			get
			{
				return accessDeniedDetail;
			}
			set	
			{
				accessDeniedDetail = value;
			}
		}

		[JsonProperty(PropertyName = "RootErrorMsg")]
		public string RootErrorMsg
		{
			get
			{
				return rootErrorMsg;
			}
			set	
			{
				rootErrorMsg = value;
			}
		}

		[JsonProperty(PropertyName = "RootErrorCode")]
		public string RootErrorCode
		{
			get
			{
				return rootErrorCode;
			}
			set	
			{
				rootErrorCode = value;
			}
		}

		[JsonProperty(PropertyName = "CurrentPageNum")]
		public int? CurrentPageNum
		{
			get
			{
				return currentPageNum;
			}
			set	
			{
				currentPageNum = value;
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "TotalPageNum")]
		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		[JsonProperty(PropertyName = "PrePage")]
		public bool? PrePage
		{
			get
			{
				return prePage;
			}
			set	
			{
				prePage = value;
			}
		}

		[JsonProperty(PropertyName = "NextPage")]
		public bool? NextPage
		{
			get
			{
				return nextPage;
			}
			set	
			{
				nextPage = value;
			}
		}

		[JsonProperty(PropertyName = "ResultLimit")]
		public bool? ResultLimit
		{
			get
			{
				return resultLimit;
			}
			set	
			{
				resultLimit = value;
			}
		}

		[JsonProperty(PropertyName = "AllowRetry")]
		public bool? AllowRetry
		{
			get
			{
				return allowRetry;
			}
			set	
			{
				allowRetry = value;
			}
		}

		[JsonProperty(PropertyName = "AppName")]
		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
			}
		}

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

		[JsonProperty(PropertyName = "Data")]
		public List<ListAppInstances_DataItem> Data
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

		[JsonProperty(PropertyName = "ErrorArgs")]
		public List<string> ErrorArgs
		{
			get
			{
				return errorArgs;
			}
			set	
			{
				errorArgs = value;
			}
		}

		public class ListAppInstances_DataItem
		{

			private string createTime;

			private string gmtModified;

			private string bizId;

			private string name;

			private string userId;

			private string appType;

			private string appSubType;

			private string buildType;

			private string description;

			private string iconUrl;

			private string thumbnailUrl;

			private string slug;

			private string status;

			private string statusText;

			private string designSpecId;

			private string gmtPublish;

			private string gmtDelete;

			private string startTime;

			private string endTime;

			private string domain;

			private string siteHost;

			private string espBizId;

			private int? deleted;

			private string designSpecBizId;

			private string sourceType;

			private List<ListAppInstances_AiStaffListItem> aiStaffList;

			private List<ListAppInstances_AppServiceListItem> appServiceList;

			private ListAppInstances_Profile profile;

			private ListAppInstances_AppOperationAddress appOperationAddress;

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

			[JsonProperty(PropertyName = "GmtModified")]
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

			[JsonProperty(PropertyName = "BizId")]
			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
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

			[JsonProperty(PropertyName = "UserId")]
			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			[JsonProperty(PropertyName = "AppType")]
			public string AppType
			{
				get
				{
					return appType;
				}
				set	
				{
					appType = value;
				}
			}

			[JsonProperty(PropertyName = "AppSubType")]
			public string AppSubType
			{
				get
				{
					return appSubType;
				}
				set	
				{
					appSubType = value;
				}
			}

			[JsonProperty(PropertyName = "BuildType")]
			public string BuildType
			{
				get
				{
					return buildType;
				}
				set	
				{
					buildType = value;
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

			[JsonProperty(PropertyName = "IconUrl")]
			public string IconUrl
			{
				get
				{
					return iconUrl;
				}
				set	
				{
					iconUrl = value;
				}
			}

			[JsonProperty(PropertyName = "ThumbnailUrl")]
			public string ThumbnailUrl
			{
				get
				{
					return thumbnailUrl;
				}
				set	
				{
					thumbnailUrl = value;
				}
			}

			[JsonProperty(PropertyName = "Slug")]
			public string Slug
			{
				get
				{
					return slug;
				}
				set	
				{
					slug = value;
				}
			}

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

			[JsonProperty(PropertyName = "StatusText")]
			public string StatusText
			{
				get
				{
					return statusText;
				}
				set	
				{
					statusText = value;
				}
			}

			[JsonProperty(PropertyName = "DesignSpecId")]
			public string DesignSpecId
			{
				get
				{
					return designSpecId;
				}
				set	
				{
					designSpecId = value;
				}
			}

			[JsonProperty(PropertyName = "GmtPublish")]
			public string GmtPublish
			{
				get
				{
					return gmtPublish;
				}
				set	
				{
					gmtPublish = value;
				}
			}

			[JsonProperty(PropertyName = "GmtDelete")]
			public string GmtDelete
			{
				get
				{
					return gmtDelete;
				}
				set	
				{
					gmtDelete = value;
				}
			}

			[JsonProperty(PropertyName = "StartTime")]
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

			[JsonProperty(PropertyName = "EndTime")]
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

			[JsonProperty(PropertyName = "Domain")]
			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			[JsonProperty(PropertyName = "SiteHost")]
			public string SiteHost
			{
				get
				{
					return siteHost;
				}
				set	
				{
					siteHost = value;
				}
			}

			[JsonProperty(PropertyName = "EspBizId")]
			public string EspBizId
			{
				get
				{
					return espBizId;
				}
				set	
				{
					espBizId = value;
				}
			}

			[JsonProperty(PropertyName = "Deleted")]
			public int? Deleted
			{
				get
				{
					return deleted;
				}
				set	
				{
					deleted = value;
				}
			}

			[JsonProperty(PropertyName = "DesignSpecBizId")]
			public string DesignSpecBizId
			{
				get
				{
					return designSpecBizId;
				}
				set	
				{
					designSpecBizId = value;
				}
			}

			[JsonProperty(PropertyName = "SourceType")]
			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			[JsonProperty(PropertyName = "AiStaffList")]
			public List<ListAppInstances_AiStaffListItem> AiStaffList
			{
				get
				{
					return aiStaffList;
				}
				set	
				{
					aiStaffList = value;
				}
			}

			[JsonProperty(PropertyName = "AppServiceList")]
			public List<ListAppInstances_AppServiceListItem> AppServiceList
			{
				get
				{
					return appServiceList;
				}
				set	
				{
					appServiceList = value;
				}
			}

			[JsonProperty(PropertyName = "Profile")]
			public ListAppInstances_Profile Profile
			{
				get
				{
					return profile;
				}
				set	
				{
					profile = value;
				}
			}

			[JsonProperty(PropertyName = "AppOperationAddress")]
			public ListAppInstances_AppOperationAddress AppOperationAddress
			{
				get
				{
					return appOperationAddress;
				}
				set	
				{
					appOperationAddress = value;
				}
			}

			public class ListAppInstances_AiStaffListItem
			{

				private string staffId;

				private string staffName;

				private string staffType;

				private string status;

				[JsonProperty(PropertyName = "StaffId")]
				public string StaffId
				{
					get
					{
						return staffId;
					}
					set	
					{
						staffId = value;
					}
				}

				[JsonProperty(PropertyName = "StaffName")]
				public string StaffName
				{
					get
					{
						return staffName;
					}
					set	
					{
						staffName = value;
					}
				}

				[JsonProperty(PropertyName = "StaffType")]
				public string StaffType
				{
					get
					{
						return staffType;
					}
					set	
					{
						staffType = value;
					}
				}

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
			}

			public class ListAppInstances_AppServiceListItem
			{

				private string name;

				private string gmtCreate;

				private string gmtModified;

				private string bizId;

				private string serviceType;

				private string serviceTypeText;

				private string userId;

				private string status;

				private int? deleted;

				private string startTime;

				private string endTime;

				private string slug;

				private string instanceBizId;

				private string espBizId;

				private ListAppInstances_Profile1 profile1;

				private ListAppInstances_OperationAddress operationAddress;

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

				[JsonProperty(PropertyName = "GmtCreate")]
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

				[JsonProperty(PropertyName = "GmtModified")]
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

				[JsonProperty(PropertyName = "BizId")]
				public string BizId
				{
					get
					{
						return bizId;
					}
					set	
					{
						bizId = value;
					}
				}

				[JsonProperty(PropertyName = "ServiceType")]
				public string ServiceType
				{
					get
					{
						return serviceType;
					}
					set	
					{
						serviceType = value;
					}
				}

				[JsonProperty(PropertyName = "ServiceTypeText")]
				public string ServiceTypeText
				{
					get
					{
						return serviceTypeText;
					}
					set	
					{
						serviceTypeText = value;
					}
				}

				[JsonProperty(PropertyName = "UserId")]
				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

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

				[JsonProperty(PropertyName = "Deleted")]
				public int? Deleted
				{
					get
					{
						return deleted;
					}
					set	
					{
						deleted = value;
					}
				}

				[JsonProperty(PropertyName = "StartTime")]
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

				[JsonProperty(PropertyName = "EndTime")]
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

				[JsonProperty(PropertyName = "Slug")]
				public string Slug
				{
					get
					{
						return slug;
					}
					set	
					{
						slug = value;
					}
				}

				[JsonProperty(PropertyName = "InstanceBizId")]
				public string InstanceBizId
				{
					get
					{
						return instanceBizId;
					}
					set	
					{
						instanceBizId = value;
					}
				}

				[JsonProperty(PropertyName = "EspBizId")]
				public string EspBizId
				{
					get
					{
						return espBizId;
					}
					set	
					{
						espBizId = value;
					}
				}

				[JsonProperty(PropertyName = "Profile1")]
				public ListAppInstances_Profile1 Profile1
				{
					get
					{
						return profile1;
					}
					set	
					{
						profile1 = value;
					}
				}

				[JsonProperty(PropertyName = "OperationAddress")]
				public ListAppInstances_OperationAddress OperationAddress
				{
					get
					{
						return operationAddress;
					}
					set	
					{
						operationAddress = value;
					}
				}

				public class ListAppInstances_Profile1
				{

					private string bizId;

					private string designType;

					private string designTypeText;

					private string serviceSpec;

					private string serviceSpecText;

					private string orderId;

					private string instanceId;

					[JsonProperty(PropertyName = "BizId")]
					public string BizId
					{
						get
						{
							return bizId;
						}
						set	
						{
							bizId = value;
						}
					}

					[JsonProperty(PropertyName = "DesignType")]
					public string DesignType
					{
						get
						{
							return designType;
						}
						set	
						{
							designType = value;
						}
					}

					[JsonProperty(PropertyName = "DesignTypeText")]
					public string DesignTypeText
					{
						get
						{
							return designTypeText;
						}
						set	
						{
							designTypeText = value;
						}
					}

					[JsonProperty(PropertyName = "ServiceSpec")]
					public string ServiceSpec
					{
						get
						{
							return serviceSpec;
						}
						set	
						{
							serviceSpec = value;
						}
					}

					[JsonProperty(PropertyName = "ServiceSpecText")]
					public string ServiceSpecText
					{
						get
						{
							return serviceSpecText;
						}
						set	
						{
							serviceSpecText = value;
						}
					}

					[JsonProperty(PropertyName = "OrderId")]
					public string OrderId
					{
						get
						{
							return orderId;
						}
						set	
						{
							orderId = value;
						}
					}

					[JsonProperty(PropertyName = "InstanceId")]
					public string InstanceId
					{
						get
						{
							return instanceId;
						}
						set	
						{
							instanceId = value;
						}
					}
				}

				public class ListAppInstances_OperationAddress
				{

					private List<ListAppInstances_ActionsItem> actions;

					[JsonProperty(PropertyName = "Actions")]
					public List<ListAppInstances_ActionsItem> Actions
					{
						get
						{
							return actions;
						}
						set	
						{
							actions = value;
						}
					}

					public class ListAppInstances_ActionsItem
					{

						private string actionKey;

						private string actionText;

						private string href;

						private bool? enable;

						[JsonProperty(PropertyName = "ActionKey")]
						public string ActionKey
						{
							get
							{
								return actionKey;
							}
							set	
							{
								actionKey = value;
							}
						}

						[JsonProperty(PropertyName = "ActionText")]
						public string ActionText
						{
							get
							{
								return actionText;
							}
							set	
							{
								actionText = value;
							}
						}

						[JsonProperty(PropertyName = "Href")]
						public string Href
						{
							get
							{
								return href;
							}
							set	
							{
								href = value;
							}
						}

						[JsonProperty(PropertyName = "Enable")]
						public bool? Enable
						{
							get
							{
								return enable;
							}
							set	
							{
								enable = value;
							}
						}
					}
				}
			}

			public class ListAppInstances_Profile
			{

				private string commodityCode;

				private string payTime;

				private string bizId;

				private string templateId;

				private string templateEtag;

				private string orderId;

				private string seoSite;

				private string customerService;

				private string applicationType;

				private string applicationTypeText;

				private string deployArea;

				private string siteVersion;

				private string siteVersionText;

				private string ordTime;

				private string source;

				private string instanceId;

				[JsonProperty(PropertyName = "CommodityCode")]
				public string CommodityCode
				{
					get
					{
						return commodityCode;
					}
					set	
					{
						commodityCode = value;
					}
				}

				[JsonProperty(PropertyName = "PayTime")]
				public string PayTime
				{
					get
					{
						return payTime;
					}
					set	
					{
						payTime = value;
					}
				}

				[JsonProperty(PropertyName = "BizId")]
				public string BizId
				{
					get
					{
						return bizId;
					}
					set	
					{
						bizId = value;
					}
				}

				[JsonProperty(PropertyName = "TemplateId")]
				public string TemplateId
				{
					get
					{
						return templateId;
					}
					set	
					{
						templateId = value;
					}
				}

				[JsonProperty(PropertyName = "TemplateEtag")]
				public string TemplateEtag
				{
					get
					{
						return templateEtag;
					}
					set	
					{
						templateEtag = value;
					}
				}

				[JsonProperty(PropertyName = "OrderId")]
				public string OrderId
				{
					get
					{
						return orderId;
					}
					set	
					{
						orderId = value;
					}
				}

				[JsonProperty(PropertyName = "SeoSite")]
				public string SeoSite
				{
					get
					{
						return seoSite;
					}
					set	
					{
						seoSite = value;
					}
				}

				[JsonProperty(PropertyName = "CustomerService")]
				public string CustomerService
				{
					get
					{
						return customerService;
					}
					set	
					{
						customerService = value;
					}
				}

				[JsonProperty(PropertyName = "ApplicationType")]
				public string ApplicationType
				{
					get
					{
						return applicationType;
					}
					set	
					{
						applicationType = value;
					}
				}

				[JsonProperty(PropertyName = "ApplicationTypeText")]
				public string ApplicationTypeText
				{
					get
					{
						return applicationTypeText;
					}
					set	
					{
						applicationTypeText = value;
					}
				}

				[JsonProperty(PropertyName = "DeployArea")]
				public string DeployArea
				{
					get
					{
						return deployArea;
					}
					set	
					{
						deployArea = value;
					}
				}

				[JsonProperty(PropertyName = "SiteVersion")]
				public string SiteVersion
				{
					get
					{
						return siteVersion;
					}
					set	
					{
						siteVersion = value;
					}
				}

				[JsonProperty(PropertyName = "SiteVersionText")]
				public string SiteVersionText
				{
					get
					{
						return siteVersionText;
					}
					set	
					{
						siteVersionText = value;
					}
				}

				[JsonProperty(PropertyName = "OrdTime")]
				public string OrdTime
				{
					get
					{
						return ordTime;
					}
					set	
					{
						ordTime = value;
					}
				}

				[JsonProperty(PropertyName = "Source")]
				public string Source
				{
					get
					{
						return source;
					}
					set	
					{
						source = value;
					}
				}

				[JsonProperty(PropertyName = "InstanceId")]
				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}
			}

			public class ListAppInstances_AppOperationAddress
			{

				private List<ListAppInstances_ActionsItem3> actions2;

				[JsonProperty(PropertyName = "Actions2")]
				public List<ListAppInstances_ActionsItem3> Actions2
				{
					get
					{
						return actions2;
					}
					set	
					{
						actions2 = value;
					}
				}

				public class ListAppInstances_ActionsItem3
				{

					private string actionKey;

					private string actionText;

					private string href;

					private bool? enable;

					[JsonProperty(PropertyName = "ActionKey")]
					public string ActionKey
					{
						get
						{
							return actionKey;
						}
						set	
						{
							actionKey = value;
						}
					}

					[JsonProperty(PropertyName = "ActionText")]
					public string ActionText
					{
						get
						{
							return actionText;
						}
						set	
						{
							actionText = value;
						}
					}

					[JsonProperty(PropertyName = "Href")]
					public string Href
					{
						get
						{
							return href;
						}
						set	
						{
							href = value;
						}
					}

					[JsonProperty(PropertyName = "Enable")]
					public bool? Enable
					{
						get
						{
							return enable;
						}
						set	
						{
							enable = value;
						}
					}
				}
			}
		}
	}
}
