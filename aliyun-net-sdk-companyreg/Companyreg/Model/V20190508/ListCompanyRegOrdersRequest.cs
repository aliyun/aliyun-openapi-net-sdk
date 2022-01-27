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
using Aliyun.Acs.companyreg.Transform;
using Aliyun.Acs.companyreg.Transform.V20190508;

namespace Aliyun.Acs.companyreg.Model.V20190508
{
    public class ListCompanyRegOrdersRequest : RpcAcsRequest<ListCompanyRegOrdersResponse>
    {
        public ListCompanyRegOrdersRequest()
            : base("companyreg", "2019-05-08", "ListCompanyRegOrders", "companyreg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string notBizStatus;

		private int? pageNum;

		private string bizStatus;

		private string companyName;

		private int? pageSize;

		private string aliyunOrderId;

		private string bizSubCode;

		public string NotBizStatus
		{
			get
			{
				return notBizStatus;
			}
			set	
			{
				notBizStatus = value;
				DictionaryUtil.Add(QueryParameters, "NotBizStatus", value);
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

		public string BizStatus
		{
			get
			{
				return bizStatus;
			}
			set	
			{
				bizStatus = value;
				DictionaryUtil.Add(QueryParameters, "BizStatus", value);
			}
		}

		public string CompanyName
		{
			get
			{
				return companyName;
			}
			set	
			{
				companyName = value;
				DictionaryUtil.Add(QueryParameters, "CompanyName", value);
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

		public string BizSubCode
		{
			get
			{
				return bizSubCode;
			}
			set	
			{
				bizSubCode = value;
				DictionaryUtil.Add(QueryParameters, "BizSubCode", value);
			}
		}

        public override ListCompanyRegOrdersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListCompanyRegOrdersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
