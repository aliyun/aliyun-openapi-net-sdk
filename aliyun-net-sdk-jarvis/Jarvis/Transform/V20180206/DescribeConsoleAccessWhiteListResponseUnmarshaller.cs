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
using Aliyun.Acs.jarvis.Model.V20180206;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribeConsoleAccessWhiteListResponseUnmarshaller
    {
        public static DescribeConsoleAccessWhiteListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConsoleAccessWhiteListResponse describeConsoleAccessWhiteListResponse = new DescribeConsoleAccessWhiteListResponse();

			describeConsoleAccessWhiteListResponse.HttpResponse = context.HttpResponse;
			describeConsoleAccessWhiteListResponse.RequestId = context.StringValue("DescribeConsoleAccessWhiteList.RequestId");
			describeConsoleAccessWhiteListResponse.Module = context.StringValue("DescribeConsoleAccessWhiteList.Module");

			DescribeConsoleAccessWhiteListResponse.DescribeConsoleAccessWhiteList_PageInfo pageInfo = new DescribeConsoleAccessWhiteListResponse.DescribeConsoleAccessWhiteList_PageInfo();
			pageInfo.Total = context.IntegerValue("DescribeConsoleAccessWhiteList.PageInfo.Total");
			pageInfo.PageSize = context.IntegerValue("DescribeConsoleAccessWhiteList.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeConsoleAccessWhiteList.PageInfo.CurrentPage");
			describeConsoleAccessWhiteListResponse.PageInfo = pageInfo;

			List<DescribeConsoleAccessWhiteListResponse.DescribeConsoleAccessWhiteList_Data> describeConsoleAccessWhiteListResponse_dataList = new List<DescribeConsoleAccessWhiteListResponse.DescribeConsoleAccessWhiteList_Data>();
			for (int i = 0; i < context.Length("DescribeConsoleAccessWhiteList.DataList.Length"); i++) {
				DescribeConsoleAccessWhiteListResponse.DescribeConsoleAccessWhiteList_Data data = new DescribeConsoleAccessWhiteListResponse.DescribeConsoleAccessWhiteList_Data();
				data.Id = context.IntegerValue("DescribeConsoleAccessWhiteList.DataList["+ i +"].Id");
				data.SrcIp = context.StringValue("DescribeConsoleAccessWhiteList.DataList["+ i +"].SrcIp");
				data.DstIp = context.StringValue("DescribeConsoleAccessWhiteList.DataList["+ i +"].DstIp");
				data.InsProduct = context.StringValue("DescribeConsoleAccessWhiteList.DataList["+ i +"].InsProduct");
				data.RegionId = context.StringValue("DescribeConsoleAccessWhiteList.DataList["+ i +"].RegionId");
				data.Status = context.StringValue("DescribeConsoleAccessWhiteList.DataList["+ i +"].Status");
				data.GmtCreate = context.StringValue("DescribeConsoleAccessWhiteList.DataList["+ i +"].GmtCreate");
				data.GmtRealExpire = context.StringValue("DescribeConsoleAccessWhiteList.DataList["+ i +"].GmtRealExpire");

				describeConsoleAccessWhiteListResponse_dataList.Add(data);
			}
			describeConsoleAccessWhiteListResponse.DataList = describeConsoleAccessWhiteListResponse_dataList;
        
			return describeConsoleAccessWhiteListResponse;
        }
    }
}
