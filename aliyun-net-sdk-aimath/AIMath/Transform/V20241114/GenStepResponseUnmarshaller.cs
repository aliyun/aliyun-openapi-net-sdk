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
using Aliyun.Acs.AIMath.Model.V20241114;

namespace Aliyun.Acs.AIMath.Transform.V20241114
{
    public class GenStepResponseUnmarshaller
    {
        public static GenStepResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GenStepResponse genStepResponse = new GenStepResponse();

			genStepResponse.HttpResponse = _ctx.HttpResponse;
			genStepResponse.RequestId = _ctx.StringValue("GenStep.RequestId");
			genStepResponse.EventType = _ctx.StringValue("GenStep.EventType");
			genStepResponse.Content = _ctx.StringValue("GenStep.Content");
			genStepResponse.ErrCode = _ctx.StringValue("GenStep.ErrCode");
			genStepResponse.ErrMsg = _ctx.StringValue("GenStep.ErrMsg");
        
			return genStepResponse;
        }
    }
}
