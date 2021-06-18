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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeVersionConfigResponseUnmarshaller
    {
        public static DescribeVersionConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVersionConfigResponse describeVersionConfigResponse = new DescribeVersionConfigResponse();

			describeVersionConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeVersionConfigResponse.RequestId = _ctx.StringValue("DescribeVersionConfig.RequestId");
			describeVersionConfigResponse.AssetLevel = _ctx.IntegerValue("DescribeVersionConfig.AssetLevel");
			describeVersionConfigResponse.AvdsFlag = _ctx.IntegerValue("DescribeVersionConfig.AvdsFlag");
			describeVersionConfigResponse.CreateTime = _ctx.LongValue("DescribeVersionConfig.CreateTime");
			describeVersionConfigResponse.Flag = _ctx.IntegerValue("DescribeVersionConfig.Flag");
			describeVersionConfigResponse.InstanceId = _ctx.StringValue("DescribeVersionConfig.InstanceId");
			describeVersionConfigResponse.IsSasOpening = _ctx.BooleanValue("DescribeVersionConfig.IsSasOpening");
			describeVersionConfigResponse.IsTrialVersion = _ctx.IntegerValue("DescribeVersionConfig.IsTrialVersion");
			describeVersionConfigResponse.LogCapacity = _ctx.IntegerValue("DescribeVersionConfig.LogCapacity");
			describeVersionConfigResponse.LogTime = _ctx.IntegerValue("DescribeVersionConfig.LogTime");
			describeVersionConfigResponse.ReleaseTime = _ctx.LongValue("DescribeVersionConfig.ReleaseTime");
			describeVersionConfigResponse.SasLog = _ctx.IntegerValue("DescribeVersionConfig.SasLog");
			describeVersionConfigResponse.SasScreen = _ctx.IntegerValue("DescribeVersionConfig.SasScreen");
			describeVersionConfigResponse.Version = _ctx.IntegerValue("DescribeVersionConfig.Version");
			describeVersionConfigResponse.UserDefinedAlarms = _ctx.IntegerValue("DescribeVersionConfig.UserDefinedAlarms");
			describeVersionConfigResponse.WebLock = _ctx.IntegerValue("DescribeVersionConfig.WebLock");
			describeVersionConfigResponse.WebLockAuthCount = _ctx.LongValue("DescribeVersionConfig.WebLockAuthCount");
			describeVersionConfigResponse.AppWhiteListAuthCount = _ctx.LongValue("DescribeVersionConfig.AppWhiteListAuthCount");
			describeVersionConfigResponse.AppWhiteList = _ctx.IntegerValue("DescribeVersionConfig.AppWhiteList");
			describeVersionConfigResponse.SlsCapacity = _ctx.LongValue("DescribeVersionConfig.SlsCapacity");
			describeVersionConfigResponse.GmtCreate = _ctx.LongValue("DescribeVersionConfig.GmtCreate");
			describeVersionConfigResponse.LastInstanceReleaseTime = _ctx.LongValue("DescribeVersionConfig.LastInstanceReleaseTime");
			describeVersionConfigResponse.IsOverBalance = _ctx.BooleanValue("DescribeVersionConfig.IsOverBalance");
			describeVersionConfigResponse.LastTrailEndTime = _ctx.LongValue("DescribeVersionConfig.LastTrailEndTime");
			describeVersionConfigResponse.HoneypotCapacity = _ctx.LongValue("DescribeVersionConfig.HoneypotCapacity");
			describeVersionConfigResponse.ImageScanCapacity = _ctx.LongValue("DescribeVersionConfig.ImageScanCapacity");
			describeVersionConfigResponse.VmCores = _ctx.IntegerValue("DescribeVersionConfig.VmCores");
			describeVersionConfigResponse.IsPaidUser = _ctx.BooleanValue("DescribeVersionConfig.IsPaidUser");
			describeVersionConfigResponse.HighestVersion = _ctx.IntegerValue("DescribeVersionConfig.HighestVersion");
			describeVersionConfigResponse.MVAuthCount = _ctx.IntegerValue("DescribeVersionConfig.MVAuthCount");
			describeVersionConfigResponse.MVUnusedAuthCount = _ctx.IntegerValue("DescribeVersionConfig.MVUnusedAuthCount");
			describeVersionConfigResponse.AllowPartialBuy = _ctx.IntegerValue("DescribeVersionConfig.AllowPartialBuy");
        
			return describeVersionConfigResponse;
        }
    }
}
