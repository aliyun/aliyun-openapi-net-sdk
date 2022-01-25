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
using Aliyun.Acs.quickbi_public.Transform.V20210325;

namespace Aliyun.Acs.quickbi_public.Model.V20210325
{
    public class CreateTicketRequest : RpcAcsRequest<CreateTicketResponse>
    {
        public CreateTicketRequest()
            : base("quickbi-public", "2021-03-25", "CreateTicket", "quickbi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.quickbi_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.quickbi_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? expireTime;

		private int? accountType;

		private string cmptId;

		private string userId;

		private string accountName;

		private string globalParam;

		private string worksId;

		private int? ticketNum;

		private string watermarkParam;

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

		public string CmptId
		{
			get
			{
				return cmptId;
			}
			set	
			{
				cmptId = value;
				DictionaryUtil.Add(QueryParameters, "CmptId", value);
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

		public string GlobalParam
		{
			get
			{
				return globalParam;
			}
			set	
			{
				globalParam = value;
				DictionaryUtil.Add(QueryParameters, "GlobalParam", value);
			}
		}

		public string WorksId
		{
			get
			{
				return worksId;
			}
			set	
			{
				worksId = value;
				DictionaryUtil.Add(QueryParameters, "WorksId", value);
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

		public string WatermarkParam
		{
			get
			{
				return watermarkParam;
			}
			set	
			{
				watermarkParam = value;
				DictionaryUtil.Add(QueryParameters, "WatermarkParam", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTicketResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTicketResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
