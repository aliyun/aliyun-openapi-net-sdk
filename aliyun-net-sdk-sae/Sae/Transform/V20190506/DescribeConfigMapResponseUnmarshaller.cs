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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeConfigMapResponseUnmarshaller
    {
        public static DescribeConfigMapResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeConfigMapResponse describeConfigMapResponse = new DescribeConfigMapResponse();

			describeConfigMapResponse.HttpResponse = _ctx.HttpResponse;
			describeConfigMapResponse.RequestId = _ctx.StringValue("DescribeConfigMap.RequestId");
			describeConfigMapResponse.Code = _ctx.StringValue("DescribeConfigMap.Code");
			describeConfigMapResponse.Message = _ctx.StringValue("DescribeConfigMap.Message");
			describeConfigMapResponse.ErrorCode = _ctx.StringValue("DescribeConfigMap.ErrorCode");
			describeConfigMapResponse.TraceId = _ctx.StringValue("DescribeConfigMap.TraceId");
			describeConfigMapResponse.Success = _ctx.BooleanValue("DescribeConfigMap.Success");

			DescribeConfigMapResponse.DescribeConfigMap_Data data = new DescribeConfigMapResponse.DescribeConfigMap_Data();
			data.ConfigMapId = _ctx.LongValue("DescribeConfigMap.Data.ConfigMapId");
			data.Name = _ctx.StringValue("DescribeConfigMap.Data.Name");
			data.NamespaceId = _ctx.StringValue("DescribeConfigMap.Data.NamespaceId");
			data.Description = _ctx.StringValue("DescribeConfigMap.Data.Description");
			data.Data = _ctx.StringValue("DescribeConfigMap.Data.Data");
			data.CreateTime = _ctx.LongValue("DescribeConfigMap.Data.CreateTime");
			data.UpdateTime = _ctx.LongValue("DescribeConfigMap.Data.UpdateTime");

			List<DescribeConfigMapResponse.DescribeConfigMap_Data.DescribeConfigMap_RelateApp> data_relateApps = new List<DescribeConfigMapResponse.DescribeConfigMap_Data.DescribeConfigMap_RelateApp>();
			for (int i = 0; i < _ctx.Length("DescribeConfigMap.Data.RelateApps.Length"); i++) {
				DescribeConfigMapResponse.DescribeConfigMap_Data.DescribeConfigMap_RelateApp relateApp = new DescribeConfigMapResponse.DescribeConfigMap_Data.DescribeConfigMap_RelateApp();
				relateApp.AppId = _ctx.StringValue("DescribeConfigMap.Data.RelateApps["+ i +"].AppId");
				relateApp.AppName = _ctx.StringValue("DescribeConfigMap.Data.RelateApps["+ i +"].AppName");

				data_relateApps.Add(relateApp);
			}
			data.RelateApps = data_relateApps;
			describeConfigMapResponse.Data = data;
        
			return describeConfigMapResponse;
        }
    }
}
