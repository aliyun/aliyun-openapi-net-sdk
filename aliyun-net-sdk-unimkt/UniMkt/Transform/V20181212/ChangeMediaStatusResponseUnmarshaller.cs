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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class ChangeMediaStatusResponseUnmarshaller
    {
        public static ChangeMediaStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ChangeMediaStatusResponse changeMediaStatusResponse = new ChangeMediaStatusResponse();

			changeMediaStatusResponse.HttpResponse = _ctx.HttpResponse;
			changeMediaStatusResponse.Code = _ctx.StringValue("ChangeMediaStatus.Code");
			changeMediaStatusResponse.Success = _ctx.BooleanValue("ChangeMediaStatus.Success");
			changeMediaStatusResponse.Message = _ctx.StringValue("ChangeMediaStatus.Message");
			changeMediaStatusResponse.RequestId = _ctx.StringValue("ChangeMediaStatus.RequestId");

			ChangeMediaStatusResponse.ChangeMediaStatus_Model model = new ChangeMediaStatusResponse.ChangeMediaStatus_Model();
			model.CreateTime = _ctx.LongValue("ChangeMediaStatus.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("ChangeMediaStatus.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("ChangeMediaStatus.Model.TenantId");
			model.MediaName = _ctx.StringValue("ChangeMediaStatus.Model.MediaName");
			model.MediaId = _ctx.StringValue("ChangeMediaStatus.Model.MediaId");
			model.MediaType = _ctx.StringValue("ChangeMediaStatus.Model.MediaType");
			model.FirstScene = _ctx.StringValue("ChangeMediaStatus.Model.FirstScene");
			model.SecondScene = _ctx.StringValue("ChangeMediaStatus.Model.SecondScene");
			model.MediaStatus = _ctx.StringValue("ChangeMediaStatus.Model.MediaStatus");
			model.AccessStatus = _ctx.StringValue("ChangeMediaStatus.Model.AccessStatus");
			model.Os = _ctx.StringValue("ChangeMediaStatus.Model.Os");
			model.Config = _ctx.StringValue("ChangeMediaStatus.Model.Config");
			model.KeyWords = _ctx.StringValue("ChangeMediaStatus.Model.KeyWords");
			model.AccessWay = _ctx.StringValue("ChangeMediaStatus.Model.AccessWay");
			model.ExtInfo = _ctx.StringValue("ChangeMediaStatus.Model.ExtInfo");
			model.Version = _ctx.LongValue("ChangeMediaStatus.Model.Version");
			changeMediaStatusResponse.Model = model;
        
			return changeMediaStatusResponse;
        }
    }
}
