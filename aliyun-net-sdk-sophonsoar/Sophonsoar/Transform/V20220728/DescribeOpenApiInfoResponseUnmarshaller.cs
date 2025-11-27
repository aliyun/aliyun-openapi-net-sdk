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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeOpenApiInfoResponseUnmarshaller
    {
        public static DescribeOpenApiInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOpenApiInfoResponse describeOpenApiInfoResponse = new DescribeOpenApiInfoResponse();

			describeOpenApiInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeOpenApiInfoResponse.RequestId = _ctx.StringValue("DescribeOpenApiInfo.RequestId");

			DescribeOpenApiInfoResponse.DescribeOpenApiInfo_Data data = new DescribeOpenApiInfoResponse.DescribeOpenApiInfo_Data();
			data.OutputParams = _ctx.StringValue("DescribeOpenApiInfo.Data.OutputParams");
			data.InputParams = _ctx.StringValue("DescribeOpenApiInfo.Data.InputParams");
			data.ResponseDemo = _ctx.StringValue("DescribeOpenApiInfo.Data.ResponseDemo");
			data.Title = _ctx.StringValue("DescribeOpenApiInfo.Data.Title");
			data.Summary = _ctx.StringValue("DescribeOpenApiInfo.Data.Summary");
			data.Description = _ctx.StringValue("DescribeOpenApiInfo.Data.Description");
			describeOpenApiInfoResponse.Data = data;
        
			return describeOpenApiInfoResponse;
        }
    }
}
