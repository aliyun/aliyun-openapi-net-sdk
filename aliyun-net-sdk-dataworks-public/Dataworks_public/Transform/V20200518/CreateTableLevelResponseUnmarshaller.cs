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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class CreateTableLevelResponseUnmarshaller
    {
        public static CreateTableLevelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTableLevelResponse createTableLevelResponse = new CreateTableLevelResponse();

			createTableLevelResponse.HttpResponse = _ctx.HttpResponse;
			createTableLevelResponse.RequestId = _ctx.StringValue("CreateTableLevel.RequestId");
			createTableLevelResponse.ErrorCode = _ctx.StringValue("CreateTableLevel.ErrorCode");
			createTableLevelResponse.ErrorMessage = _ctx.StringValue("CreateTableLevel.ErrorMessage");
			createTableLevelResponse.HttpStatusCode = _ctx.IntegerValue("CreateTableLevel.HttpStatusCode");
			createTableLevelResponse.Success = _ctx.BooleanValue("CreateTableLevel.Success");
			createTableLevelResponse.LevelId = _ctx.LongValue("CreateTableLevel.LevelId");
        
			return createTableLevelResponse;
        }
    }
}
