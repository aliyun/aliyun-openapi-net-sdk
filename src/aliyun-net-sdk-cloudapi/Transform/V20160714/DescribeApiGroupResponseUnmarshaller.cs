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
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeApiGroupResponseUnmarshaller
    {
        public static DescribeApiGroupResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeApiGroupResponse describeApiGroupResponse = new DescribeApiGroupResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeApiGroup.RequestId"),
                GroupId = context.StringValue("DescribeApiGroup.GroupId"),
                GroupName = context.StringValue("DescribeApiGroup.GroupName"),
                SubDomain = context.StringValue("DescribeApiGroup.SubDomain"),
                Description = context.StringValue("DescribeApiGroup.Description"),
                CreatedTime = context.StringValue("DescribeApiGroup.CreatedTime"),
                ModifiedTime = context.StringValue("DescribeApiGroup.ModifiedTime"),
                RegionId = context.StringValue("DescribeApiGroup.RegionId"),
                Status = context.StringValue("DescribeApiGroup.Status"),
                BillingStatus = context.EnumValue<DescribeApiGroupResponse.BillingStatusEnum>("DescribeApiGroup.BillingStatus"),
                IllegalStatus = context.EnumValue<DescribeApiGroupResponse.IllegalStatusEnum>("DescribeApiGroup.IllegalStatus"),
                TrafficLimit = context.IntegerValue("DescribeApiGroup.TrafficLimit")
            };
            List<DescribeApiGroupResponse.DomainItem> customDomains = new List<DescribeApiGroupResponse.DomainItem>();
			for (int i = 0; i < context.Length("DescribeApiGroup.CustomDomains.Length"); i++) {
                DescribeApiGroupResponse.DomainItem domainItem = new DescribeApiGroupResponse.DomainItem()
                {
                    DomainName = context.StringValue($"DescribeApiGroup.CustomDomains[{i}].DomainName"),
                    CertificateId = context.StringValue($"DescribeApiGroup.CustomDomains[{i}].CertificateId"),
                    CertificateName = context.StringValue($"DescribeApiGroup.CustomDomains[{i}].CertificateName"),
                    DomainCnameStatus = context.StringValue($"DescribeApiGroup.CustomDomains[{i}].DomainCNAMEStatus"),
                    DomainBindingStatus = context.StringValue($"DescribeApiGroup.CustomDomains[{i}].DomainBindingStatus")
                };
                customDomains.Add(domainItem);
			}
			describeApiGroupResponse.CustomDomains = customDomains;
        
			return describeApiGroupResponse;
        }
    }
}