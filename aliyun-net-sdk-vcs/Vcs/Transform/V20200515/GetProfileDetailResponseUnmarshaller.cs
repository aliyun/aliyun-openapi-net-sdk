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
    public class GetProfileDetailResponseUnmarshaller
    {
        public static GetProfileDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetProfileDetailResponse getProfileDetailResponse = new GetProfileDetailResponse();

			getProfileDetailResponse.HttpResponse = context.HttpResponse;
			getProfileDetailResponse.Code = context.StringValue("GetProfileDetail.Code");
			getProfileDetailResponse.Message = context.StringValue("GetProfileDetail.Message");
			getProfileDetailResponse.RequestId = context.StringValue("GetProfileDetail.RequestId");

			GetProfileDetailResponse.GetProfileDetail_Data data = new GetProfileDetailResponse.GetProfileDetail_Data();
			data.LiveAddress = context.StringValue("GetProfileDetail.Data.LiveAddress");
			data.SceneType = context.StringValue("GetProfileDetail.Data.SceneType");
			data.BizId = context.StringValue("GetProfileDetail.Data.BizId");
			data.FaceUrl = context.StringValue("GetProfileDetail.Data.FaceUrl");
			data.Gender = context.StringValue("GetProfileDetail.Data.Gender");
			data.IdNumber = context.StringValue("GetProfileDetail.Data.IdNumber");
			data.IsvSubId = context.StringValue("GetProfileDetail.Data.IsvSubId");
			data.PhoneNo = context.StringValue("GetProfileDetail.Data.PhoneNo");
			data.PlateNo = context.StringValue("GetProfileDetail.Data.PlateNo");
			data.CatalogId = context.IntegerValue("GetProfileDetail.Data.CatalogId");
			data.ProfileId = context.IntegerValue("GetProfileDetail.Data.ProfileId");
			data.Name = context.StringValue("GetProfileDetail.Data.Name");
			data.PersonId = context.StringValue("GetProfileDetail.Data.PersonId");
			getProfileDetailResponse.Data = data;
        
			return getProfileDetailResponse;
        }
    }
}
