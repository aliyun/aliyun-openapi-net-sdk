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
    public class BindAxgResponseUnmarshaller
    {
        public static BindAxgResponse Unmarshall(UnmarshallerContext context)
        {
			BindAxgResponse bindAxgResponse = new BindAxgResponse();

			bindAxgResponse.HttpResponse = context.HttpResponse;
			bindAxgResponse.RequestId = context.StringValue("BindAxg.RequestId");
			bindAxgResponse.Code = context.StringValue("BindAxg.Code");
			bindAxgResponse.Message = context.StringValue("BindAxg.Message");

			BindAxgResponse.BindAxg_SecretBindDTO secretBindDTO = new BindAxgResponse.BindAxg_SecretBindDTO();
			secretBindDTO.SubsId = context.StringValue("BindAxg.SecretBindDTO.SubsId");
			secretBindDTO.SecretNo = context.StringValue("BindAxg.SecretBindDTO.SecretNo");
			secretBindDTO.Extension = context.StringValue("BindAxg.SecretBindDTO.Extension");
			bindAxgResponse.SecretBindDTO = secretBindDTO;
        
			return bindAxgResponse;
        }
    }
}
