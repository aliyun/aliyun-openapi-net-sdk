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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class ListSQLReviewOriginSQLRequest : RpcAcsRequest<ListSQLReviewOriginSQLResponse>
    {
        public ListSQLReviewOriginSQLRequest()
            : base("dms-enterprise", "2018-11-01", "ListSQLReviewOriginSQL", "dms-enterprise", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? orderId;

		private OrderActionDetail orderActionDetail_;

		private long? tid;

		[JsonProperty(PropertyName = "OrderId")]
		public long? OrderId
		{
			get
			{
				return orderId;
			}
			set	
			{
				orderId = value;
				DictionaryUtil.Add(QueryParameters, "OrderId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "OrderActionDetail")]
		public OrderActionDetail OrderActionDetail_
		{
			get
			{
				return orderActionDetail_;
			}

			set
			{
				orderActionDetail_ = value;
				DictionaryUtil.Add(QueryParameters, "OrderActionDetail", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "Tid")]
		public long? Tid
		{
			get
			{
				return tid;
			}
			set	
			{
				tid = value;
				DictionaryUtil.Add(QueryParameters, "Tid", value.ToString());
			}
		}

		public class OrderActionDetail
		{

			private string checkStatusResult;

			private string sQLReviewResult;

			private Page page_;

			private long? fileId;

			[JsonProperty(PropertyName = "CheckStatusResult")]
			public string CheckStatusResult
			{
				get
				{
					return checkStatusResult;
				}
				set	
				{
					checkStatusResult = value;
				}
			}

			[JsonProperty(PropertyName = "SQLReviewResult")]
			public string SQLReviewResult
			{
				get
				{
					return sQLReviewResult;
				}
				set	
				{
					sQLReviewResult = value;
				}
			}

			[JsonProperty(PropertyName = "Page")]
			public Page Page_
			{
				get
				{
					return page_;
				}
				set	
				{
					page_ = value;
				}
			}

			[JsonProperty(PropertyName = "FileId")]
			public long? FileId
			{
				get
				{
					return fileId;
				}
				set	
				{
					fileId = value;
				}
			}

			public class Page
			{

				private int? pageSize;

				private int? pageNumber;

				[JsonProperty(PropertyName = "PageSize")]
				public int? PageSize
				{
					get
					{
						return pageSize;
					}
					set	
					{
						pageSize = value;
					}
				}

				[JsonProperty(PropertyName = "PageNumber")]
				public int? PageNumber
				{
					get
					{
						return pageNumber;
					}
					set	
					{
						pageNumber = value;
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListSQLReviewOriginSQLResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListSQLReviewOriginSQLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
