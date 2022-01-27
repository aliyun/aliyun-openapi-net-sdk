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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class DescribeGWSInstancesResponseUnmarshaller
    {
        public static DescribeGWSInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGWSInstancesResponse describeGWSInstancesResponse = new DescribeGWSInstancesResponse();

			describeGWSInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeGWSInstancesResponse.RequestId = _ctx.StringValue("DescribeGWSInstances.RequestId");
			describeGWSInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeGWSInstances.TotalCount");
			describeGWSInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeGWSInstances.PageNumber");
			describeGWSInstancesResponse.PageSize = _ctx.IntegerValue("DescribeGWSInstances.PageSize");

			List<DescribeGWSInstancesResponse.DescribeGWSInstances_InstanceInfo> describeGWSInstancesResponse_instances = new List<DescribeGWSInstancesResponse.DescribeGWSInstances_InstanceInfo>();
			for (int i = 0; i < _ctx.Length("DescribeGWSInstances.Instances.Length"); i++) {
				DescribeGWSInstancesResponse.DescribeGWSInstances_InstanceInfo instanceInfo = new DescribeGWSInstancesResponse.DescribeGWSInstances_InstanceInfo();
				instanceInfo.ClusterId = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].ClusterId");
				instanceInfo.InstanceId = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].InstanceId");
				instanceInfo.InstanceType = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].InstanceType");
				instanceInfo.Status = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].Status");
				instanceInfo.CreateTime = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].CreateTime");
				instanceInfo.ExpireTime = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].ExpireTime");
				instanceInfo.WorkMode = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].WorkMode");
				instanceInfo.Name = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].Name");
				instanceInfo.UserName = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].UserName");

				List<DescribeGWSInstancesResponse.DescribeGWSInstances_InstanceInfo.DescribeGWSInstances_AppInfo> instanceInfo_appList = new List<DescribeGWSInstancesResponse.DescribeGWSInstances_InstanceInfo.DescribeGWSInstances_AppInfo>();
				for (int j = 0; j < _ctx.Length("DescribeGWSInstances.Instances["+ i +"].AppList.Length"); j++) {
					DescribeGWSInstancesResponse.DescribeGWSInstances_InstanceInfo.DescribeGWSInstances_AppInfo appInfo = new DescribeGWSInstancesResponse.DescribeGWSInstances_InstanceInfo.DescribeGWSInstances_AppInfo();
					appInfo.AppName = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].AppList["+ j +"].AppName");
					appInfo.AppPath = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].AppList["+ j +"].AppPath");
					appInfo.AppArgs = _ctx.StringValue("DescribeGWSInstances.Instances["+ i +"].AppList["+ j +"].AppArgs");

					instanceInfo_appList.Add(appInfo);
				}
				instanceInfo.AppList = instanceInfo_appList;

				describeGWSInstancesResponse_instances.Add(instanceInfo);
			}
			describeGWSInstancesResponse.Instances = describeGWSInstancesResponse_instances;
        
			return describeGWSInstancesResponse;
        }
    }
}
