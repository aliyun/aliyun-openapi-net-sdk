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
    public class DescribeTransferDomainsResponseUnmarshaller
    {
        public static DescribeTransferDomainsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTransferDomainsResponse describeTransferDomainsResponse = new DescribeTransferDomainsResponse();

			describeTransferDomainsResponse.HttpResponse = _ctx.HttpResponse;
			describeTransferDomainsResponse.RequestId = _ctx.StringValue("DescribeTransferDomains.RequestId");
			describeTransferDomainsResponse.TotalCount = _ctx.LongValue("DescribeTransferDomains.TotalCount");
			describeTransferDomainsResponse.PageNumber = _ctx.LongValue("DescribeTransferDomains.PageNumber");
			describeTransferDomainsResponse.PageSize = _ctx.LongValue("DescribeTransferDomains.PageSize");

			List<DescribeTransferDomainsResponse.DescribeTransferDomains_DomainTransfer> describeTransferDomainsResponse_domainTransfers = new List<DescribeTransferDomainsResponse.DescribeTransferDomains_DomainTransfer>();
			for (int i = 0; i < _ctx.Length("DescribeTransferDomains.DomainTransfers.Length"); i++) {
				DescribeTransferDomainsResponse.DescribeTransferDomains_DomainTransfer domainTransfer = new DescribeTransferDomainsResponse.DescribeTransferDomains_DomainTransfer();
				domainTransfer.DomainName = _ctx.StringValue("DescribeTransferDomains.DomainTransfers["+ i +"].DomainName");
				domainTransfer.CreateTime = _ctx.StringValue("DescribeTransferDomains.DomainTransfers["+ i +"].CreateTime");
				domainTransfer.CreateTimestamp = _ctx.LongValue("DescribeTransferDomains.DomainTransfers["+ i +"].CreateTimestamp");
				domainTransfer.FromUserId = _ctx.LongValue("DescribeTransferDomains.DomainTransfers["+ i +"].FromUserId");
				domainTransfer.TargetUserId = _ctx.LongValue("DescribeTransferDomains.DomainTransfers["+ i +"].TargetUserId");
				domainTransfer.Id = _ctx.LongValue("DescribeTransferDomains.DomainTransfers["+ i +"].Id");

				describeTransferDomainsResponse_domainTransfers.Add(domainTransfer);
			}
			describeTransferDomainsResponse.DomainTransfers = describeTransferDomainsResponse_domainTransfers;
        
			return describeTransferDomainsResponse;
        }
    }
}
