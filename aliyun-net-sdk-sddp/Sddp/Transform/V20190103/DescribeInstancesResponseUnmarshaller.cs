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
			describeInstancesResponse.CurrentPage = _ctx.IntegerValue("DescribeInstances.CurrentPage");
			describeInstancesResponse.RequestId = _ctx.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.PageSize = _ctx.IntegerValue("DescribeInstances.PageSize");
			describeInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeInstances.TotalCount");

			List<DescribeInstancesResponse.DescribeInstances_Instance> describeInstancesResponse_items = new List<DescribeInstancesResponse.DescribeInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeInstances.Items.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_Instance instance = new DescribeInstancesResponse.DescribeInstances_Instance();
				instance.CreationTime = _ctx.LongValue("DescribeInstances.Items["+ i +"].CreationTime");
				instance.Acl = _ctx.StringValue("DescribeInstances.Items["+ i +"].Acl");
				instance.LastFinishTime = _ctx.LongValue("DescribeInstances.Items["+ i +"].LastFinishTime");
				instance.Owner = _ctx.StringValue("DescribeInstances.Items["+ i +"].Owner");
				instance.CountDetails = _ctx.StringValue("DescribeInstances.Items["+ i +"].CountDetails");
				instance.FileCountDetails = _ctx.StringValue("DescribeInstances.Items["+ i +"].FileCountDetails");
				instance.TenantName = _ctx.StringValue("DescribeInstances.Items["+ i +"].TenantName");
				instance.Protection = _ctx.BooleanValue("DescribeInstances.Items["+ i +"].Protection");
				instance.DepartName = _ctx.StringValue("DescribeInstances.Items["+ i +"].DepartName");
				instance.Labelsec = _ctx.BooleanValue("DescribeInstances.Items["+ i +"].Labelsec");
				instance.RiskScore = _ctx.FloatValue("DescribeInstances.Items["+ i +"].RiskScore");
				instance.RiskLevelId = _ctx.LongValue("DescribeInstances.Items["+ i +"].RiskLevelId");
				instance.S3Count = _ctx.IntegerValue("DescribeInstances.Items["+ i +"].S3Count");
				instance.S1Count = _ctx.IntegerValue("DescribeInstances.Items["+ i +"].S1Count");
				instance.ProductId = _ctx.StringValue("DescribeInstances.Items["+ i +"].ProductId");
				instance.Name = _ctx.StringValue("DescribeInstances.Items["+ i +"].Name");
				instance.S2Count = _ctx.IntegerValue("DescribeInstances.Items["+ i +"].S2Count");
				instance.EngineType = _ctx.StringValue("DescribeInstances.Items["+ i +"].EngineType");
				instance.TotalCount = _ctx.IntegerValue("DescribeInstances.Items["+ i +"].TotalCount");
				instance.InstanceDescription = _ctx.StringValue("DescribeInstances.Items["+ i +"].InstanceDescription");
				instance.RuleName = _ctx.StringValue("DescribeInstances.Items["+ i +"].RuleName");
				instance.RegionId = _ctx.StringValue("DescribeInstances.Items["+ i +"].RegionId");
				instance.Sensitive = _ctx.BooleanValue("DescribeInstances.Items["+ i +"].Sensitive");
				instance.SensLevelName = _ctx.StringValue("DescribeInstances.Items["+ i +"].SensLevelName");
				instance.RegionName = _ctx.StringValue("DescribeInstances.Items["+ i +"].RegionName");
				instance.LastRiskScore = _ctx.FloatValue("DescribeInstances.Items["+ i +"].LastRiskScore");
				instance.RiskLevelName = _ctx.StringValue("DescribeInstances.Items["+ i +"].RiskLevelName");
				instance.OdpsRiskLevelName = _ctx.StringValue("DescribeInstances.Items["+ i +"].OdpsRiskLevelName");
				instance.SensitiveCount = _ctx.IntegerValue("DescribeInstances.Items["+ i +"].SensitiveCount");
				instance.Id = _ctx.LongValue("DescribeInstances.Items["+ i +"].Id");
				instance.ProductCode = _ctx.StringValue("DescribeInstances.Items["+ i +"].ProductCode");

				describeInstancesResponse_items.Add(instance);
			}
			describeInstancesResponse.Items = describeInstancesResponse_items;
        
			return describeInstancesResponse;
        }
    }
}
