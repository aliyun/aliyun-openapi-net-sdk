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
using Aliyun.Acs.Yundun_ds.Model.V20190103;

namespace Aliyun.Acs.Yundun_ds.Transform.V20190103
{
    public class DescribeUserStatusResponseUnmarshaller
    {
        public static DescribeUserStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserStatusResponse describeUserStatusResponse = new DescribeUserStatusResponse();

			describeUserStatusResponse.HttpResponse = context.HttpResponse;
			describeUserStatusResponse.RequestId = context.StringValue("DescribeUserStatus.RequestId");

			DescribeUserStatusResponse.DescribeUserStatus_UserStatus userStatus = new DescribeUserStatusResponse.DescribeUserStatus_UserStatus();
			userStatus.Authed = context.BooleanValue("DescribeUserStatus.UserStatus.Authed");
			userStatus.Buyed = context.BooleanValue("DescribeUserStatus.UserStatus.Buyed");
			userStatus.OssBucketSet = context.BooleanValue("DescribeUserStatus.UserStatus.OssBucketSet");
			userStatus.OdpsSet = context.BooleanValue("DescribeUserStatus.UserStatus.OdpsSet");
			userStatus.RdsSet = context.BooleanValue("DescribeUserStatus.UserStatus.RdsSet");
			userStatus.AccessKeyId = context.StringValue("DescribeUserStatus.UserStatus.AccessKeyId");
			describeUserStatusResponse.UserStatus = userStatus;
        
			return describeUserStatusResponse;
        }
    }
}
