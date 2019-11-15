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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnUserResourcePackageResponseUnmarshaller
    {
        public static DescribeDcdnUserResourcePackageResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDcdnUserResourcePackageResponse describeDcdnUserResourcePackageResponse = new DescribeDcdnUserResourcePackageResponse();

			describeDcdnUserResourcePackageResponse.HttpResponse = context.HttpResponse;
			describeDcdnUserResourcePackageResponse.RequestId = context.StringValue("DescribeDcdnUserResourcePackage.RequestId");

			List<DescribeDcdnUserResourcePackageResponse.DescribeDcdnUserResourcePackage_ResourcePackageInfo> describeDcdnUserResourcePackageResponse_resourcePackageInfos = new List<DescribeDcdnUserResourcePackageResponse.DescribeDcdnUserResourcePackage_ResourcePackageInfo>();
			for (int i = 0; i < context.Length("DescribeDcdnUserResourcePackage.ResourcePackageInfos.Length"); i++) {
				DescribeDcdnUserResourcePackageResponse.DescribeDcdnUserResourcePackage_ResourcePackageInfo resourcePackageInfo = new DescribeDcdnUserResourcePackageResponse.DescribeDcdnUserResourcePackage_ResourcePackageInfo();
				resourcePackageInfo.CurrCapacity = context.StringValue("DescribeDcdnUserResourcePackage.ResourcePackageInfos["+ i +"].CurrCapacity");
				resourcePackageInfo.InitCapacity = context.StringValue("DescribeDcdnUserResourcePackage.ResourcePackageInfos["+ i +"].InitCapacity");
				resourcePackageInfo.CommodityCode = context.StringValue("DescribeDcdnUserResourcePackage.ResourcePackageInfos["+ i +"].CommodityCode");
				resourcePackageInfo.DisplayName = context.StringValue("DescribeDcdnUserResourcePackage.ResourcePackageInfos["+ i +"].DisplayName");
				resourcePackageInfo.TemplateName = context.StringValue("DescribeDcdnUserResourcePackage.ResourcePackageInfos["+ i +"].TemplateName");
				resourcePackageInfo.InstanceId = context.StringValue("DescribeDcdnUserResourcePackage.ResourcePackageInfos["+ i +"].InstanceId");
				resourcePackageInfo.Status = context.StringValue("DescribeDcdnUserResourcePackage.ResourcePackageInfos["+ i +"].Status");
				resourcePackageInfo.StartTime = context.StringValue("DescribeDcdnUserResourcePackage.ResourcePackageInfos["+ i +"].StartTime");
				resourcePackageInfo.EndTime = context.StringValue("DescribeDcdnUserResourcePackage.ResourcePackageInfos["+ i +"].EndTime");

				describeDcdnUserResourcePackageResponse_resourcePackageInfos.Add(resourcePackageInfo);
			}
			describeDcdnUserResourcePackageResponse.ResourcePackageInfos = describeDcdnUserResourcePackageResponse_resourcePackageInfos;
        
			return describeDcdnUserResourcePackageResponse;
        }
    }
}
