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
using Aliyun.Acs.Dm.Model.V20170622;

namespace Aliyun.Acs.Dm.Transform.V20170622
{
    public class GetRegionListResponseUnmarshaller
    {
        public static GetRegionListResponse Unmarshall(UnmarshallerContext context)
        {
			GetRegionListResponse getRegionListResponse = new GetRegionListResponse();

			getRegionListResponse.HttpResponse = context.HttpResponse;
			getRegionListResponse.RequestId = context.StringValue("GetRegionList.RequestId");
			getRegionListResponse.Total = context.IntegerValue("GetRegionList.Total");
			getRegionListResponse.PageNo = context.IntegerValue("GetRegionList.PageNo");
			getRegionListResponse.PageSize = context.IntegerValue("GetRegionList.PageSize");

			List<GetRegionListResponse.GetRegionList_RegionList> getRegionListResponse_data = new List<GetRegionListResponse.GetRegionList_RegionList>();
			for (int i = 0; i < context.Length("GetRegionList.Data.Length"); i++) {
				GetRegionListResponse.GetRegionList_RegionList regionList = new GetRegionListResponse.GetRegionList_RegionList();
				regionList.Region = context.StringValue("GetRegionList.Data["+ i +"].Region");
				regionList.RegionDesc = context.StringValue("GetRegionList.Data["+ i +"].RegionDesc");

				getRegionListResponse_data.Add(regionList);
			}
			getRegionListResponse.Data = getRegionListResponse_data;
        
			return getRegionListResponse;
        }
    }
}
