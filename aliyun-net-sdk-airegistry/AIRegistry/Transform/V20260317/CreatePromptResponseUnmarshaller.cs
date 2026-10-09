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
using Aliyun.Acs.AIRegistry.Model.V20260317;

namespace Aliyun.Acs.AIRegistry.Transform.V20260317
{
    public class CreatePromptResponseUnmarshaller
    {
        public static CreatePromptResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreatePromptResponse createPromptResponse = new CreatePromptResponse();

			createPromptResponse.HttpResponse = _ctx.HttpResponse;
			createPromptResponse.RequestId = _ctx.StringValue("CreatePrompt.RequestId");
			createPromptResponse.Data = _ctx.StringValue("CreatePrompt.Data");
        
			return createPromptResponse;
        }
    }
}
