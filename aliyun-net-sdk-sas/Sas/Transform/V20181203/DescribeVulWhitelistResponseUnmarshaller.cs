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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeVulWhitelistResponseUnmarshaller
    {
        public static DescribeVulWhitelistResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVulWhitelistResponse describeVulWhitelistResponse = new DescribeVulWhitelistResponse();

			describeVulWhitelistResponse.HttpResponse = context.HttpResponse;
			describeVulWhitelistResponse.RequestId = context.StringValue("DescribeVulWhitelist.RequestId");
			describeVulWhitelistResponse.PageSize = context.IntegerValue("DescribeVulWhitelist.PageSize");
			describeVulWhitelistResponse.CurrentPage = context.IntegerValue("DescribeVulWhitelist.CurrentPage");
			describeVulWhitelistResponse.TotalCount = context.IntegerValue("DescribeVulWhitelist.TotalCount");

			List<DescribeVulWhitelistResponse.DescribeVulWhitelist_VulWhitelist> describeVulWhitelistResponse_vulWhitelists = new List<DescribeVulWhitelistResponse.DescribeVulWhitelist_VulWhitelist>();
			for (int i = 0; i < context.Length("DescribeVulWhitelist.VulWhitelists.Length"); i++) {
				DescribeVulWhitelistResponse.DescribeVulWhitelist_VulWhitelist vulWhitelist = new DescribeVulWhitelistResponse.DescribeVulWhitelist_VulWhitelist();
				vulWhitelist.Name = context.StringValue("DescribeVulWhitelist.VulWhitelists["+ i +"].Name");
				vulWhitelist.Type = context.StringValue("DescribeVulWhitelist.VulWhitelists["+ i +"].Type");
				vulWhitelist.AliasName = context.StringValue("DescribeVulWhitelist.VulWhitelists["+ i +"].AliasName");
				vulWhitelist.Reason = context.StringValue("DescribeVulWhitelist.VulWhitelists["+ i +"].Reason");

				describeVulWhitelistResponse_vulWhitelists.Add(vulWhitelist);
			}
			describeVulWhitelistResponse.VulWhitelists = describeVulWhitelistResponse_vulWhitelists;
        
			return describeVulWhitelistResponse;
        }
    }
}
