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
using Aliyun.Acs.Dytnsapi.Model.V20200217;

namespace Aliyun.Acs.Dytnsapi.Transform.V20200217
{
    public class DescribePhoneNumberOnlineTimeResponseUnmarshaller
    {
        public static DescribePhoneNumberOnlineTimeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePhoneNumberOnlineTimeResponse describePhoneNumberOnlineTimeResponse = new DescribePhoneNumberOnlineTimeResponse();

			describePhoneNumberOnlineTimeResponse.HttpResponse = _ctx.HttpResponse;
			describePhoneNumberOnlineTimeResponse.RequestId = _ctx.StringValue("DescribePhoneNumberOnlineTime.RequestId");
			describePhoneNumberOnlineTimeResponse.Code = _ctx.StringValue("DescribePhoneNumberOnlineTime.Code");
			describePhoneNumberOnlineTimeResponse.Message = _ctx.StringValue("DescribePhoneNumberOnlineTime.Message");

			DescribePhoneNumberOnlineTimeResponse.DescribePhoneNumberOnlineTime_Data data = new DescribePhoneNumberOnlineTimeResponse.DescribePhoneNumberOnlineTime_Data();
			data.VerifyResult = _ctx.StringValue("DescribePhoneNumberOnlineTime.Data.VerifyResult");
			describePhoneNumberOnlineTimeResponse.Data = data;
        
			return describePhoneNumberOnlineTimeResponse;
        }
    }
}
