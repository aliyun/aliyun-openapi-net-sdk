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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class GetBusinessCategoryListResponseUnmarshaller
    {
        public static GetBusinessCategoryListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetBusinessCategoryListResponse getBusinessCategoryListResponse = new GetBusinessCategoryListResponse();

			getBusinessCategoryListResponse.HttpResponse = _ctx.HttpResponse;
			getBusinessCategoryListResponse.RequestId = _ctx.StringValue("GetBusinessCategoryList.RequestId");
			getBusinessCategoryListResponse.Success = _ctx.BooleanValue("GetBusinessCategoryList.Success");
			getBusinessCategoryListResponse.Code = _ctx.StringValue("GetBusinessCategoryList.Code");
			getBusinessCategoryListResponse.Message = _ctx.StringValue("GetBusinessCategoryList.Message");

			List<GetBusinessCategoryListResponse.GetBusinessCategoryList_BusinessCategoryBasicInfo> getBusinessCategoryListResponse_data = new List<GetBusinessCategoryListResponse.GetBusinessCategoryList_BusinessCategoryBasicInfo>();
			for (int i = 0; i < _ctx.Length("GetBusinessCategoryList.Data.Length"); i++) {
				GetBusinessCategoryListResponse.GetBusinessCategoryList_BusinessCategoryBasicInfo businessCategoryBasicInfo = new GetBusinessCategoryListResponse.GetBusinessCategoryList_BusinessCategoryBasicInfo();
				businessCategoryBasicInfo.Bid = _ctx.IntegerValue("GetBusinessCategoryList.Data["+ i +"].Bid");
				businessCategoryBasicInfo.ServiceType = _ctx.IntegerValue("GetBusinessCategoryList.Data["+ i +"].ServiceType");
				businessCategoryBasicInfo.BusinessName = _ctx.StringValue("GetBusinessCategoryList.Data["+ i +"].BusinessName");

				getBusinessCategoryListResponse_data.Add(businessCategoryBasicInfo);
			}
			getBusinessCategoryListResponse.Data = getBusinessCategoryListResponse_data;
        
			return getBusinessCategoryListResponse;
        }
    }
}
