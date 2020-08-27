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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class GetUserDetailResponseUnmarshaller
    {
        public static GetUserDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetUserDetailResponse getUserDetailResponse = new GetUserDetailResponse();

			getUserDetailResponse.HttpResponse = context.HttpResponse;
			getUserDetailResponse.Code = context.StringValue("GetUserDetail.Code");
			getUserDetailResponse.Message = context.StringValue("GetUserDetail.Message");
			getUserDetailResponse.RequestId = context.StringValue("GetUserDetail.RequestId");

			GetUserDetailResponse.GetUserDetail_Data data = new GetUserDetailResponse.GetUserDetail_Data();
			data.Address = context.StringValue("GetUserDetail.Data.Address");
			data.Age = context.StringValue("GetUserDetail.Data.Age");
			data.Attachment = context.StringValue("GetUserDetail.Data.Attachment");
			data.BizId = context.StringValue("GetUserDetail.Data.BizId");
			data.FaceImageUrl = context.StringValue("GetUserDetail.Data.FaceImageUrl");
			data.Gender = context.StringValue("GetUserDetail.Data.Gender");
			data.IdNumber = context.StringValue("GetUserDetail.Data.IdNumber");
			data.PhoneNo = context.StringValue("GetUserDetail.Data.PhoneNo");
			data.PlateNo = context.StringValue("GetUserDetail.Data.PlateNo");
			data.UserGroupId = context.IntegerValue("GetUserDetail.Data.UserGroupId");
			data.UserId = context.IntegerValue("GetUserDetail.Data.UserId");
			data.UserName = context.StringValue("GetUserDetail.Data.UserName");
			data.IsvSubId = context.StringValue("GetUserDetail.Data.IsvSubId");
			getUserDetailResponse.Data = data;
        
			return getUserDetailResponse;
        }
    }
}
