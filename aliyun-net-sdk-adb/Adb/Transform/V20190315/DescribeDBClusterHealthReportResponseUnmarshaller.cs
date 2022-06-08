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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeDBClusterHealthReportResponseUnmarshaller
    {
        public static DescribeDBClusterHealthReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterHealthReportResponse describeDBClusterHealthReportResponse = new DescribeDBClusterHealthReportResponse();

			describeDBClusterHealthReportResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterHealthReportResponse.RequestId = _ctx.StringValue("DescribeDBClusterHealthReport.RequestId");

			List<DescribeDBClusterHealthReportResponse.DescribeDBClusterHealthReport_ItemsItem> describeDBClusterHealthReportResponse_items = new List<DescribeDBClusterHealthReportResponse.DescribeDBClusterHealthReport_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterHealthReport.Items.Length"); i++) {
				DescribeDBClusterHealthReportResponse.DescribeDBClusterHealthReport_ItemsItem itemsItem = new DescribeDBClusterHealthReportResponse.DescribeDBClusterHealthReport_ItemsItem();
				itemsItem.Key = _ctx.StringValue("DescribeDBClusterHealthReport.Items["+ i +"].Key");
				itemsItem.Max = _ctx.StringValue("DescribeDBClusterHealthReport.Items["+ i +"].Max");
				itemsItem.Name = _ctx.StringValue("DescribeDBClusterHealthReport.Items["+ i +"].Name");
				itemsItem.Avg = _ctx.StringValue("DescribeDBClusterHealthReport.Items["+ i +"].Avg");

				describeDBClusterHealthReportResponse_items.Add(itemsItem);
			}
			describeDBClusterHealthReportResponse.Items = describeDBClusterHealthReportResponse_items;
        
			return describeDBClusterHealthReportResponse;
        }
    }
}
