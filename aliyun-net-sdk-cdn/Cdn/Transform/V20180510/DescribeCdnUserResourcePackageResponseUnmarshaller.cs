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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnUserResourcePackageResponseUnmarshaller
    {
        public static DescribeCdnUserResourcePackageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnUserResourcePackageResponse describeCdnUserResourcePackageResponse = new DescribeCdnUserResourcePackageResponse();

			describeCdnUserResourcePackageResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnUserResourcePackageResponse.RequestId = _ctx.StringValue("DescribeCdnUserResourcePackage.RequestId");

			List<DescribeCdnUserResourcePackageResponse.DescribeCdnUserResourcePackage_ResourcePackageInfo> describeCdnUserResourcePackageResponse_resourcePackageInfos = new List<DescribeCdnUserResourcePackageResponse.DescribeCdnUserResourcePackage_ResourcePackageInfo>();
			for (int i = 0; i < _ctx.Length("DescribeCdnUserResourcePackage.ResourcePackageInfos.Length"); i++) {
				DescribeCdnUserResourcePackageResponse.DescribeCdnUserResourcePackage_ResourcePackageInfo resourcePackageInfo = new DescribeCdnUserResourcePackageResponse.DescribeCdnUserResourcePackage_ResourcePackageInfo();
				resourcePackageInfo.CurrCapacity = _ctx.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].CurrCapacity");
				resourcePackageInfo.InitCapacity = _ctx.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].InitCapacity");
				resourcePackageInfo.CommodityCode = _ctx.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].CommodityCode");
				resourcePackageInfo.DisplayName = _ctx.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].DisplayName");
				resourcePackageInfo.TemplateName = _ctx.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].TemplateName");
				resourcePackageInfo.InstanceId = _ctx.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].InstanceId");
				resourcePackageInfo.Status = _ctx.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].Status");
				resourcePackageInfo.StartTime = _ctx.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].StartTime");
				resourcePackageInfo.EndTime = _ctx.StringValue("DescribeCdnUserResourcePackage.ResourcePackageInfos["+ i +"].EndTime");

				describeCdnUserResourcePackageResponse_resourcePackageInfos.Add(resourcePackageInfo);
			}
			describeCdnUserResourcePackageResponse.ResourcePackageInfos = describeCdnUserResourcePackageResponse_resourcePackageInfos;
        
			return describeCdnUserResourcePackageResponse;
        }
    }
}
