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
using Aliyun.Acs.Oms;
using Aliyun.Acs.Oms.Transform;
using Aliyun.Acs.Oms.Transform.V20190527;

namespace Aliyun.Acs.Oms.Model.V20190527
{
    public class GetDomainFieldsRequest : RpcAcsRequest<GetDomainFieldsResponse>
    {
        public GetDomainFieldsRequest()
            : base("Oms", "2019-05-27", "GetDomainFields")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Oms.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Oms.Endpoint.endpointRegionalType, null);
            }
        }

		private string domainCode;

		private bool? useCache;

		public string DomainCode
		{
			get
			{
				return domainCode;
			}
			set	
			{
				domainCode = value;
				DictionaryUtil.Add(QueryParameters, "DomainCode", value);
			}
		}

		public bool? UseCache
		{
			get
			{
				return useCache;
			}
			set	
			{
				useCache = value;
				DictionaryUtil.Add(QueryParameters, "UseCache", value.ToString());
			}
		}

        public override GetDomainFieldsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetDomainFieldsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
