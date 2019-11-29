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
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20190801;

namespace Aliyun.Acs.cloudesl.Model.V20190801
{
    public class DescribeUserLogRequest : RpcAcsRequest<DescribeUserLogResponse>
    {
        public DescribeUserLogRequest()
            : base("cloudesl", "2019-08-01", "DescribeUserLog", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? operateUserId;

		private string storeId;

		private int? pageNumber;

		private string fromDate;

		private long? itemId;

		private string toDate;

		private string eslBarCode;

		private int? pageSize;

		private string itemBarCode;

		private string operateStatus;

		private string itemTitle;

		private bool? reverse;

		private string operateType;

		public long? OperateUserId
		{
			get
			{
				return operateUserId;
			}
			set	
			{
				operateUserId = value;
				DictionaryUtil.Add(BodyParameters, "OperateUserId", value.ToString());
			}
		}

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(BodyParameters, "StoreId", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public string FromDate
		{
			get
			{
				return fromDate;
			}
			set	
			{
				fromDate = value;
				DictionaryUtil.Add(BodyParameters, "FromDate", value);
			}
		}

		public long? ItemId
		{
			get
			{
				return itemId;
			}
			set	
			{
				itemId = value;
				DictionaryUtil.Add(BodyParameters, "ItemId", value.ToString());
			}
		}

		public string ToDate
		{
			get
			{
				return toDate;
			}
			set	
			{
				toDate = value;
				DictionaryUtil.Add(BodyParameters, "ToDate", value);
			}
		}

		public string EslBarCode
		{
			get
			{
				return eslBarCode;
			}
			set	
			{
				eslBarCode = value;
				DictionaryUtil.Add(BodyParameters, "EslBarCode", value);
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
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string ItemBarCode
		{
			get
			{
				return itemBarCode;
			}
			set	
			{
				itemBarCode = value;
				DictionaryUtil.Add(BodyParameters, "ItemBarCode", value);
			}
		}

		public string OperateStatus
		{
			get
			{
				return operateStatus;
			}
			set	
			{
				operateStatus = value;
				DictionaryUtil.Add(BodyParameters, "OperateStatus", value);
			}
		}

		public string ItemTitle
		{
			get
			{
				return itemTitle;
			}
			set	
			{
				itemTitle = value;
				DictionaryUtil.Add(BodyParameters, "ItemTitle", value);
			}
		}

		public bool? Reverse
		{
			get
			{
				return reverse;
			}
			set	
			{
				reverse = value;
				DictionaryUtil.Add(BodyParameters, "Reverse", value.ToString());
			}
		}

		public string OperateType
		{
			get
			{
				return operateType;
			}
			set	
			{
				operateType = value;
				DictionaryUtil.Add(BodyParameters, "OperateType", value);
			}
		}

        public override DescribeUserLogResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeUserLogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
