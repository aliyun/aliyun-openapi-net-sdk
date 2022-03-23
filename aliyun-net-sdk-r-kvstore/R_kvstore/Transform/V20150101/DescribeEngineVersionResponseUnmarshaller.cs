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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeEngineVersionResponseUnmarshaller
    {
        public static DescribeEngineVersionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEngineVersionResponse describeEngineVersionResponse = new DescribeEngineVersionResponse();

			describeEngineVersionResponse.HttpResponse = _ctx.HttpResponse;
			describeEngineVersionResponse.IsLatestVersion = _ctx.BooleanValue("DescribeEngineVersion.IsLatestVersion");
			describeEngineVersionResponse.RequestId = _ctx.StringValue("DescribeEngineVersion.RequestId");
			describeEngineVersionResponse.ProxyMinorVersion = _ctx.StringValue("DescribeEngineVersion.ProxyMinorVersion");
			describeEngineVersionResponse.DBVersionRelease = _ctx.StringValue("DescribeEngineVersion.DBVersionRelease");
			describeEngineVersionResponse.ProxyVersionRelease = _ctx.StringValue("DescribeEngineVersion.ProxyVersionRelease");
			describeEngineVersionResponse.EnableUpgradeMajorVersion = _ctx.BooleanValue("DescribeEngineVersion.EnableUpgradeMajorVersion");
			describeEngineVersionResponse.EnableUpgradeMinorVersion = _ctx.BooleanValue("DescribeEngineVersion.EnableUpgradeMinorVersion");
			describeEngineVersionResponse.MajorVersion = _ctx.StringValue("DescribeEngineVersion.MajorVersion");
			describeEngineVersionResponse.Engine = _ctx.StringValue("DescribeEngineVersion.Engine");
			describeEngineVersionResponse.MinorVersion = _ctx.StringValue("DescribeEngineVersion.MinorVersion");
        
			return describeEngineVersionResponse;
        }
    }
}
