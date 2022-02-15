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
    public class GetPatentStatisticsDetailListRequest : RpcAcsRequest<GetPatentStatisticsDetailListResponse>
    {
        public GetPatentStatisticsDetailListRequest()
            : base("Copyright", "2019-01-23", "GetPatentStatisticsDetailList")
        {
        }

		private string userType;

		private string discount;

		private long? startDate;

		private string type;

		private long? endDate;

		private int? startYear;

		private string keyword;

		private int? endYear;

		public string UserType
		{
			get
			{
				return userType;
			}
			set	
			{
				userType = value;
				DictionaryUtil.Add(QueryParameters, "UserType", value);
			}
		}

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

		public long? StartDate
		{
			get
			{
				return startDate;
			}
			set	
			{
				startDate = value;
				DictionaryUtil.Add(QueryParameters, "StartDate", value.ToString());
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

		public long? EndDate
		{
			get
			{
				return endDate;
			}
			set	
			{
				endDate = value;
				DictionaryUtil.Add(QueryParameters, "EndDate", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetPatentStatisticsDetailListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetPatentStatisticsDetailListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
