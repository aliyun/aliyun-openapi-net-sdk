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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeSecurityEventOperationStatusResponseUnmarshaller
    {
        public static DescribeSecurityEventOperationStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecurityEventOperationStatusResponse describeSecurityEventOperationStatusResponse = new DescribeSecurityEventOperationStatusResponse();

			describeSecurityEventOperationStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeSecurityEventOperationStatusResponse.RequestId = _ctx.StringValue("DescribeSecurityEventOperationStatus.RequestId");

			DescribeSecurityEventOperationStatusResponse.DescribeSecurityEventOperationStatus_SecurityEventOperationStatusResponse securityEventOperationStatusResponse = new DescribeSecurityEventOperationStatusResponse.DescribeSecurityEventOperationStatus_SecurityEventOperationStatusResponse();
			securityEventOperationStatusResponse.TaskStatus = _ctx.StringValue("DescribeSecurityEventOperationStatus.SecurityEventOperationStatusResponse.TaskStatus");

			List<DescribeSecurityEventOperationStatusResponse.DescribeSecurityEventOperationStatus_SecurityEventOperationStatusResponse.DescribeSecurityEventOperationStatus_SecurityEventOperationStatus> securityEventOperationStatusResponse_securityEventOperationStatuses = new List<DescribeSecurityEventOperationStatusResponse.DescribeSecurityEventOperationStatus_SecurityEventOperationStatusResponse.DescribeSecurityEventOperationStatus_SecurityEventOperationStatus>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityEventOperationStatus.SecurityEventOperationStatusResponse.SecurityEventOperationStatuses.Length"); i++) {
				DescribeSecurityEventOperationStatusResponse.DescribeSecurityEventOperationStatus_SecurityEventOperationStatusResponse.DescribeSecurityEventOperationStatus_SecurityEventOperationStatus securityEventOperationStatus = new DescribeSecurityEventOperationStatusResponse.DescribeSecurityEventOperationStatus_SecurityEventOperationStatusResponse.DescribeSecurityEventOperationStatus_SecurityEventOperationStatus();
				securityEventOperationStatus.SecurityEventId = _ctx.StringValue("DescribeSecurityEventOperationStatus.SecurityEventOperationStatusResponse.SecurityEventOperationStatuses["+ i +"].SecurityEventId");
				securityEventOperationStatus.Status = _ctx.StringValue("DescribeSecurityEventOperationStatus.SecurityEventOperationStatusResponse.SecurityEventOperationStatuses["+ i +"].Status");
				securityEventOperationStatus.ErrorCode = _ctx.StringValue("DescribeSecurityEventOperationStatus.SecurityEventOperationStatusResponse.SecurityEventOperationStatuses["+ i +"].ErrorCode");

				securityEventOperationStatusResponse_securityEventOperationStatuses.Add(securityEventOperationStatus);
			}
			securityEventOperationStatusResponse.SecurityEventOperationStatuses = securityEventOperationStatusResponse_securityEventOperationStatuses;
			describeSecurityEventOperationStatusResponse.SecurityEventOperationStatusResponse = securityEventOperationStatusResponse;
        
			return describeSecurityEventOperationStatusResponse;
        }
    }
}
