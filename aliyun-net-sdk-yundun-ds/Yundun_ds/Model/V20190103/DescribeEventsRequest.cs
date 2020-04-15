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
using Aliyun.Acs.Yundun_ds.Transform;
using Aliyun.Acs.Yundun_ds.Transform.V20190103;

namespace Aliyun.Acs.Yundun_ds.Model.V20190103
{
    public class DescribeEventsRequest : RpcAcsRequest<DescribeEventsResponse>
    {
        public DescribeEventsRequest()
            : base("Yundun-ds", "2019-01-03", "DescribeEvents", "sddp", "openAPI")
        {
        }

		private string startTime;

		private long? userId;

		private string typeCode;

		private string subTypeCode;

		private int? pageSize;

		private string lang;

		private string dealUserId;

		private int? featureType;

		private string endTime;

		private int? currentPage;

		private long? departId;

		private string status;

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public long? UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value.ToString());
			}
		}

		public string TypeCode
		{
			get
			{
				return typeCode;
			}
			set	
			{
				typeCode = value;
				DictionaryUtil.Add(QueryParameters, "TypeCode", value);
			}
		}

		public string SubTypeCode
		{
			get
			{
				return subTypeCode;
			}
			set	
			{
				subTypeCode = value;
				DictionaryUtil.Add(QueryParameters, "SubTypeCode", value);
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

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string DealUserId
		{
			get
			{
				return dealUserId;
			}
			set	
			{
				dealUserId = value;
				DictionaryUtil.Add(QueryParameters, "DealUserId", value);
			}
		}

		public int? FeatureType
		{
			get
			{
				return featureType;
			}
			set	
			{
				featureType = value;
				DictionaryUtil.Add(QueryParameters, "FeatureType", value.ToString());
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public long? DepartId
		{
			get
			{
				return departId;
			}
			set	
			{
				departId = value;
				DictionaryUtil.Add(QueryParameters, "DepartId", value.ToString());
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
