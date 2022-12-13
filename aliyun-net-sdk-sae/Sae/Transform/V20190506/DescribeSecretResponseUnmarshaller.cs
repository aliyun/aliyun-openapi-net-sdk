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
    public class DescribeSecretResponseUnmarshaller
    {
        public static DescribeSecretResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecretResponse describeSecretResponse = new DescribeSecretResponse();

			describeSecretResponse.HttpResponse = _ctx.HttpResponse;
			describeSecretResponse.RequestId = _ctx.StringValue("DescribeSecret.RequestId");
			describeSecretResponse.Message = _ctx.StringValue("DescribeSecret.Message");
			describeSecretResponse.TraceId = _ctx.StringValue("DescribeSecret.TraceId");
			describeSecretResponse.ErrorCode = _ctx.StringValue("DescribeSecret.ErrorCode");
			describeSecretResponse.Code = _ctx.StringValue("DescribeSecret.Code");
			describeSecretResponse.Success = _ctx.BooleanValue("DescribeSecret.Success");

			DescribeSecretResponse.DescribeSecret_Data data = new DescribeSecretResponse.DescribeSecret_Data();
			data.NamespaceId = _ctx.StringValue("DescribeSecret.Data.NamespaceId");
			data.SecretId = _ctx.LongValue("DescribeSecret.Data.SecretId");
			data.SecretName = _ctx.StringValue("DescribeSecret.Data.SecretName");
			data.SecretType = _ctx.StringValue("DescribeSecret.Data.SecretType");
			data.SecretData = _ctx.StringValue("DescribeSecret.Data.SecretData");
			data.CreateTime = _ctx.LongValue("DescribeSecret.Data.CreateTime");
			data.UpdateTime = _ctx.LongValue("DescribeSecret.Data.UpdateTime");

			List<DescribeSecretResponse.DescribeSecret_Data.DescribeSecret_RelateApp> data_relateApps = new List<DescribeSecretResponse.DescribeSecret_Data.DescribeSecret_RelateApp>();
			for (int i = 0; i < _ctx.Length("DescribeSecret.Data.RelateApps.Length"); i++) {
				DescribeSecretResponse.DescribeSecret_Data.DescribeSecret_RelateApp relateApp = new DescribeSecretResponse.DescribeSecret_Data.DescribeSecret_RelateApp();
				relateApp.AppId = _ctx.StringValue("DescribeSecret.Data.RelateApps["+ i +"].AppId");
				relateApp.AppName = _ctx.StringValue("DescribeSecret.Data.RelateApps["+ i +"].AppName");

				data_relateApps.Add(relateApp);
			}
			data.RelateApps = data_relateApps;
			describeSecretResponse.Data = data;
        
			return describeSecretResponse;
        }
    }
}
