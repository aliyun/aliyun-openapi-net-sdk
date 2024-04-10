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
using Aliyun.Acs.nis.Model.V20211216;

namespace Aliyun.Acs.nis.Transform.V20211216
{
    public class GetNatTopNResponseUnmarshaller
    {
        public static GetNatTopNResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNatTopNResponse getNatTopNResponse = new GetNatTopNResponse();

			getNatTopNResponse.HttpResponse = _ctx.HttpResponse;
			getNatTopNResponse.RequestId = _ctx.StringValue("GetNatTopN.RequestId");
			getNatTopNResponse.IsTopNOpen = _ctx.BooleanValue("GetNatTopN.IsTopNOpen");

			List<GetNatTopNResponse.GetNatTopN_NatGatewayTopNItem> getNatTopNResponse_natGatewayTopN = new List<GetNatTopNResponse.GetNatTopN_NatGatewayTopNItem>();
			for (int i = 0; i < _ctx.Length("GetNatTopN.NatGatewayTopN.Length"); i++) {
				GetNatTopNResponse.GetNatTopN_NatGatewayTopNItem natGatewayTopNItem = new GetNatTopNResponse.GetNatTopN_NatGatewayTopNItem();
				natGatewayTopNItem.Ip = _ctx.StringValue("GetNatTopN.NatGatewayTopN["+ i +"].Ip");
				natGatewayTopNItem.InBps = _ctx.FloatValue("GetNatTopN.NatGatewayTopN["+ i +"].InBps");
				natGatewayTopNItem.OutBps = _ctx.FloatValue("GetNatTopN.NatGatewayTopN["+ i +"].OutBps");
				natGatewayTopNItem.InPps = _ctx.FloatValue("GetNatTopN.NatGatewayTopN["+ i +"].InPps");
				natGatewayTopNItem.OutPps = _ctx.FloatValue("GetNatTopN.NatGatewayTopN["+ i +"].OutPps");
				natGatewayTopNItem.InFlowPerMinute = _ctx.FloatValue("GetNatTopN.NatGatewayTopN["+ i +"].InFlowPerMinute");
				natGatewayTopNItem.OutFlowPerMinute = _ctx.FloatValue("GetNatTopN.NatGatewayTopN["+ i +"].OutFlowPerMinute");
				natGatewayTopNItem.NewSessionPerSecond = _ctx.FloatValue("GetNatTopN.NatGatewayTopN["+ i +"].NewSessionPerSecond");
				natGatewayTopNItem.ActiveSessionCount = _ctx.FloatValue("GetNatTopN.NatGatewayTopN["+ i +"].ActiveSessionCount");

				getNatTopNResponse_natGatewayTopN.Add(natGatewayTopNItem);
			}
			getNatTopNResponse.NatGatewayTopN = getNatTopNResponse_natGatewayTopN;
        
			return getNatTopNResponse;
        }
    }
}
