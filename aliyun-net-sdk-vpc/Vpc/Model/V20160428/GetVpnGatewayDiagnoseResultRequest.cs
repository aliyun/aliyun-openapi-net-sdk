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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class GetVpnGatewayDiagnoseResultRequest : RpcAcsRequest<GetVpnGatewayDiagnoseResultResponse>
    {
        public GetVpnGatewayDiagnoseResultRequest()
            : base("Vpc", "2016-04-28", "GetVpnGatewayDiagnoseResult", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string diagnoseId;

		private string vpnGatewayId;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string DiagnoseId
		{
			get
			{
				return diagnoseId;
			}
			set	
			{
				diagnoseId = value;
				DictionaryUtil.Add(QueryParameters, "DiagnoseId", value);
			}
		}

		public string VpnGatewayId
		{
			get
			{
				return vpnGatewayId;
			}
			set	
			{
				vpnGatewayId = value;
				DictionaryUtil.Add(QueryParameters, "VpnGatewayId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetVpnGatewayDiagnoseResultResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetVpnGatewayDiagnoseResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
