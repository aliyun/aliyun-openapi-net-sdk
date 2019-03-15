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
using Aliyun.Acs.Ubsms.Model.V20150623;

namespace Aliyun.Acs.Ubsms.Transform.V20150623
{
    public class DescribeBusinessStatusResponseUnmarshaller
    {
        public static DescribeBusinessStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBusinessStatusResponse describeBusinessStatusResponse = new DescribeBusinessStatusResponse();

			describeBusinessStatusResponse.HttpResponse = context.HttpResponse;
			describeBusinessStatusResponse.RequestId = context.StringValue("DescribeBusinessStatus.RequestId");
			describeBusinessStatusResponse.Success = context.BooleanValue("DescribeBusinessStatus.Success");

			List<DescribeBusinessStatusResponse.DescribeBusinessStatus_UserBusinessStatus> describeBusinessStatusResponse_userBusinessStatusList = new List<DescribeBusinessStatusResponse.DescribeBusinessStatus_UserBusinessStatus>();
			for (int i = 0; i < context.Length("DescribeBusinessStatus.UserBusinessStatusList.Length"); i++) {
				DescribeBusinessStatusResponse.DescribeBusinessStatus_UserBusinessStatus userBusinessStatus = new DescribeBusinessStatusResponse.DescribeBusinessStatus_UserBusinessStatus();
				userBusinessStatus.Uid = context.StringValue("DescribeBusinessStatus.UserBusinessStatusList["+ i +"].Uid");
				userBusinessStatus.ServiceCode = context.StringValue("DescribeBusinessStatus.UserBusinessStatusList["+ i +"].ServiceCode");

				List<DescribeBusinessStatusResponse.DescribeBusinessStatus_UserBusinessStatus.DescribeBusinessStatus_Status> userBusinessStatus_statuses = new List<DescribeBusinessStatusResponse.DescribeBusinessStatus_UserBusinessStatus.DescribeBusinessStatus_Status>();
				for (int j = 0; j < context.Length("DescribeBusinessStatus.UserBusinessStatusList["+ i +"].Statuses.Length"); j++) {
					DescribeBusinessStatusResponse.DescribeBusinessStatus_UserBusinessStatus.DescribeBusinessStatus_Status status = new DescribeBusinessStatusResponse.DescribeBusinessStatus_UserBusinessStatus.DescribeBusinessStatus_Status();
					status.StatusKey = context.StringValue("DescribeBusinessStatus.UserBusinessStatusList["+ i +"].Statuses["+ j +"].StatusKey");
					status.StatusValue = context.StringValue("DescribeBusinessStatus.UserBusinessStatusList["+ i +"].Statuses["+ j +"].StatusValue");

					userBusinessStatus_statuses.Add(status);
				}
				userBusinessStatus.Statuses = userBusinessStatus_statuses;

				describeBusinessStatusResponse_userBusinessStatusList.Add(userBusinessStatus);
			}
			describeBusinessStatusResponse.UserBusinessStatusList = describeBusinessStatusResponse_userBusinessStatusList;
        
			return describeBusinessStatusResponse;
        }
    }
}
