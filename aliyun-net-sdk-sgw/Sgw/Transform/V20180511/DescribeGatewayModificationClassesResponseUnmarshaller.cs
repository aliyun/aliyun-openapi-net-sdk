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
    public class DescribeGatewayModificationClassesResponseUnmarshaller
    {
        public static DescribeGatewayModificationClassesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayModificationClassesResponse describeGatewayModificationClassesResponse = new DescribeGatewayModificationClassesResponse();

			describeGatewayModificationClassesResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayModificationClassesResponse.RequestId = _ctx.StringValue("DescribeGatewayModificationClasses.RequestId");
			describeGatewayModificationClassesResponse.Success = _ctx.BooleanValue("DescribeGatewayModificationClasses.Success");
			describeGatewayModificationClassesResponse.Code = _ctx.StringValue("DescribeGatewayModificationClasses.Code");
			describeGatewayModificationClassesResponse.Message = _ctx.StringValue("DescribeGatewayModificationClasses.Message");

			List<DescribeGatewayModificationClassesResponse.DescribeGatewayModificationClasses_TargetGatewayClass> describeGatewayModificationClassesResponse_targetGatewayClasses = new List<DescribeGatewayModificationClassesResponse.DescribeGatewayModificationClasses_TargetGatewayClass>();
			for (int i = 0; i < _ctx.Length("DescribeGatewayModificationClasses.TargetGatewayClasses.Length"); i++) {
				DescribeGatewayModificationClassesResponse.DescribeGatewayModificationClasses_TargetGatewayClass targetGatewayClass = new DescribeGatewayModificationClassesResponse.DescribeGatewayModificationClasses_TargetGatewayClass();
				targetGatewayClass.GatewayClass = _ctx.StringValue("DescribeGatewayModificationClasses.TargetGatewayClasses["+ i +"].GatewayClass");
				targetGatewayClass.IsAvailable = _ctx.BooleanValue("DescribeGatewayModificationClasses.TargetGatewayClasses["+ i +"].IsAvailable");

				describeGatewayModificationClassesResponse_targetGatewayClasses.Add(targetGatewayClass);
			}
			describeGatewayModificationClassesResponse.TargetGatewayClasses = describeGatewayModificationClassesResponse_targetGatewayClasses;
        
			return describeGatewayModificationClassesResponse;
        }
    }
}
