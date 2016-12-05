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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Push.Model.V20160801;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class QueryAppInfoResponseUnmarshaller
    {
        public static QueryAppInfoResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAppInfoResponse queryAppInfoResponse = new QueryAppInfoResponse();

			queryAppInfoResponse.HttpResponse = context.HttpResponse;
			queryAppInfoResponse.RequestId = context.StringValue("QueryAppInfo.RequestId");

			QueryAppInfoResponse.AppInfo_ appInfo = new QueryAppInfoResponse.AppInfo_();
			appInfo.AppKey = context.LongValue("QueryAppInfo.AppInfo.AppKey");
			appInfo.AppId = context.StringValue("QueryAppInfo.AppInfo.AppId");
			appInfo.PushAppId = context.StringValue("QueryAppInfo.AppInfo.PushAppId");
			appInfo.AppName = context.StringValue("QueryAppInfo.AppInfo.AppName");
			appInfo.Description = context.StringValue("QueryAppInfo.AppInfo.Description");
			appInfo.IndustryId = context.IntegerValue("QueryAppInfo.AppInfo.IndustryId");
			appInfo.AndroidStatus = context.IntegerValue("QueryAppInfo.AppInfo.AndroidStatus");
			appInfo.IOSStatus = context.IntegerValue("QueryAppInfo.AppInfo.IOSStatus");
			appInfo.DeviceCount = context.LongValue("QueryAppInfo.AppInfo.DeviceCount");
			appInfo.AppStatus = context.IntegerValue("QueryAppInfo.AppInfo.AppStatus");
			appInfo.Status = context.IntegerValue("QueryAppInfo.AppInfo.Status");

			QueryAppInfoResponse.AppInfo_.Extension_ extension = new QueryAppInfoResponse.AppInfo_.Extension_();
			extension.XmAppSecretKey = context.StringValue("QueryAppInfo.AppInfo.Extension.XmAppSecretKey");
			extension.HwAppKey = context.StringValue("QueryAppInfo.AppInfo.Extension.HwAppKey");
			extension.HwAppSecretKey = context.StringValue("QueryAppInfo.AppInfo.Extension.HwAppSecretKey");
			appInfo.Extension = extension;
			queryAppInfoResponse.AppInfo = appInfo;
        
			return queryAppInfoResponse;
        }
    }
}