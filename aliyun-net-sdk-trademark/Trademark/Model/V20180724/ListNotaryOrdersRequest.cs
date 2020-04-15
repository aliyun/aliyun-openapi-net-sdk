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
    public class ListNotaryOrdersRequest : RpcAcsRequest<ListNotaryOrdersResponse>
    {
        public ListNotaryOrdersRequest()
            : base("Trademark", "2018-07-24", "ListNotaryOrders", "trademark", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? startOrderDate;

		private int? notaryType;

		private int? pageNum;

		private int? sortKeyType;

		private string sortByType;

		private int? pageSize;

		private string bizId;

		private long? endOrderDate;

		private string aliyunOrderId;

		private int? notaryStatus;

		public long? StartOrderDate
		{
			get
			{
				return startOrderDate;
			}
			set	
			{
				startOrderDate = value;
				DictionaryUtil.Add(QueryParameters, "StartOrderDate", value.ToString());
			}
		}

		public int? NotaryType
		{
			get
			{
				return notaryType;
			}
			set	
			{
				notaryType = value;
				DictionaryUtil.Add(QueryParameters, "NotaryType", value.ToString());
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

		public int? SortKeyType
		{
			get
			{
				return sortKeyType;
			}
			set	
			{
				sortKeyType = value;
				DictionaryUtil.Add(QueryParameters, "SortKeyType", value.ToString());
			}
		}

		public string SortByType
		{
			get
			{
				return sortByType;
			}
			set	
			{
				sortByType = value;
				DictionaryUtil.Add(QueryParameters, "SortByType", value);
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

		public long? EndOrderDate
		{
			get
			{
				return endOrderDate;
			}
			set	
			{
				endOrderDate = value;
				DictionaryUtil.Add(QueryParameters, "EndOrderDate", value.ToString());
			}
		}

		public string AliyunOrderId
		{
			get
			{
				return aliyunOrderId;
			}
			set	
			{
				aliyunOrderId = value;
				DictionaryUtil.Add(QueryParameters, "AliyunOrderId", value);
			}
		}

		public int? NotaryStatus
		{
			get
			{
				return notaryStatus;
			}
			set	
			{
				notaryStatus = value;
				DictionaryUtil.Add(QueryParameters, "NotaryStatus", value.ToString());
			}
		}

        public override ListNotaryOrdersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListNotaryOrdersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
