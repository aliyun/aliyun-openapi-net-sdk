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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class CreateOfficeConversionTaskResponseUnmarshaller
    {
        public static CreateOfficeConversionTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateOfficeConversionTaskResponse createOfficeConversionTaskResponse = new CreateOfficeConversionTaskResponse();

			createOfficeConversionTaskResponse.HttpResponse = _ctx.HttpResponse;
			createOfficeConversionTaskResponse.Status = _ctx.StringValue("CreateOfficeConversionTask.Status");
			createOfficeConversionTaskResponse.TaskId = _ctx.StringValue("CreateOfficeConversionTask.TaskId");
			createOfficeConversionTaskResponse.RequestId = _ctx.StringValue("CreateOfficeConversionTask.RequestId");
			createOfficeConversionTaskResponse.Percent = _ctx.IntegerValue("CreateOfficeConversionTask.Percent");
			createOfficeConversionTaskResponse.TgtLoc = _ctx.StringValue("CreateOfficeConversionTask.TgtLoc");
			createOfficeConversionTaskResponse.CreateTime = _ctx.StringValue("CreateOfficeConversionTask.CreateTime");
        
			return createOfficeConversionTaskResponse;
        }
    }
}
