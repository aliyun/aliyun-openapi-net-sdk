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
using Aliyun.Acs.CloudAPI.Model.V20160714;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeApiIpControlsResponseUnmarshaller
    {
        public static DescribeApiIpControlsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiIpControlsResponse describeApiIpControlsResponse = new DescribeApiIpControlsResponse();

			describeApiIpControlsResponse.HttpResponse = context.HttpResponse;
			describeApiIpControlsResponse.RequestId = context.StringValue("DescribeApiIpControls.RequestId");
			describeApiIpControlsResponse.TotalCount = context.IntegerValue("DescribeApiIpControls.TotalCount");
			describeApiIpControlsResponse.PageSize = context.IntegerValue("DescribeApiIpControls.PageSize");
			describeApiIpControlsResponse.PageNumber = context.IntegerValue("DescribeApiIpControls.PageNumber");

			List<DescribeApiIpControlsResponse.DescribeApiIpControls_ApiIpControlItem> describeApiIpControlsResponse_apiIpControls = new List<DescribeApiIpControlsResponse.DescribeApiIpControls_ApiIpControlItem>();
			for (int i = 0; i < context.Length("DescribeApiIpControls.ApiIpControls.Length"); i++) {
				DescribeApiIpControlsResponse.DescribeApiIpControls_ApiIpControlItem apiIpControlItem = new DescribeApiIpControlsResponse.DescribeApiIpControls_ApiIpControlItem();
				apiIpControlItem.ApiId = context.StringValue("DescribeApiIpControls.ApiIpControls["+ i +"].ApiId");
				apiIpControlItem.ApiName = context.StringValue("DescribeApiIpControls.ApiIpControls["+ i +"].ApiName");
				apiIpControlItem.IpControlId = context.StringValue("DescribeApiIpControls.ApiIpControls["+ i +"].IpControlId");
				apiIpControlItem.IpControlName = context.StringValue("DescribeApiIpControls.ApiIpControls["+ i +"].IpControlName");
				apiIpControlItem.BoundTime = context.StringValue("DescribeApiIpControls.ApiIpControls["+ i +"].BoundTime");

				describeApiIpControlsResponse_apiIpControls.Add(apiIpControlItem);
			}
			describeApiIpControlsResponse.ApiIpControls = describeApiIpControlsResponse_apiIpControls;
        
			return describeApiIpControlsResponse;
        }
    }
}
