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
    public class CreateTicket4CopilotRequest : RpcAcsRequest<CreateTicket4CopilotResponse>
    {
        public CreateTicket4CopilotRequest()
            : base("quickbi-public", "2022-01-01", "CreateTicket4Copilot", "2.2.0", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string copilotId;

		private int? expireTime;

		private int? accountType;

		private string userId;

		private string accountName;

		private int? ticketNum;

		public string CopilotId
		{
			get
			{
				return copilotId;
			}
			set	
			{
				copilotId = value;
				DictionaryUtil.Add(QueryParameters, "CopilotId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTicket4CopilotResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTicket4CopilotResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
