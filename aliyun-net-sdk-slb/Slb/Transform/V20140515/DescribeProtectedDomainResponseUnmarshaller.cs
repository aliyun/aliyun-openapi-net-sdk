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
using Aliyun.Acs.Slb.Model.V20140515;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeProtectedDomainResponseUnmarshaller
    {
        public static DescribeProtectedDomainResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeProtectedDomainResponse describeProtectedDomainResponse = new DescribeProtectedDomainResponse();

			describeProtectedDomainResponse.HttpResponse = context.HttpResponse;
			describeProtectedDomainResponse.RequestId = context.StringValue("DescribeProtectedDomain.RequestId");
			describeProtectedDomainResponse.DomainName = context.StringValue("DescribeProtectedDomain.DomainName");
			describeProtectedDomainResponse.CcStatus = context.StringValue("DescribeProtectedDomain.CcStatus");
			describeProtectedDomainResponse.WafStatus = context.StringValue("DescribeProtectedDomain.WafStatus");
			describeProtectedDomainResponse.WafPolicyLevel = context.StringValue("DescribeProtectedDomain.WafPolicyLevel");

			List<DescribeProtectedDomainResponse.IpItems> ccBlackList = new List<DescribeProtectedDomainResponse.IpItems>();
			for (int i = 0; i < context.Length("DescribeProtectedDomain.CcBlackList.Length"); i++) {
				DescribeProtectedDomainResponse.IpItems ipItems = new DescribeProtectedDomainResponse.IpItems();
				ipItems.IpItem = context.StringValue("DescribeProtectedDomain.CcBlackList["+ i +"].IpItem");

				ccBlackList.Add(ipItems);
			}
			describeProtectedDomainResponse.CcBlackList = ccBlackList;

			List<DescribeProtectedDomainResponse.IpItems> ccWhiteList = new List<DescribeProtectedDomainResponse.IpItems>();
			for (int i = 0; i < context.Length("DescribeProtectedDomain.CcWhiteList.Length"); i++) {
				DescribeProtectedDomainResponse.IpItems ipItems = new DescribeProtectedDomainResponse.IpItems();
				ipItems.IpItem = context.StringValue("DescribeProtectedDomain.CcWhiteList["+ i +"].IpItem");

				ccWhiteList.Add(ipItems);
			}
			describeProtectedDomainResponse.CcWhiteList = ccWhiteList;

			List<DescribeProtectedDomainResponse.IpItems> wafBlackList = new List<DescribeProtectedDomainResponse.IpItems>();
			for (int i = 0; i < context.Length("DescribeProtectedDomain.WafBlackList.Length"); i++) {
				DescribeProtectedDomainResponse.IpItems ipItems = new DescribeProtectedDomainResponse.IpItems();
				ipItems.IpItem = context.StringValue("DescribeProtectedDomain.WafBlackList["+ i +"].IpItem");

				wafBlackList.Add(ipItems);
			}
			describeProtectedDomainResponse.WafBlackList = wafBlackList;

			List<DescribeProtectedDomainResponse.IpItems> wafWhiteList = new List<DescribeProtectedDomainResponse.IpItems>();
			for (int i = 0; i < context.Length("DescribeProtectedDomain.WafWhiteList.Length"); i++) {
				DescribeProtectedDomainResponse.IpItems ipItems = new DescribeProtectedDomainResponse.IpItems();
				ipItems.IpItem = context.StringValue("DescribeProtectedDomain.WafWhiteList["+ i +"].IpItem");

				wafWhiteList.Add(ipItems);
			}
			describeProtectedDomainResponse.WafWhiteList = wafWhiteList;
        
			return describeProtectedDomainResponse;
        }
    }
}