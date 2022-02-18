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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GisQueryDeviceLocationResponseUnmarshaller
    {
        public static GisQueryDeviceLocationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GisQueryDeviceLocationResponse gisQueryDeviceLocationResponse = new GisQueryDeviceLocationResponse();

			gisQueryDeviceLocationResponse.HttpResponse = _ctx.HttpResponse;
			gisQueryDeviceLocationResponse.RequestId = _ctx.StringValue("GisQueryDeviceLocation.RequestId");
			gisQueryDeviceLocationResponse.Success = _ctx.BooleanValue("GisQueryDeviceLocation.Success");
			gisQueryDeviceLocationResponse.Code = _ctx.StringValue("GisQueryDeviceLocation.Code");
			gisQueryDeviceLocationResponse.ErrorMessage = _ctx.StringValue("GisQueryDeviceLocation.ErrorMessage");

			List<GisQueryDeviceLocationResponse.GisQueryDeviceLocation_DataItem> gisQueryDeviceLocationResponse_data = new List<GisQueryDeviceLocationResponse.GisQueryDeviceLocation_DataItem>();
			for (int i = 0; i < _ctx.Length("GisQueryDeviceLocation.Data.Length"); i++) {
				GisQueryDeviceLocationResponse.GisQueryDeviceLocation_DataItem dataItem = new GisQueryDeviceLocationResponse.GisQueryDeviceLocation_DataItem();
				dataItem.ProductKey = _ctx.StringValue("GisQueryDeviceLocation.Data["+ i +"].ProductKey");
				dataItem.DeviceName = _ctx.StringValue("GisQueryDeviceLocation.Data["+ i +"].DeviceName");
				dataItem.Ip = _ctx.StringValue("GisQueryDeviceLocation.Data["+ i +"].Ip");
				dataItem.Country = _ctx.StringValue("GisQueryDeviceLocation.Data["+ i +"].Country");
				dataItem.Province = _ctx.StringValue("GisQueryDeviceLocation.Data["+ i +"].Province");
				dataItem.City = _ctx.StringValue("GisQueryDeviceLocation.Data["+ i +"].City");
				dataItem.Longitude = _ctx.FloatValue("GisQueryDeviceLocation.Data["+ i +"].Longitude");
				dataItem.Latitude = _ctx.FloatValue("GisQueryDeviceLocation.Data["+ i +"].Latitude");
				dataItem.CoordinateSystem = _ctx.IntegerValue("GisQueryDeviceLocation.Data["+ i +"].CoordinateSystem");
				dataItem.Adcode = _ctx.LongValue("GisQueryDeviceLocation.Data["+ i +"].Adcode");

				gisQueryDeviceLocationResponse_data.Add(dataItem);
			}
			gisQueryDeviceLocationResponse.Data = gisQueryDeviceLocationResponse_data;
        
			return gisQueryDeviceLocationResponse;
        }
    }
}
