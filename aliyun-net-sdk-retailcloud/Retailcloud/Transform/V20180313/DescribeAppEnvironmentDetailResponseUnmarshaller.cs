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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DescribeAppEnvironmentDetailResponseUnmarshaller
    {
        public static DescribeAppEnvironmentDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAppEnvironmentDetailResponse describeAppEnvironmentDetailResponse = new DescribeAppEnvironmentDetailResponse();

			describeAppEnvironmentDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeAppEnvironmentDetailResponse.Code = _ctx.IntegerValue("DescribeAppEnvironmentDetail.Code");
			describeAppEnvironmentDetailResponse.RequestId = _ctx.StringValue("DescribeAppEnvironmentDetail.RequestId");
			describeAppEnvironmentDetailResponse.ErrMsg = _ctx.StringValue("DescribeAppEnvironmentDetail.ErrMsg");

			DescribeAppEnvironmentDetailResponse.DescribeAppEnvironmentDetail_Result result = new DescribeAppEnvironmentDetailResponse.DescribeAppEnvironmentDetail_Result();
			result.AppId = _ctx.LongValue("DescribeAppEnvironmentDetail.Result.AppId");
			result.EnvId = _ctx.LongValue("DescribeAppEnvironmentDetail.Result.EnvId");
			result.EnvName = _ctx.StringValue("DescribeAppEnvironmentDetail.Result.EnvName");
			result.EnvType = _ctx.IntegerValue("DescribeAppEnvironmentDetail.Result.EnvType");
			result.EnvTypeName = _ctx.StringValue("DescribeAppEnvironmentDetail.Result.EnvTypeName");
			result.AppSchemaId = _ctx.LongValue("DescribeAppEnvironmentDetail.Result.AppSchemaId");
			result.Region = _ctx.StringValue("DescribeAppEnvironmentDetail.Result.Region");
			result.Replicas = _ctx.IntegerValue("DescribeAppEnvironmentDetail.Result.Replicas");
			describeAppEnvironmentDetailResponse.Result = result;
        
			return describeAppEnvironmentDetailResponse;
        }
    }
}
