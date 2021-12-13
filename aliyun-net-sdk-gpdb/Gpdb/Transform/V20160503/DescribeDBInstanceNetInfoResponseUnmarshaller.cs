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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeDBInstanceNetInfoResponseUnmarshaller
    {
        public static DescribeDBInstanceNetInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceNetInfoResponse describeDBInstanceNetInfoResponse = new DescribeDBInstanceNetInfoResponse();

			describeDBInstanceNetInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceNetInfoResponse.RequestId = _ctx.StringValue("DescribeDBInstanceNetInfo.RequestId");
			describeDBInstanceNetInfoResponse.InstanceNetworkType = _ctx.StringValue("DescribeDBInstanceNetInfo.InstanceNetworkType");

			List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo> describeDBInstanceNetInfoResponse_dBInstanceNetInfos = new List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceNetInfo.DBInstanceNetInfos.Length"); i++) {
				DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo dBInstanceNetInfo = new DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo();
				dBInstanceNetInfo.VSwitchId = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].VSwitchId");
				dBInstanceNetInfo.ConnectionString = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].ConnectionString");
				dBInstanceNetInfo.IPType = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].IPType");
				dBInstanceNetInfo.Port = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].Port");
				dBInstanceNetInfo.VpcInstanceId = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].VpcInstanceId");
				dBInstanceNetInfo.VPCId = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].VPCId");
				dBInstanceNetInfo.IPAddress = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].IPAddress");
				dBInstanceNetInfo.AddressType = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].AddressType");

				describeDBInstanceNetInfoResponse_dBInstanceNetInfos.Add(dBInstanceNetInfo);
			}
			describeDBInstanceNetInfoResponse.DBInstanceNetInfos = describeDBInstanceNetInfoResponse_dBInstanceNetInfos;
        
			return describeDBInstanceNetInfoResponse;
        }
    }
}
