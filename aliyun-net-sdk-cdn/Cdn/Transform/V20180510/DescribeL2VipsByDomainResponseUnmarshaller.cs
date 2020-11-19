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
    public class DescribeL2VipsByDomainResponseUnmarshaller
    {
        public static DescribeL2VipsByDomainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeL2VipsByDomainResponse describeL2VipsByDomainResponse = new DescribeL2VipsByDomainResponse();

			describeL2VipsByDomainResponse.HttpResponse = _ctx.HttpResponse;
			describeL2VipsByDomainResponse.RequestId = _ctx.StringValue("DescribeL2VipsByDomain.RequestId");
			describeL2VipsByDomainResponse.DomainName = _ctx.StringValue("DescribeL2VipsByDomain.DomainName");

			List<string> describeL2VipsByDomainResponse_vips = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeL2VipsByDomain.Vips.Length"); i++) {
				describeL2VipsByDomainResponse_vips.Add(_ctx.StringValue("DescribeL2VipsByDomain.Vips["+ i +"]"));
			}
			describeL2VipsByDomainResponse.Vips = describeL2VipsByDomainResponse_vips;
        
			return describeL2VipsByDomainResponse;
        }
    }
}
