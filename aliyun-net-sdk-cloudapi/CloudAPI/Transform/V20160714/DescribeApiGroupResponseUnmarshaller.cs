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
			describeApiGroupResponse.BillingStatus = context.StringValue("DescribeApiGroup.BillingStatus");
			describeApiGroupResponse.IllegalStatus = context.StringValue("DescribeApiGroup.IllegalStatus");
			describeApiGroupResponse.TrafficLimit = context.IntegerValue("DescribeApiGroup.TrafficLimit");
			describeApiGroupResponse.VpcDomain = context.StringValue("DescribeApiGroup.VpcDomain");
			describeApiGroupResponse.InstanceType = context.StringValue("DescribeApiGroup.InstanceType");
			describeApiGroupResponse.InstanceId = context.StringValue("DescribeApiGroup.InstanceId");
			describeApiGroupResponse.HttpsPolicy = context.StringValue("DescribeApiGroup.HttpsPolicy");
			describeApiGroupResponse.UserLogConfig = context.StringValue("DescribeApiGroup.UserLogConfig");
			describeApiGroupResponse.CustomTraceConfig = context.StringValue("DescribeApiGroup.CustomTraceConfig");
			describeApiGroupResponse.RpcPattern = context.StringValue("DescribeApiGroup.RpcPattern");
			describeApiGroupResponse.CompatibleFlags = context.StringValue("DescribeApiGroup.CompatibleFlags");

			List<DescribeApiGroupResponse.DescribeApiGroup_DomainItem> describeApiGroupResponse_customDomains = new List<DescribeApiGroupResponse.DescribeApiGroup_DomainItem>();
			for (int i = 0; i < context.Length("DescribeApiGroup.CustomDomains.Length"); i++) {
				DescribeApiGroupResponse.DescribeApiGroup_DomainItem domainItem = new DescribeApiGroupResponse.DescribeApiGroup_DomainItem();
				domainItem.DomainName = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].DomainName");
				domainItem.CertificateId = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].CertificateId");
				domainItem.CertificateName = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].CertificateName");
				domainItem.DomainCNAMEStatus = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].DomainCNAMEStatus");
				domainItem.DomainBindingStatus = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].DomainBindingStatus");
				domainItem.BindStageName = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].BindStageName");
				domainItem.DomainLegalStatus = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].DomainLegalStatus");
				domainItem.DomainWebSocketStatus = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].DomainWebSocketStatus");
				domainItem.DomainRemark = context.StringValue("DescribeApiGroup.CustomDomains["+ i +"].DomainRemark");

				describeApiGroupResponse_customDomains.Add(domainItem);
			}
			describeApiGroupResponse.CustomDomains = describeApiGroupResponse_customDomains;

			List<DescribeApiGroupResponse.DescribeApiGroup_StageInfo> describeApiGroupResponse_stageItems = new List<DescribeApiGroupResponse.DescribeApiGroup_StageInfo>();
			for (int i = 0; i < context.Length("DescribeApiGroup.StageItems.Length"); i++) {
				DescribeApiGroupResponse.DescribeApiGroup_StageInfo stageInfo = new DescribeApiGroupResponse.DescribeApiGroup_StageInfo();
				stageInfo.StageId = context.StringValue("DescribeApiGroup.StageItems["+ i +"].StageId");
				stageInfo.StageName = context.StringValue("DescribeApiGroup.StageItems["+ i +"].StageName");
				stageInfo.Description = context.StringValue("DescribeApiGroup.StageItems["+ i +"].Description");

				describeApiGroupResponse_stageItems.Add(stageInfo);
			}
			describeApiGroupResponse.StageItems = describeApiGroupResponse_stageItems;
        
			return describeApiGroupResponse;
        }
    }
}
