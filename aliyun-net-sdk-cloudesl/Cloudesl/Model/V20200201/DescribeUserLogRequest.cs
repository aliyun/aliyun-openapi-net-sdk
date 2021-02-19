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
using Aliyun.Acs.cloudesl.Transform.V20200201;

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
    public class DescribeUserLogRequest : RpcAcsRequest<DescribeUserLogResponse>
    {
        public DescribeUserLogRequest()
            : base("cloudesl", "2020-02-01", "DescribeUserLog", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.cloudesl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string extraParams;

		private string storeId;

		private string userId;

		private int? pageNumber;

		private string fromDate;

		private string operationStatus;

		private string toDate;

		private string eslBarCode;

		private int? pageSize;

		private string itemBarCode;

		private string itemShortTitle;

		private string operationType;

		private string logId;

		public string ExtraParams
		{
			get
			{
				return extraParams;
			}
			set	
			{
				extraParams = value;
				DictionaryUtil.Add(BodyParameters, "ExtraParams", value);
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

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(BodyParameters, "UserId", value);
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

		public string OperationStatus
		{
			get
			{
				return operationStatus;
			}
			set	
			{
				operationStatus = value;
				DictionaryUtil.Add(BodyParameters, "OperationStatus", value);
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

		public string ItemShortTitle
		{
			get
			{
				return itemShortTitle;
			}
			set	
			{
				itemShortTitle = value;
				DictionaryUtil.Add(BodyParameters, "ItemShortTitle", value);
			}
		}

		public string OperationType
		{
			get
			{
				return operationType;
			}
			set	
			{
				operationType = value;
				DictionaryUtil.Add(BodyParameters, "OperationType", value);
			}
		}

		public string LogId
		{
			get
			{
				return logId;
			}
			set	
			{
				logId = value;
				DictionaryUtil.Add(BodyParameters, "LogId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeUserLogResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeUserLogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
