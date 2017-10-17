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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeDBInstanceNetInfoResponseUnmarshaller
    {
        public static DescribeDBInstanceNetInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceNetInfoResponse describeDBInstanceNetInfoResponse = new DescribeDBInstanceNetInfoResponse();

			describeDBInstanceNetInfoResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceNetInfoResponse.RequestId = context.StringValue("DescribeDBInstanceNetInfo.RequestId");
			describeDBInstanceNetInfoResponse.InstanceNetworkType = context.StringValue("DescribeDBInstanceNetInfo.InstanceNetworkType");

			List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_InstanceNetInfo> describeDBInstanceNetInfoResponse_netInfoItems = new List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_InstanceNetInfo>();
			for (int i = 0; i < context.Length("DescribeDBInstanceNetInfo.NetInfoItems.Length"); i++) {
				DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_InstanceNetInfo instanceNetInfo = new DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_InstanceNetInfo();
				instanceNetInfo.ConnectionString = context.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].ConnectionString");
				instanceNetInfo.IPAddress = context.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].IPAddress");
				instanceNetInfo.Port = context.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].Port");
				instanceNetInfo.VPCId = context.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].VPCId");
				instanceNetInfo.VSwitchId = context.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].VSwitchId");
				instanceNetInfo.DBInstanceNetType = context.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].DBInstanceNetType");
				instanceNetInfo.ExpiredTime = context.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].ExpiredTime");
				instanceNetInfo.Upgradeable = context.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].Upgradeable");

				describeDBInstanceNetInfoResponse_netInfoItems.Add(instanceNetInfo);
			}
			describeDBInstanceNetInfoResponse.NetInfoItems = describeDBInstanceNetInfoResponse_netInfoItems;
        
			return describeDBInstanceNetInfoResponse;
        }
    }
}