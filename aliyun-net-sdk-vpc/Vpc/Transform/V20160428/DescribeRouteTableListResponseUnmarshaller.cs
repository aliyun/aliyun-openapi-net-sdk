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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeRouteTableListResponseUnmarshaller
    {
        public static DescribeRouteTableListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRouteTableListResponse describeRouteTableListResponse = new DescribeRouteTableListResponse();

			describeRouteTableListResponse.HttpResponse = context.HttpResponse;
			describeRouteTableListResponse.RequestId = context.StringValue("DescribeRouteTableList.RequestId");
			describeRouteTableListResponse.Code = context.StringValue("DescribeRouteTableList.Code");
			describeRouteTableListResponse.Message = context.StringValue("DescribeRouteTableList.Message");
			describeRouteTableListResponse.Success = context.BooleanValue("DescribeRouteTableList.Success");
			describeRouteTableListResponse.PageSize = context.IntegerValue("DescribeRouteTableList.PageSize");
			describeRouteTableListResponse.PageNumber = context.IntegerValue("DescribeRouteTableList.PageNumber");
			describeRouteTableListResponse.TotalCount = context.IntegerValue("DescribeRouteTableList.TotalCount");

			List<DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType> describeRouteTableListResponse_routerTableList = new List<DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType>();
			for (int i = 0; i < context.Length("DescribeRouteTableList.RouterTableList.Length"); i++) {
				DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType routerTableListType = new DescribeRouteTableListResponse.DescribeRouteTableList_RouterTableListType();
				routerTableListType.VpcId = context.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].VpcId");
				routerTableListType.RouterType = context.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].RouterType");
				routerTableListType.RouterId = context.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].RouterId");
				routerTableListType.RouteTableId = context.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].RouteTableId");
				routerTableListType.RouteTableName = context.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].RouteTableName");
				routerTableListType.RouteTableType = context.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].RouteTableType");
				routerTableListType.Description = context.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].Description");
				routerTableListType.CreationTime = context.StringValue("DescribeRouteTableList.RouterTableList["+ i +"].CreationTime");

				describeRouteTableListResponse_routerTableList.Add(routerTableListType);
			}
			describeRouteTableListResponse.RouterTableList = describeRouteTableListResponse_routerTableList;
        
			return describeRouteTableListResponse;
        }
    }
}