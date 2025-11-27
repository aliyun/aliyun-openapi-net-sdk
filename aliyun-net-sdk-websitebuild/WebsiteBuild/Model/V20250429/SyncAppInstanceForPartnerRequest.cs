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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.WebsiteBuild;
using Aliyun.Acs.WebsiteBuild.Transform;
using Aliyun.Acs.WebsiteBuild.Transform.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Model.V20250429
{
    public class SyncAppInstanceForPartnerRequest : RpcAcsRequest<SyncAppInstanceForPartnerResponse>
    {
        public SyncAppInstanceForPartnerRequest()
            : base("WebsiteBuild", "2025-04-29", "SyncAppInstanceForPartner")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private AppInstance appInstance_;

		private string sourceBizId;

		private string _operator;

		private string eventType;

		private string sourceType;

		[JsonProperty(PropertyName = "AppInstance")]
		public AppInstance AppInstance_
		{
			get
			{
				return appInstance_;
			}

			set
			{
				appInstance_ = value;
				DictionaryUtil.Add(QueryParameters, "AppInstance", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "SourceBizId")]
		public string SourceBizId
		{
			get
			{
				return sourceBizId;
			}
			set	
			{
				sourceBizId = value;
				DictionaryUtil.Add(QueryParameters, "SourceBizId", value);
			}
		}

		[JsonProperty(PropertyName = "Operator")]
		public string _Operator
		{
			get
			{
				return _operator;
			}
			set	
			{
				_operator = value;
				DictionaryUtil.Add(QueryParameters, "Operator", value);
			}
		}

		[JsonProperty(PropertyName = "EventType")]
		public string EventType
		{
			get
			{
				return eventType;
			}
			set	
			{
				eventType = value;
				DictionaryUtil.Add(QueryParameters, "EventType", value);
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
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
			}
		}

		public class AppInstance
		{

			private string appType;

			private Profile profile_;

			private string siteHost;

			private string endTime;

			private string startTime;

			private string userId;

			private string gmtPublish;

			private string deleted;

			private string domain;

			private string bizId;

			private string name;

			private string iconUrl;

			private string gmtDelete;

			private string slug;

			private string thumbnailUrl;

			private string status;

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

			[JsonProperty(PropertyName = "Profile")]
			public Profile Profile_
			{
				get
				{
					return profile_;
				}
				set	
				{
					profile_ = value;
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

			[JsonProperty(PropertyName = "Deleted")]
			public string Deleted
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

			public class Profile
			{

				private string deployArea;

				private string templateEtag;

				private string orderId;

				private string lxInstanceId;

				private string siteVersion;

				private string templateId;

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

				[JsonProperty(PropertyName = "LxInstanceId")]
				public string LxInstanceId
				{
					get
					{
						return lxInstanceId;
					}
					set	
					{
						lxInstanceId = value;
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
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SyncAppInstanceForPartnerResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SyncAppInstanceForPartnerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
