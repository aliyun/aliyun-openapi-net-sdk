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
    public class GetThingTopoResponseUnmarshaller
    {
        public static GetThingTopoResponse Unmarshall(UnmarshallerContext context)
        {
			GetThingTopoResponse getThingTopoResponse = new GetThingTopoResponse();

			getThingTopoResponse.HttpResponse = context.HttpResponse;
			getThingTopoResponse.RequestId = context.StringValue("GetThingTopo.RequestId");
			getThingTopoResponse.Success = context.BooleanValue("GetThingTopo.Success");
			getThingTopoResponse.Code = context.StringValue("GetThingTopo.Code");
			getThingTopoResponse.ErrorMessage = context.StringValue("GetThingTopo.ErrorMessage");

			GetThingTopoResponse.GetThingTopo_Data data = new GetThingTopoResponse.GetThingTopo_Data();
			data.Total = context.LongValue("GetThingTopo.Data.Total");
			data.CurrentPage = context.IntegerValue("GetThingTopo.Data.CurrentPage");
			data.PageSize = context.IntegerValue("GetThingTopo.Data.PageSize");
			data.PageCount = context.LongValue("GetThingTopo.Data.PageCount");

			List<GetThingTopoResponse.GetThingTopo_Data.GetThingTopo_DeviceInfo> data_list = new List<GetThingTopoResponse.GetThingTopo_Data.GetThingTopo_DeviceInfo>();
			for (int i = 0; i < context.Length("GetThingTopo.Data.List.Length"); i++) {
				GetThingTopoResponse.GetThingTopo_Data.GetThingTopo_DeviceInfo deviceInfo = new GetThingTopoResponse.GetThingTopo_Data.GetThingTopo_DeviceInfo();
				deviceInfo.IotId = context.StringValue("GetThingTopo.Data.List["+ i +"].IotId");
				deviceInfo.ProductKey = context.StringValue("GetThingTopo.Data.List["+ i +"].ProductKey");
				deviceInfo.DeviceName = context.StringValue("GetThingTopo.Data.List["+ i +"].DeviceName");

				data_list.Add(deviceInfo);
			}
			data.List = data_list;
			getThingTopoResponse.Data = data;
        
			return getThingTopoResponse;
        }
    }
}
