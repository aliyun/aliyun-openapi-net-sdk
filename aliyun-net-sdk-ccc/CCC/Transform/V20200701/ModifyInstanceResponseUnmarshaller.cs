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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ModifyInstanceResponseUnmarshaller
    {
        public static ModifyInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyInstanceResponse modifyInstanceResponse = new ModifyInstanceResponse();

			modifyInstanceResponse.HttpResponse = _ctx.HttpResponse;
			modifyInstanceResponse.HttpStatusCode = _ctx.IntegerValue("ModifyInstance.HttpStatusCode");
			modifyInstanceResponse.Code = _ctx.StringValue("ModifyInstance.Code");
			modifyInstanceResponse.Message = _ctx.StringValue("ModifyInstance.Message");
			modifyInstanceResponse.Data = _ctx.StringValue("ModifyInstance.Data");
			modifyInstanceResponse.RequestId = _ctx.StringValue("ModifyInstance.RequestId");

			List<string> modifyInstanceResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ModifyInstance.Params.Length"); i++) {
				modifyInstanceResponse_params.Add(_ctx.StringValue("ModifyInstance.Params["+ i +"]"));
			}
			modifyInstanceResponse._Params = modifyInstanceResponse_params;
        
			return modifyInstanceResponse;
        }
    }
}
