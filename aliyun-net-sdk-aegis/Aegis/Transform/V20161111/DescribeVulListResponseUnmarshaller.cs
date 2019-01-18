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
using Aliyun.Acs.aegis.Model.V20161111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeVulListResponseUnmarshaller
    {
        public static DescribeVulListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVulListResponse describeVulListResponse = new DescribeVulListResponse();

			describeVulListResponse.HttpResponse = context.HttpResponse;
			describeVulListResponse.RequestId = context.StringValue("DescribeVulList.RequestId");
			describeVulListResponse.Count = context.IntegerValue("DescribeVulList.Count");
			describeVulListResponse.PageSize = context.IntegerValue("DescribeVulList.PageSize");
			describeVulListResponse.CurrentPage = context.IntegerValue("DescribeVulList.CurrentPage");
			describeVulListResponse.TotalCount = context.IntegerValue("DescribeVulList.TotalCount");

			List<string> describeVulListResponse_vulRecords = new List<string>();
			for (int i = 0; i < context.Length("DescribeVulList.VulRecords.Length"); i++) {
				describeVulListResponse_vulRecords.Add(context.StringValue("DescribeVulList.VulRecords["+ i +"]"));
			}
			describeVulListResponse.VulRecords = describeVulListResponse_vulRecords;
        
			return describeVulListResponse;
        }
    }
}