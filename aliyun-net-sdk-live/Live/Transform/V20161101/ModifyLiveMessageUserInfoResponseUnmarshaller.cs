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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class ModifyLiveMessageUserInfoResponseUnmarshaller
    {
        public static ModifyLiveMessageUserInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyLiveMessageUserInfoResponse modifyLiveMessageUserInfoResponse = new ModifyLiveMessageUserInfoResponse();

			modifyLiveMessageUserInfoResponse.HttpResponse = _ctx.HttpResponse;
			modifyLiveMessageUserInfoResponse.RequestId = _ctx.StringValue("ModifyLiveMessageUserInfo.RequestId");

			List<ModifyLiveMessageUserInfoResponse.ModifyLiveMessageUserInfo_FailGroups> modifyLiveMessageUserInfoResponse_failList = new List<ModifyLiveMessageUserInfoResponse.ModifyLiveMessageUserInfo_FailGroups>();
			for (int i = 0; i < _ctx.Length("ModifyLiveMessageUserInfo.FailList.Length"); i++) {
				ModifyLiveMessageUserInfoResponse.ModifyLiveMessageUserInfo_FailGroups failGroups = new ModifyLiveMessageUserInfoResponse.ModifyLiveMessageUserInfo_FailGroups();
				failGroups.Code = _ctx.IntegerValue("ModifyLiveMessageUserInfo.FailList["+ i +"].Code");
				failGroups.GroupId = _ctx.StringValue("ModifyLiveMessageUserInfo.FailList["+ i +"].GroupId");
				failGroups.Reason = _ctx.StringValue("ModifyLiveMessageUserInfo.FailList["+ i +"].Reason");
				failGroups.Success = _ctx.BooleanValue("ModifyLiveMessageUserInfo.FailList["+ i +"].Success");

				modifyLiveMessageUserInfoResponse_failList.Add(failGroups);
			}
			modifyLiveMessageUserInfoResponse.FailList = modifyLiveMessageUserInfoResponse_failList;

			List<ModifyLiveMessageUserInfoResponse.ModifyLiveMessageUserInfo_SuccessGroups> modifyLiveMessageUserInfoResponse_successList = new List<ModifyLiveMessageUserInfoResponse.ModifyLiveMessageUserInfo_SuccessGroups>();
			for (int i = 0; i < _ctx.Length("ModifyLiveMessageUserInfo.SuccessList.Length"); i++) {
				ModifyLiveMessageUserInfoResponse.ModifyLiveMessageUserInfo_SuccessGroups successGroups = new ModifyLiveMessageUserInfoResponse.ModifyLiveMessageUserInfo_SuccessGroups();
				successGroups.GroupId = _ctx.StringValue("ModifyLiveMessageUserInfo.SuccessList["+ i +"].GroupId");
				successGroups.Success = _ctx.BooleanValue("ModifyLiveMessageUserInfo.SuccessList["+ i +"].Success");

				modifyLiveMessageUserInfoResponse_successList.Add(successGroups);
			}
			modifyLiveMessageUserInfoResponse.SuccessList = modifyLiveMessageUserInfoResponse_successList;
        
			return modifyLiveMessageUserInfoResponse;
        }
    }
}
