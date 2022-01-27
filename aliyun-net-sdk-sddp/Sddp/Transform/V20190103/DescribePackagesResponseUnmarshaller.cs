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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribePackagesResponseUnmarshaller
    {
        public static DescribePackagesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePackagesResponse describePackagesResponse = new DescribePackagesResponse();

			describePackagesResponse.HttpResponse = _ctx.HttpResponse;
			describePackagesResponse.RequestId = _ctx.StringValue("DescribePackages.RequestId");
			describePackagesResponse.PageSize = _ctx.IntegerValue("DescribePackages.PageSize");
			describePackagesResponse.CurrentPage = _ctx.IntegerValue("DescribePackages.CurrentPage");
			describePackagesResponse.TotalCount = _ctx.IntegerValue("DescribePackages.TotalCount");

			List<DescribePackagesResponse.DescribePackages_Package> describePackagesResponse_items = new List<DescribePackagesResponse.DescribePackages_Package>();
			for (int i = 0; i < _ctx.Length("DescribePackages.Items.Length"); i++) {
				DescribePackagesResponse.DescribePackages_Package package = new DescribePackagesResponse.DescribePackages_Package();
				package.Id = _ctx.LongValue("DescribePackages.Items["+ i +"].Id");
				package.Name = _ctx.StringValue("DescribePackages.Items["+ i +"].Name");
				package.Owner = _ctx.StringValue("DescribePackages.Items["+ i +"].Owner");
				package.CreationTime = _ctx.LongValue("DescribePackages.Items["+ i +"].CreationTime");
				package.Sensitive = _ctx.BooleanValue("DescribePackages.Items["+ i +"].Sensitive");
				package.RiskLevelId = _ctx.LongValue("DescribePackages.Items["+ i +"].RiskLevelId");
				package.RiskLevelName = _ctx.StringValue("DescribePackages.Items["+ i +"].RiskLevelName");
				package.DepartName = _ctx.StringValue("DescribePackages.Items["+ i +"].DepartName");
				package.TotalCount = _ctx.IntegerValue("DescribePackages.Items["+ i +"].TotalCount");
				package.SensitiveCount = _ctx.IntegerValue("DescribePackages.Items["+ i +"].SensitiveCount");
				package.InstanceId = _ctx.LongValue("DescribePackages.Items["+ i +"].InstanceId");

				describePackagesResponse_items.Add(package);
			}
			describePackagesResponse.Items = describePackagesResponse_items;
        
			return describePackagesResponse;
        }
    }
}
