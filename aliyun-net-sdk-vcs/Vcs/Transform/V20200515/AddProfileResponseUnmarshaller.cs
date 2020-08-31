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
    public class AddProfileResponseUnmarshaller
    {
        public static AddProfileResponse Unmarshall(UnmarshallerContext context)
        {
			AddProfileResponse addProfileResponse = new AddProfileResponse();

			addProfileResponse.HttpResponse = context.HttpResponse;
			addProfileResponse.Code = context.StringValue("AddProfile.Code");
			addProfileResponse.Message = context.StringValue("AddProfile.Message");
			addProfileResponse.RequestId = context.StringValue("AddProfile.RequestId");

			AddProfileResponse.AddProfile_Data data = new AddProfileResponse.AddProfile_Data();
			data.LiveAddress = context.StringValue("AddProfile.Data.LiveAddress");
			data.SceneType = context.StringValue("AddProfile.Data.SceneType");
			data.BizId = context.StringValue("AddProfile.Data.BizId");
			data.FaceUrl = context.StringValue("AddProfile.Data.FaceUrl");
			data.Gender = context.StringValue("AddProfile.Data.Gender");
			data.IdNumber = context.StringValue("AddProfile.Data.IdNumber");
			data.IsvSubId = context.StringValue("AddProfile.Data.IsvSubId");
			data.PhoneNo = context.StringValue("AddProfile.Data.PhoneNo");
			data.PlateNo = context.StringValue("AddProfile.Data.PlateNo");
			data.CatalogId = context.IntegerValue("AddProfile.Data.CatalogId");
			data.ProfileId = context.IntegerValue("AddProfile.Data.ProfileId");
			data.Name = context.StringValue("AddProfile.Data.Name");
			addProfileResponse.Data = data;
        
			return addProfileResponse;
        }
    }
}
