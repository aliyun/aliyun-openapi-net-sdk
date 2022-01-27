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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class ConfirmRelationResponseUnmarshaller
    {
        public static ConfirmRelationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ConfirmRelationResponse confirmRelationResponse = new ConfirmRelationResponse();

			confirmRelationResponse.HttpResponse = _ctx.HttpResponse;
			confirmRelationResponse.Code = _ctx.StringValue("ConfirmRelation.Code");
			confirmRelationResponse.RequestId = _ctx.StringValue("ConfirmRelation.RequestId");
			confirmRelationResponse.Success = _ctx.BooleanValue("ConfirmRelation.Success");
			confirmRelationResponse.Message = _ctx.StringValue("ConfirmRelation.Message");

			ConfirmRelationResponse.ConfirmRelation_Data data = new ConfirmRelationResponse.ConfirmRelation_Data();
			data.HostId = _ctx.StringValue("ConfirmRelation.Data.HostId");
			confirmRelationResponse.Data = data;
        
			return confirmRelationResponse;
        }
    }
}
