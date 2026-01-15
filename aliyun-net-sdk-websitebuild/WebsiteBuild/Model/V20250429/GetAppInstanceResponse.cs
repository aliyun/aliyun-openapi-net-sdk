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
	public class GetAppInstanceResponse : AcsResponse
	{

		private string requestId;

		private string dynamicCode;

		private string dynamicMessage;

		private bool? synchro;

		private string accessDeniedDetail;

		private string rootErrorMsg;

		private string rootErrorCode;

		private bool? allowRetry;

		private string appName;

		private List<string> errorArgs;

		private GetAppInstance_Module module;

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

		public GetAppInstance_Module Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public class GetAppInstance_Module
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

			private List<GetAppInstance_AiStaffListItem> aiStaffList;

			private List<GetAppInstance_AppServiceListItem> appServiceList;

			private GetAppInstance_Profile profile;

			private GetAppInstance_AppOperationAddress appOperationAddress;

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

			public List<GetAppInstance_AiStaffListItem> AiStaffList
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

			public List<GetAppInstance_AppServiceListItem> AppServiceList
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

			public GetAppInstance_Profile Profile
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

			public GetAppInstance_AppOperationAddress AppOperationAddress
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

			public class GetAppInstance_AiStaffListItem
			{

				private string staffId;

				private string staffName;

				private string staffType;

				private string status;

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

			public class GetAppInstance_AppServiceListItem
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

				private GetAppInstance_Profile1 profile1;

				private GetAppInstance_OperationAddress operationAddress;

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

				public GetAppInstance_Profile1 Profile1
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

				public GetAppInstance_OperationAddress OperationAddress
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

				public class GetAppInstance_Profile1
				{

					private string bizId;

					private string designType;

					private string designTypeText;

					private string serviceSpec;

					private string serviceSpecText;

					private string orderId;

					private string instanceId;

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

				public class GetAppInstance_OperationAddress
				{

					private List<GetAppInstance_ActionsItem> actions;

					public List<GetAppInstance_ActionsItem> Actions
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

					public class GetAppInstance_ActionsItem
					{

						private string actionKey;

						private string actionText;

						private string href;

						private bool? enable;

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

			public class GetAppInstance_Profile
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

			public class GetAppInstance_AppOperationAddress
			{

				private List<GetAppInstance_ActionsItem3> actions2;

				public List<GetAppInstance_ActionsItem3> Actions2
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

				public class GetAppInstance_ActionsItem3
				{

					private string actionKey;

					private string actionText;

					private string href;

					private bool? enable;

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
