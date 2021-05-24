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
    public class ModifySkillLevelsOfUserResponseUnmarshaller
    {
        public static ModifySkillLevelsOfUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifySkillLevelsOfUserResponse modifySkillLevelsOfUserResponse = new ModifySkillLevelsOfUserResponse();

			modifySkillLevelsOfUserResponse.HttpResponse = _ctx.HttpResponse;
			modifySkillLevelsOfUserResponse.Code = _ctx.StringValue("ModifySkillLevelsOfUser.Code");
			modifySkillLevelsOfUserResponse.HttpStatusCode = _ctx.IntegerValue("ModifySkillLevelsOfUser.HttpStatusCode");
			modifySkillLevelsOfUserResponse.Message = _ctx.StringValue("ModifySkillLevelsOfUser.Message");
			modifySkillLevelsOfUserResponse.RequestId = _ctx.StringValue("ModifySkillLevelsOfUser.RequestId");

			List<string> modifySkillLevelsOfUserResponse_params = new List<string>();
			for (int i = 0; i < _ctx.Length("ModifySkillLevelsOfUser.Params.Length"); i++) {
				modifySkillLevelsOfUserResponse_params.Add(_ctx.StringValue("ModifySkillLevelsOfUser.Params["+ i +"]"));
			}
			modifySkillLevelsOfUserResponse._Params = modifySkillLevelsOfUserResponse_params;
        
			return modifySkillLevelsOfUserResponse;
        }
    }
}
