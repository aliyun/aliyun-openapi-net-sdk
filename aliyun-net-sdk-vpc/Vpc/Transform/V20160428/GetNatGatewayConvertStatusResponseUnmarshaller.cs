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
    public class GetNatGatewayConvertStatusResponseUnmarshaller
    {
        public static GetNatGatewayConvertStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNatGatewayConvertStatusResponse getNatGatewayConvertStatusResponse = new GetNatGatewayConvertStatusResponse();

			getNatGatewayConvertStatusResponse.HttpResponse = _ctx.HttpResponse;
			getNatGatewayConvertStatusResponse.RequestId = _ctx.StringValue("GetNatGatewayConvertStatus.RequestId");
			getNatGatewayConvertStatusResponse.NatGatewayId = _ctx.StringValue("GetNatGatewayConvertStatus.NatGatewayId");
			getNatGatewayConvertStatusResponse.Bid = _ctx.StringValue("GetNatGatewayConvertStatus.Bid");
			getNatGatewayConvertStatusResponse.AliUid = _ctx.LongValue("GetNatGatewayConvertStatus.AliUid");
			getNatGatewayConvertStatusResponse.DstNatType = _ctx.StringValue("GetNatGatewayConvertStatus.DstNatType");

			List<GetNatGatewayConvertStatusResponse.GetNatGatewayConvertStatus_ConvertStep> getNatGatewayConvertStatusResponse_convertSteps = new List<GetNatGatewayConvertStatusResponse.GetNatGatewayConvertStatus_ConvertStep>();
			for (int i = 0; i < _ctx.Length("GetNatGatewayConvertStatus.ConvertSteps.Length"); i++) {
				GetNatGatewayConvertStatusResponse.GetNatGatewayConvertStatus_ConvertStep convertStep = new GetNatGatewayConvertStatusResponse.GetNatGatewayConvertStatus_ConvertStep();
				convertStep.StepName = _ctx.StringValue("GetNatGatewayConvertStatus.ConvertSteps["+ i +"].StepName");
				convertStep.StepStatus = _ctx.StringValue("GetNatGatewayConvertStatus.ConvertSteps["+ i +"].StepStatus");
				convertStep.StepStartTime = _ctx.StringValue("GetNatGatewayConvertStatus.ConvertSteps["+ i +"].StepStartTime");

				getNatGatewayConvertStatusResponse_convertSteps.Add(convertStep);
			}
			getNatGatewayConvertStatusResponse.ConvertSteps = getNatGatewayConvertStatusResponse_convertSteps;
        
			return getNatGatewayConvertStatusResponse;
        }
    }
}
