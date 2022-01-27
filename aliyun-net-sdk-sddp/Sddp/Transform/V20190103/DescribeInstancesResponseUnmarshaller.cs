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
    public class DescribeInstancesResponseUnmarshaller
    {
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstancesResponse.RequestId = _ctx.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.PageSize = _ctx.IntegerValue("DescribeInstances.PageSize");
			describeInstancesResponse.CurrentPage = _ctx.IntegerValue("DescribeInstances.CurrentPage");
			describeInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeInstances.TotalCount");

			List<DescribeInstancesResponse.DescribeInstances_Instance> describeInstancesResponse_items = new List<DescribeInstancesResponse.DescribeInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeInstances.Items.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_Instance instance = new DescribeInstancesResponse.DescribeInstances_Instance();
				instance.Id = _ctx.LongValue("DescribeInstances.Items["+ i +"].Id");
				instance.Name = _ctx.StringValue("DescribeInstances.Items["+ i +"].Name");
				instance.Owner = _ctx.StringValue("DescribeInstances.Items["+ i +"].Owner");
				instance.CreationTime = _ctx.LongValue("DescribeInstances.Items["+ i +"].CreationTime");
				instance.ProductId = _ctx.StringValue("DescribeInstances.Items["+ i +"].ProductId");
				instance.ProductCode = _ctx.StringValue("DescribeInstances.Items["+ i +"].ProductCode");
				instance.Protection = _ctx.BooleanValue("DescribeInstances.Items["+ i +"].Protection");
				instance.Labelsec = _ctx.BooleanValue("DescribeInstances.Items["+ i +"].Labelsec");
				instance.OdpsRiskLevelName = _ctx.StringValue("DescribeInstances.Items["+ i +"].OdpsRiskLevelName");
				instance.Sensitive = _ctx.BooleanValue("DescribeInstances.Items["+ i +"].Sensitive");
				instance.RiskLevelId = _ctx.LongValue("DescribeInstances.Items["+ i +"].RiskLevelId");
				instance.RiskLevelName = _ctx.StringValue("DescribeInstances.Items["+ i +"].RiskLevelName");
				instance.RuleName = _ctx.StringValue("DescribeInstances.Items["+ i +"].RuleName");
				instance.DepartName = _ctx.StringValue("DescribeInstances.Items["+ i +"].DepartName");
				instance.TotalCount = _ctx.IntegerValue("DescribeInstances.Items["+ i +"].TotalCount");
				instance.SensitiveCount = _ctx.IntegerValue("DescribeInstances.Items["+ i +"].SensitiveCount");
				instance.Acl = _ctx.StringValue("DescribeInstances.Items["+ i +"].Acl");
				instance.S2Count = _ctx.IntegerValue("DescribeInstances.Items["+ i +"].S2Count");
				instance.S3Count = _ctx.IntegerValue("DescribeInstances.Items["+ i +"].S3Count");
				instance.CountDetails = _ctx.StringValue("DescribeInstances.Items["+ i +"].CountDetails");
				instance.LastFinishTime = _ctx.LongValue("DescribeInstances.Items["+ i +"].LastFinishTime");
				instance.RegionName = _ctx.StringValue("DescribeInstances.Items["+ i +"].RegionName");
				instance.RegionId = _ctx.StringValue("DescribeInstances.Items["+ i +"].RegionId");
				instance.EngineType = _ctx.StringValue("DescribeInstances.Items["+ i +"].EngineType");
				instance.S1Count = _ctx.IntegerValue("DescribeInstances.Items["+ i +"].S1Count");
				instance.RiskScore = _ctx.FloatValue("DescribeInstances.Items["+ i +"].RiskScore");
				instance.LastRiskScore = _ctx.FloatValue("DescribeInstances.Items["+ i +"].LastRiskScore");
				instance.SensLevelName = _ctx.StringValue("DescribeInstances.Items["+ i +"].SensLevelName");
				instance.InstanceDescription = _ctx.StringValue("DescribeInstances.Items["+ i +"].InstanceDescription");
				instance.TenantName = _ctx.StringValue("DescribeInstances.Items["+ i +"].TenantName");

				describeInstancesResponse_items.Add(instance);
			}
			describeInstancesResponse.Items = describeInstancesResponse_items;
        
			return describeInstancesResponse;
        }
    }
}
