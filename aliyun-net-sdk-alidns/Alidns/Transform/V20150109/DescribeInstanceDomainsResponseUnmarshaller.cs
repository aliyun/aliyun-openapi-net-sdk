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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeInstanceDomainsResponseUnmarshaller
    {
        public static DescribeInstanceDomainsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceDomainsResponse describeInstanceDomainsResponse = new DescribeInstanceDomainsResponse();

			describeInstanceDomainsResponse.HttpResponse = context.HttpResponse;
			describeInstanceDomainsResponse.RequestId = context.StringValue("DescribeInstanceDomains.RequestId");
			describeInstanceDomainsResponse.TotalItems = context.IntegerValue("DescribeInstanceDomains.TotalItems");
			describeInstanceDomainsResponse.PageNumber = context.IntegerValue("DescribeInstanceDomains.PageNumber");
			describeInstanceDomainsResponse.PageSize = context.IntegerValue("DescribeInstanceDomains.PageSize");
			describeInstanceDomainsResponse.TotalPages = context.IntegerValue("DescribeInstanceDomains.TotalPages");

			List<DescribeInstanceDomainsResponse.DescribeInstanceDomains_InstanceDomain> describeInstanceDomainsResponse_instanceDomains = new List<DescribeInstanceDomainsResponse.DescribeInstanceDomains_InstanceDomain>();
			for (int i = 0; i < context.Length("DescribeInstanceDomains.InstanceDomains.Length"); i++) {
				DescribeInstanceDomainsResponse.DescribeInstanceDomains_InstanceDomain instanceDomain = new DescribeInstanceDomainsResponse.DescribeInstanceDomains_InstanceDomain();
				instanceDomain.DomainName = context.StringValue("DescribeInstanceDomains.InstanceDomains["+ i +"].DomainName");
				instanceDomain.CreateTime = context.StringValue("DescribeInstanceDomains.InstanceDomains["+ i +"].CreateTime");
				instanceDomain.CreateTimestamp = context.LongValue("DescribeInstanceDomains.InstanceDomains["+ i +"].CreateTimestamp");

				describeInstanceDomainsResponse_instanceDomains.Add(instanceDomain);
			}
			describeInstanceDomainsResponse.InstanceDomains = describeInstanceDomainsResponse_instanceDomains;
        
			return describeInstanceDomainsResponse;
        }
    }
}
