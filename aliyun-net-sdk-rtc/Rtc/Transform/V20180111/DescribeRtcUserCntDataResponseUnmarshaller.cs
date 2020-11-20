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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRtcUserCntDataResponseUnmarshaller
    {
        public static DescribeRtcUserCntDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcUserCntDataResponse describeRtcUserCntDataResponse = new DescribeRtcUserCntDataResponse();

			describeRtcUserCntDataResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcUserCntDataResponse.RequestId = _ctx.StringValue("DescribeRtcUserCntData.RequestId");

			List<DescribeRtcUserCntDataResponse.DescribeRtcUserCntData_UserCntModule> describeRtcUserCntDataResponse_userCntDataPerInterval = new List<DescribeRtcUserCntDataResponse.DescribeRtcUserCntData_UserCntModule>();
			for (int i = 0; i < _ctx.Length("DescribeRtcUserCntData.UserCntDataPerInterval.Length"); i++) {
				DescribeRtcUserCntDataResponse.DescribeRtcUserCntData_UserCntModule userCntModule = new DescribeRtcUserCntDataResponse.DescribeRtcUserCntData_UserCntModule();
				userCntModule.TimeStamp = _ctx.StringValue("DescribeRtcUserCntData.UserCntDataPerInterval["+ i +"].TimeStamp");
				userCntModule.ActiveUserCnt = _ctx.LongValue("DescribeRtcUserCntData.UserCntDataPerInterval["+ i +"].ActiveUserCnt");

				describeRtcUserCntDataResponse_userCntDataPerInterval.Add(userCntModule);
			}
			describeRtcUserCntDataResponse.UserCntDataPerInterval = describeRtcUserCntDataResponse_userCntDataPerInterval;
        
			return describeRtcUserCntDataResponse;
        }
    }
}
