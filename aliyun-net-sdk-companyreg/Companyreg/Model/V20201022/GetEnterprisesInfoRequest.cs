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
using Aliyun.Acs.companyreg.Transform.V20201022;

namespace Aliyun.Acs.companyreg.Model.V20201022
{
    public class GetEnterprisesInfoRequest : RpcAcsRequest<GetEnterprisesInfoResponse>
    {
        public GetEnterprisesInfoRequest()
            : base("companyreg", "2020-10-22", "GetEnterprisesInfo", "companyreg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointRegionalType, null);
            }
        }

		private string creditCode;

		private string enterpriseName;

		public string CreditCode
		{
			get
			{
				return creditCode;
			}
			set	
			{
				creditCode = value;
				DictionaryUtil.Add(QueryParameters, "CreditCode", value);
			}
		}

		public string EnterpriseName
		{
			get
			{
				return enterpriseName;
			}
			set	
			{
				enterpriseName = value;
				DictionaryUtil.Add(QueryParameters, "EnterpriseName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetEnterprisesInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetEnterprisesInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
