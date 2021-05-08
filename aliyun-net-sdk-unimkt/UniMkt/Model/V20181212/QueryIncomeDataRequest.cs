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
    public class QueryIncomeDataRequest : RpcAcsRequest<QueryIncomeDataResponse>
    {
        public QueryIncomeDataRequest()
            : base("UniMkt", "2018-12-12", "QueryIncomeData", "uniMkt", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string adSlotType;

		private string business;

		private long? endTime;

		private long? startTime;

		private string mediaId;

		private string userId;

		private string originSiteUserId;

		private string mediaName;

		private string environment;

		private string appName;

		private string tenantId;

		private string adSlotId;

		private string userSite;

		private string adSlotName;

		private string dimension;

		private string queryType;

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

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
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

		public string MediaName
		{
			get
			{
				return mediaName;
			}
			set	
			{
				mediaName = value;
				DictionaryUtil.Add(QueryParameters, "MediaName", value);
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

		public string AdSlotName
		{
			get
			{
				return adSlotName;
			}
			set	
			{
				adSlotName = value;
				DictionaryUtil.Add(QueryParameters, "AdSlotName", value);
			}
		}

		public string Dimension
		{
			get
			{
				return dimension;
			}
			set	
			{
				dimension = value;
				DictionaryUtil.Add(QueryParameters, "Dimension", value);
			}
		}

		public string QueryType
		{
			get
			{
				return queryType;
			}
			set	
			{
				queryType = value;
				DictionaryUtil.Add(QueryParameters, "QueryType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryIncomeDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryIncomeDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
