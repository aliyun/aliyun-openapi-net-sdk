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
using Aliyun.Acs.dg.Transform;
using Aliyun.Acs.dg.Transform.V20190327;

namespace Aliyun.Acs.dg.Model.V20190327
{
    public class StopGatewayRequest : RpcAcsRequest<StopGatewayResponse>
    {
        public StopGatewayRequest()
            : base("dg", "2019-03-27", "StopGateway", "dg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dg.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string gatewayInstanceId;

		private string gatewayId;

		public string GatewayInstanceId
		{
			get
			{
				return gatewayInstanceId;
			}
			set	
			{
				gatewayInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "GatewayInstanceId", value);
			}
		}

		public string GatewayId
		{
			get
			{
				return gatewayId;
			}
			set	
			{
				gatewayId = value;
				DictionaryUtil.Add(BodyParameters, "GatewayId", value);
			}
		}

        public override StopGatewayResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StopGatewayResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
