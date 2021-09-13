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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class ListActiveGatewaysResponseUnmarshaller
    {
        public static ListActiveGatewaysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListActiveGatewaysResponse listActiveGatewaysResponse = new ListActiveGatewaysResponse();

			listActiveGatewaysResponse.HttpResponse = _ctx.HttpResponse;
			listActiveGatewaysResponse.RequestId = _ctx.StringValue("ListActiveGateways.RequestId");
			listActiveGatewaysResponse.Success = _ctx.BooleanValue("ListActiveGateways.Success");

			List<ListActiveGatewaysResponse.ListActiveGateways_Gateway> listActiveGatewaysResponse_data = new List<ListActiveGatewaysResponse.ListActiveGateways_Gateway>();
			for (int i = 0; i < _ctx.Length("ListActiveGateways.Data.Length"); i++) {
				ListActiveGatewaysResponse.ListActiveGateways_Gateway gateway = new ListActiveGatewaysResponse.ListActiveGateways_Gateway();
				gateway.GwEui = _ctx.StringValue("ListActiveGateways.Data["+ i +"].GwEui");
				gateway.Name = _ctx.StringValue("ListActiveGateways.Data["+ i +"].Name");
				gateway.Description = _ctx.StringValue("ListActiveGateways.Data["+ i +"].Description");
				gateway.City = _ctx.StringValue("ListActiveGateways.Data["+ i +"].City");
				gateway.District = _ctx.StringValue("ListActiveGateways.Data["+ i +"].District");
				gateway.Address = _ctx.StringValue("ListActiveGateways.Data["+ i +"].Address");
				gateway.AddressCode = _ctx.LongValue("ListActiveGateways.Data["+ i +"].AddressCode");
				gateway.GisCoordinateSystem = _ctx.StringValue("ListActiveGateways.Data["+ i +"].GisCoordinateSystem");
				gateway.Longitude = _ctx.FloatValue("ListActiveGateways.Data["+ i +"].Longitude");
				gateway.Latitude = _ctx.FloatValue("ListActiveGateways.Data["+ i +"].Latitude");
				gateway.FreqBandPlanGroupId = _ctx.LongValue("ListActiveGateways.Data["+ i +"].FreqBandPlanGroupId");
				gateway.CommunicationMode = _ctx.StringValue("ListActiveGateways.Data["+ i +"].CommunicationMode");
				gateway.OnlineState = _ctx.StringValue("ListActiveGateways.Data["+ i +"].OnlineState");
				gateway.ChargeStatus = _ctx.StringValue("ListActiveGateways.Data["+ i +"].ChargeStatus");

				listActiveGatewaysResponse_data.Add(gateway);
			}
			listActiveGatewaysResponse.Data = listActiveGatewaysResponse_data;
        
			return listActiveGatewaysResponse;
        }
    }
}
