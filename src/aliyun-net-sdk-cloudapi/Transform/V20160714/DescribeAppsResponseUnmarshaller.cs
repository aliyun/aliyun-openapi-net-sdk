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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeAppsResponseUnmarshaller
    {
        public static DescribeAppsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeAppsResponse describeAppsResponse = new DescribeAppsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeApps.RequestId"),
                TotalCount = context.IntegerValue("DescribeApps.TotalCount"),
                PageSize = context.IntegerValue("DescribeApps.PageSize"),
                PageNumber = context.IntegerValue("DescribeApps.PageNumber")
            };
            List<DescribeAppsResponse.AppItem> apps = new List<DescribeAppsResponse.AppItem>();
			for (int i = 0; i < context.Length("DescribeApps.Apps.Length"); i++) {
                DescribeAppsResponse.AppItem appItem = new DescribeAppsResponse.AppItem()
                {
                    AppId = context.LongValue($"DescribeApps.Apps[{i}].AppId"),
                    AppName = context.StringValue($"DescribeApps.Apps[{i}].AppName"),
                    Description = context.StringValue($"DescribeApps.Apps[{i}].Description")
                };
                apps.Add(appItem);
			}
			describeAppsResponse.Apps = apps;
        
			return describeAppsResponse;
        }
    }
}