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
using Aliyun.Acs.Copyright.Model.V20190123;

namespace Aliyun.Acs.Copyright.Transform.V20190123
{
    public class GetPatentOverviewInfoResponseUnmarshaller
    {
        public static GetPatentOverviewInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPatentOverviewInfoResponse getPatentOverviewInfoResponse = new GetPatentOverviewInfoResponse();

			getPatentOverviewInfoResponse.HttpResponse = _ctx.HttpResponse;
			getPatentOverviewInfoResponse.RequestId = _ctx.StringValue("GetPatentOverviewInfo.RequestId");
			getPatentOverviewInfoResponse.Success = _ctx.BooleanValue("GetPatentOverviewInfo.Success");

			List<GetPatentOverviewInfoResponse.GetPatentOverviewInfo_DataItem> getPatentOverviewInfoResponse_data = new List<GetPatentOverviewInfoResponse.GetPatentOverviewInfo_DataItem>();
			for (int i = 0; i < _ctx.Length("GetPatentOverviewInfo.Data.Length"); i++) {
				GetPatentOverviewInfoResponse.GetPatentOverviewInfo_DataItem dataItem = new GetPatentOverviewInfoResponse.GetPatentOverviewInfo_DataItem();
				dataItem.FamingCount = _ctx.IntegerValue("GetPatentOverviewInfo.Data["+ i +"].FamingCount");
				dataItem.ShiyongCount = _ctx.IntegerValue("GetPatentOverviewInfo.Data["+ i +"].ShiyongCount");
				dataItem.Total = _ctx.IntegerValue("GetPatentOverviewInfo.Data["+ i +"].Total");
				dataItem.UserType = _ctx.StringValue("GetPatentOverviewInfo.Data["+ i +"].UserType");
				dataItem.WaiguanCount = _ctx.IntegerValue("GetPatentOverviewInfo.Data["+ i +"].WaiguanCount");

				getPatentOverviewInfoResponse_data.Add(dataItem);
			}
			getPatentOverviewInfoResponse.Data = getPatentOverviewInfoResponse_data;
        
			return getPatentOverviewInfoResponse;
        }
    }
}
