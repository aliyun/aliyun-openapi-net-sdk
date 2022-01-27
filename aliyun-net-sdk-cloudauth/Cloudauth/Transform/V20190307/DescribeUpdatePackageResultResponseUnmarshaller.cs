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
using Aliyun.Acs.Cloudauth.Model.V20190307;

namespace Aliyun.Acs.Cloudauth.Transform.V20190307
{
    public class DescribeUpdatePackageResultResponseUnmarshaller
    {
        public static DescribeUpdatePackageResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUpdatePackageResultResponse describeUpdatePackageResultResponse = new DescribeUpdatePackageResultResponse();

			describeUpdatePackageResultResponse.HttpResponse = _ctx.HttpResponse;
			describeUpdatePackageResultResponse.RequestId = _ctx.StringValue("DescribeUpdatePackageResult.RequestId");

			DescribeUpdatePackageResultResponse.DescribeUpdatePackageResult_AppInfo appInfo = new DescribeUpdatePackageResultResponse.DescribeUpdatePackageResult_AppInfo();
			appInfo.Id = _ctx.LongValue("DescribeUpdatePackageResult.AppInfo.Id");
			appInfo.Name = _ctx.StringValue("DescribeUpdatePackageResult.AppInfo.Name");
			appInfo.PackageName = _ctx.StringValue("DescribeUpdatePackageResult.AppInfo.PackageName");
			appInfo.Icon = _ctx.StringValue("DescribeUpdatePackageResult.AppInfo.Icon");
			appInfo.StartDate = _ctx.StringValue("DescribeUpdatePackageResult.AppInfo.StartDate");
			appInfo.EndDate = _ctx.StringValue("DescribeUpdatePackageResult.AppInfo.EndDate");
			appInfo.Type = _ctx.IntegerValue("DescribeUpdatePackageResult.AppInfo.Type");

			DescribeUpdatePackageResultResponse.DescribeUpdatePackageResult_AppInfo.DescribeUpdatePackageResult_PackageInfo packageInfo = new DescribeUpdatePackageResultResponse.DescribeUpdatePackageResult_AppInfo.DescribeUpdatePackageResult_PackageInfo();
			packageInfo.Version = _ctx.StringValue("DescribeUpdatePackageResult.AppInfo.PackageInfo.Version");
			appInfo.PackageInfo = packageInfo;

			DescribeUpdatePackageResultResponse.DescribeUpdatePackageResult_AppInfo.DescribeUpdatePackageResult_DebugPackageInfo debugPackageInfo = new DescribeUpdatePackageResultResponse.DescribeUpdatePackageResult_AppInfo.DescribeUpdatePackageResult_DebugPackageInfo();
			debugPackageInfo.Version = _ctx.StringValue("DescribeUpdatePackageResult.AppInfo.DebugPackageInfo.Version");
			appInfo.DebugPackageInfo = debugPackageInfo;
			describeUpdatePackageResultResponse.AppInfo = appInfo;
        
			return describeUpdatePackageResultResponse;
        }
    }
}
