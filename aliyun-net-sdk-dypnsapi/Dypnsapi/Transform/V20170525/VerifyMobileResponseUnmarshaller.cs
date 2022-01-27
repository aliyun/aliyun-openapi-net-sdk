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
using Aliyun.Acs.Dypnsapi.Model.V20170525;

namespace Aliyun.Acs.Dypnsapi.Transform.V20170525
{
    public class VerifyMobileResponseUnmarshaller
    {
        public static VerifyMobileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			VerifyMobileResponse verifyMobileResponse = new VerifyMobileResponse();

			verifyMobileResponse.HttpResponse = _ctx.HttpResponse;
			verifyMobileResponse.RequestId = _ctx.StringValue("VerifyMobile.RequestId");
			verifyMobileResponse.Code = _ctx.StringValue("VerifyMobile.Code");
			verifyMobileResponse.Message = _ctx.StringValue("VerifyMobile.Message");

			VerifyMobileResponse.VerifyMobile_GateVerifyResultDTO gateVerifyResultDTO = new VerifyMobileResponse.VerifyMobile_GateVerifyResultDTO();
			gateVerifyResultDTO.VerifyId = _ctx.StringValue("VerifyMobile.GateVerifyResultDTO.VerifyId");
			gateVerifyResultDTO.VerifyResult = _ctx.StringValue("VerifyMobile.GateVerifyResultDTO.VerifyResult");
			verifyMobileResponse.GateVerifyResultDTO = gateVerifyResultDTO;
        
			return verifyMobileResponse;
        }
    }
}
