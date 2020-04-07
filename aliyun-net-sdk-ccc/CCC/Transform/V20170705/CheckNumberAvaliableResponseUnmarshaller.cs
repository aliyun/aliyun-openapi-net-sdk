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
        public static CheckNumberAvaliableResponse Unmarshall(UnmarshallerContext context)
        {
			CheckNumberAvaliableResponse checkNumberAvaliableResponse = new CheckNumberAvaliableResponse();

			checkNumberAvaliableResponse.HttpResponse = context.HttpResponse;
			checkNumberAvaliableResponse.RequestId = context.StringValue("CheckNumberAvaliable.RequestId");
			checkNumberAvaliableResponse.Success = context.BooleanValue("CheckNumberAvaliable.Success");
			checkNumberAvaliableResponse.Code = context.StringValue("CheckNumberAvaliable.Code");
			checkNumberAvaliableResponse.Message = context.StringValue("CheckNumberAvaliable.Message");
			checkNumberAvaliableResponse.HttpStatusCode = context.IntegerValue("CheckNumberAvaliable.HttpStatusCode");

			CheckNumberAvaliableResponse.CheckNumberAvaliable_CallerAvaliable callerAvaliable = new CheckNumberAvaliableResponse.CheckNumberAvaliable_CallerAvaliable();
			callerAvaliable.Avaliable = context.BooleanValue("CheckNumberAvaliable.CallerAvaliable.Avaliable");
			callerAvaliable.Reason = context.StringValue("CheckNumberAvaliable.CallerAvaliable.Reason");
			checkNumberAvaliableResponse.CallerAvaliable = callerAvaliable;

			CheckNumberAvaliableResponse.CheckNumberAvaliable_CalleeAvaliable calleeAvaliable = new CheckNumberAvaliableResponse.CheckNumberAvaliable_CalleeAvaliable();
			calleeAvaliable.Avaliable = context.BooleanValue("CheckNumberAvaliable.CalleeAvaliable.Avaliable");
			calleeAvaliable.Reason = context.StringValue("CheckNumberAvaliable.CalleeAvaliable.Reason");
			checkNumberAvaliableResponse.CalleeAvaliable = calleeAvaliable;
        
			return checkNumberAvaliableResponse;
        }
    }
}
