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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class ModifyBindAccountResponseUnmarshaller
    {
        public static ModifyBindAccountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyBindAccountResponse modifyBindAccountResponse = new ModifyBindAccountResponse();

			modifyBindAccountResponse.HttpResponse = _ctx.HttpResponse;
			modifyBindAccountResponse.RequestId = _ctx.StringValue("ModifyBindAccount.RequestId");

			ModifyBindAccountResponse.ModifyBindAccount_Data data = new ModifyBindAccountResponse.ModifyBindAccount_Data();
			data.Count = _ctx.IntegerValue("ModifyBindAccount.Data.Count");
			modifyBindAccountResponse.Data = data;
        
			return modifyBindAccountResponse;
        }
    }
}
