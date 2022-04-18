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
    public class DescribeInstanceSourcesResponseUnmarshaller
    {
        public static DescribeInstanceSourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceSourcesResponse describeInstanceSourcesResponse = new DescribeInstanceSourcesResponse();

			describeInstanceSourcesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceSourcesResponse.CurrentPage = _ctx.IntegerValue("DescribeInstanceSources.CurrentPage");
			describeInstanceSourcesResponse.RequestId = _ctx.StringValue("DescribeInstanceSources.RequestId");
			describeInstanceSourcesResponse.PageSize = _ctx.IntegerValue("DescribeInstanceSources.PageSize");
			describeInstanceSourcesResponse.TotalCount = _ctx.IntegerValue("DescribeInstanceSources.TotalCount");

			List<DescribeInstanceSourcesResponse.DescribeInstanceSources_InstanceSource> describeInstanceSourcesResponse_items = new List<DescribeInstanceSourcesResponse.DescribeInstanceSources_InstanceSource>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceSources.Items.Length"); i++) {
				DescribeInstanceSourcesResponse.DescribeInstanceSources_InstanceSource instanceSource = new DescribeInstanceSourcesResponse.DescribeInstanceSources_InstanceSource();
				instanceSource.LastModifyUserId = _ctx.StringValue("DescribeInstanceSources.Items["+ i +"].LastModifyUserId");
				instanceSource.PasswordStatus = _ctx.IntegerValue("DescribeInstanceSources.Items["+ i +"].PasswordStatus");
				instanceSource.EngineType = _ctx.StringValue("DescribeInstanceSources.Items["+ i +"].EngineType");
				instanceSource.TenantName = _ctx.StringValue("DescribeInstanceSources.Items["+ i +"].TenantName");
				instanceSource.InstanceId = _ctx.StringValue("DescribeInstanceSources.Items["+ i +"].InstanceId");
				instanceSource.InstanceDescription = _ctx.StringValue("DescribeInstanceSources.Items["+ i +"].InstanceDescription");
				instanceSource.DataLimitId = _ctx.LongValue("DescribeInstanceSources.Items["+ i +"].DataLimitId");
				instanceSource.RegionId = _ctx.StringValue("DescribeInstanceSources.Items["+ i +"].RegionId");
				instanceSource.DbName = _ctx.StringValue("DescribeInstanceSources.Items["+ i +"].DbName");
				instanceSource.LastModifyTime = _ctx.LongValue("DescribeInstanceSources.Items["+ i +"].LastModifyTime");
				instanceSource.RegionName = _ctx.StringValue("DescribeInstanceSources.Items["+ i +"].RegionName");
				instanceSource.CanModifyUserName = _ctx.BooleanValue("DescribeInstanceSources.Items["+ i +"].CanModifyUserName");
				instanceSource.LogStoreDay = _ctx.IntegerValue("DescribeInstanceSources.Items["+ i +"].LogStoreDay");
				instanceSource.GmtCreate = _ctx.LongValue("DescribeInstanceSources.Items["+ i +"].GmtCreate");
				instanceSource.AutoScan = _ctx.IntegerValue("DescribeInstanceSources.Items["+ i +"].AutoScan");
				instanceSource.ProductId = _ctx.LongValue("DescribeInstanceSources.Items["+ i +"].ProductId");
				instanceSource.InstanceSize = _ctx.LongValue("DescribeInstanceSources.Items["+ i +"].InstanceSize");
				instanceSource.UserName = _ctx.StringValue("DescribeInstanceSources.Items["+ i +"].UserName");
				instanceSource.AuditStatus = _ctx.IntegerValue("DescribeInstanceSources.Items["+ i +"].AuditStatus");
				instanceSource.Id = _ctx.LongValue("DescribeInstanceSources.Items["+ i +"].Id");
				instanceSource.TenantId = _ctx.StringValue("DescribeInstanceSources.Items["+ i +"].TenantId");
				instanceSource.Enable = _ctx.IntegerValue("DescribeInstanceSources.Items["+ i +"].Enable");
				instanceSource.CheckStatus = _ctx.IntegerValue("DescribeInstanceSources.Items["+ i +"].CheckStatus");
				instanceSource.DatamaskStatus = _ctx.IntegerValue("DescribeInstanceSources.Items["+ i +"].DatamaskStatus");
				instanceSource.ErrorMessage = _ctx.StringValue("DescribeInstanceSources.Items["+ i +"].ErrorMessage");
				instanceSource.SamplingSize = _ctx.IntegerValue("DescribeInstanceSources.Items["+ i +"].SamplingSize");

				describeInstanceSourcesResponse_items.Add(instanceSource);
			}
			describeInstanceSourcesResponse.Items = describeInstanceSourcesResponse_items;
        
			return describeInstanceSourcesResponse;
        }
    }
}
