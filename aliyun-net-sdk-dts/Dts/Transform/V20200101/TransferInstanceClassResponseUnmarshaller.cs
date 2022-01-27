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
    public class TransferInstanceClassResponseUnmarshaller
    {
        public static TransferInstanceClassResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TransferInstanceClassResponse transferInstanceClassResponse = new TransferInstanceClassResponse();

			transferInstanceClassResponse.HttpResponse = _ctx.HttpResponse;
			transferInstanceClassResponse.Code = _ctx.StringValue("TransferInstanceClass.Code");
			transferInstanceClassResponse.DynamicMessage = _ctx.StringValue("TransferInstanceClass.DynamicMessage");
			transferInstanceClassResponse.ErrCode = _ctx.StringValue("TransferInstanceClass.ErrCode");
			transferInstanceClassResponse.ErrMessage = _ctx.StringValue("TransferInstanceClass.ErrMessage");
			transferInstanceClassResponse.HttpStatusCode = _ctx.IntegerValue("TransferInstanceClass.HttpStatusCode");
			transferInstanceClassResponse.RequestId = _ctx.StringValue("TransferInstanceClass.RequestId");
			transferInstanceClassResponse.Success = _ctx.BooleanValue("TransferInstanceClass.Success");
			transferInstanceClassResponse.DtsJobId = _ctx.StringValue("TransferInstanceClass.DtsJobId");
			transferInstanceClassResponse.InstanceId = _ctx.StringValue("TransferInstanceClass.InstanceId");
			transferInstanceClassResponse.ChargeType = _ctx.StringValue("TransferInstanceClass.ChargeType");
			transferInstanceClassResponse.EndTime = _ctx.StringValue("TransferInstanceClass.EndTime");
        
			return transferInstanceClassResponse;
        }
    }
}
