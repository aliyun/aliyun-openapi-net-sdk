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
    public class GetIpfilterListResponseUnmarshaller
    {
        public static GetIpfilterListResponse Unmarshall(UnmarshallerContext context)
        {
			GetIpfilterListResponse getIpfilterListResponse = new GetIpfilterListResponse();

			getIpfilterListResponse.HttpResponse = context.HttpResponse;
			getIpfilterListResponse.RequestId = context.StringValue("GetIpfilterList.RequestId");
			getIpfilterListResponse.TotalCount = context.IntegerValue("GetIpfilterList.TotalCount");
			getIpfilterListResponse.PageNumber = context.IntegerValue("GetIpfilterList.PageNumber");
			getIpfilterListResponse.PageSize = context.IntegerValue("GetIpfilterList.PageSize");

			List<GetIpfilterListResponse.GetIpfilterList_Ipfilters> getIpfilterListResponse_data = new List<GetIpfilterListResponse.GetIpfilterList_Ipfilters>();
			for (int i = 0; i < context.Length("GetIpfilterList.Data.Length"); i++) {
				GetIpfilterListResponse.GetIpfilterList_Ipfilters ipfilters = new GetIpfilterListResponse.GetIpfilterList_Ipfilters();
				ipfilters.Id = context.StringValue("GetIpfilterList.Data["+ i +"].Id");
				ipfilters.IpAddress = context.StringValue("GetIpfilterList.Data["+ i +"].IpAddress");
				ipfilters.CreateTime = context.StringValue("GetIpfilterList.Data["+ i +"].CreateTime");

				getIpfilterListResponse_data.Add(ipfilters);
			}
			getIpfilterListResponse.Data = getIpfilterListResponse_data;
        
			return getIpfilterListResponse;
        }
    }
}
