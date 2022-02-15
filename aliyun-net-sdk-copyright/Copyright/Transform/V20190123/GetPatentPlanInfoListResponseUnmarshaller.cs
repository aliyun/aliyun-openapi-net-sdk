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
    public class GetPatentPlanInfoListResponseUnmarshaller
    {
        public static GetPatentPlanInfoListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPatentPlanInfoListResponse getPatentPlanInfoListResponse = new GetPatentPlanInfoListResponse();

			getPatentPlanInfoListResponse.HttpResponse = _ctx.HttpResponse;
			getPatentPlanInfoListResponse.PageNum = _ctx.IntegerValue("GetPatentPlanInfoList.PageNum");
			getPatentPlanInfoListResponse.PageSize = _ctx.IntegerValue("GetPatentPlanInfoList.PageSize");
			getPatentPlanInfoListResponse.RequestId = _ctx.StringValue("GetPatentPlanInfoList.RequestId");
			getPatentPlanInfoListResponse.Success = _ctx.BooleanValue("GetPatentPlanInfoList.Success");
			getPatentPlanInfoListResponse.TotalItemNum = _ctx.IntegerValue("GetPatentPlanInfoList.TotalItemNum");
			getPatentPlanInfoListResponse.TotalPageNum = _ctx.IntegerValue("GetPatentPlanInfoList.TotalPageNum");

			List<GetPatentPlanInfoListResponse.GetPatentPlanInfoList_Produces> getPatentPlanInfoListResponse_data = new List<GetPatentPlanInfoListResponse.GetPatentPlanInfoList_Produces>();
			for (int i = 0; i < _ctx.Length("GetPatentPlanInfoList.Data.Length"); i++) {
				GetPatentPlanInfoListResponse.GetPatentPlanInfoList_Produces produces = new GetPatentPlanInfoListResponse.GetPatentPlanInfoList_Produces();
				produces.Contact = _ctx.StringValue("GetPatentPlanInfoList.Data["+ i +"].Contact");
				produces.Name = _ctx.StringValue("GetPatentPlanInfoList.Data["+ i +"].Name");
				produces.Owner = _ctx.StringValue("GetPatentPlanInfoList.Data["+ i +"].Owner");
				produces.PlanId = _ctx.LongValue("GetPatentPlanInfoList.Data["+ i +"].PlanId");
				produces.WarnDays = _ctx.IntegerValue("GetPatentPlanInfoList.Data["+ i +"].WarnDays");

				getPatentPlanInfoListResponse_data.Add(produces);
			}
			getPatentPlanInfoListResponse.Data = getPatentPlanInfoListResponse_data;
        
			return getPatentPlanInfoListResponse;
        }
    }
}
