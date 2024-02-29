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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeUserStatusResponseUnmarshaller
    {
        public static DescribeUserStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserStatusResponse describeUserStatusResponse = new DescribeUserStatusResponse();

			describeUserStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeUserStatusResponse.RequestId = _ctx.StringValue("DescribeUserStatus.RequestId");

			DescribeUserStatusResponse.DescribeUserStatus_UserStatus userStatus = new DescribeUserStatusResponse.DescribeUserStatus_UserStatus();
			userStatus.UseOssSize = _ctx.LongValue("DescribeUserStatus.UserStatus.UseOssSize");
			userStatus.UseInstanceNum = _ctx.IntegerValue("DescribeUserStatus.UserStatus.UseInstanceNum");
			userStatus.InstanceNum = _ctx.IntegerValue("DescribeUserStatus.UserStatus.InstanceNum");
			userStatus.ChargeType = _ctx.StringValue("DescribeUserStatus.UserStatus.ChargeType");
			userStatus.IncSensitiveTables = _ctx.LongValue("DescribeUserStatus.UserStatus.IncSensitiveTables");
			userStatus.AuditUpgradeStatus = _ctx.BooleanValue("DescribeUserStatus.UserStatus.AuditUpgradeStatus");
			userStatus.DataMaskTasks = _ctx.LongValue("DescribeUserStatus.UserStatus.DataMaskTasks");
			userStatus.Authed = _ctx.BooleanValue("DescribeUserStatus.UserStatus.Authed");
			userStatus.LabStatus = _ctx.IntegerValue("DescribeUserStatus.UserStatus.LabStatus");
			userStatus.Version = _ctx.StringValue("DescribeUserStatus.UserStatus.Version");
			userStatus.OdpsSet = _ctx.BooleanValue("DescribeUserStatus.UserStatus.OdpsSet");
			userStatus.OssBucketSet = _ctx.BooleanValue("DescribeUserStatus.UserStatus.OssBucketSet");
			userStatus.SensitiveTable = _ctx.LongValue("DescribeUserStatus.UserStatus.SensitiveTable");
			userStatus.RemainDays = _ctx.IntegerValue("DescribeUserStatus.UserStatus.RemainDays");
			userStatus.TotalDataMaskColumns = _ctx.LongValue("DescribeUserStatus.UserStatus.TotalDataMaskColumns");
			userStatus.DatamaskColumns = _ctx.LongValue("DescribeUserStatus.UserStatus.DatamaskColumns");
			userStatus.AuthProductList = _ctx.StringValue("DescribeUserStatus.UserStatus.AuthProductList");
			userStatus.Trail = _ctx.BooleanValue("DescribeUserStatus.UserStatus.Trail");
			userStatus.DivulgeCount = _ctx.LongValue("DescribeUserStatus.UserStatus.DivulgeCount");
			userStatus.RdsSet = _ctx.BooleanValue("DescribeUserStatus.UserStatus.RdsSet");
			userStatus.DbAuditStatus = _ctx.IntegerValue("DescribeUserStatus.UserStatus.DbAuditStatus");
			userStatus.RenewStatus = _ctx.BooleanValue("DescribeUserStatus.UserStatus.RenewStatus");
			userStatus.SensitiveObjects = _ctx.LongValue("DescribeUserStatus.UserStatus.SensitiveObjects");
			userStatus.DataMaskColumns = _ctx.LongValue("DescribeUserStatus.UserStatus.DataMaskColumns");
			userStatus.DlpTotalCount = _ctx.LongValue("DescribeUserStatus.UserStatus.DlpTotalCount");
			userStatus.SensitiveObject = _ctx.LongValue("DescribeUserStatus.UserStatus.SensitiveObject");
			userStatus.DlpCount = _ctx.LongValue("DescribeUserStatus.UserStatus.DlpCount");
			userStatus.InstanceId = _ctx.StringValue("DescribeUserStatus.UserStatus.InstanceId");
			userStatus.AccessKeyId = _ctx.StringValue("DescribeUserStatus.UserStatus.AccessKeyId");
			userStatus.OssSize = _ctx.LongValue("DescribeUserStatus.UserStatus.OssSize");
			userStatus.SensitiveTotalTop = _ctx.StringValue("DescribeUserStatus.UserStatus.SensitiveTotalTop");
			userStatus.SensitiveTables = _ctx.LongValue("DescribeUserStatus.UserStatus.SensitiveTables");
			userStatus.SensitiveTop = _ctx.StringValue("DescribeUserStatus.UserStatus.SensitiveTop");
			userStatus.Purchased = _ctx.BooleanValue("DescribeUserStatus.UserStatus.Purchased");
			userStatus.Buyed = _ctx.BooleanValue("DescribeUserStatus.UserStatus.Buyed");
			userStatus.IncSensitiveObjects = _ctx.LongValue("DescribeUserStatus.UserStatus.IncSensitiveObjects");
			userStatus.InstanceStatus = _ctx.IntegerValue("DescribeUserStatus.UserStatus.InstanceStatus");
			userStatus.AssetScanned = _ctx.BooleanValue("DescribeUserStatus.UserStatus.AssetScanned");
			userStatus.AlarmCount = _ctx.LongValue("DescribeUserStatus.UserStatus.AlarmCount");
			userStatus.DisplayTime = _ctx.StringValue("DescribeUserStatus.UserStatus.DisplayTime");
			userStatus.DataManagerRole = _ctx.IntegerValue("DescribeUserStatus.UserStatus.DataManagerRole");
			userStatus.ReleaseDays = _ctx.IntegerValue("DescribeUserStatus.UserStatus.ReleaseDays");
			userStatus.AuditClosable = _ctx.BooleanValue("DescribeUserStatus.UserStatus.AuditClosable");
			userStatus.AuditReleasable = _ctx.BooleanValue("DescribeUserStatus.UserStatus.AuditReleasable");
			userStatus.ReleaseTime = _ctx.LongValue("DescribeUserStatus.UserStatus.ReleaseTime");
			userStatus.InstanceTotalCount = _ctx.LongValue("DescribeUserStatus.UserStatus.InstanceTotalCount");
			userStatus.OssTotalSize = _ctx.LongValue("DescribeUserStatus.UserStatus.OssTotalSize");
			userStatus.UseAgentAudit = _ctx.BooleanValue("DescribeUserStatus.UserStatus.UseAgentAudit");
			userStatus.ProtectionDays = _ctx.IntegerValue("DescribeUserStatus.UserStatus.ProtectionDays");
			describeUserStatusResponse.UserStatus = userStatus;
        
			return describeUserStatusResponse;
        }
    }
}
