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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class SubmitHotExpandPreCheckTaskResponseUnmarshaller
    {
        public static SubmitHotExpandPreCheckTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitHotExpandPreCheckTaskResponse submitHotExpandPreCheckTaskResponse = new SubmitHotExpandPreCheckTaskResponse();

			submitHotExpandPreCheckTaskResponse.HttpResponse = _ctx.HttpResponse;
			submitHotExpandPreCheckTaskResponse.RequestId = _ctx.StringValue("SubmitHotExpandPreCheckTask.RequestId");
			submitHotExpandPreCheckTaskResponse.Success = _ctx.BooleanValue("SubmitHotExpandPreCheckTask.Success");
			submitHotExpandPreCheckTaskResponse.Msg = _ctx.StringValue("SubmitHotExpandPreCheckTask.Msg");
			submitHotExpandPreCheckTaskResponse.TaskId = _ctx.LongValue("SubmitHotExpandPreCheckTask.TaskId");
        
			return submitHotExpandPreCheckTaskResponse;
        }
    }
}
