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
using Aliyun.Acs.hitsdb.Model.V20170601;

namespace Aliyun.Acs.hitsdb.Transform.V20170601
{
    public class DescribeHiTSDBInstanceResponseUnmarshaller
    {
        public static DescribeHiTSDBInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHiTSDBInstanceResponse describeHiTSDBInstanceResponse = new DescribeHiTSDBInstanceResponse();

			describeHiTSDBInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeHiTSDBInstanceResponse.RequestId = _ctx.StringValue("DescribeHiTSDBInstance.RequestId");
			describeHiTSDBInstanceResponse.InstanceId = _ctx.StringValue("DescribeHiTSDBInstance.InstanceId");
			describeHiTSDBInstanceResponse.InstanceAlias = _ctx.StringValue("DescribeHiTSDBInstance.InstanceAlias");
			describeHiTSDBInstanceResponse.InstanceDescription = _ctx.StringValue("DescribeHiTSDBInstance.InstanceDescription");
			describeHiTSDBInstanceResponse.RegionId = _ctx.StringValue("DescribeHiTSDBInstance.RegionId");
			describeHiTSDBInstanceResponse.ZoneId = _ctx.StringValue("DescribeHiTSDBInstance.ZoneId");
			describeHiTSDBInstanceResponse.InstanceStatus = _ctx.StringValue("DescribeHiTSDBInstance.InstanceStatus");
			describeHiTSDBInstanceResponse.ChargeType = _ctx.StringValue("DescribeHiTSDBInstance.ChargeType");
			describeHiTSDBInstanceResponse.NetworkType = _ctx.StringValue("DescribeHiTSDBInstance.NetworkType");
			describeHiTSDBInstanceResponse.GmtCreated = _ctx.StringValue("DescribeHiTSDBInstance.GmtCreated");
			describeHiTSDBInstanceResponse.GmtExpire = _ctx.StringValue("DescribeHiTSDBInstance.GmtExpire");
			describeHiTSDBInstanceResponse.InstanceClass = _ctx.StringValue("DescribeHiTSDBInstance.InstanceClass");
			describeHiTSDBInstanceResponse.MaxTimelineLimit = _ctx.StringValue("DescribeHiTSDBInstance.MaxTimelineLimit");
			describeHiTSDBInstanceResponse.InstanceStorage = _ctx.StringValue("DescribeHiTSDBInstance.InstanceStorage");
			describeHiTSDBInstanceResponse.InstanceTps = _ctx.StringValue("DescribeHiTSDBInstance.InstanceTps");
			describeHiTSDBInstanceResponse.ReverseVpcIp = _ctx.StringValue("DescribeHiTSDBInstance.ReverseVpcIp");
			describeHiTSDBInstanceResponse.ReverseVpcPort = _ctx.StringValue("DescribeHiTSDBInstance.ReverseVpcPort");
			describeHiTSDBInstanceResponse.VpcId = _ctx.StringValue("DescribeHiTSDBInstance.VpcId");
			describeHiTSDBInstanceResponse.VswitchId = _ctx.StringValue("DescribeHiTSDBInstance.VswitchId");
			describeHiTSDBInstanceResponse.ConnectionString = _ctx.StringValue("DescribeHiTSDBInstance.ConnectionString");
			describeHiTSDBInstanceResponse.PublicConnectionString = _ctx.StringValue("DescribeHiTSDBInstance.PublicConnectionString");
			describeHiTSDBInstanceResponse.AutoRenew = _ctx.StringValue("DescribeHiTSDBInstance.AutoRenew");
			describeHiTSDBInstanceResponse.EngineType = _ctx.StringValue("DescribeHiTSDBInstance.EngineType");
			describeHiTSDBInstanceResponse.CpuNumber = _ctx.StringValue("DescribeHiTSDBInstance.CpuNumber");
			describeHiTSDBInstanceResponse.MemSize = _ctx.StringValue("DescribeHiTSDBInstance.MemSize");
			describeHiTSDBInstanceResponse.Series = _ctx.IntegerValue("DescribeHiTSDBInstance.Series");
			describeHiTSDBInstanceResponse.RDSStatus = _ctx.StringValue("DescribeHiTSDBInstance.RDSStatus");
			describeHiTSDBInstanceResponse.DiskCategory = _ctx.StringValue("DescribeHiTSDBInstance.DiskCategory");
			describeHiTSDBInstanceResponse.Status = _ctx.StringValue("DescribeHiTSDBInstance.Status");
			describeHiTSDBInstanceResponse.PaymentType = _ctx.StringValue("DescribeHiTSDBInstance.PaymentType");
			describeHiTSDBInstanceResponse.CreateTime = _ctx.LongValue("DescribeHiTSDBInstance.CreateTime");
			describeHiTSDBInstanceResponse.ExpiredTime = _ctx.LongValue("DescribeHiTSDBInstance.ExpiredTime");

			List<DescribeHiTSDBInstanceResponse.DescribeHiTSDBInstance_SecurityIp> describeHiTSDBInstanceResponse_securityIpList = new List<DescribeHiTSDBInstanceResponse.DescribeHiTSDBInstance_SecurityIp>();
			for (int i = 0; i < _ctx.Length("DescribeHiTSDBInstance.SecurityIpList.Length"); i++) {
				DescribeHiTSDBInstanceResponse.DescribeHiTSDBInstance_SecurityIp securityIp = new DescribeHiTSDBInstanceResponse.DescribeHiTSDBInstance_SecurityIp();
				securityIp.Ip = _ctx.StringValue("DescribeHiTSDBInstance.SecurityIpList["+ i +"].Ip");

				describeHiTSDBInstanceResponse_securityIpList.Add(securityIp);
			}
			describeHiTSDBInstanceResponse.SecurityIpList = describeHiTSDBInstanceResponse_securityIpList;
        
			return describeHiTSDBInstanceResponse;
        }
    }
}
