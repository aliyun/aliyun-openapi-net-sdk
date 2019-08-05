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
        public static DescribeBackupGatewayListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupGatewayListResponse describeBackupGatewayListResponse = new DescribeBackupGatewayListResponse();

			describeBackupGatewayListResponse.HttpResponse = context.HttpResponse;
			describeBackupGatewayListResponse.Success = context.BooleanValue("DescribeBackupGatewayList.Success");
			describeBackupGatewayListResponse.ErrCode = context.StringValue("DescribeBackupGatewayList.ErrCode");
			describeBackupGatewayListResponse.ErrMessage = context.StringValue("DescribeBackupGatewayList.ErrMessage");
			describeBackupGatewayListResponse.HttpStatusCode = context.IntegerValue("DescribeBackupGatewayList.HttpStatusCode");
			describeBackupGatewayListResponse.RequestId = context.StringValue("DescribeBackupGatewayList.RequestId");
			describeBackupGatewayListResponse.TotalPages = context.IntegerValue("DescribeBackupGatewayList.TotalPages");
			describeBackupGatewayListResponse.PageSize = context.IntegerValue("DescribeBackupGatewayList.PageSize");
			describeBackupGatewayListResponse.PageNum = context.IntegerValue("DescribeBackupGatewayList.PageNum");
			describeBackupGatewayListResponse.TotalElements = context.IntegerValue("DescribeBackupGatewayList.TotalElements");

			List<DescribeBackupGatewayListResponse.DescribeBackupGatewayList_BackupGateway> describeBackupGatewayListResponse_items = new List<DescribeBackupGatewayListResponse.DescribeBackupGatewayList_BackupGateway>();
			for (int i = 0; i < context.Length("DescribeBackupGatewayList.Items.Length"); i++) {
				DescribeBackupGatewayListResponse.DescribeBackupGatewayList_BackupGateway backupGateway = new DescribeBackupGatewayListResponse.DescribeBackupGatewayList_BackupGateway();
				backupGateway.BackupGatewayId = context.StringValue("DescribeBackupGatewayList.Items["+ i +"].BackupGatewayId");
				backupGateway.SourceEndpointInternetIP = context.StringValue("DescribeBackupGatewayList.Items["+ i +"].SourceEndpointInternetIP");
				backupGateway.SourceEndpointIntranetIP = context.StringValue("DescribeBackupGatewayList.Items["+ i +"].SourceEndpointIntranetIP");
				backupGateway.SourceEndpointHostname = context.StringValue("DescribeBackupGatewayList.Items["+ i +"].SourceEndpointHostname");
				backupGateway.BackupGatewayStatus = context.StringValue("DescribeBackupGatewayList.Items["+ i +"].BackupGatewayStatus");
				backupGateway.LastHeartbeatTime = context.LongValue("DescribeBackupGatewayList.Items["+ i +"].LastHeartbeatTime");
				backupGateway.BackupGatewayCreateTime = context.LongValue("DescribeBackupGatewayList.Items["+ i +"].BackupGatewayCreateTime");
				backupGateway.Region = context.StringValue("DescribeBackupGatewayList.Items["+ i +"].Region");
				backupGateway.DisplayName = context.StringValue("DescribeBackupGatewayList.Items["+ i +"].DisplayName");
				backupGateway.Identifier = context.StringValue("DescribeBackupGatewayList.Items["+ i +"].Identifier");

				describeBackupGatewayListResponse_items.Add(backupGateway);
			}
			describeBackupGatewayListResponse.Items = describeBackupGatewayListResponse_items;
        
			return describeBackupGatewayListResponse;
        }
    }
}
