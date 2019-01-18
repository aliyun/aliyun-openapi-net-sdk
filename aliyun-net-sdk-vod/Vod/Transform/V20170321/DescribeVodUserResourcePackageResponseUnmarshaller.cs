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
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class DescribeVodUserResourcePackageResponseUnmarshaller
    {
        public static DescribeVodUserResourcePackageResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVodUserResourcePackageResponse describeVodUserResourcePackageResponse = new DescribeVodUserResourcePackageResponse();

			describeVodUserResourcePackageResponse.HttpResponse = context.HttpResponse;
			describeVodUserResourcePackageResponse.RequestId = context.StringValue("DescribeVodUserResourcePackage.RequestId");

			List<DescribeVodUserResourcePackageResponse.DescribeVodUserResourcePackage_ResourcePackageInfo> describeVodUserResourcePackageResponse_resourcePackageInfos = new List<DescribeVodUserResourcePackageResponse.DescribeVodUserResourcePackage_ResourcePackageInfo>();
			for (int i = 0; i < context.Length("DescribeVodUserResourcePackage.ResourcePackageInfos.Length"); i++) {
				DescribeVodUserResourcePackageResponse.DescribeVodUserResourcePackage_ResourcePackageInfo resourcePackageInfo = new DescribeVodUserResourcePackageResponse.DescribeVodUserResourcePackage_ResourcePackageInfo();
				resourcePackageInfo.CurrCapacity = context.StringValue("DescribeVodUserResourcePackage.ResourcePackageInfos["+ i +"].CurrCapacity");
				resourcePackageInfo.InitCapacity = context.StringValue("DescribeVodUserResourcePackage.ResourcePackageInfos["+ i +"].InitCapacity");
				resourcePackageInfo.CommodityCode = context.StringValue("DescribeVodUserResourcePackage.ResourcePackageInfos["+ i +"].CommodityCode");
				resourcePackageInfo.DisplayName = context.StringValue("DescribeVodUserResourcePackage.ResourcePackageInfos["+ i +"].DisplayName");
				resourcePackageInfo.InstanceId = context.StringValue("DescribeVodUserResourcePackage.ResourcePackageInfos["+ i +"].InstanceId");
				resourcePackageInfo.Status = context.StringValue("DescribeVodUserResourcePackage.ResourcePackageInfos["+ i +"].Status");

				describeVodUserResourcePackageResponse_resourcePackageInfos.Add(resourcePackageInfo);
			}
			describeVodUserResourcePackageResponse.ResourcePackageInfos = describeVodUserResourcePackageResponse_resourcePackageInfos;
        
			return describeVodUserResourcePackageResponse;
        }
    }
}