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
    public class GetPatentPlanListResponseUnmarshaller
    {
        public static GetPatentPlanListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPatentPlanListResponse getPatentPlanListResponse = new GetPatentPlanListResponse();

			getPatentPlanListResponse.HttpResponse = _ctx.HttpResponse;
			getPatentPlanListResponse.PageNum = _ctx.IntegerValue("GetPatentPlanList.PageNum");
			getPatentPlanListResponse.RequestId = _ctx.StringValue("GetPatentPlanList.RequestId");
			getPatentPlanListResponse.Success = _ctx.BooleanValue("GetPatentPlanList.Success");
			getPatentPlanListResponse.TotalItemNum = _ctx.IntegerValue("GetPatentPlanList.TotalItemNum");
			getPatentPlanListResponse.PageSize = _ctx.IntegerValue("GetPatentPlanList.PageSize");
			getPatentPlanListResponse.TotalPageNum = _ctx.IntegerValue("GetPatentPlanList.TotalPageNum");

			List<GetPatentPlanListResponse.GetPatentPlanList_Produces> getPatentPlanListResponse_data = new List<GetPatentPlanListResponse.GetPatentPlanList_Produces>();
			for (int i = 0; i < _ctx.Length("GetPatentPlanList.Data.Length"); i++) {
				GetPatentPlanListResponse.GetPatentPlanList_Produces produces = new GetPatentPlanListResponse.GetPatentPlanList_Produces();
				produces.Owner = _ctx.StringValue("GetPatentPlanList.Data["+ i +"].Owner");
				produces.Contact = _ctx.StringValue("GetPatentPlanList.Data["+ i +"].Contact");
				produces.SoldCount = _ctx.IntegerValue("GetPatentPlanList.Data["+ i +"].SoldCount");
				produces.UnSoldCount = _ctx.StringValue("GetPatentPlanList.Data["+ i +"].UnSoldCount");
				produces.Name = _ctx.StringValue("GetPatentPlanList.Data["+ i +"].Name");
				produces.PlanId = _ctx.LongValue("GetPatentPlanList.Data["+ i +"].PlanId");
				produces.TotalCount = _ctx.IntegerValue("GetPatentPlanList.Data["+ i +"].TotalCount");

				getPatentPlanListResponse_data.Add(produces);
			}
			getPatentPlanListResponse.Data = getPatentPlanListResponse_data;
        
			return getPatentPlanListResponse;
        }
    }
}
