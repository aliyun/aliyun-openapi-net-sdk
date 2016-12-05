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
    public class QueryAppConfigResponseUnmarshaller
    {
        public static QueryAppConfigResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAppConfigResponse queryAppConfigResponse = new QueryAppConfigResponse();

			queryAppConfigResponse.HttpResponse = context.HttpResponse;
			queryAppConfigResponse.RequestId = context.StringValue("QueryAppConfig.RequestId");

			QueryAppConfigResponse.AppConfig_ appConfig = new QueryAppConfigResponse.AppConfig_();
			appConfig.AppKey = context.LongValue("QueryAppConfig.AppConfig.AppKey");
			appConfig.AppId = context.StringValue("QueryAppConfig.AppConfig.AppId");
			appConfig.AppName = context.StringValue("QueryAppConfig.AppConfig.AppName");
			appConfig.BundleId = context.StringValue("QueryAppConfig.AppConfig.BundleId");
			appConfig.PackageName = context.StringValue("QueryAppConfig.AppConfig.PackageName");
			appConfig.BoxFlag = context.BooleanValue("QueryAppConfig.AppConfig.BoxFlag");
			appConfig.Android = context.BooleanValue("QueryAppConfig.AppConfig.Android");
			appConfig.IOS = context.BooleanValue("QueryAppConfig.AppConfig.IOS");
			appConfig.ProductCertKey = context.StringValue("QueryAppConfig.AppConfig.ProductCertKey");
			appConfig.ProductCertPass = context.StringValue("QueryAppConfig.AppConfig.ProductCertPass");
			appConfig.DevCertKey = context.StringValue("QueryAppConfig.AppConfig.DevCertKey");
			appConfig.DevCertPass = context.StringValue("QueryAppConfig.AppConfig.DevCertPass");
			queryAppConfigResponse.AppConfig = appConfig;
        
			return queryAppConfigResponse;
        }
    }
}