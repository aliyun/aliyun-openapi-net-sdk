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
using Aliyun.Acs.aigen.Model.V20240111;

namespace Aliyun.Acs.aigen.Transform.V20240111
{
    public class GenerateTextTextureResponseUnmarshaller
    {
        public static GenerateTextTextureResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GenerateTextTextureResponse generateTextTextureResponse = new GenerateTextTextureResponse();

			generateTextTextureResponse.HttpResponse = _ctx.HttpResponse;
			generateTextTextureResponse.RequestId = _ctx.StringValue("GenerateTextTexture.RequestId");
			generateTextTextureResponse.Message = _ctx.StringValue("GenerateTextTexture.Message");

			GenerateTextTextureResponse.GenerateTextTexture_Data data = new GenerateTextTextureResponse.GenerateTextTexture_Data();
			data.ResultUrl = _ctx.StringValue("GenerateTextTexture.Data.ResultUrl");
			generateTextTextureResponse.Data = data;
        
			return generateTextTextureResponse;
        }
    }
}
