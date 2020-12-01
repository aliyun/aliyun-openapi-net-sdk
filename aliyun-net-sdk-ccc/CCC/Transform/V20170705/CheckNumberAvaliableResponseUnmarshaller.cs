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
    public class CheckNumberAvaliableResponseUnmarshaller
    {
        public static CheckNumberAvaliableResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CheckNumberAvaliableResponse checkNumberAvaliableResponse = new CheckNumberAvaliableResponse();

			checkNumberAvaliableResponse.HttpResponse = _ctx.HttpResponse;
			checkNumberAvaliableResponse.RequestId = _ctx.StringValue("CheckNumberAvaliable.RequestId");
			checkNumberAvaliableResponse.Success = _ctx.BooleanValue("CheckNumberAvaliable.Success");
			checkNumberAvaliableResponse.Code = _ctx.StringValue("CheckNumberAvaliable.Code");
			checkNumberAvaliableResponse.Message = _ctx.StringValue("CheckNumberAvaliable.Message");
			checkNumberAvaliableResponse.HttpStatusCode = _ctx.IntegerValue("CheckNumberAvaliable.HttpStatusCode");

			CheckNumberAvaliableResponse.CheckNumberAvaliable_CallerAvaliable callerAvaliable = new CheckNumberAvaliableResponse.CheckNumberAvaliable_CallerAvaliable();
			callerAvaliable.Avaliable = _ctx.BooleanValue("CheckNumberAvaliable.CallerAvaliable.Avaliable");
			callerAvaliable.Reason = _ctx.StringValue("CheckNumberAvaliable.CallerAvaliable.Reason");
			checkNumberAvaliableResponse.CallerAvaliable = callerAvaliable;

			CheckNumberAvaliableResponse.CheckNumberAvaliable_CalleeAvaliable calleeAvaliable = new CheckNumberAvaliableResponse.CheckNumberAvaliable_CalleeAvaliable();
			calleeAvaliable.Avaliable = _ctx.BooleanValue("CheckNumberAvaliable.CalleeAvaliable.Avaliable");
			calleeAvaliable.Reason = _ctx.StringValue("CheckNumberAvaliable.CalleeAvaliable.Reason");
			checkNumberAvaliableResponse.CalleeAvaliable = calleeAvaliable;
        
			return checkNumberAvaliableResponse;
        }
    }
}
