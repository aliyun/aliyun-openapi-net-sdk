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
        public static DescribeAppEnvironmentDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAppEnvironmentDetailResponse describeAppEnvironmentDetailResponse = new DescribeAppEnvironmentDetailResponse();

			describeAppEnvironmentDetailResponse.HttpResponse = context.HttpResponse;
			describeAppEnvironmentDetailResponse.Code = context.IntegerValue("DescribeAppEnvironmentDetail.Code");
			describeAppEnvironmentDetailResponse.RequestId = context.StringValue("DescribeAppEnvironmentDetail.RequestId");
			describeAppEnvironmentDetailResponse.ErrMsg = context.StringValue("DescribeAppEnvironmentDetail.ErrMsg");

			DescribeAppEnvironmentDetailResponse.DescribeAppEnvironmentDetail_Result result = new DescribeAppEnvironmentDetailResponse.DescribeAppEnvironmentDetail_Result();
			result.AppId = context.LongValue("DescribeAppEnvironmentDetail.Result.AppId");
			result.EnvId = context.LongValue("DescribeAppEnvironmentDetail.Result.EnvId");
			result.EnvName = context.StringValue("DescribeAppEnvironmentDetail.Result.EnvName");
			result.EnvType = context.IntegerValue("DescribeAppEnvironmentDetail.Result.EnvType");
			result.EnvTypeName = context.StringValue("DescribeAppEnvironmentDetail.Result.EnvTypeName");
			result.AppSchemaId = context.LongValue("DescribeAppEnvironmentDetail.Result.AppSchemaId");
			result.Region = context.StringValue("DescribeAppEnvironmentDetail.Result.Region");
			result.Replicas = context.IntegerValue("DescribeAppEnvironmentDetail.Result.Replicas");
			describeAppEnvironmentDetailResponse.Result = result;
        
			return describeAppEnvironmentDetailResponse;
        }
    }
}
