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
using Aliyun.Acs.Dyplsapi.Model.V20170525;

namespace Aliyun.Acs.Dyplsapi.Transform.V20170525
{
    public class BindAxnResponseUnmarshaller
    {
        public static BindAxnResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BindAxnResponse bindAxnResponse = new BindAxnResponse();

			bindAxnResponse.HttpResponse = _ctx.HttpResponse;
			bindAxnResponse.Code = _ctx.StringValue("BindAxn.Code");
			bindAxnResponse.Message = _ctx.StringValue("BindAxn.Message");
			bindAxnResponse.RequestId = _ctx.StringValue("BindAxn.RequestId");

			BindAxnResponse.BindAxn_SecretBindDTO secretBindDTO = new BindAxnResponse.BindAxn_SecretBindDTO();
			secretBindDTO.Extension = _ctx.StringValue("BindAxn.SecretBindDTO.Extension");
			secretBindDTO.SubsId = _ctx.StringValue("BindAxn.SecretBindDTO.SubsId");
			secretBindDTO.SecretNo = _ctx.StringValue("BindAxn.SecretBindDTO.SecretNo");
			bindAxnResponse.SecretBindDTO = secretBindDTO;
        
			return bindAxnResponse;
        }
    }
}
