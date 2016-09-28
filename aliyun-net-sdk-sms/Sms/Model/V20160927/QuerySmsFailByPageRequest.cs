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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Sms.Transform;
using Aliyun.Acs.Sms.Transform.V20160927;
using System.Collections.Generic;

namespace Aliyun.Acs.Sms.Model.V20160927
{
    public class QuerySmsFailByPageRequest : RpcAcsRequest<QuerySmsFailByPageResponse>
    {
        public QuerySmsFailByPageRequest()
            : base("Sms", "2016-09-27", "QuerySmsFailByPage")
        {
        }

		private long? ownerId;

		private string resourceOwnerAccount;

		private long? resourceOwnerId;

		private string queryTime;

		private int? pageSize;

		private int? pageNo;

		private int? smsType;

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string QueryTime
		{
			get
			{
				return queryTime;
			}
			set	
			{
				queryTime = value;
				DictionaryUtil.Add(QueryParameters, "QueryTime", value);
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

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "PageNo", value.ToString());
			}
		}

		public int? SmsType
		{
			get
			{
				return smsType;
			}
			set	
			{
				smsType = value;
				DictionaryUtil.Add(QueryParameters, "SmsType", value.ToString());
			}
		}

        public override QuerySmsFailByPageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QuerySmsFailByPageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}