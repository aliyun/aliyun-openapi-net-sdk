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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class CreateNatGatewayResponseUnmarshaller
    {
        public static CreateNatGatewayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateNatGatewayResponse createNatGatewayResponse = new CreateNatGatewayResponse();

			createNatGatewayResponse.HttpResponse = _ctx.HttpResponse;
			createNatGatewayResponse.RequestId = _ctx.StringValue("CreateNatGateway.RequestId");
			createNatGatewayResponse.NatGatewayId = _ctx.StringValue("CreateNatGateway.NatGatewayId");

			List<string> createNatGatewayResponse_forwardTableIds = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateNatGateway.ForwardTableIds.Length"); i++) {
				createNatGatewayResponse_forwardTableIds.Add(_ctx.StringValue("CreateNatGateway.ForwardTableIds["+ i +"]"));
			}
			createNatGatewayResponse.ForwardTableIds = createNatGatewayResponse_forwardTableIds;

			List<string> createNatGatewayResponse_snatTableIds = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateNatGateway.SnatTableIds.Length"); i++) {
				createNatGatewayResponse_snatTableIds.Add(_ctx.StringValue("CreateNatGateway.SnatTableIds["+ i +"]"));
			}
			createNatGatewayResponse.SnatTableIds = createNatGatewayResponse_snatTableIds;

			List<string> createNatGatewayResponse_bandwidthPackageIds = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateNatGateway.BandwidthPackageIds.Length"); i++) {
				createNatGatewayResponse_bandwidthPackageIds.Add(_ctx.StringValue("CreateNatGateway.BandwidthPackageIds["+ i +"]"));
			}
			createNatGatewayResponse.BandwidthPackageIds = createNatGatewayResponse_bandwidthPackageIds;
        
			return createNatGatewayResponse;
        }
    }
}
