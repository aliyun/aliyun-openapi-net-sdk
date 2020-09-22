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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsDomainDetailResponseUnmarshaller
    {
        public static DescribeVsDomainDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVsDomainDetailResponse describeVsDomainDetailResponse = new DescribeVsDomainDetailResponse();

			describeVsDomainDetailResponse.HttpResponse = context.HttpResponse;
			describeVsDomainDetailResponse.RequestId = context.StringValue("DescribeVsDomainDetail.RequestId");

			DescribeVsDomainDetailResponse.DescribeVsDomainDetail_DomainConfig domainConfig = new DescribeVsDomainDetailResponse.DescribeVsDomainDetail_DomainConfig();
			domainConfig.GmtCreated = context.StringValue("DescribeVsDomainDetail.DomainConfig.GmtCreated");
			domainConfig.GmtModified = context.StringValue("DescribeVsDomainDetail.DomainConfig.GmtModified");
			domainConfig.DomainStatus = context.StringValue("DescribeVsDomainDetail.DomainConfig.DomainStatus");
			domainConfig.Cname = context.StringValue("DescribeVsDomainDetail.DomainConfig.Cname");
			domainConfig.DomainName = context.StringValue("DescribeVsDomainDetail.DomainConfig.DomainName");
			domainConfig.DomainType = context.StringValue("DescribeVsDomainDetail.DomainConfig.DomainType");
			domainConfig.Region = context.StringValue("DescribeVsDomainDetail.DomainConfig.Region");
			domainConfig.Description = context.StringValue("DescribeVsDomainDetail.DomainConfig.Description");
			domainConfig.SSLProtocol = context.StringValue("DescribeVsDomainDetail.DomainConfig.SSLProtocol");
			domainConfig.Scope = context.StringValue("DescribeVsDomainDetail.DomainConfig.Scope");
			describeVsDomainDetailResponse.DomainConfig = domainConfig;
        
			return describeVsDomainDetailResponse;
        }
    }
}
