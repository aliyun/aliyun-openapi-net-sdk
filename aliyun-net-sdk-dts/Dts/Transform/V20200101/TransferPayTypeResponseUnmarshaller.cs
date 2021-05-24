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
using Aliyun.Acs.Dts.Model.V20200101;

namespace Aliyun.Acs.Dts.Transform.V20200101
{
    public class TransferPayTypeResponseUnmarshaller
    {
        public static TransferPayTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TransferPayTypeResponse transferPayTypeResponse = new TransferPayTypeResponse();

			transferPayTypeResponse.HttpResponse = _ctx.HttpResponse;
			transferPayTypeResponse.Code = _ctx.StringValue("TransferPayType.Code");
			transferPayTypeResponse.DynamicMessage = _ctx.StringValue("TransferPayType.DynamicMessage");
			transferPayTypeResponse.ErrCode = _ctx.StringValue("TransferPayType.ErrCode");
			transferPayTypeResponse.ErrMessage = _ctx.StringValue("TransferPayType.ErrMessage");
			transferPayTypeResponse.HttpStatusCode = _ctx.IntegerValue("TransferPayType.HttpStatusCode");
			transferPayTypeResponse.RequestId = _ctx.StringValue("TransferPayType.RequestId");
			transferPayTypeResponse.Success = _ctx.BooleanValue("TransferPayType.Success");
			transferPayTypeResponse.DtsJobId = _ctx.StringValue("TransferPayType.DtsJobId");
			transferPayTypeResponse.InstanceId = _ctx.StringValue("TransferPayType.InstanceId");
			transferPayTypeResponse.ChargeType = _ctx.StringValue("TransferPayType.ChargeType");
			transferPayTypeResponse.EndTime = _ctx.StringValue("TransferPayType.EndTime");
        
			return transferPayTypeResponse;
        }
    }
}
