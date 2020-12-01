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
    public class DialExResponseUnmarshaller
    {
        public static DialExResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DialExResponse dialExResponse = new DialExResponse();

			dialExResponse.HttpResponse = _ctx.HttpResponse;
			dialExResponse.RequestId = _ctx.StringValue("DialEx.RequestId");
			dialExResponse.Success = _ctx.BooleanValue("DialEx.Success");
			dialExResponse.Code = _ctx.StringValue("DialEx.Code");
			dialExResponse.Message = _ctx.StringValue("DialEx.Message");
			dialExResponse.HttpStatusCode = _ctx.IntegerValue("DialEx.HttpStatusCode");
			dialExResponse.StatusCode = _ctx.StringValue("DialEx.StatusCode");
			dialExResponse.StatusDesc = _ctx.StringValue("DialEx.StatusDesc");
			dialExResponse.TaskId = _ctx.StringValue("DialEx.TaskId");
			dialExResponse.TimeStamp = _ctx.StringValue("DialEx.TimeStamp");
        
			return dialExResponse;
        }
    }
}
