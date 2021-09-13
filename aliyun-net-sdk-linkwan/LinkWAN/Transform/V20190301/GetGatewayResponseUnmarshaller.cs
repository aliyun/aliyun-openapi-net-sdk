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
    public class GetGatewayResponseUnmarshaller
    {
        public static GetGatewayResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetGatewayResponse getGatewayResponse = new GetGatewayResponse();

			getGatewayResponse.HttpResponse = _ctx.HttpResponse;
			getGatewayResponse.RequestId = _ctx.StringValue("GetGateway.RequestId");
			getGatewayResponse.Success = _ctx.BooleanValue("GetGateway.Success");

			GetGatewayResponse.GetGateway_Data data = new GetGatewayResponse.GetGateway_Data();
			data.GwEui = _ctx.StringValue("GetGateway.Data.GwEui");
			data.OnlineState = _ctx.StringValue("GetGateway.Data.OnlineState");
			data.Name = _ctx.StringValue("GetGateway.Data.Name");
			data.Description = _ctx.StringValue("GetGateway.Data.Description");
			data.City = _ctx.StringValue("GetGateway.Data.City");
			data.District = _ctx.StringValue("GetGateway.Data.District");
			data.Address = _ctx.StringValue("GetGateway.Data.Address");
			data.AddressCode = _ctx.LongValue("GetGateway.Data.AddressCode");
			data.GisCoordinateSystem = _ctx.StringValue("GetGateway.Data.GisCoordinateSystem");
			data.Longitude = _ctx.FloatValue("GetGateway.Data.Longitude");
			data.Latitude = _ctx.FloatValue("GetGateway.Data.Latitude");
			data.FreqBandPlanGroupId = _ctx.LongValue("GetGateway.Data.FreqBandPlanGroupId");
			data.CommunicationMode = _ctx.StringValue("GetGateway.Data.CommunicationMode");
			data.TimeCorrectable = _ctx.BooleanValue("GetGateway.Data.TimeCorrectable");
			data.ClassBSupported = _ctx.BooleanValue("GetGateway.Data.ClassBSupported");
			data.ClassBWorking = _ctx.BooleanValue("GetGateway.Data.ClassBWorking");
			data.Enabled = _ctx.BooleanValue("GetGateway.Data.Enabled");
			data.OnlineStateChangedMillis = _ctx.LongValue("GetGateway.Data.OnlineStateChangedMillis");
			data.EmbeddedNsId = _ctx.StringValue("GetGateway.Data.EmbeddedNsId");
			data.ChargeStatus = _ctx.StringValue("GetGateway.Data.ChargeStatus");
			data.AuthTypes = _ctx.StringValue("GetGateway.Data.AuthTypes");
			getGatewayResponse.Data = data;
        
			return getGatewayResponse;
        }
    }
}
