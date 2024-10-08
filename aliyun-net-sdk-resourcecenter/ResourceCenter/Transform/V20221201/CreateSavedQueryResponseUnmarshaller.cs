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
using Aliyun.Acs.ResourceCenter.Model.V20221201;

namespace Aliyun.Acs.ResourceCenter.Transform.V20221201
{
    public class CreateSavedQueryResponseUnmarshaller
    {
        public static CreateSavedQueryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateSavedQueryResponse createSavedQueryResponse = new CreateSavedQueryResponse();

			createSavedQueryResponse.HttpResponse = _ctx.HttpResponse;
			createSavedQueryResponse.RequestId = _ctx.StringValue("CreateSavedQuery.RequestId");
			createSavedQueryResponse.QueryId = _ctx.StringValue("CreateSavedQuery.QueryId");
        
			return createSavedQueryResponse;
        }
    }
}
