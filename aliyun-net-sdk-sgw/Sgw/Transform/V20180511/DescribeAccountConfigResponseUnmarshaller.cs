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
        public static DescribeAccountConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccountConfigResponse describeAccountConfigResponse = new DescribeAccountConfigResponse();

			describeAccountConfigResponse.HttpResponse = context.HttpResponse;
			describeAccountConfigResponse.RequestId = context.StringValue("DescribeAccountConfig.RequestId");
			describeAccountConfigResponse.Success = context.BooleanValue("DescribeAccountConfig.Success");
			describeAccountConfigResponse.Code = context.StringValue("DescribeAccountConfig.Code");
			describeAccountConfigResponse.Message = context.StringValue("DescribeAccountConfig.Message");
			describeAccountConfigResponse.IsSupportServerSideEncryption = context.BooleanValue("DescribeAccountConfig.IsSupportServerSideEncryption");
			describeAccountConfigResponse.IsSupportClientSideEncryption = context.BooleanValue("DescribeAccountConfig.IsSupportClientSideEncryption");
			describeAccountConfigResponse.IsSupportGatewayLogging = context.BooleanValue("DescribeAccountConfig.IsSupportGatewayLogging");
			describeAccountConfigResponse.IsSupportElasticGatewayBeta = context.BooleanValue("DescribeAccountConfig.IsSupportElasticGatewayBeta");
        
			return describeAccountConfigResponse;
        }
    }
}
