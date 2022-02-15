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
using Aliyun.Acs.Copyright;
using Aliyun.Acs.Copyright.Transform;
using Aliyun.Acs.Copyright.Transform.V20190123;

namespace Aliyun.Acs.Copyright.Model.V20190123
{
    public class GetPatentPlanDetailListRequest : RpcAcsRequest<GetPatentPlanDetailListResponse>
    {
        public GetPatentPlanDetailListRequest()
            : base("Copyright", "2019-01-23", "GetPatentPlanDetailList")
        {
			Method = MethodType.POST;
        }

		private string discount;

		private string type;

		private string patentStatus;

		private string keyword;

		private int? endYear;

		private int? soldStatus;

		private int? label;

		private long? startPayDate;

		private long? endPayDate;

		private int? payStatus;

		private int? startYear;

		private long? planId;

		private bool? patentDiscard;

		public string Discount
		{
			get
			{
				return discount;
			}
			set	
			{
				discount = value;
				DictionaryUtil.Add(QueryParameters, "Discount", value);
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

		public string PatentStatus
		{
			get
			{
				return patentStatus;
			}
			set	
			{
				patentStatus = value;
				DictionaryUtil.Add(QueryParameters, "PatentStatus", value);
			}
		}

		public string Keyword
		{
			get
			{
				return keyword;
			}
			set	
			{
				keyword = value;
				DictionaryUtil.Add(QueryParameters, "Keyword", value);
			}
		}

		public int? EndYear
		{
			get
			{
				return endYear;
			}
			set	
			{
				endYear = value;
				DictionaryUtil.Add(QueryParameters, "EndYear", value.ToString());
			}
		}

		public int? SoldStatus
		{
			get
			{
				return soldStatus;
			}
			set	
			{
				soldStatus = value;
				DictionaryUtil.Add(QueryParameters, "SoldStatus", value.ToString());
			}
		}

		public int? Label
		{
			get
			{
				return label;
			}
			set	
			{
				label = value;
				DictionaryUtil.Add(QueryParameters, "Label", value.ToString());
			}
		}

		public long? StartPayDate
		{
			get
			{
				return startPayDate;
			}
			set	
			{
				startPayDate = value;
				DictionaryUtil.Add(QueryParameters, "StartPayDate", value.ToString());
			}
		}

		public long? EndPayDate
		{
			get
			{
				return endPayDate;
			}
			set	
			{
				endPayDate = value;
				DictionaryUtil.Add(QueryParameters, "EndPayDate", value.ToString());
			}
		}

		public int? PayStatus
		{
			get
			{
				return payStatus;
			}
			set	
			{
				payStatus = value;
				DictionaryUtil.Add(QueryParameters, "PayStatus", value.ToString());
			}
		}

		public int? StartYear
		{
			get
			{
				return startYear;
			}
			set	
			{
				startYear = value;
				DictionaryUtil.Add(QueryParameters, "StartYear", value.ToString());
			}
		}

		public long? PlanId
		{
			get
			{
				return planId;
			}
			set	
			{
				planId = value;
				DictionaryUtil.Add(QueryParameters, "PlanId", value.ToString());
			}
		}

		public bool? PatentDiscard
		{
			get
			{
				return patentDiscard;
			}
			set	
			{
				patentDiscard = value;
				DictionaryUtil.Add(QueryParameters, "PatentDiscard", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetPatentPlanDetailListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetPatentPlanDetailListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
