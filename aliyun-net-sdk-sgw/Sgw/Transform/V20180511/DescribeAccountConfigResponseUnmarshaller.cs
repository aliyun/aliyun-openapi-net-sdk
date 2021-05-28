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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeAccountConfigResponseUnmarshaller
    {
        public static DescribeAccountConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccountConfigResponse describeAccountConfigResponse = new DescribeAccountConfigResponse();

			describeAccountConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeAccountConfigResponse.RequestId = _ctx.StringValue("DescribeAccountConfig.RequestId");
			describeAccountConfigResponse.Success = _ctx.BooleanValue("DescribeAccountConfig.Success");
			describeAccountConfigResponse.Code = _ctx.StringValue("DescribeAccountConfig.Code");
			describeAccountConfigResponse.Message = _ctx.StringValue("DescribeAccountConfig.Message");
			describeAccountConfigResponse.IsSupportServerSideEncryption = _ctx.BooleanValue("DescribeAccountConfig.IsSupportServerSideEncryption");
			describeAccountConfigResponse.IsSupportClientSideEncryption = _ctx.BooleanValue("DescribeAccountConfig.IsSupportClientSideEncryption");
			describeAccountConfigResponse.IsSupportGatewayLogging = _ctx.BooleanValue("DescribeAccountConfig.IsSupportGatewayLogging");
			describeAccountConfigResponse.IsSupportElasticGatewayBeta = _ctx.BooleanValue("DescribeAccountConfig.IsSupportElasticGatewayBeta");
        
			return describeAccountConfigResponse;
        }
    }
}
