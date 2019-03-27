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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class GetNumberRegionInfoResponseUnmarshaller
    {
        public static GetNumberRegionInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetNumberRegionInfoResponse getNumberRegionInfoResponse = new GetNumberRegionInfoResponse();

			getNumberRegionInfoResponse.HttpResponse = context.HttpResponse;
			getNumberRegionInfoResponse.RequestId = context.StringValue("GetNumberRegionInfo.RequestId");
			getNumberRegionInfoResponse.Success = context.BooleanValue("GetNumberRegionInfo.Success");
			getNumberRegionInfoResponse.Code = context.StringValue("GetNumberRegionInfo.Code");
			getNumberRegionInfoResponse.Message = context.StringValue("GetNumberRegionInfo.Message");

			GetNumberRegionInfoResponse.GetNumberRegionInfo_PhoneNumber phoneNumber = new GetNumberRegionInfoResponse.GetNumberRegionInfo_PhoneNumber();
			phoneNumber.Number = context.StringValue("GetNumberRegionInfo.PhoneNumber.Number");
			phoneNumber.Province = context.StringValue("GetNumberRegionInfo.PhoneNumber.Province");
			phoneNumber.City = context.StringValue("GetNumberRegionInfo.PhoneNumber.City");
			getNumberRegionInfoResponse.PhoneNumber = phoneNumber;
        
			return getNumberRegionInfoResponse;
        }
    }
}
