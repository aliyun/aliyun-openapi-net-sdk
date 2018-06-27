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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CCC.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class TwoPartiesCallResponseUnmarshaller
    {
        public static TwoPartiesCallResponse Unmarshall(UnmarshallerContext context)
        {
			TwoPartiesCallResponse twoPartiesCallResponse = new TwoPartiesCallResponse();

			twoPartiesCallResponse.HttpResponse = context.HttpResponse;
			twoPartiesCallResponse.RequestId = context.StringValue("TwoPartiesCall.RequestId");
			twoPartiesCallResponse.Success = context.BooleanValue("TwoPartiesCall.Success");
			twoPartiesCallResponse.Code = context.StringValue("TwoPartiesCall.Code");
			twoPartiesCallResponse.Message = context.StringValue("TwoPartiesCall.Message");
			twoPartiesCallResponse.HttpStatusCode = context.IntegerValue("TwoPartiesCall.HttpStatusCode");
			twoPartiesCallResponse.StatusCode = context.StringValue("TwoPartiesCall.StatusCode");
			twoPartiesCallResponse.StatusDesc = context.StringValue("TwoPartiesCall.StatusDesc");
			twoPartiesCallResponse.TaskId = context.StringValue("TwoPartiesCall.TaskId");
			twoPartiesCallResponse.TimeStamp = context.StringValue("TwoPartiesCall.TimeStamp");
        
			return twoPartiesCallResponse;
        }
    }
}