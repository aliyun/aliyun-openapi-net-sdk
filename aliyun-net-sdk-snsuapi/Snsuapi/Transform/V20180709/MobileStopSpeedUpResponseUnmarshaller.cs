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
using Aliyun.Acs.Snsuapi.Model.V20180709;

namespace Aliyun.Acs.Snsuapi.Transform.V20180709
{
    public class MobileStopSpeedUpResponseUnmarshaller
    {
        public static MobileStopSpeedUpResponse Unmarshall(UnmarshallerContext context)
        {
			MobileStopSpeedUpResponse mobileStopSpeedUpResponse = new MobileStopSpeedUpResponse();

			mobileStopSpeedUpResponse.HttpResponse = context.HttpResponse;
			mobileStopSpeedUpResponse.RequestId = context.StringValue("MobileStopSpeedUp.RequestId");
			mobileStopSpeedUpResponse.ResultCode = context.StringValue("MobileStopSpeedUp.ResultCode");
			mobileStopSpeedUpResponse.ResultMessage = context.StringValue("MobileStopSpeedUp.ResultMessage");
			mobileStopSpeedUpResponse.ResultModule = context.BooleanValue("MobileStopSpeedUp.ResultModule");
        
			return mobileStopSpeedUpResponse;
        }
    }
}
