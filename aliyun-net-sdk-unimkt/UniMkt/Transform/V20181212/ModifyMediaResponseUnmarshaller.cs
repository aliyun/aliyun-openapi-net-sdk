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
    public class ModifyMediaResponseUnmarshaller
    {
        public static ModifyMediaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyMediaResponse modifyMediaResponse = new ModifyMediaResponse();

			modifyMediaResponse.HttpResponse = _ctx.HttpResponse;
			modifyMediaResponse.Code = _ctx.StringValue("ModifyMedia.Code");
			modifyMediaResponse.Success = _ctx.BooleanValue("ModifyMedia.Success");
			modifyMediaResponse.Message = _ctx.StringValue("ModifyMedia.Message");
			modifyMediaResponse.RequestId = _ctx.StringValue("ModifyMedia.RequestId");

			ModifyMediaResponse.ModifyMedia_Model model = new ModifyMediaResponse.ModifyMedia_Model();
			model.CreateTime = _ctx.LongValue("ModifyMedia.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("ModifyMedia.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("ModifyMedia.Model.TenantId");
			model.MediaName = _ctx.StringValue("ModifyMedia.Model.MediaName");
			model.MediaId = _ctx.StringValue("ModifyMedia.Model.MediaId");
			model.MediaType = _ctx.StringValue("ModifyMedia.Model.MediaType");
			model.FirstScene = _ctx.StringValue("ModifyMedia.Model.FirstScene");
			model.SecondScene = _ctx.StringValue("ModifyMedia.Model.SecondScene");
			model.MediaStatus = _ctx.StringValue("ModifyMedia.Model.MediaStatus");
			model.AccessStatus = _ctx.StringValue("ModifyMedia.Model.AccessStatus");
			model.Os = _ctx.StringValue("ModifyMedia.Model.Os");
			model.Config = _ctx.StringValue("ModifyMedia.Model.Config");
			model.KeyWords = _ctx.StringValue("ModifyMedia.Model.KeyWords");
			model.AccessWay = _ctx.StringValue("ModifyMedia.Model.AccessWay");
			model.ExtInfo = _ctx.StringValue("ModifyMedia.Model.ExtInfo");
			model.Version = _ctx.LongValue("ModifyMedia.Model.Version");
			modifyMediaResponse.Model = model;
        
			return modifyMediaResponse;
        }
    }
}
