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
    public class ListMediaNameRequest : RpcAcsRequest<ListMediaNameResponse>
    {
        public ListMediaNameRequest()
            : base("UniMkt", "2018-12-12", "ListMediaName", "1.0.0", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.UniMkt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string userId;

		private string originSiteUserId;

		private int? pageNumber;

		private string mediaName;

		private string appName;

		private string tenantId;

		private int? pageSize;

		private string accessStatus;

		private string firstScene;

		private long? endCreateTime;

		private string business;

		private string os;

		private string mediaStatus;

		private string environment;

		private long? startCreateTime;

		private string userSite;

		private string secondScene;

		private string mediaType;

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

		public string AccessStatus
		{
			get
			{
				return accessStatus;
			}
			set	
			{
				accessStatus = value;
				DictionaryUtil.Add(QueryParameters, "AccessStatus", value);
			}
		}

		public string FirstScene
		{
			get
			{
				return firstScene;
			}
			set	
			{
				firstScene = value;
				DictionaryUtil.Add(QueryParameters, "FirstScene", value);
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

		public string Os
		{
			get
			{
				return os;
			}
			set	
			{
				os = value;
				DictionaryUtil.Add(QueryParameters, "Os", value);
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

		public string SecondScene
		{
			get
			{
				return secondScene;
			}
			set	
			{
				secondScene = value;
				DictionaryUtil.Add(QueryParameters, "SecondScene", value);
			}
		}

		public string MediaType
		{
			get
			{
				return mediaType;
			}
			set	
			{
				mediaType = value;
				DictionaryUtil.Add(QueryParameters, "MediaType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListMediaNameResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListMediaNameResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
