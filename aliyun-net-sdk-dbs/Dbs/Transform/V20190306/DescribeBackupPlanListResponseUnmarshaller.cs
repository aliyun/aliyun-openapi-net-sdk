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
    public class DescribeBackupPlanListResponseUnmarshaller
    {
        public static DescribeBackupPlanListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPlanListResponse describeBackupPlanListResponse = new DescribeBackupPlanListResponse();

			describeBackupPlanListResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPlanListResponse.Success = _ctx.BooleanValue("DescribeBackupPlanList.Success");
			describeBackupPlanListResponse.ErrCode = _ctx.StringValue("DescribeBackupPlanList.ErrCode");
			describeBackupPlanListResponse.ErrMessage = _ctx.StringValue("DescribeBackupPlanList.ErrMessage");
			describeBackupPlanListResponse.HttpStatusCode = _ctx.IntegerValue("DescribeBackupPlanList.HttpStatusCode");
			describeBackupPlanListResponse.RequestId = _ctx.StringValue("DescribeBackupPlanList.RequestId");
			describeBackupPlanListResponse.TotalPages = _ctx.IntegerValue("DescribeBackupPlanList.TotalPages");
			describeBackupPlanListResponse.PageSize = _ctx.IntegerValue("DescribeBackupPlanList.PageSize");
			describeBackupPlanListResponse.PageNum = _ctx.IntegerValue("DescribeBackupPlanList.PageNum");
			describeBackupPlanListResponse.TotalElements = _ctx.IntegerValue("DescribeBackupPlanList.TotalElements");

			List<DescribeBackupPlanListResponse.DescribeBackupPlanList_BackupPlanDetail> describeBackupPlanListResponse_items = new List<DescribeBackupPlanListResponse.DescribeBackupPlanList_BackupPlanDetail>();
			for (int i = 0; i < _ctx.Length("DescribeBackupPlanList.Items.Length"); i++) {
				DescribeBackupPlanListResponse.DescribeBackupPlanList_BackupPlanDetail backupPlanDetail = new DescribeBackupPlanListResponse.DescribeBackupPlanList_BackupPlanDetail();
				backupPlanDetail.BackupPlanId = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupPlanId");
				backupPlanDetail.SourceEndpointInstanceType = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].SourceEndpointInstanceType");
				backupPlanDetail.SourceEndpointRegion = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].SourceEndpointRegion");
				backupPlanDetail.SourceEndpointInstanceID = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].SourceEndpointInstanceID");
				backupPlanDetail.SourceEndpointIpPort = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].SourceEndpointIpPort");
				backupPlanDetail.SourceEndpointDatabaseName = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].SourceEndpointDatabaseName");
				backupPlanDetail.SourceEndpointUserName = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].SourceEndpointUserName");
				backupPlanDetail.BackupObjects = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupObjects");
				backupPlanDetail.BackupGatewayId = _ctx.LongValue("DescribeBackupPlanList.Items["+ i +"].BackupGatewayId");
				backupPlanDetail.OSSBucketRegion = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].OSSBucketRegion");
				backupPlanDetail.OSSBucketName = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].OSSBucketName");
				backupPlanDetail.BackupPeriod = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupPeriod");
				backupPlanDetail.BackupStartTime = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupStartTime");
				backupPlanDetail.EnableBackupLog = _ctx.BooleanValue("DescribeBackupPlanList.Items["+ i +"].EnableBackupLog");
				backupPlanDetail.BackupRetentionPeriod = _ctx.IntegerValue("DescribeBackupPlanList.Items["+ i +"].BackupRetentionPeriod");
				backupPlanDetail.DuplicationInfrequentAccessPeriod = _ctx.IntegerValue("DescribeBackupPlanList.Items["+ i +"].DuplicationInfrequentAccessPeriod");
				backupPlanDetail.DuplicationArchivePeriod = _ctx.IntegerValue("DescribeBackupPlanList.Items["+ i +"].DuplicationArchivePeriod");
				backupPlanDetail.BackupPlanName = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupPlanName");
				backupPlanDetail.SourceEndpointOracleSID = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].SourceEndpointOracleSID");
				backupPlanDetail.InstanceClass = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].InstanceClass");
				backupPlanDetail.BackupMethod = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupMethod");
				backupPlanDetail.BackupPlanCreateTime = _ctx.LongValue("DescribeBackupPlanList.Items["+ i +"].BackupPlanCreateTime");
				backupPlanDetail.BackupPlanStatus = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupPlanStatus");
				backupPlanDetail.BeginTimestampForRestore = _ctx.LongValue("DescribeBackupPlanList.Items["+ i +"].BeginTimestampForRestore");
				backupPlanDetail.EndTimestampForRestore = _ctx.LongValue("DescribeBackupPlanList.Items["+ i +"].EndTimestampForRestore");
				backupPlanDetail.OpenBackupSetAutoDownload = _ctx.BooleanValue("DescribeBackupPlanList.Items["+ i +"].OpenBackupSetAutoDownload");
				backupPlanDetail.BackupSetDownloadTargetType = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupSetDownloadTargetType");
				backupPlanDetail.BackupSetDownloadDir = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupSetDownloadDir");
				backupPlanDetail.BackupSetDownloadGatewayId = _ctx.LongValue("DescribeBackupPlanList.Items["+ i +"].BackupSetDownloadGatewayId");
				backupPlanDetail.BackupSetDownloadFullDataFormat = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupSetDownloadFullDataFormat");
				backupPlanDetail.BackupSetDownloadIncrementDataFormat = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupSetDownloadIncrementDataFormat");
				backupPlanDetail.CrossAliyunId = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].CrossAliyunId");
				backupPlanDetail.CrossRoleName = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].CrossRoleName");
				backupPlanDetail.BackupStorageType = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].BackupStorageType");
				backupPlanDetail.ErrMessage = _ctx.StringValue("DescribeBackupPlanList.Items["+ i +"].ErrMessage");

				describeBackupPlanListResponse_items.Add(backupPlanDetail);
			}
			describeBackupPlanListResponse.Items = describeBackupPlanListResponse_items;
        
			return describeBackupPlanListResponse;
        }
    }
}
