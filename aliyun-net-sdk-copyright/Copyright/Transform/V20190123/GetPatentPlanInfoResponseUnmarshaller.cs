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
    public class GetPatentPlanInfoResponseUnmarshaller
    {
        public static GetPatentPlanInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPatentPlanInfoResponse getPatentPlanInfoResponse = new GetPatentPlanInfoResponse();

			getPatentPlanInfoResponse.HttpResponse = _ctx.HttpResponse;
			getPatentPlanInfoResponse.RequestId = _ctx.StringValue("GetPatentPlanInfo.RequestId");
			getPatentPlanInfoResponse.Success = _ctx.BooleanValue("GetPatentPlanInfo.Success");

			List<GetPatentPlanInfoResponse.GetPatentPlanInfo_DataItem> getPatentPlanInfoResponse_data = new List<GetPatentPlanInfoResponse.GetPatentPlanInfo_DataItem>();
			for (int i = 0; i < _ctx.Length("GetPatentPlanInfo.Data.Length"); i++) {
				GetPatentPlanInfoResponse.GetPatentPlanInfo_DataItem dataItem = new GetPatentPlanInfoResponse.GetPatentPlanInfo_DataItem();
				dataItem.Contact = _ctx.StringValue("GetPatentPlanInfo.Data["+ i +"].Contact");
				dataItem.Name = _ctx.StringValue("GetPatentPlanInfo.Data["+ i +"].Name");
				dataItem.Owner = _ctx.StringValue("GetPatentPlanInfo.Data["+ i +"].Owner");
				dataItem.PlanId = _ctx.IntegerValue("GetPatentPlanInfo.Data["+ i +"].PlanId");
				dataItem.WarnDays = _ctx.IntegerValue("GetPatentPlanInfo.Data["+ i +"].WarnDays");

				getPatentPlanInfoResponse_data.Add(dataItem);
			}
			getPatentPlanInfoResponse.Data = getPatentPlanInfoResponse_data;
        
			return getPatentPlanInfoResponse;
        }
    }
}
