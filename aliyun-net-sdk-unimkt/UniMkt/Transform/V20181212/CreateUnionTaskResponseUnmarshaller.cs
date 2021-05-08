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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class CreateUnionTaskResponseUnmarshaller
    {
        public static CreateUnionTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateUnionTaskResponse createUnionTaskResponse = new CreateUnionTaskResponse();

			createUnionTaskResponse.HttpResponse = _ctx.HttpResponse;
			createUnionTaskResponse.Code = _ctx.IntegerValue("CreateUnionTask.Code");
			createUnionTaskResponse.Success = _ctx.BooleanValue("CreateUnionTask.Success");
			createUnionTaskResponse.ErrorMsg = _ctx.StringValue("CreateUnionTask.ErrorMsg");
			createUnionTaskResponse.RequestId = _ctx.StringValue("CreateUnionTask.RequestId");
			createUnionTaskResponse.Data = _ctx.LongValue("CreateUnionTask.Data");
        
			return createUnionTaskResponse;
        }
    }
}
