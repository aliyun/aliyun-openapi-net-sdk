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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class CreateErResponseUnmarshaller
    {
        public static CreateErResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateErResponse createErResponse = new CreateErResponse();

			createErResponse.HttpResponse = _ctx.HttpResponse;
			createErResponse.Code = _ctx.IntegerValue("CreateEr.Code");
			createErResponse.Message = _ctx.StringValue("CreateEr.Message");
			createErResponse.RequestId = _ctx.StringValue("CreateEr.RequestId");

			CreateErResponse.CreateEr_Content content = new CreateErResponse.CreateEr_Content();
			content.ErId = _ctx.StringValue("CreateEr.Content.ErId");
			createErResponse.Content = content;
        
			return createErResponse;
        }
    }
}
