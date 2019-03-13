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
    public class DescribeEcsListPageResponseUnmarshaller
    {
        public static DescribeEcsListPageResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEcsListPageResponse describeEcsListPageResponse = new DescribeEcsListPageResponse();

			describeEcsListPageResponse.HttpResponse = context.HttpResponse;
			describeEcsListPageResponse.RequestId = context.StringValue("DescribeEcsListPage.RequestId");
			describeEcsListPageResponse.Module = context.StringValue("DescribeEcsListPage.Module");

			DescribeEcsListPageResponse.DescribeEcsListPage_PageInfo pageInfo = new DescribeEcsListPageResponse.DescribeEcsListPage_PageInfo();
			pageInfo.Total = context.IntegerValue("DescribeEcsListPage.PageInfo.Total");
			pageInfo.PageSize = context.IntegerValue("DescribeEcsListPage.PageInfo.PageSize");
			pageInfo.CurrentPage = context.IntegerValue("DescribeEcsListPage.PageInfo.CurrentPage");
			describeEcsListPageResponse.PageInfo = pageInfo;

			List<DescribeEcsListPageResponse.DescribeEcsListPage_Data> describeEcsListPageResponse_dataList = new List<DescribeEcsListPageResponse.DescribeEcsListPage_Data>();
			for (int i = 0; i < context.Length("DescribeEcsListPage.DataList.Length"); i++) {
				DescribeEcsListPageResponse.DescribeEcsListPage_Data data = new DescribeEcsListPageResponse.DescribeEcsListPage_Data();
				data.InstanceId = context.StringValue("DescribeEcsListPage.DataList["+ i +"].InstanceId");
				data.InstanceName = context.StringValue("DescribeEcsListPage.DataList["+ i +"].InstanceName");
				data.IP = context.StringValue("DescribeEcsListPage.DataList["+ i +"].IP");
				data.Region = context.StringValue("DescribeEcsListPage.DataList["+ i +"].Region");
				data.ItemSign = context.StringValue("DescribeEcsListPage.DataList["+ i +"].ItemSign");

				describeEcsListPageResponse_dataList.Add(data);
			}
			describeEcsListPageResponse.DataList = describeEcsListPageResponse_dataList;
        
			return describeEcsListPageResponse;
        }
    }
}
