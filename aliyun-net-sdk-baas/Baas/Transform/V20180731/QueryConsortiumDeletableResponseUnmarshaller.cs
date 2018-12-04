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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class QueryConsortiumDeletableResponseUnmarshaller
    {
        public static QueryConsortiumDeletableResponse Unmarshall(UnmarshallerContext context)
        {
			QueryConsortiumDeletableResponse queryConsortiumDeletableResponse = new QueryConsortiumDeletableResponse();

			queryConsortiumDeletableResponse.HttpResponse = context.HttpResponse;
			queryConsortiumDeletableResponse.RequestId = context.StringValue("QueryConsortiumDeletable.RequestId");
			queryConsortiumDeletableResponse.Success = context.BooleanValue("QueryConsortiumDeletable.Success");
			queryConsortiumDeletableResponse.ErrorCode = context.IntegerValue("QueryConsortiumDeletable.ErrorCode");

			QueryConsortiumDeletableResponse.QueryConsortiumDeletable_Result result = new QueryConsortiumDeletableResponse.QueryConsortiumDeletable_Result();
			result.ConsortiumId = context.StringValue("QueryConsortiumDeletable.Result.ConsortiumId");
			result.Name = context.StringValue("QueryConsortiumDeletable.Result.Name");
			result.RegionId = context.StringValue("QueryConsortiumDeletable.Result.RegionId");
			result.ZoneId = context.StringValue("QueryConsortiumDeletable.Result.ZoneId");
			result.CodeName = context.StringValue("QueryConsortiumDeletable.Result.CodeName");
			result.Domain = context.StringValue("QueryConsortiumDeletable.Result.Domain");
			result.Description = context.StringValue("QueryConsortiumDeletable.Result.Description");
			result.State = context.StringValue("QueryConsortiumDeletable.Result.State");
			result.Deletable = context.BooleanValue("QueryConsortiumDeletable.Result.Deletable");
			queryConsortiumDeletableResponse.Result = result;
        
			return queryConsortiumDeletableResponse;
        }
    }
}