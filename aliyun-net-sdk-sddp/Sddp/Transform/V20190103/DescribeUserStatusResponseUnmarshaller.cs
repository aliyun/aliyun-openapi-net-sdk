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
			userStatus.Authed = _ctx.BooleanValue("DescribeUserStatus.UserStatus.Authed");
			userStatus.Buyed = _ctx.BooleanValue("DescribeUserStatus.UserStatus.Buyed");
			userStatus.OssBucketSet = _ctx.BooleanValue("DescribeUserStatus.UserStatus.OssBucketSet");
			userStatus.OdpsSet = _ctx.BooleanValue("DescribeUserStatus.UserStatus.OdpsSet");
			userStatus.RdsSet = _ctx.BooleanValue("DescribeUserStatus.UserStatus.RdsSet");
			userStatus.AuthProductList = _ctx.StringValue("DescribeUserStatus.UserStatus.AuthProductList");
			userStatus.AccessKeyId = _ctx.StringValue("DescribeUserStatus.UserStatus.AccessKeyId");
			userStatus.Trail = _ctx.BooleanValue("DescribeUserStatus.UserStatus.Trail");
			userStatus.InstanceStatus = _ctx.IntegerValue("DescribeUserStatus.UserStatus.InstanceStatus");
			userStatus.InstanceId = _ctx.StringValue("DescribeUserStatus.UserStatus.InstanceId");
			userStatus.RemainDays = _ctx.IntegerValue("DescribeUserStatus.UserStatus.RemainDays");
			userStatus.RenewStatus = _ctx.BooleanValue("DescribeUserStatus.UserStatus.RenewStatus");
			userStatus.InstanceNum = _ctx.IntegerValue("DescribeUserStatus.UserStatus.InstanceNum");
			userStatus.UseInstanceNum = _ctx.IntegerValue("DescribeUserStatus.UserStatus.UseInstanceNum");
			userStatus.OssSize = _ctx.LongValue("DescribeUserStatus.UserStatus.OssSize");
			userStatus.UseOssSize = _ctx.LongValue("DescribeUserStatus.UserStatus.UseOssSize");
			userStatus.ChargeType = _ctx.StringValue("DescribeUserStatus.UserStatus.ChargeType");
			userStatus.LabStatus = _ctx.IntegerValue("DescribeUserStatus.UserStatus.LabStatus");
			userStatus.Version = _ctx.StringValue("DescribeUserStatus.UserStatus.Version");
			userStatus.DbAuditStatus = _ctx.IntegerValue("DescribeUserStatus.UserStatus.DbAuditStatus");
			userStatus.AssetScanned = _ctx.BooleanValue("DescribeUserStatus.UserStatus.AssetScanned");
			userStatus.AuditUpgradeStatus = _ctx.BooleanValue("DescribeUserStatus.UserStatus.AuditUpgradeStatus");
			userStatus.SensitiveTable = _ctx.LongValue("DescribeUserStatus.UserStatus.SensitiveTable");
			userStatus.SensitiveObject = _ctx.LongValue("DescribeUserStatus.UserStatus.SensitiveObject");
			userStatus.DatamaskColumns = _ctx.LongValue("DescribeUserStatus.UserStatus.DatamaskColumns");
			userStatus.AlarmCount = _ctx.LongValue("DescribeUserStatus.UserStatus.AlarmCount");
			userStatus.DivulgeCount = _ctx.LongValue("DescribeUserStatus.UserStatus.DivulgeCount");
			userStatus.DisplayTime = _ctx.StringValue("DescribeUserStatus.UserStatus.DisplayTime");
			userStatus.TotalDataMaskColumns = _ctx.LongValue("DescribeUserStatus.UserStatus.TotalDataMaskColumns");
			userStatus.DataMaskTasks = _ctx.LongValue("DescribeUserStatus.UserStatus.DataMaskTasks");
			userStatus.DataMaskColumns = _ctx.LongValue("DescribeUserStatus.UserStatus.DataMaskColumns");
			userStatus.SensitiveTables = _ctx.LongValue("DescribeUserStatus.UserStatus.SensitiveTables");
			userStatus.SensitiveObjects = _ctx.LongValue("DescribeUserStatus.UserStatus.SensitiveObjects");
			userStatus.IncSensitiveTables = _ctx.LongValue("DescribeUserStatus.UserStatus.IncSensitiveTables");
			userStatus.IncSensitiveObjects = _ctx.LongValue("DescribeUserStatus.UserStatus.IncSensitiveObjects");
			userStatus.SensitiveTop = _ctx.StringValue("DescribeUserStatus.UserStatus.SensitiveTop");
			userStatus.DlpTotalCount = _ctx.LongValue("DescribeUserStatus.UserStatus.DlpTotalCount");
			userStatus.DlpCount = _ctx.LongValue("DescribeUserStatus.UserStatus.DlpCount");
			userStatus.SensitiveTotalTop = _ctx.StringValue("DescribeUserStatus.UserStatus.SensitiveTotalTop");
			describeUserStatusResponse.UserStatus = userStatus;
        
			return describeUserStatusResponse;
        }
    }
}
