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
    public class DescribeApiGroupResponseUnmarshaller
    {
        public static DescribeApiGroupResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiGroupResponse describeApiGroupResponse = new DescribeApiGroupResponse();

			describeApiGroupResponse.HttpResponse = context.HttpResponse;
			describeApiGroupResponse.RequestId = context.StringValue("DescribeApiGroup.RequestId");
			describeApiGroupResponse.GroupId = context.StringValue("DescribeApiGroup.GroupId");
			describeApiGroupResponse.GroupName = context.StringValue("DescribeApiGroup.GroupName");
			describeApiGroupResponse.SubDomain = context.StringValue("DescribeApiGroup.SubDomain");
			describeApiGroupResponse.Description = context.StringValue("DescribeApiGroup.Description");
			describeApiGroupResponse.CreatedTime = context.StringValue("DescribeApiGroup.CreatedTime");
			describeApiGroupResponse.ModifiedTime = context.StringValue("DescribeApiGroup.ModifiedTime");
			describeApiGroupResponse.RegionId = context.StringValue("DescribeApiGroup.RegionId");
			describeApiGroupResponse.Status = context.StringValue("DescribeApiGroup.Status");
			describeApiGroupResponse.BillingStatus = context.EnumValue<DescribeApiGroupResponse.BillingStatusEnum>("DescribeApiGroup.BillingStatus");
			describeApiGroupResponse.IllegalStatus = context.EnumValue<DescribeApiGroupResponse.IllegalStatusEnum>("DescribeApiGroup.IllegalStatus");
			describeApiGroupResponse.TrafficLimit = context.IntegerValue("DescribeApiGroup.TrafficLimit");

			List<DescribeApiGroupResponse.DomainItem> customDomains = new List<DescribeApiGroupResponse.DomainItem>();
			for (int i = 0; i < context.Length("DescribeApiGroup.CustomDomains.Length"); i++) {
				DescribeApiGroupResponse.DomainItem domainItem = new DescribeApiGroupResponse.DomainItem();
				domainItem.DomainName = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].DomainName");
				domainItem.CertificateId = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].CertificateId");
				domainItem.CertificateName = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].CertificateName");
				domainItem.DomainCNAMEStatus = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].DomainCNAMEStatus");
				domainItem.DomainBindingStatus = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].DomainBindingStatus");
				domainItem.DomainLegalStatus = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].DomainLegalStatus");
				domainItem.DomainRemark = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].DomainRemark");

				customDomains.Add(domainItem);
			}
			describeApiGroupResponse.CustomDomains = customDomains;

			List<DescribeApiGroupResponse.StageInfo> stageItems = new List<DescribeApiGroupResponse.StageInfo>();
			for (int i = 0; i < context.Length("DescribeApiGroup.StageItems.Length"); i++) {
				DescribeApiGroupResponse.StageInfo stageInfo = new DescribeApiGroupResponse.StageInfo();
				stageInfo.StageId = context.StringValue("DescribeApiGroup.StageItems["+ i +"].StageId");
				stageInfo.StageName = context.StringValue("DescribeApiGroup.StageItems["+ i +"].StageName");
				stageInfo.Description = context.StringValue("DescribeApiGroup.StageItems["+ i +"].Description");

				stageItems.Add(stageInfo);
			}
			describeApiGroupResponse.StageItems = stageItems;
        
			return describeApiGroupResponse;
        }
    }
}