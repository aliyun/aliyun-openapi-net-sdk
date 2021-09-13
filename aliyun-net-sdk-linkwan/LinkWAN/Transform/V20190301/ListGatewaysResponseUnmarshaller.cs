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
    public class ListGatewaysResponseUnmarshaller
    {
        public static ListGatewaysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGatewaysResponse listGatewaysResponse = new ListGatewaysResponse();

			listGatewaysResponse.HttpResponse = _ctx.HttpResponse;
			listGatewaysResponse.RequestId = _ctx.StringValue("ListGateways.RequestId");
			listGatewaysResponse.Success = _ctx.BooleanValue("ListGateways.Success");

			ListGatewaysResponse.ListGateways_Data data = new ListGatewaysResponse.ListGateways_Data();
			data.TotalCount = _ctx.LongValue("ListGateways.Data.TotalCount");

			List<ListGatewaysResponse.ListGateways_Data.ListGateways_Gateway> data_list = new List<ListGatewaysResponse.ListGateways_Data.ListGateways_Gateway>();
			for (int i = 0; i < _ctx.Length("ListGateways.Data.List.Length"); i++) {
				ListGatewaysResponse.ListGateways_Data.ListGateways_Gateway gateway = new ListGatewaysResponse.ListGateways_Data.ListGateways_Gateway();
				gateway.GwEui = _ctx.StringValue("ListGateways.Data.List["+ i +"].GwEui");
				gateway.Name = _ctx.StringValue("ListGateways.Data.List["+ i +"].Name");
				gateway.Description = _ctx.StringValue("ListGateways.Data.List["+ i +"].Description");
				gateway.City = _ctx.StringValue("ListGateways.Data.List["+ i +"].City");
				gateway.District = _ctx.StringValue("ListGateways.Data.List["+ i +"].District");
				gateway.Address = _ctx.StringValue("ListGateways.Data.List["+ i +"].Address");
				gateway.AddressCode = _ctx.LongValue("ListGateways.Data.List["+ i +"].AddressCode");
				gateway.GisCoordinateSystem = _ctx.StringValue("ListGateways.Data.List["+ i +"].GisCoordinateSystem");
				gateway.Longitude = _ctx.FloatValue("ListGateways.Data.List["+ i +"].Longitude");
				gateway.Latitude = _ctx.FloatValue("ListGateways.Data.List["+ i +"].Latitude");
				gateway.FreqBandPlanGroupId = _ctx.LongValue("ListGateways.Data.List["+ i +"].FreqBandPlanGroupId");
				gateway.CommunicationMode = _ctx.StringValue("ListGateways.Data.List["+ i +"].CommunicationMode");
				gateway.OnlineState = _ctx.StringValue("ListGateways.Data.List["+ i +"].OnlineState");
				gateway.Enabled = _ctx.BooleanValue("ListGateways.Data.List["+ i +"].Enabled");
				gateway.ClassBSupported = _ctx.BooleanValue("ListGateways.Data.List["+ i +"].ClassBSupported");
				gateway.ClassBWorking = _ctx.BooleanValue("ListGateways.Data.List["+ i +"].ClassBWorking");
				gateway.TimeCorrectable = _ctx.BooleanValue("ListGateways.Data.List["+ i +"].TimeCorrectable");
				gateway.OnlineStateChangedMillis = _ctx.LongValue("ListGateways.Data.List["+ i +"].OnlineStateChangedMillis");
				gateway.EmbeddedNsId = _ctx.StringValue("ListGateways.Data.List["+ i +"].EmbeddedNsId");
				gateway.ChargeStatus = _ctx.StringValue("ListGateways.Data.List["+ i +"].ChargeStatus");
				gateway.AuthTypes = _ctx.StringValue("ListGateways.Data.List["+ i +"].AuthTypes");

				data_list.Add(gateway);
			}
			data.List = data_list;
			listGatewaysResponse.Data = data;
        
			return listGatewaysResponse;
        }
    }
}
