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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.UniMkt.Transform;
using Aliyun.Acs.UniMkt.Transform.V20181212;

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
    public class ListRuleAreaRequest : RpcAcsRequest<ListRuleAreaResponse>
    {
        public ListRuleAreaRequest()
            : base("UniMkt", "2018-12-12", "ListRuleArea", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string adSlotType;

		private string ruleName;

		private string userId;

		private string originSiteUserId;

		private int? pageNumber;

		private string appName;

		private string tenantId;

		private string adSlotId;

		private int? pageSize;

		private long? endCreateTime;

		private string business;

		private string ruleType;

		private string mediaId;

		private string mediaStatus;

		private string environment;

		private long? startCreateTime;

		private string userSite;

		private string ruleId;

		public string AdSlotType
		{
			get
			{
				return adSlotType;
			}
			set	
			{
				adSlotType = value;
				DictionaryUtil.Add(QueryParameters, "AdSlotType", value);
			}
		}

		public string RuleName
		{
			get
			{
				return ruleName;
			}
			set	
			{
				ruleName = value;
				DictionaryUtil.Add(QueryParameters, "RuleName", value);
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
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public string OriginSiteUserId
		{
			get
			{
				return originSiteUserId;
			}
			set	
			{
				originSiteUserId = value;
				DictionaryUtil.Add(QueryParameters, "OriginSiteUserId", value);
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
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public string TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(QueryParameters, "TenantId", value);
			}
		}

		public string AdSlotId
		{
			get
			{
				return adSlotId;
			}
			set	
			{
				adSlotId = value;
				DictionaryUtil.Add(QueryParameters, "AdSlotId", value);
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public long? EndCreateTime
		{
			get
			{
				return endCreateTime;
			}
			set	
			{
				endCreateTime = value;
				DictionaryUtil.Add(QueryParameters, "EndCreateTime", value.ToString());
			}
		}

		public string Business
		{
			get
			{
				return business;
			}
			set	
			{
				business = value;
				DictionaryUtil.Add(QueryParameters, "Business", value);
			}
		}

		public string RuleType
		{
			get
			{
				return ruleType;
			}
			set	
			{
				ruleType = value;
				DictionaryUtil.Add(QueryParameters, "RuleType", value);
			}
		}

		public string MediaId
		{
			get
			{
				return mediaId;
			}
			set	
			{
				mediaId = value;
				DictionaryUtil.Add(QueryParameters, "MediaId", value);
			}
		}

		public string MediaStatus
		{
			get
			{
				return mediaStatus;
			}
			set	
			{
				mediaStatus = value;
				DictionaryUtil.Add(QueryParameters, "MediaStatus", value);
			}
		}

		public string Environment
		{
			get
			{
				return environment;
			}
			set	
			{
				environment = value;
				DictionaryUtil.Add(QueryParameters, "Environment", value);
			}
		}

		public long? StartCreateTime
		{
			get
			{
				return startCreateTime;
			}
			set	
			{
				startCreateTime = value;
				DictionaryUtil.Add(QueryParameters, "StartCreateTime", value.ToString());
			}
		}

		public string UserSite
		{
			get
			{
				return userSite;
			}
			set	
			{
				userSite = value;
				DictionaryUtil.Add(QueryParameters, "UserSite", value);
			}
		}

		public string RuleId
		{
			get
			{
				return ruleId;
			}
			set	
			{
				ruleId = value;
				DictionaryUtil.Add(QueryParameters, "RuleId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListRuleAreaResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListRuleAreaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
