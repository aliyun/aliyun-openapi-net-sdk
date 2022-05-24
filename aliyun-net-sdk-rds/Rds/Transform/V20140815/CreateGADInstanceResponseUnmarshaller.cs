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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class CreateGADInstanceResponseUnmarshaller
    {
        public static CreateGADInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateGADInstanceResponse createGADInstanceResponse = new CreateGADInstanceResponse();

			createGADInstanceResponse.HttpResponse = _ctx.HttpResponse;
			createGADInstanceResponse.RequestId = _ctx.StringValue("CreateGADInstance.RequestId");

			CreateGADInstanceResponse.CreateGADInstance_Result result = new CreateGADInstanceResponse.CreateGADInstance_Result();
			result.GadInstanceName = _ctx.StringValue("CreateGADInstance.Result.GadInstanceName");
			result.CreateMemberCount = _ctx.StringValue("CreateGADInstance.Result.CreateMemberCount");
			result.TaskID = _ctx.StringValue("CreateGADInstance.Result.TaskID");
			createGADInstanceResponse.Result = result;
        
			return createGADInstanceResponse;
        }
    }
}
