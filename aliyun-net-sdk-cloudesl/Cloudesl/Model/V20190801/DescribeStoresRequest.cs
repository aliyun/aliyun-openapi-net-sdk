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
    public class DescribeStoresRequest : RpcAcsRequest<DescribeStoresResponse>
    {
        public DescribeStoresRequest()
            : base("cloudesl", "2019-08-01", "DescribeStores", "cloudesl", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string storeName;

		private string storeId;

		private int? pageNumber;

		private string fromDate;

		private string companyId;

		private string toDate;

		private int? pageSize;

		private string brand;

		public string StoreName
		{
			get
			{
				return storeName;
			}
			set	
			{
				storeName = value;
				DictionaryUtil.Add(BodyParameters, "StoreName", value);
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

		public string CompanyId
		{
			get
			{
				return companyId;
			}
			set	
			{
				companyId = value;
				DictionaryUtil.Add(BodyParameters, "CompanyId", value);
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

		public string Brand
		{
			get
			{
				return brand;
			}
			set	
			{
				brand = value;
				DictionaryUtil.Add(BodyParameters, "Brand", value);
			}
		}

        public override DescribeStoresResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeStoresResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
