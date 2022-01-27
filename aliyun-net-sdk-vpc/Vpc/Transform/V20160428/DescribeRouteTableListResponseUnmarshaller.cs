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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeRouteTableListResponseUnmarshaller
    {
        public static DescribeRouteTableListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRouteTableListResponse describeRouteTableListResponse = new DescribeRouteTableListResponse();

			describeRouteTableListResponse.HttpResponse = _ctx.HttpResponse;
			describeRouteTableListResponse.RequestId = _ctx.StringValue("DescribeRouteTableList.RequestId");
			describeRouteTableListResponse.Code = _ctx.StringValue("DescribeRouteTableList.Code");
			describeRouteTableListResponse.Message = _ctx.StringValue("DescribeRouteTableList.Message");
			describeRouteTableListResponse.Success = _ctx.BooleanValue("DescribeRouteTableList.Success");
			describeRouteTableListResponse.PageSize = _ctx.IntegerValue("DescribeRouteTableList.PageSize");
			describeRouteTableListResponse.PageNumber = _ctx.IntegerValue("DescribeRouteTableList.PageNumber");
			describeRouteTableListResponse.TotalCount = _ctx.IntegerValue("DescribeRouteTableList.TotalCount");

			List<DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType> describeRouteTableListResponse_routerTableList = new List<DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType>();
			for (int i = 0; i < _ctx.Length("DescribeRouteTableList.RouterTableList.Length"); i++) {
				DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType routerTableListType = new DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType();
				routerTableListType.VpcId = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].VpcId");
				routerTableListType.RouterType = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].RouterType");
				routerTableListType.RouterId = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].RouterId");
				routerTableListType.RouteTableId = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].RouteTableId");
				routerTableListType.RouteTableName = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].RouteTableName");
				routerTableListType.RouteTableType = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].RouteTableType");
				routerTableListType.Description = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].Description");
				routerTableListType.ResourceGroupId = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].ResourceGroupId");
				routerTableListType.CreationTime = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].CreationTime");
				routerTableListType.Status = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].Status");
				routerTableListType.OwnerId = _ctx.LongValue("DescribeRouteTableList.RouterTableList["+ i +"].OwnerId");

				List<string> routerTableListType_vSwitchIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeRouteTableList.RouterTableList["+ i +"].VSwitchIds.Length"); j++) {
					routerTableListType_vSwitchIds.Add(_ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].VSwitchIds["+ j +"]"));
				}
				routerTableListType.VSwitchIds = routerTableListType_vSwitchIds;

				List<DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType.DescribeRouteTableList_Tag> routerTableListType_tags = new List<DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType.DescribeRouteTableList_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeRouteTableList.RouterTableList["+ i +"].Tags.Length"); j++) {
					DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType.DescribeRouteTableList_Tag tag = new DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType.DescribeRouteTableList_Tag();
					tag.Key = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].Tags["+ j +"].Value");

					routerTableListType_tags.Add(tag);
				}
				routerTableListType.Tags = routerTableListType_tags;

				describeRouteTableListResponse_routerTableList.Add(routerTableListType);
			}
			describeRouteTableListResponse.RouterTableList = describeRouteTableListResponse_routerTableList;
        
			return describeRouteTableListResponse;
        }
    }
}
