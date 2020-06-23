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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class ListServerLockRequest : RpcAcsRequest<ListServerLockResponse>
    {
        public ListServerLockRequest()
            : base("Domain", "2018-01-29", "ListServerLock", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string lockProductId;

		private long? endExpireDate;

		private int? pageNum;

		private long? beginStartDate;

		private int? serverLockStatus;

		private long? startExpireDate;

		private int? pageSize;

		private string lang;

		private string domainName;

		private long? endStartDate;

		private string userClientIp;

		public string LockProductId
		{
			get
			{
				return lockProductId;
			}
			set	
			{
				lockProductId = value;
				DictionaryUtil.Add(QueryParameters, "LockProductId", value);
			}
		}

		public long? EndExpireDate
		{
			get
			{
				return endExpireDate;
			}
			set	
			{
				endExpireDate = value;
				DictionaryUtil.Add(QueryParameters, "EndExpireDate", value.ToString());
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public long? BeginStartDate
		{
			get
			{
				return beginStartDate;
			}
			set	
			{
				beginStartDate = value;
				DictionaryUtil.Add(QueryParameters, "BeginStartDate", value.ToString());
			}
		}

		public int? ServerLockStatus
		{
			get
			{
				return serverLockStatus;
			}
			set	
			{
				serverLockStatus = value;
				DictionaryUtil.Add(QueryParameters, "ServerLockStatus", value.ToString());
			}
		}

		public long? StartExpireDate
		{
			get
			{
				return startExpireDate;
			}
			set	
			{
				startExpireDate = value;
				DictionaryUtil.Add(QueryParameters, "StartExpireDate", value.ToString());
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

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public long? EndStartDate
		{
			get
			{
				return endStartDate;
			}
			set	
			{
				endStartDate = value;
				DictionaryUtil.Add(QueryParameters, "EndStartDate", value.ToString());
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListServerLockResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListServerLockResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
