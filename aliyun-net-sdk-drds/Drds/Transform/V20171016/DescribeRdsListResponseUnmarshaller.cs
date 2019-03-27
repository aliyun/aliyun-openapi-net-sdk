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
using Aliyun.Acs.Drds.Model.V20171016;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class DescribeRdsListResponseUnmarshaller
    {
        public static DescribeRdsListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRdsListResponse describeRdsListResponse = new DescribeRdsListResponse();

			describeRdsListResponse.HttpResponse = context.HttpResponse;
			describeRdsListResponse.RequestId = context.StringValue("DescribeRdsList.RequestId");
			describeRdsListResponse.Success = context.BooleanValue("DescribeRdsList.Success");

			List<DescribeRdsListResponse.DescribeRdsList_RdsInstance> describeRdsListResponse_data = new List<DescribeRdsListResponse.DescribeRdsList_RdsInstance>();
			for (int i = 0; i < context.Length("DescribeRdsList.Data.Length"); i++) {
				DescribeRdsListResponse.DescribeRdsList_RdsInstance rdsInstance = new DescribeRdsListResponse.DescribeRdsList_RdsInstance();
				rdsInstance.InstanceId = context.IntegerValue("DescribeRdsList.Data["+ i +"].InstanceId");
				rdsInstance.InstanceName = context.StringValue("DescribeRdsList.Data["+ i +"].InstanceName");
				rdsInstance.ConnectUrl = context.StringValue("DescribeRdsList.Data["+ i +"].ConnectUrl");
				rdsInstance.Port = context.IntegerValue("DescribeRdsList.Data["+ i +"].Port");
				rdsInstance.InstanceStatus = context.StringValue("DescribeRdsList.Data["+ i +"].InstanceStatus");
				rdsInstance.DbType = context.StringValue("DescribeRdsList.Data["+ i +"].DbType");
				rdsInstance.ReadWeight = context.IntegerValue("DescribeRdsList.Data["+ i +"].ReadWeight");

				List<DescribeRdsListResponse.DescribeRdsList_RdsInstance.DescribeRdsList_Child> rdsInstance_readOnlyChildren = new List<DescribeRdsListResponse.DescribeRdsList_RdsInstance.DescribeRdsList_Child>();
				for (int j = 0; j < context.Length("DescribeRdsList.Data["+ i +"].ReadOnlyChildren.Length"); j++) {
					DescribeRdsListResponse.DescribeRdsList_RdsInstance.DescribeRdsList_Child child = new DescribeRdsListResponse.DescribeRdsList_RdsInstance.DescribeRdsList_Child();
					child.InstanceId = context.StringValue("DescribeRdsList.Data["+ i +"].ReadOnlyChildren["+ j +"].InstanceId");
					child.InstanceName = context.StringValue("DescribeRdsList.Data["+ i +"].ReadOnlyChildren["+ j +"].InstanceName");
					child.ConnectUrl = context.StringValue("DescribeRdsList.Data["+ i +"].ReadOnlyChildren["+ j +"].ConnectUrl");
					child.Port = context.IntegerValue("DescribeRdsList.Data["+ i +"].ReadOnlyChildren["+ j +"].Port");
					child.InstanceStatus = context.StringValue("DescribeRdsList.Data["+ i +"].ReadOnlyChildren["+ j +"].InstanceStatus");
					child.DbType = context.StringValue("DescribeRdsList.Data["+ i +"].ReadOnlyChildren["+ j +"].DbType");
					child.ReadWeight = context.IntegerValue("DescribeRdsList.Data["+ i +"].ReadOnlyChildren["+ j +"].ReadWeight");

					rdsInstance_readOnlyChildren.Add(child);
				}
				rdsInstance.ReadOnlyChildren = rdsInstance_readOnlyChildren;

				describeRdsListResponse_data.Add(rdsInstance);
			}
			describeRdsListResponse.Data = describeRdsListResponse_data;
        
			return describeRdsListResponse;
        }
    }
}
