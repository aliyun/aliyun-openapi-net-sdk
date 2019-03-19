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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeL2VipsByDynamicDomainResponseUnmarshaller
    {
        public static DescribeL2VipsByDynamicDomainResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeL2VipsByDynamicDomainResponse describeL2VipsByDynamicDomainResponse = new DescribeL2VipsByDynamicDomainResponse();

			describeL2VipsByDynamicDomainResponse.HttpResponse = context.HttpResponse;
			describeL2VipsByDynamicDomainResponse.RequestId = context.StringValue("DescribeL2VipsByDynamicDomain.RequestId");
			describeL2VipsByDynamicDomainResponse.DomainName = context.StringValue("DescribeL2VipsByDynamicDomain.DomainName");

			List<string> describeL2VipsByDynamicDomainResponse_vips = new List<string>();
			for (int i = 0; i < context.Length("DescribeL2VipsByDynamicDomain.Vips.Length"); i++) {
				describeL2VipsByDynamicDomainResponse_vips.Add(context.StringValue("DescribeL2VipsByDynamicDomain.Vips["+ i +"]"));
			}
			describeL2VipsByDynamicDomainResponse.Vips = describeL2VipsByDynamicDomainResponse_vips;
        
			return describeL2VipsByDynamicDomainResponse;
        }
    }
}
