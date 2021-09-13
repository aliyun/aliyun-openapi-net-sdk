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
    public class ListGatewaysGisInfoResponseUnmarshaller
    {
        public static ListGatewaysGisInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGatewaysGisInfoResponse listGatewaysGisInfoResponse = new ListGatewaysGisInfoResponse();

			listGatewaysGisInfoResponse.HttpResponse = _ctx.HttpResponse;
			listGatewaysGisInfoResponse.RequestId = _ctx.StringValue("ListGatewaysGisInfo.RequestId");
			listGatewaysGisInfoResponse.Success = _ctx.BooleanValue("ListGatewaysGisInfo.Success");

			List<ListGatewaysGisInfoResponse.ListGatewaysGisInfo_GatewayGisInfo> listGatewaysGisInfoResponse_data = new List<ListGatewaysGisInfoResponse.ListGatewaysGisInfo_GatewayGisInfo>();
			for (int i = 0; i < _ctx.Length("ListGatewaysGisInfo.Data.Length"); i++) {
				ListGatewaysGisInfoResponse.ListGatewaysGisInfo_GatewayGisInfo gatewayGisInfo = new ListGatewaysGisInfoResponse.ListGatewaysGisInfo_GatewayGisInfo();
				gatewayGisInfo.GwEui = _ctx.StringValue("ListGatewaysGisInfo.Data["+ i +"].GwEui");
				gatewayGisInfo.GisCoordinateSystem = _ctx.StringValue("ListGatewaysGisInfo.Data["+ i +"].GisCoordinateSystem");
				gatewayGisInfo.Longitude = _ctx.FloatValue("ListGatewaysGisInfo.Data["+ i +"].Longitude");
				gatewayGisInfo.Latitude = _ctx.FloatValue("ListGatewaysGisInfo.Data["+ i +"].Latitude");
				gatewayGisInfo.FreqBandPlanGroupId = _ctx.LongValue("ListGatewaysGisInfo.Data["+ i +"].FreqBandPlanGroupId");
				gatewayGisInfo.Name = _ctx.StringValue("ListGatewaysGisInfo.Data["+ i +"].Name");
				gatewayGisInfo.OnlineState = _ctx.StringValue("ListGatewaysGisInfo.Data["+ i +"].OnlineState");
				gatewayGisInfo.GisSourceType = _ctx.StringValue("ListGatewaysGisInfo.Data["+ i +"].GisSourceType");
				gatewayGisInfo.Enabled = _ctx.BooleanValue("ListGatewaysGisInfo.Data["+ i +"].Enabled");
				gatewayGisInfo.ChargeStatus = _ctx.StringValue("ListGatewaysGisInfo.Data["+ i +"].ChargeStatus");
				gatewayGisInfo.AuthTypes = _ctx.StringValue("ListGatewaysGisInfo.Data["+ i +"].AuthTypes");

				listGatewaysGisInfoResponse_data.Add(gatewayGisInfo);
			}
			listGatewaysGisInfoResponse.Data = listGatewaysGisInfoResponse_data;
        
			return listGatewaysGisInfoResponse;
        }
    }
}
