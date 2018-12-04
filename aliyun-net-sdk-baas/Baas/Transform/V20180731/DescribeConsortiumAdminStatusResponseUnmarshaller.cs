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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeConsortiumAdminStatusResponseUnmarshaller
    {
        public static DescribeConsortiumAdminStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConsortiumAdminStatusResponse describeConsortiumAdminStatusResponse = new DescribeConsortiumAdminStatusResponse();

			describeConsortiumAdminStatusResponse.HttpResponse = context.HttpResponse;
			describeConsortiumAdminStatusResponse.RequestId = context.StringValue("DescribeConsortiumAdminStatus.RequestId");
			describeConsortiumAdminStatusResponse.Success = context.BooleanValue("DescribeConsortiumAdminStatus.Success");
			describeConsortiumAdminStatusResponse.ErrorCode = context.IntegerValue("DescribeConsortiumAdminStatus.ErrorCode");

			List<DescribeConsortiumAdminStatusResponse.DescribeConsortiumAdminStatus_ConsortimeAdminStatus> describeConsortiumAdminStatusResponse_result = new List<DescribeConsortiumAdminStatusResponse.DescribeConsortiumAdminStatus_ConsortimeAdminStatus>();
			for (int i = 0; i < context.Length("DescribeConsortiumAdminStatus.Result.Length"); i++) {
				DescribeConsortiumAdminStatusResponse.DescribeConsortiumAdminStatus_ConsortimeAdminStatus consortimeAdminStatus = new DescribeConsortiumAdminStatusResponse.DescribeConsortiumAdminStatus_ConsortimeAdminStatus();
				consortimeAdminStatus.ConsortiumId = context.StringValue("DescribeConsortiumAdminStatus.Result["+ i +"].ConsortiumId");
				consortimeAdminStatus.ConsortiumAdministrator = context.BooleanValue("DescribeConsortiumAdminStatus.Result["+ i +"].ConsortiumAdministrator");

				describeConsortiumAdminStatusResponse_result.Add(consortimeAdminStatus);
			}
			describeConsortiumAdminStatusResponse.Result = describeConsortiumAdminStatusResponse_result;
        
			return describeConsortiumAdminStatusResponse;
        }
    }
}