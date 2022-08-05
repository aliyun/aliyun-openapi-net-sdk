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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class QueryContainerListResponseUnmarshaller
    {
        public static QueryContainerListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryContainerListResponse queryContainerListResponse = new QueryContainerListResponse();

			queryContainerListResponse.HttpResponse = _ctx.HttpResponse;
			queryContainerListResponse.RequestId = _ctx.StringValue("QueryContainerList.RequestId");
			queryContainerListResponse.Success = _ctx.BooleanValue("QueryContainerList.Success");
			queryContainerListResponse.Message = _ctx.StringValue("QueryContainerList.Message");
			queryContainerListResponse.ErrorCode = _ctx.StringValue("QueryContainerList.ErrorCode");
			queryContainerListResponse.ErrorMessage = _ctx.StringValue("QueryContainerList.ErrorMessage");
			queryContainerListResponse.Code = _ctx.StringValue("QueryContainerList.Code");
			queryContainerListResponse.DynamicCode = _ctx.StringValue("QueryContainerList.DynamicCode");
			queryContainerListResponse.DynamicMessage = _ctx.StringValue("QueryContainerList.DynamicMessage");
			queryContainerListResponse.PageSize = _ctx.IntegerValue("QueryContainerList.PageSize");
			queryContainerListResponse.PageNumber = _ctx.IntegerValue("QueryContainerList.PageNumber");
			queryContainerListResponse.TotalCount = _ctx.IntegerValue("QueryContainerList.TotalCount");

			List<QueryContainerListResponse.QueryContainerList_Container> queryContainerListResponse_containerList = new List<QueryContainerListResponse.QueryContainerList_Container>();
			for (int i = 0; i < _ctx.Length("QueryContainerList.ContainerList.Length"); i++) {
				QueryContainerListResponse.QueryContainerList_Container container = new QueryContainerListResponse.QueryContainerList_Container();
				container.ContainerId = _ctx.StringValue("QueryContainerList.ContainerList["+ i +"].ContainerId");
				container.ContainerName = _ctx.StringValue("QueryContainerList.ContainerList["+ i +"].ContainerName");
				container.Description = _ctx.StringValue("QueryContainerList.ContainerList["+ i +"].Description");
				container.TopPx = _ctx.IntegerValue("QueryContainerList.ContainerList["+ i +"].TopPx");
				container.LeftPx = _ctx.IntegerValue("QueryContainerList.ContainerList["+ i +"].LeftPx");
				container.WidthPx = _ctx.IntegerValue("QueryContainerList.ContainerList["+ i +"].WidthPx");
				container.HeightPx = _ctx.IntegerValue("QueryContainerList.ContainerList["+ i +"].HeightPx");
				container.GroupId = _ctx.StringValue("QueryContainerList.ContainerList["+ i +"].GroupId");
				container.GroupName = _ctx.StringValue("QueryContainerList.ContainerList["+ i +"].GroupName");
				container.DemoTemplateId = _ctx.StringValue("QueryContainerList.ContainerList["+ i +"].DemoTemplateId");
				container.DemoTemplateName = _ctx.StringValue("QueryContainerList.ContainerList["+ i +"].DemoTemplateName");

				queryContainerListResponse_containerList.Add(container);
			}
			queryContainerListResponse.ContainerList = queryContainerListResponse_containerList;
        
			return queryContainerListResponse;
        }
    }
}
