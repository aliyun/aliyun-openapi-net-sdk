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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudesl.Transform;
using Aliyun.Acs.cloudesl.Transform.V20180801;
using System.Collections.Generic;

namespace Aliyun.Acs.cloudesl.Model.V20180801
{
    public class DescribeUserOperationLogRequest : RpcAcsRequest<DescribeUserOperationLogResponse>
    {
        public DescribeUserOperationLogRequest()
            : base("cloudesl", "2018-08-01", "DescribeUserOperationLog")
        {
        }

		private long? operateUserId;

		private string itemTitle;

		private string operateStatus;

		private string storeId;

		private bool? reverse;

		private int? pageNumber;

		private string fromDate;

		private long? itemId;

		private string toDate;

		private string eslBarCode;

		private int? pageSize;

		private string operateType;

		private string itemBarCode;

		public long? OperateUserId
		{
			get
			{
				return operateUserId;
			}
			set	
			{
				operateUserId = value;
				DictionaryUtil.Add(QueryParameters, "OperateUserId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ItemTitle", value);
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
				DictionaryUtil.Add(QueryParameters, "OperateStatus", value);
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
				DictionaryUtil.Add(QueryParameters, "StoreId", value);
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
				DictionaryUtil.Add(QueryParameters, "Reverse", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "FromDate", value);
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
				DictionaryUtil.Add(QueryParameters, "ItemId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ToDate", value);
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
				DictionaryUtil.Add(QueryParameters, "EslBarCode", value);
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

		public string OperateType
		{
			get
			{
				return operateType;
			}
			set	
			{
				operateType = value;
				DictionaryUtil.Add(QueryParameters, "OperateType", value);
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
				DictionaryUtil.Add(QueryParameters, "ItemBarCode", value);
			}
		}

        public override DescribeUserOperationLogResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeUserOperationLogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}