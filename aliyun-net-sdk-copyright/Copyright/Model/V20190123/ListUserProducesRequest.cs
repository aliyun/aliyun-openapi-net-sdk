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
using Aliyun.Acs.Copyright;
using Aliyun.Acs.Copyright.Transform;
using Aliyun.Acs.Copyright.Transform.V20190123;

namespace Aliyun.Acs.Copyright.Model.V20190123
{
    public class ListUserProducesRequest : RpcAcsRequest<ListUserProducesResponse>
    {
        public ListUserProducesRequest()
            : base("Copyright", "2019-01-23", "ListUserProduces")
        {
			Method = MethodType.POST;
        }

		private string intentionBizId;

		private int? pageNum;

		private int? pageSize;

		private string sortParam;

		private string extCondition;

		private string orderId;

		private List<object> existStatus;

		private string bizType;

		private string bizId;

		private string solutionBizId;

		private int? status;

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

		public string SortParam
		{
			get
			{
				return sortParam;
			}
			set	
			{
				sortParam = value;
				DictionaryUtil.Add(QueryParameters, "SortParam", value);
			}
		}

		public string ExtCondition
		{
			get
			{
				return extCondition;
			}
			set	
			{
				extCondition = value;
				DictionaryUtil.Add(QueryParameters, "ExtCondition", value);
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

		public List<object> ExistStatus
		{
			get
			{
				return existStatus;
			}
			set	
			{
				existStatus = value;
				DictionaryUtil.Add(QueryParameters, "ExistStatus", JsonConvert.SerializeObject(value));
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
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

		public string SolutionBizId
		{
			get
			{
				return solutionBizId;
			}
			set	
			{
				solutionBizId = value;
				DictionaryUtil.Add(QueryParameters, "SolutionBizId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListUserProducesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListUserProducesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
