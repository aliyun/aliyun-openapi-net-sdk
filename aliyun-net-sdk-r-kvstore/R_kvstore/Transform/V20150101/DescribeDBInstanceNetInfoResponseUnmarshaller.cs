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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeDBInstanceNetInfoResponseUnmarshaller
    {
        public static DescribeDBInstanceNetInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceNetInfoResponse describeDBInstanceNetInfoResponse = new DescribeDBInstanceNetInfoResponse();

			describeDBInstanceNetInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceNetInfoResponse.RequestId = _ctx.StringValue("DescribeDBInstanceNetInfo.RequestId");
			describeDBInstanceNetInfoResponse.InstanceNetworkType = _ctx.StringValue("DescribeDBInstanceNetInfo.InstanceNetworkType");

			List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_InstanceNetInfo> describeDBInstanceNetInfoResponse_netInfoItems = new List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_InstanceNetInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceNetInfo.NetInfoItems.Length"); i++) {
				DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_InstanceNetInfo instanceNetInfo = new DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_InstanceNetInfo();
				instanceNetInfo.ConnectionString = _ctx.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].ConnectionString");
				instanceNetInfo.IPAddress = _ctx.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].IPAddress");
				instanceNetInfo.Port = _ctx.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].Port");
				instanceNetInfo.VPCId = _ctx.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].VPCId");
				instanceNetInfo.VSwitchId = _ctx.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].VSwitchId");
				instanceNetInfo.DBInstanceNetType = _ctx.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].DBInstanceNetType");
				instanceNetInfo.VPCInstanceId = _ctx.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].VPCInstanceId");
				instanceNetInfo.IPType = _ctx.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].IPType");
				instanceNetInfo.ExpiredTime = _ctx.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].ExpiredTime");
				instanceNetInfo.Upgradeable = _ctx.StringValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].Upgradeable");
				instanceNetInfo.DirectConnection = _ctx.IntegerValue("DescribeDBInstanceNetInfo.NetInfoItems["+ i +"].DirectConnection");

				describeDBInstanceNetInfoResponse_netInfoItems.Add(instanceNetInfo);
			}
			describeDBInstanceNetInfoResponse.NetInfoItems = describeDBInstanceNetInfoResponse_netInfoItems;
        
			return describeDBInstanceNetInfoResponse;
        }
    }
}
