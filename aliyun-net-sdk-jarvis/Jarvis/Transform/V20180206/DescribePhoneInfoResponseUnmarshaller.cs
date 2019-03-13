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
using Aliyun.Acs.jarvis.Model.V20180206;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribePhoneInfoResponseUnmarshaller
    {
        public static DescribePhoneInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePhoneInfoResponse describePhoneInfoResponse = new DescribePhoneInfoResponse();

			describePhoneInfoResponse.HttpResponse = context.HttpResponse;
			describePhoneInfoResponse.RequestId = context.StringValue("DescribePhoneInfo.RequestId");
			describePhoneInfoResponse.Module = context.StringValue("DescribePhoneInfo.Module");
			describePhoneInfoResponse.PhoneNum = context.LongValue("DescribePhoneInfo.PhoneNum");
			describePhoneInfoResponse.RiskLevel = context.LongValue("DescribePhoneInfo.RiskLevel");
			describePhoneInfoResponse.DetectTime = context.StringValue("DescribePhoneInfo.DetectTime");
        
			return describePhoneInfoResponse;
        }
    }
}
