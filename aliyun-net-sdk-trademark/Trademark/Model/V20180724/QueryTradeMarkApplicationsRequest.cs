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
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class QueryTradeMarkApplicationsRequest : RpcAcsRequest<QueryTradeMarkApplicationsResponse>
    {
        public QueryTradeMarkApplicationsRequest()
            : base("Trademark", "2018-07-24", "QueryTradeMarkApplications", "trademark", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string tmName;

		private string materialName;

		private int? hidden;

		private string orderId;

		private string tmNumber;

		private string intentionBizId;

		private int? pageNum;

		private string type;

		private int? supplementStatus;

		private int? pageSize;

		private string bizId;

		private string sortOrder;

		private int? status;

		public string TmName
		{
			get
			{
				return tmName;
			}
			set	
			{
				tmName = value;
				DictionaryUtil.Add(QueryParameters, "TmName", value);
			}
		}

		public string MaterialName
		{
			get
			{
				return materialName;
			}
			set	
			{
				materialName = value;
				DictionaryUtil.Add(QueryParameters, "MaterialName", value);
			}
		}

		public int? Hidden
		{
			get
			{
				return hidden;
			}
			set	
			{
				hidden = value;
				DictionaryUtil.Add(QueryParameters, "Hidden", value.ToString());
			}
		}

		public string OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
				DictionaryUtil.Add(QueryParameters, "OrderId", value);
			}
		}

		public string TmNumber
		{
			get
			{
				return tmNumber;
			}
			set	
			{
				tmNumber = value;
				DictionaryUtil.Add(QueryParameters, "TmNumber", value);
			}
		}

		public string IntentionBizId
		{
			get
			{
				return intentionBizId;
			}
			set	
			{
				intentionBizId = value;
				DictionaryUtil.Add(QueryParameters, "IntentionBizId", value);
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

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public int? SupplementStatus
		{
			get
			{
				return supplementStatus;
			}
			set	
			{
				supplementStatus = value;
				DictionaryUtil.Add(QueryParameters, "SupplementStatus", value.ToString());
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

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		public string SortOrder
		{
			get
			{
				return sortOrder;
			}
			set	
			{
				sortOrder = value;
				DictionaryUtil.Add(QueryParameters, "SortOrder", value);
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

        public override QueryTradeMarkApplicationsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryTradeMarkApplicationsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
