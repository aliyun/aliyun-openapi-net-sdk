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
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSQLInjectionInfosResponseUnmarshaller
    {
        public static DescribeSQLInjectionInfosResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSQLInjectionInfosResponse describeSQLInjectionInfosResponse = new DescribeSQLInjectionInfosResponse();

			describeSQLInjectionInfosResponse.HttpResponse = context.HttpResponse;
			describeSQLInjectionInfosResponse.RequestId = context.StringValue("DescribeSQLInjectionInfos.RequestId");
			describeSQLInjectionInfosResponse.Engine = context.StringValue("DescribeSQLInjectionInfos.Engine");
			describeSQLInjectionInfosResponse.TotalRecordCount = context.IntegerValue("DescribeSQLInjectionInfos.TotalRecordCount");
			describeSQLInjectionInfosResponse.PageNumber = context.IntegerValue("DescribeSQLInjectionInfos.PageNumber");
			describeSQLInjectionInfosResponse.PageRecordCount = context.IntegerValue("DescribeSQLInjectionInfos.PageRecordCount");

			List<DescribeSQLInjectionInfosResponse.DescribeSQLInjectionInfos_SQLInjectionInfo> describeSQLInjectionInfosResponse_items = new List<DescribeSQLInjectionInfosResponse.DescribeSQLInjectionInfos_SQLInjectionInfo>();
			for (int i = 0; i < context.Length("DescribeSQLInjectionInfos.Items.Length"); i++) {
				DescribeSQLInjectionInfosResponse.DescribeSQLInjectionInfos_SQLInjectionInfo sQLInjectionInfo = new DescribeSQLInjectionInfosResponse.DescribeSQLInjectionInfos_SQLInjectionInfo();
				sQLInjectionInfo.DBName = context.StringValue("DescribeSQLInjectionInfos.Items["+ i +"].DBName");
				sQLInjectionInfo.SQLText = context.StringValue("DescribeSQLInjectionInfos.Items["+ i +"].SQLText");
				sQLInjectionInfo.LatencyTime = context.StringValue("DescribeSQLInjectionInfos.Items["+ i +"].LatencyTime");
				sQLInjectionInfo.HostAddress = context.StringValue("DescribeSQLInjectionInfos.Items["+ i +"].HostAddress");
				sQLInjectionInfo.ExecuteTime = context.StringValue("DescribeSQLInjectionInfos.Items["+ i +"].ExecuteTime");
				sQLInjectionInfo.AccountName = context.StringValue("DescribeSQLInjectionInfos.Items["+ i +"].AccountName");
				sQLInjectionInfo.EffectRowCount = context.StringValue("DescribeSQLInjectionInfos.Items["+ i +"].EffectRowCount");

				describeSQLInjectionInfosResponse_items.Add(sQLInjectionInfo);
			}
			describeSQLInjectionInfosResponse.Items = describeSQLInjectionInfosResponse_items;
        
			return describeSQLInjectionInfosResponse;
        }
    }
}