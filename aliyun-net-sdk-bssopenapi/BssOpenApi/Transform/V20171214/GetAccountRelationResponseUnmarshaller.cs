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
    public class GetAccountRelationResponseUnmarshaller
    {
        public static GetAccountRelationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAccountRelationResponse getAccountRelationResponse = new GetAccountRelationResponse();

			getAccountRelationResponse.HttpResponse = _ctx.HttpResponse;
			getAccountRelationResponse.Message = _ctx.StringValue("GetAccountRelation.Message");
			getAccountRelationResponse.RequestId = _ctx.StringValue("GetAccountRelation.RequestId");
			getAccountRelationResponse.Code = _ctx.StringValue("GetAccountRelation.Code");
			getAccountRelationResponse.Success = _ctx.BooleanValue("GetAccountRelation.Success");

			GetAccountRelationResponse.GetAccountRelation_Data data = new GetAccountRelationResponse.GetAccountRelation_Data();
			data.Id = _ctx.LongValue("GetAccountRelation.Data.Id");
			data.ParentUserId = _ctx.LongValue("GetAccountRelation.Data.ParentUserId");
			data.ChildUserId = _ctx.LongValue("GetAccountRelation.Data.ChildUserId");
			data.StartTime = _ctx.LongValue("GetAccountRelation.Data.StartTime");
			data.EndTime = _ctx.LongValue("GetAccountRelation.Data.EndTime");
			data.Type = _ctx.StringValue("GetAccountRelation.Data.Type");
			data.Status = _ctx.StringValue("GetAccountRelation.Data.Status");
			data.GmtModified = _ctx.LongValue("GetAccountRelation.Data.GmtModified");
			getAccountRelationResponse.Data = data;
        
			return getAccountRelationResponse;
        }
    }
}
