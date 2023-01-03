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
    public class CreateVccResponseUnmarshaller
    {
        public static CreateVccResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateVccResponse createVccResponse = new CreateVccResponse();

			createVccResponse.HttpResponse = _ctx.HttpResponse;
			createVccResponse.Code = _ctx.IntegerValue("CreateVcc.Code");
			createVccResponse.Message = _ctx.StringValue("CreateVcc.Message");
			createVccResponse.RequestId = _ctx.StringValue("CreateVcc.RequestId");

			CreateVccResponse.CreateVcc_Content content = new CreateVccResponse.CreateVcc_Content();
			content.VccId = _ctx.StringValue("CreateVcc.Content.VccId");
			createVccResponse.Content = content;
        
			return createVccResponse;
        }
    }
}
