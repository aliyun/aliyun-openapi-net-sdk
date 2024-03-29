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
    public class DescribeUserVipsByDomainResponseUnmarshaller
    {
        public static DescribeUserVipsByDomainResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserVipsByDomainResponse describeUserVipsByDomainResponse = new DescribeUserVipsByDomainResponse();

			describeUserVipsByDomainResponse.HttpResponse = _ctx.HttpResponse;
			describeUserVipsByDomainResponse.DomainName = _ctx.StringValue("DescribeUserVipsByDomain.DomainName");
			describeUserVipsByDomainResponse.RequestId = _ctx.StringValue("DescribeUserVipsByDomain.RequestId");

			List<string> describeUserVipsByDomainResponse_vips = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeUserVipsByDomain.Vips.Length"); i++) {
				describeUserVipsByDomainResponse_vips.Add(_ctx.StringValue("DescribeUserVipsByDomain.Vips["+ i +"]"));
			}
			describeUserVipsByDomainResponse.Vips = describeUserVipsByDomainResponse_vips;
        
			return describeUserVipsByDomainResponse;
        }
    }
}
