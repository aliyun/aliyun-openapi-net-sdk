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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribeBackupGatewayListResponseUnmarshaller
    {
        public static DescribeBackupGatewayListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupGatewayListResponse describeBackupGatewayListResponse = new DescribeBackupGatewayListResponse();

			describeBackupGatewayListResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupGatewayListResponse.Success = _ctx.BooleanValue("DescribeBackupGatewayList.Success");
			describeBackupGatewayListResponse.ErrCode = _ctx.StringValue("DescribeBackupGatewayList.ErrCode");
			describeBackupGatewayListResponse.ErrMessage = _ctx.StringValue("DescribeBackupGatewayList.ErrMessage");
			describeBackupGatewayListResponse.HttpStatusCode = _ctx.IntegerValue("DescribeBackupGatewayList.HttpStatusCode");
			describeBackupGatewayListResponse.RequestId = _ctx.StringValue("DescribeBackupGatewayList.RequestId");
			describeBackupGatewayListResponse.TotalPages = _ctx.IntegerValue("DescribeBackupGatewayList.TotalPages");
			describeBackupGatewayListResponse.PageSize = _ctx.IntegerValue("DescribeBackupGatewayList.PageSize");
			describeBackupGatewayListResponse.PageNum = _ctx.IntegerValue("DescribeBackupGatewayList.PageNum");
			describeBackupGatewayListResponse.TotalElements = _ctx.IntegerValue("DescribeBackupGatewayList.TotalElements");

			List<DescribeBackupGatewayListResponse.DescribeBackupGatewayList_BackupGateway> describeBackupGatewayListResponse_items = new List<DescribeBackupGatewayListResponse.DescribeBackupGatewayList_BackupGateway>();
			for (int i = 0; i < _ctx.Length("DescribeBackupGatewayList.Items.Length"); i++) {
				DescribeBackupGatewayListResponse.DescribeBackupGatewayList_BackupGateway backupGateway = new DescribeBackupGatewayListResponse.DescribeBackupGatewayList_BackupGateway();
				backupGateway.BackupGatewayId = _ctx.StringValue("DescribeBackupGatewayList.Items["+ i +"].BackupGatewayId");
				backupGateway.SourceEndpointInternetIP = _ctx.StringValue("DescribeBackupGatewayList.Items["+ i +"].SourceEndpointInternetIP");
				backupGateway.SourceEndpointIntranetIP = _ctx.StringValue("DescribeBackupGatewayList.Items["+ i +"].SourceEndpointIntranetIP");
				backupGateway.SourceEndpointHostname = _ctx.StringValue("DescribeBackupGatewayList.Items["+ i +"].SourceEndpointHostname");
				backupGateway.BackupGatewayStatus = _ctx.StringValue("DescribeBackupGatewayList.Items["+ i +"].BackupGatewayStatus");
				backupGateway.LastHeartbeatTime = _ctx.LongValue("DescribeBackupGatewayList.Items["+ i +"].LastHeartbeatTime");
				backupGateway.BackupGatewayCreateTime = _ctx.LongValue("DescribeBackupGatewayList.Items["+ i +"].BackupGatewayCreateTime");
				backupGateway.Region = _ctx.StringValue("DescribeBackupGatewayList.Items["+ i +"].Region");
				backupGateway.DisplayName = _ctx.StringValue("DescribeBackupGatewayList.Items["+ i +"].DisplayName");
				backupGateway.Identifier = _ctx.StringValue("DescribeBackupGatewayList.Items["+ i +"].Identifier");

				describeBackupGatewayListResponse_items.Add(backupGateway);
			}
			describeBackupGatewayListResponse.Items = describeBackupGatewayListResponse_items;
        
			return describeBackupGatewayListResponse;
        }
    }
}
