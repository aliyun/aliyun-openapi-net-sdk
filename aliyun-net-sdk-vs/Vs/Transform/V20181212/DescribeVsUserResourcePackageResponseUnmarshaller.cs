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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsUserResourcePackageResponseUnmarshaller
    {
        public static DescribeVsUserResourcePackageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsUserResourcePackageResponse describeVsUserResourcePackageResponse = new DescribeVsUserResourcePackageResponse();

			describeVsUserResourcePackageResponse.HttpResponse = _ctx.HttpResponse;
			describeVsUserResourcePackageResponse.RequestId = _ctx.StringValue("DescribeVsUserResourcePackage.RequestId");

			List<DescribeVsUserResourcePackageResponse.DescribeVsUserResourcePackage_ResourcePackageInfo> describeVsUserResourcePackageResponse_resourcePackageInfos = new List<DescribeVsUserResourcePackageResponse.DescribeVsUserResourcePackage_ResourcePackageInfo>();
			for (int i = 0; i < _ctx.Length("DescribeVsUserResourcePackage.ResourcePackageInfos.Length"); i++) {
				DescribeVsUserResourcePackageResponse.DescribeVsUserResourcePackage_ResourcePackageInfo resourcePackageInfo = new DescribeVsUserResourcePackageResponse.DescribeVsUserResourcePackage_ResourcePackageInfo();
				resourcePackageInfo.CurrCapacity = _ctx.StringValue("DescribeVsUserResourcePackage.ResourcePackageInfos["+ i +"].CurrCapacity");
				resourcePackageInfo.InitCapacity = _ctx.StringValue("DescribeVsUserResourcePackage.ResourcePackageInfos["+ i +"].InitCapacity");
				resourcePackageInfo.CommodityCode = _ctx.StringValue("DescribeVsUserResourcePackage.ResourcePackageInfos["+ i +"].CommodityCode");
				resourcePackageInfo.DisplayName = _ctx.StringValue("DescribeVsUserResourcePackage.ResourcePackageInfos["+ i +"].DisplayName");
				resourcePackageInfo.InstanceId = _ctx.StringValue("DescribeVsUserResourcePackage.ResourcePackageInfos["+ i +"].InstanceId");
				resourcePackageInfo.Status = _ctx.StringValue("DescribeVsUserResourcePackage.ResourcePackageInfos["+ i +"].Status");

				describeVsUserResourcePackageResponse_resourcePackageInfos.Add(resourcePackageInfo);
			}
			describeVsUserResourcePackageResponse.ResourcePackageInfos = describeVsUserResourcePackageResponse_resourcePackageInfos;
        
			return describeVsUserResourcePackageResponse;
        }
    }
}
