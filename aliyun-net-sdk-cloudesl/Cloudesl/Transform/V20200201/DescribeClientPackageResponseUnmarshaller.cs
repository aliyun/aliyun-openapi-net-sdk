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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeClientPackageResponseUnmarshaller
    {
        public static DescribeClientPackageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClientPackageResponse describeClientPackageResponse = new DescribeClientPackageResponse();

			describeClientPackageResponse.HttpResponse = _ctx.HttpResponse;
			describeClientPackageResponse.ErrorMessage = _ctx.StringValue("DescribeClientPackage.ErrorMessage");
			describeClientPackageResponse.ErrorCode = _ctx.StringValue("DescribeClientPackage.ErrorCode");
			describeClientPackageResponse.Description = _ctx.StringValue("DescribeClientPackage.Description");
			describeClientPackageResponse.Message = _ctx.StringValue("DescribeClientPackage.Message");
			describeClientPackageResponse.UpdateType = _ctx.StringValue("DescribeClientPackage.UpdateType");
			describeClientPackageResponse.Url = _ctx.StringValue("DescribeClientPackage.Url");
			describeClientPackageResponse.Version = _ctx.StringValue("DescribeClientPackage.Version");
			describeClientPackageResponse.DynamicCode = _ctx.StringValue("DescribeClientPackage.DynamicCode");
			describeClientPackageResponse.Code = _ctx.StringValue("DescribeClientPackage.Code");
			describeClientPackageResponse.DynamicMessage = _ctx.StringValue("DescribeClientPackage.DynamicMessage");
			describeClientPackageResponse.RequestId = _ctx.StringValue("DescribeClientPackage.RequestId");
			describeClientPackageResponse.Success = _ctx.BooleanValue("DescribeClientPackage.Success");
        
			return describeClientPackageResponse;
        }
    }
}
