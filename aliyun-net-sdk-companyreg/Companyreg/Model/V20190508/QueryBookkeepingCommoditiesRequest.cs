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
    public class QueryBookkeepingCommoditiesRequest : RpcAcsRequest<QueryBookkeepingCommoditiesResponse>
    {
        public QueryBookkeepingCommoditiesRequest()
            : base("companyreg", "2019-05-08", "QueryBookkeepingCommodities", "companyreg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string serviceType;

		private string city;

		private string companyType;

		private string areaType;

		public string ServiceType
		{
			get
			{
				return serviceType;
			}
			set	
			{
				serviceType = value;
				DictionaryUtil.Add(QueryParameters, "ServiceType", value);
			}
		}

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(QueryParameters, "City", value);
			}
		}

		public string CompanyType
		{
			get
			{
				return companyType;
			}
			set	
			{
				companyType = value;
				DictionaryUtil.Add(QueryParameters, "CompanyType", value);
			}
		}

		public string AreaType
		{
			get
			{
				return areaType;
			}
			set	
			{
				areaType = value;
				DictionaryUtil.Add(QueryParameters, "AreaType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryBookkeepingCommoditiesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryBookkeepingCommoditiesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
