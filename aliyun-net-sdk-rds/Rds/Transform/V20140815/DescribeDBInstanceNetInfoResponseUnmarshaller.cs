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
    public class DescribeDBInstanceNetInfoResponseUnmarshaller
    {
        public static DescribeDBInstanceNetInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceNetInfoResponse describeDBInstanceNetInfoResponse = new DescribeDBInstanceNetInfoResponse();

			describeDBInstanceNetInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceNetInfoResponse.RequestId = _ctx.StringValue("DescribeDBInstanceNetInfo.RequestId");
			describeDBInstanceNetInfoResponse.InstanceNetworkType = _ctx.StringValue("DescribeDBInstanceNetInfo.InstanceNetworkType");
			describeDBInstanceNetInfoResponse.SecurityIPMode = _ctx.StringValue("DescribeDBInstanceNetInfo.SecurityIPMode");

			List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo> describeDBInstanceNetInfoResponse_dBInstanceNetInfos = new List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceNetInfo.DBInstanceNetInfos.Length"); i++) {
				DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo dBInstanceNetInfo = new DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo();
				dBInstanceNetInfo.Upgradeable = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].Upgradeable");
				dBInstanceNetInfo.ExpiredTime = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].ExpiredTime");
				dBInstanceNetInfo.ConnectionString = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].ConnectionString");
				dBInstanceNetInfo.IPAddress = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].IPAddress");
				dBInstanceNetInfo.IPType = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].IPType");
				dBInstanceNetInfo.Port = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].Port");
				dBInstanceNetInfo.VPCId = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].VPCId");
				dBInstanceNetInfo.VSwitchId = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].VSwitchId");
				dBInstanceNetInfo.ConnectionStringType = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].ConnectionStringType");
				dBInstanceNetInfo.MaxDelayTime = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].MaxDelayTime");
				dBInstanceNetInfo.DistributionType = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].DistributionType");

				List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo.DescribeDBInstanceNetInfo_SecurityIPGroup> dBInstanceNetInfo_securityIPGroups = new List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo.DescribeDBInstanceNetInfo_SecurityIPGroup>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].SecurityIPGroups.Length"); j++) {
					DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo.DescribeDBInstanceNetInfo_SecurityIPGroup securityIPGroup = new DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo.DescribeDBInstanceNetInfo_SecurityIPGroup();
					securityIPGroup.SecurityIPGroupName = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].SecurityIPGroups["+ j +"].SecurityIPGroupName");
					securityIPGroup.SecurityIPs = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].SecurityIPGroups["+ j +"].SecurityIPs");

					dBInstanceNetInfo_securityIPGroups.Add(securityIPGroup);
				}
				dBInstanceNetInfo.SecurityIPGroups = dBInstanceNetInfo_securityIPGroups;

				List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo.DescribeDBInstanceNetInfo_DBInstanceWeight> dBInstanceNetInfo_dBInstanceWeights = new List<DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo.DescribeDBInstanceNetInfo_DBInstanceWeight>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].DBInstanceWeights.Length"); j++) {
					DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo.DescribeDBInstanceNetInfo_DBInstanceWeight dBInstanceWeight = new DescribeDBInstanceNetInfoResponse.DescribeDBInstanceNetInfo_DBInstanceNetInfo.DescribeDBInstanceNetInfo_DBInstanceWeight();
					dBInstanceWeight.DBInstanceId = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].DBInstanceWeights["+ j +"].DBInstanceId");
					dBInstanceWeight.DBInstanceType = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].DBInstanceWeights["+ j +"].DBInstanceType");
					dBInstanceWeight.Availability = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].DBInstanceWeights["+ j +"].Availability");
					dBInstanceWeight.Weight = _ctx.StringValue("DescribeDBInstanceNetInfo.DBInstanceNetInfos["+ i +"].DBInstanceWeights["+ j +"].Weight");

					dBInstanceNetInfo_dBInstanceWeights.Add(dBInstanceWeight);
				}
				dBInstanceNetInfo.DBInstanceWeights = dBInstanceNetInfo_dBInstanceWeights;

				describeDBInstanceNetInfoResponse_dBInstanceNetInfos.Add(dBInstanceNetInfo);
			}
			describeDBInstanceNetInfoResponse.DBInstanceNetInfos = describeDBInstanceNetInfoResponse_dBInstanceNetInfos;
        
			return describeDBInstanceNetInfoResponse;
        }
    }
}
