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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeIpControlsResponseUnmarshaller
    {
        public static DescribeIpControlsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIpControlsResponse describeIpControlsResponse = new DescribeIpControlsResponse();

			describeIpControlsResponse.HttpResponse = context.HttpResponse;
			describeIpControlsResponse.RequestId = context.StringValue("DescribeIpControls.RequestId");
			describeIpControlsResponse.TotalCount = context.IntegerValue("DescribeIpControls.TotalCount");
			describeIpControlsResponse.PageSize = context.IntegerValue("DescribeIpControls.PageSize");
			describeIpControlsResponse.PageNumber = context.IntegerValue("DescribeIpControls.PageNumber");

			List<DescribeIpControlsResponse.DescribeIpControls_IpControlInfo> describeIpControlsResponse_ipControlInfos = new List<DescribeIpControlsResponse.DescribeIpControls_IpControlInfo>();
			for (int i = 0; i < context.Length("DescribeIpControls.IpControlInfos.Length"); i++) {
				DescribeIpControlsResponse.DescribeIpControls_IpControlInfo ipControlInfo = new DescribeIpControlsResponse.DescribeIpControls_IpControlInfo();
				ipControlInfo.IpControlId = context.StringValue("DescribeIpControls.IpControlInfos["+ i +"].IpControlId");
				ipControlInfo.IpControlName = context.StringValue("DescribeIpControls.IpControlInfos["+ i +"].IpControlName");
				ipControlInfo.IpControlType = context.StringValue("DescribeIpControls.IpControlInfos["+ i +"].IpControlType");
				ipControlInfo.Description = context.StringValue("DescribeIpControls.IpControlInfos["+ i +"].Description");
				ipControlInfo.CreateTime = context.StringValue("DescribeIpControls.IpControlInfos["+ i +"].CreateTime");
				ipControlInfo.ModifiedTime = context.StringValue("DescribeIpControls.IpControlInfos["+ i +"].ModifiedTime");
				ipControlInfo.RegionId = context.StringValue("DescribeIpControls.IpControlInfos["+ i +"].RegionId");

				describeIpControlsResponse_ipControlInfos.Add(ipControlInfo);
			}
			describeIpControlsResponse.IpControlInfos = describeIpControlsResponse_ipControlInfos;
        
			return describeIpControlsResponse;
        }
    }
}