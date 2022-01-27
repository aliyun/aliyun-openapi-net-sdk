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
    public class DescribeAppInfoResponseUnmarshaller
    {
        public static DescribeAppInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAppInfoResponse describeAppInfoResponse = new DescribeAppInfoResponse();

			describeAppInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeAppInfoResponse.RequestId = _ctx.StringValue("DescribeAppInfo.RequestId");
			describeAppInfoResponse.PageSize = _ctx.IntegerValue("DescribeAppInfo.PageSize");
			describeAppInfoResponse.CurrentPage = _ctx.IntegerValue("DescribeAppInfo.CurrentPage");
			describeAppInfoResponse.TotalCount = _ctx.IntegerValue("DescribeAppInfo.TotalCount");

			List<DescribeAppInfoResponse.DescribeAppInfo_AppInfo> describeAppInfoResponse_appInfoList = new List<DescribeAppInfoResponse.DescribeAppInfo_AppInfo>();
			for (int i = 0; i < _ctx.Length("DescribeAppInfo.AppInfoList.Length"); i++) {
				DescribeAppInfoResponse.DescribeAppInfo_AppInfo appInfo = new DescribeAppInfoResponse.DescribeAppInfo_AppInfo();
				appInfo.Id = _ctx.LongValue("DescribeAppInfo.AppInfoList["+ i +"].Id");
				appInfo.Name = _ctx.StringValue("DescribeAppInfo.AppInfoList["+ i +"].Name");
				appInfo.PackageName = _ctx.StringValue("DescribeAppInfo.AppInfoList["+ i +"].PackageName");
				appInfo.Icon = _ctx.StringValue("DescribeAppInfo.AppInfoList["+ i +"].Icon");
				appInfo.StartDate = _ctx.StringValue("DescribeAppInfo.AppInfoList["+ i +"].StartDate");
				appInfo.EndDate = _ctx.StringValue("DescribeAppInfo.AppInfoList["+ i +"].EndDate");
				appInfo.Type = _ctx.IntegerValue("DescribeAppInfo.AppInfoList["+ i +"].Type");

				DescribeAppInfoResponse.DescribeAppInfo_AppInfo.DescribeAppInfo_PackageInfo packageInfo = new DescribeAppInfoResponse.DescribeAppInfo_AppInfo.DescribeAppInfo_PackageInfo();
				packageInfo.Version = _ctx.StringValue("DescribeAppInfo.AppInfoList["+ i +"].PackageInfo.Version");
				appInfo.PackageInfo = packageInfo;

				DescribeAppInfoResponse.DescribeAppInfo_AppInfo.DescribeAppInfo_DebugPackageInfo debugPackageInfo = new DescribeAppInfoResponse.DescribeAppInfo_AppInfo.DescribeAppInfo_DebugPackageInfo();
				debugPackageInfo.Version = _ctx.StringValue("DescribeAppInfo.AppInfoList["+ i +"].DebugPackageInfo.Version");
				appInfo.DebugPackageInfo = debugPackageInfo;

				describeAppInfoResponse_appInfoList.Add(appInfo);
			}
			describeAppInfoResponse.AppInfoList = describeAppInfoResponse_appInfoList;
        
			return describeAppInfoResponse;
        }
    }
}
