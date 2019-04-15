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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeVersionConfigResponseUnmarshaller
    {
        public static DescribeVersionConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVersionConfigResponse describeVersionConfigResponse = new DescribeVersionConfigResponse();

			describeVersionConfigResponse.HttpResponse = context.HttpResponse;
			describeVersionConfigResponse.RequestId = context.StringValue("DescribeVersionConfig.RequestId");
			describeVersionConfigResponse.AssetLevel = context.IntegerValue("DescribeVersionConfig.AssetLevel");
			describeVersionConfigResponse.AvdsFlag = context.IntegerValue("DescribeVersionConfig.AvdsFlag");
			describeVersionConfigResponse.CreateTime = context.LongValue("DescribeVersionConfig.CreateTime");
			describeVersionConfigResponse.Flag = context.IntegerValue("DescribeVersionConfig.Flag");
			describeVersionConfigResponse.InstanceId = context.StringValue("DescribeVersionConfig.InstanceId");
			describeVersionConfigResponse.IsSasOpening = context.BooleanValue("DescribeVersionConfig.IsSasOpening");
			describeVersionConfigResponse.IsTrialVersion = context.IntegerValue("DescribeVersionConfig.IsTrialVersion");
			describeVersionConfigResponse.LogCapacity = context.IntegerValue("DescribeVersionConfig.LogCapacity");
			describeVersionConfigResponse.LogTime = context.IntegerValue("DescribeVersionConfig.LogTime");
			describeVersionConfigResponse.ReleaseTime = context.LongValue("DescribeVersionConfig.ReleaseTime");
			describeVersionConfigResponse.SasLog = context.IntegerValue("DescribeVersionConfig.SasLog");
			describeVersionConfigResponse.SasScreen = context.IntegerValue("DescribeVersionConfig.SasScreen");
			describeVersionConfigResponse.Version = context.IntegerValue("DescribeVersionConfig.Version");
			describeVersionConfigResponse.UserDefinedAlarms = context.IntegerValue("DescribeVersionConfig.UserDefinedAlarms");
			describeVersionConfigResponse.WebLock = context.IntegerValue("DescribeVersionConfig.WebLock");
			describeVersionConfigResponse.WebLockAuthCount = context.LongValue("DescribeVersionConfig.WebLockAuthCount");
			describeVersionConfigResponse.AppWhiteListAuthCount = context.LongValue("DescribeVersionConfig.AppWhiteListAuthCount");
			describeVersionConfigResponse.AppWhiteList = context.IntegerValue("DescribeVersionConfig.AppWhiteList");
			describeVersionConfigResponse.SlsCapacity = context.LongValue("DescribeVersionConfig.SlsCapacity");
        
			return describeVersionConfigResponse;
        }
    }
}
