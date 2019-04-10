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
using Aliyun.Acs.Dm.Transform;
using Aliyun.Acs.Dm.Transform.V20170622;

namespace Aliyun.Acs.Dm.Model.V20170622
{
    public class SenderStatisticsDetailByParamRequest : RpcAcsRequest<SenderStatisticsDetailByParamResponse>
    {
        public SenderStatisticsDetailByParamRequest()
            : base("Dm", "2017-06-22", "SenderStatisticsDetailByParam", "dm", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string toAddress;

		private int? length;

		private string nextStart;

		private string endTime;

		private string startTime;

		private long? ownerId;

		private string accessKeyId;

		private string tagName;

		private string accountName;

		private string action;

		private int? status;

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

		public string ToAddress
		{
			get
			{
				return toAddress;
			}
			set	
			{
				toAddress = value;
				DictionaryUtil.Add(QueryParameters, "ToAddress", value);
			}
		}

		public int? Length
		{
			get
			{
				return length;
			}
			set	
			{
				length = value;
				DictionaryUtil.Add(QueryParameters, "Length", value.ToString());
			}
		}

		public string NextStart
		{
			get
			{
				return nextStart;
			}
			set	
			{
				nextStart = value;
				DictionaryUtil.Add(QueryParameters, "NextStart", value);
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
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
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
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string TagName
		{
			get
			{
				return tagName;
			}
			set	
			{
				tagName = value;
				DictionaryUtil.Add(QueryParameters, "TagName", value);
			}
		}

		public string AccountName
		{
			get
			{
				return accountName;
			}
			set	
			{
				accountName = value;
				DictionaryUtil.Add(QueryParameters, "AccountName", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

        public override SenderStatisticsDetailByParamResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SenderStatisticsDetailByParamResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
