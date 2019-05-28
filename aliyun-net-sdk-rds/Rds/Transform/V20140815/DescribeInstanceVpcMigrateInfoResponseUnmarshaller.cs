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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeInstanceVpcMigrateInfoResponseUnmarshaller
    {
        public static DescribeInstanceVpcMigrateInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceVpcMigrateInfoResponse describeInstanceVpcMigrateInfoResponse = new DescribeInstanceVpcMigrateInfoResponse();

			describeInstanceVpcMigrateInfoResponse.HttpResponse = context.HttpResponse;
			describeInstanceVpcMigrateInfoResponse.RequestId = context.StringValue("DescribeInstanceVpcMigrateInfo.RequestId");

			List<DescribeInstanceVpcMigrateInfoResponse.DescribeInstanceVpcMigrateInfo_DBInstanceMigrateInfo> describeInstanceVpcMigrateInfoResponse_dBInstanceMigrateInfos = new List<DescribeInstanceVpcMigrateInfoResponse.DescribeInstanceVpcMigrateInfo_DBInstanceMigrateInfo>();
			for (int i = 0; i < context.Length("DescribeInstanceVpcMigrateInfo.DBInstanceMigrateInfos.Length"); i++) {
				DescribeInstanceVpcMigrateInfoResponse.DescribeInstanceVpcMigrateInfo_DBInstanceMigrateInfo dBInstanceMigrateInfo = new DescribeInstanceVpcMigrateInfoResponse.DescribeInstanceVpcMigrateInfo_DBInstanceMigrateInfo();
				dBInstanceMigrateInfo.DBInstanceId = context.StringValue("DescribeInstanceVpcMigrateInfo.DBInstanceMigrateInfos["+ i +"].DBInstanceId");
				dBInstanceMigrateInfo.TargetRegionId = context.StringValue("DescribeInstanceVpcMigrateInfo.DBInstanceMigrateInfos["+ i +"].TargetRegionId");
				dBInstanceMigrateInfo.TargetZoneId = context.StringValue("DescribeInstanceVpcMigrateInfo.DBInstanceMigrateInfos["+ i +"].TargetZoneId");
				dBInstanceMigrateInfo.TargetVPCId = context.StringValue("DescribeInstanceVpcMigrateInfo.DBInstanceMigrateInfos["+ i +"].TargetVPCId");
				dBInstanceMigrateInfo.TargetVSwitchId = context.StringValue("DescribeInstanceVpcMigrateInfo.DBInstanceMigrateInfos["+ i +"].TargetVSwitchId");
				dBInstanceMigrateInfo.TargetIPAddress = context.StringValue("DescribeInstanceVpcMigrateInfo.DBInstanceMigrateInfos["+ i +"].TargetIPAddress");
				dBInstanceMigrateInfo.TargetVpcInstanceId = context.StringValue("DescribeInstanceVpcMigrateInfo.DBInstanceMigrateInfos["+ i +"].TargetVpcInstanceId");

				describeInstanceVpcMigrateInfoResponse_dBInstanceMigrateInfos.Add(dBInstanceMigrateInfo);
			}
			describeInstanceVpcMigrateInfoResponse.DBInstanceMigrateInfos = describeInstanceVpcMigrateInfoResponse_dBInstanceMigrateInfos;
        
			return describeInstanceVpcMigrateInfoResponse;
        }
    }
}
