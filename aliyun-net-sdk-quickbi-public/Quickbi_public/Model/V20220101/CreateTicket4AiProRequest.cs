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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class CreateTicket4AiProRequest : RpcAcsRequest<CreateTicket4AiProResponse>
    {
        public CreateTicket4AiProRequest()
            : base("quickbi-public", "2022-01-01", "CreateTicket4AiPro", "QuickBI", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private int? accountType;

		private string customParam;

		private string systemUid;

		private string accountName;

		private int? expireTime;

		private string aiProId;

		private int? ticketNum;

		private string quickBIUserId;

		public int? AccountType
		{
			get
			{
				return accountType;
			}
			set	
			{
				accountType = value;
				DictionaryUtil.Add(QueryParameters, "AccountType", value.ToString());
			}
		}

		public string CustomParam
		{
			get
			{
				return customParam;
			}
			set	
			{
				customParam = value;
				DictionaryUtil.Add(QueryParameters, "CustomParam", value);
			}
		}

		public string SystemUid
		{
			get
			{
				return systemUid;
			}
			set	
			{
				systemUid = value;
				DictionaryUtil.Add(QueryParameters, "SystemUid", value);
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

		public int? ExpireTime
		{
			get
			{
				return expireTime;
			}
			set	
			{
				expireTime = value;
				DictionaryUtil.Add(QueryParameters, "ExpireTime", value.ToString());
			}
		}

		public string AiProId
		{
			get
			{
				return aiProId;
			}
			set	
			{
				aiProId = value;
				DictionaryUtil.Add(QueryParameters, "AiProId", value);
			}
		}

		public int? TicketNum
		{
			get
			{
				return ticketNum;
			}
			set	
			{
				ticketNum = value;
				DictionaryUtil.Add(QueryParameters, "TicketNum", value.ToString());
			}
		}

		public string QuickBIUserId
		{
			get
			{
				return quickBIUserId;
			}
			set	
			{
				quickBIUserId = value;
				DictionaryUtil.Add(QueryParameters, "QuickBIUserId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTicket4AiProResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTicket4AiProResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
