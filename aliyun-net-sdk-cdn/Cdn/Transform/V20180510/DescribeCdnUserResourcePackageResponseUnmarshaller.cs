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
using Aliyun.Acs.Cdn.Model.V20180510;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnUserResourcePackageResponseUnmarshaller
    {
        public static DescribeCdnUserResourcePackageResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCdnUserResourcePackageResponse describeCdnUserResourcePackageResponse = new DescribeCdnUserResourcePackageResponse();

			describeCdnUserResourcePackageResponse.HttpResponse = context.HttpResponse;
			describeCdnUserResourcePackageResponse.RequestId = context.StringValue("DescribeCdnUserResourcePackage.RequestId");

			List<DescribeCdnUserResourcePackageResponse.DescribeCdnUserResourcePackage_ResourcePackageInfo> describeCdnUserResourcePackageResponse_resourcePackageInfos = new List<DescribeCdnUserResourcePackageResponse.DescribeCdnUserResourcePackage_ResourcePackageInfo>();
			for (int i = 0; i < context.Length("DescribeCdnUserResourcePackage.ResourcePackageInfos.Length"); i++) {
				DescribeCdnUserResourcePackageResponse.DescribeCdnUserResourcePackage_ResourcePackageInfo resourcePackageInfo = new DescribeCdnUserResourcePackageResponse.DescribeCdnUserResourcePackage_ResourcePackageInfo();
				resourcePackageInfo.CurrCapacity = context.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].CurrCapacity");
				resourcePackageInfo.InitCapacity = context.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].InitCapacity");
				resourcePackageInfo.CommodityCode = context.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].CommodityCode");
				resourcePackageInfo.DisplayName = context.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].DisplayName");
				resourcePackageInfo.InstanceId = context.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].InstanceId");
				resourcePackageInfo.Status = context.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].Status");
				resourcePackageInfo.StartTime = context.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].StartTime");
				resourcePackageInfo.EndTime = context.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].EndTime");

				describeCdnUserResourcePackageResponse_resourcePackageInfos.Add(resourcePackageInfo);
			}
			describeCdnUserResourcePackageResponse.ResourcePackageInfos = describeCdnUserResourcePackageResponse_resourcePackageInfos;
        
			return describeCdnUserResourcePackageResponse;
        }
    }
}