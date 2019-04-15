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
    public class DescribeScreenVersionConfigResponseUnmarshaller
    {
        public static DescribeScreenVersionConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScreenVersionConfigResponse describeScreenVersionConfigResponse = new DescribeScreenVersionConfigResponse();

			describeScreenVersionConfigResponse.HttpResponse = context.HttpResponse;
			describeScreenVersionConfigResponse.RequestId = context.StringValue("DescribeScreenVersionConfig.RequestId");
			describeScreenVersionConfigResponse.AssetLevel = context.IntegerValue("DescribeScreenVersionConfig.AssetLevel");
			describeScreenVersionConfigResponse.AvdsFlag = context.IntegerValue("DescribeScreenVersionConfig.AvdsFlag");
			describeScreenVersionConfigResponse.CreateTime = context.LongValue("DescribeScreenVersionConfig.CreateTime");
			describeScreenVersionConfigResponse.Flag = context.IntegerValue("DescribeScreenVersionConfig.Flag");
			describeScreenVersionConfigResponse.InstanceId = context.StringValue("DescribeScreenVersionConfig.InstanceId");
			describeScreenVersionConfigResponse.IsSasOpening = context.BooleanValue("DescribeScreenVersionConfig.IsSasOpening");
			describeScreenVersionConfigResponse.IsTrialVersion = context.IntegerValue("DescribeScreenVersionConfig.IsTrialVersion");
			describeScreenVersionConfigResponse.LogCapacity = context.IntegerValue("DescribeScreenVersionConfig.LogCapacity");
			describeScreenVersionConfigResponse.LogTime = context.IntegerValue("DescribeScreenVersionConfig.LogTime");
			describeScreenVersionConfigResponse.ReleaseTime = context.LongValue("DescribeScreenVersionConfig.ReleaseTime");
			describeScreenVersionConfigResponse.SasLog = context.IntegerValue("DescribeScreenVersionConfig.SasLog");
			describeScreenVersionConfigResponse.SasScreen = context.IntegerValue("DescribeScreenVersionConfig.SasScreen");
			describeScreenVersionConfigResponse.Version = context.IntegerValue("DescribeScreenVersionConfig.Version");
        
			return describeScreenVersionConfigResponse;
        }
    }
}
