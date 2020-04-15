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
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = context.HttpResponse;
			describeInstancesResponse.RequestId = context.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.PageSize = context.IntegerValue("DescribeInstances.PageSize");
			describeInstancesResponse.CurrentPage = context.IntegerValue("DescribeInstances.CurrentPage");
			describeInstancesResponse.TotalCount = context.IntegerValue("DescribeInstances.TotalCount");

			List<DescribeInstancesResponse.DescribeInstances_Instance> describeInstancesResponse_items = new List<DescribeInstancesResponse.DescribeInstances_Instance>();
			for (int i = 0; i < context.Length("DescribeInstances.Items.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_Instance instance = new DescribeInstancesResponse.DescribeInstances_Instance();
				instance.Id = context.LongValue("DescribeInstances.Items["+ i +"].Id");
				instance.Name = context.StringValue("DescribeInstances.Items["+ i +"].Name");
				instance.Owner = context.StringValue("DescribeInstances.Items["+ i +"].Owner");
				instance.CreationTime = context.LongValue("DescribeInstances.Items["+ i +"].CreationTime");
				instance.ProductId = context.StringValue("DescribeInstances.Items["+ i +"].ProductId");
				instance.ProductCode = context.StringValue("DescribeInstances.Items["+ i +"].ProductCode");
				instance.Protection = context.BooleanValue("DescribeInstances.Items["+ i +"].Protection");
				instance.Labelsec = context.BooleanValue("DescribeInstances.Items["+ i +"].Labelsec");
				instance.OdpsRiskLevelName = context.StringValue("DescribeInstances.Items["+ i +"].OdpsRiskLevelName");
				instance.Sensitive = context.BooleanValue("DescribeInstances.Items["+ i +"].Sensitive");
				instance.RiskLevelId = context.LongValue("DescribeInstances.Items["+ i +"].RiskLevelId");
				instance.RiskLevelName = context.StringValue("DescribeInstances.Items["+ i +"].RiskLevelName");
				instance.RuleName = context.StringValue("DescribeInstances.Items["+ i +"].RuleName");
				instance.DepartName = context.StringValue("DescribeInstances.Items["+ i +"].DepartName");
				instance.TotalCount = context.IntegerValue("DescribeInstances.Items["+ i +"].TotalCount");
				instance.SensitiveCount = context.IntegerValue("DescribeInstances.Items["+ i +"].SensitiveCount");
				instance.Acl = context.StringValue("DescribeInstances.Items["+ i +"].Acl");
				instance.S2Count = context.IntegerValue("DescribeInstances.Items["+ i +"].S2Count");
				instance.S3Count = context.IntegerValue("DescribeInstances.Items["+ i +"].S3Count");
				instance.LastFinishTime = context.LongValue("DescribeInstances.Items["+ i +"].LastFinishTime");
				instance.RegionName = context.StringValue("DescribeInstances.Items["+ i +"].RegionName");
				instance.RegionId = context.StringValue("DescribeInstances.Items["+ i +"].RegionId");
				instance.EngineType = context.StringValue("DescribeInstances.Items["+ i +"].EngineType");

				describeInstancesResponse_items.Add(instance);
			}
			describeInstancesResponse.Items = describeInstancesResponse_items;
        
			return describeInstancesResponse;
        }
    }
}
