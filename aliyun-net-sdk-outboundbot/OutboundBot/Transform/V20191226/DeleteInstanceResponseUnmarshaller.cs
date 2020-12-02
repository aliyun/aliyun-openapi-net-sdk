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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class DeleteInstanceResponseUnmarshaller
    {
        public static DeleteInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteInstanceResponse deleteInstanceResponse = new DeleteInstanceResponse();

			deleteInstanceResponse.HttpResponse = _ctx.HttpResponse;
			deleteInstanceResponse.Code = _ctx.StringValue("DeleteInstance.Code");
			deleteInstanceResponse.HttpStatusCode = _ctx.IntegerValue("DeleteInstance.HttpStatusCode");
			deleteInstanceResponse.Message = _ctx.StringValue("DeleteInstance.Message");
			deleteInstanceResponse.RequestId = _ctx.StringValue("DeleteInstance.RequestId");
			deleteInstanceResponse.Success = _ctx.BooleanValue("DeleteInstance.Success");
        
			return deleteInstanceResponse;
        }
    }
}
