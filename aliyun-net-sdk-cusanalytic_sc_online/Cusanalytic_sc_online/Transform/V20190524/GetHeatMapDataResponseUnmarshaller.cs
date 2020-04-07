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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetHeatMapDataResponseUnmarshaller
    {
        public static GetHeatMapDataResponse Unmarshall(UnmarshallerContext context)
        {
			GetHeatMapDataResponse getHeatMapDataResponse = new GetHeatMapDataResponse();

			getHeatMapDataResponse.HttpResponse = context.HttpResponse;
			getHeatMapDataResponse.EMapName = context.StringValue("GetHeatMapData.EMapName");
			getHeatMapDataResponse.Width = context.FloatValue("GetHeatMapData.Width");
			getHeatMapDataResponse.EMapUrl = context.StringValue("GetHeatMapData.EMapUrl");
			getHeatMapDataResponse.StoreId = context.LongValue("GetHeatMapData.StoreId");
			getHeatMapDataResponse.Height = context.FloatValue("GetHeatMapData.Height");
			getHeatMapDataResponse.Msg = context.StringValue("GetHeatMapData.Msg");
			getHeatMapDataResponse.Success = context.BooleanValue("GetHeatMapData.Success");

			List<GetHeatMapDataResponse.GetHeatMapData_HeatMapItem> getHeatMapDataResponse_heatMapItems = new List<GetHeatMapDataResponse.GetHeatMapData_HeatMapItem>();
			for (int i = 0; i < context.Length("GetHeatMapData.HeatMapItems.Length"); i++) {
				GetHeatMapDataResponse.GetHeatMapData_HeatMapItem heatMapItem = new GetHeatMapDataResponse.GetHeatMapData_HeatMapItem();
				heatMapItem.Y = context.FloatValue("GetHeatMapData.HeatMapItems["+ i +"].Y");
				heatMapItem.Weight = context.FloatValue("GetHeatMapData.HeatMapItems["+ i +"].Weight");
				heatMapItem.X = context.FloatValue("GetHeatMapData.HeatMapItems["+ i +"].X");

				getHeatMapDataResponse_heatMapItems.Add(heatMapItem);
			}
			getHeatMapDataResponse.HeatMapItems = getHeatMapDataResponse_heatMapItems;
        
			return getHeatMapDataResponse;
        }
    }
}
