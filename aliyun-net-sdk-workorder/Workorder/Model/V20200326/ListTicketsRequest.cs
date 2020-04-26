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
using Aliyun.Acs.Workorder.Transform;
using Aliyun.Acs.Workorder.Transform.V20200326;

namespace Aliyun.Acs.Workorder.Model.V20200326
{
    public class ListTicketsRequest : RpcAcsRequest<ListTicketsResponse>
    {
        public ListTicketsRequest()
            : base("Workorder", "2020-03-26", "ListTickets", "workorder", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string productCode;

		private string language;

		private string subUserId;

		private long? createdBeforeTime;

		private int? pageSize;

		private string ids;

		private string ticketStatus;

		private int? pageStart;

		private long? createdAfterTime;

		public string ProductCode
		{
			get
			{
				return productCode;
			}
			set	
			{
				productCode = value;
				DictionaryUtil.Add(QueryParameters, "ProductCode", value);
			}
		}

		public string Language
		{
			get
			{
				return language;
			}
			set	
			{
				language = value;
				DictionaryUtil.Add(QueryParameters, "Language", value);
			}
		}

		public string SubUserId
		{
			get
			{
				return subUserId;
			}
			set	
			{
				subUserId = value;
				DictionaryUtil.Add(QueryParameters, "SubUserId", value);
			}
		}

		public long? CreatedBeforeTime
		{
			get
			{
				return createdBeforeTime;
			}
			set	
			{
				createdBeforeTime = value;
				DictionaryUtil.Add(QueryParameters, "CreatedBeforeTime", value.ToString());
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

		public string Ids
		{
			get
			{
				return ids;
			}
			set	
			{
				ids = value;
				DictionaryUtil.Add(QueryParameters, "Ids", value);
			}
		}

		public string TicketStatus
		{
			get
			{
				return ticketStatus;
			}
			set	
			{
				ticketStatus = value;
				DictionaryUtil.Add(QueryParameters, "TicketStatus", value);
			}
		}

		public int? PageStart
		{
			get
			{
				return pageStart;
			}
			set	
			{
				pageStart = value;
				DictionaryUtil.Add(QueryParameters, "PageStart", value.ToString());
			}
		}

		public long? CreatedAfterTime
		{
			get
			{
				return createdAfterTime;
			}
			set	
			{
				createdAfterTime = value;
				DictionaryUtil.Add(QueryParameters, "CreatedAfterTime", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListTicketsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListTicketsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
