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
    public class CreateMediaResponseUnmarshaller
    {
        public static CreateMediaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateMediaResponse createMediaResponse = new CreateMediaResponse();

			createMediaResponse.HttpResponse = _ctx.HttpResponse;
			createMediaResponse.Code = _ctx.StringValue("CreateMedia.Code");
			createMediaResponse.Success = _ctx.BooleanValue("CreateMedia.Success");
			createMediaResponse.Message = _ctx.StringValue("CreateMedia.Message");
			createMediaResponse.RequestId = _ctx.StringValue("CreateMedia.RequestId");

			CreateMediaResponse.CreateMedia_Model model = new CreateMediaResponse.CreateMedia_Model();
			model.CreateTime = _ctx.LongValue("CreateMedia.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("CreateMedia.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("CreateMedia.Model.TenantId");
			model.MediaName = _ctx.StringValue("CreateMedia.Model.MediaName");
			model.MediaId = _ctx.StringValue("CreateMedia.Model.MediaId");
			model.MediaType = _ctx.StringValue("CreateMedia.Model.MediaType");
			model.FirstScene = _ctx.StringValue("CreateMedia.Model.FirstScene");
			model.SecondScene = _ctx.StringValue("CreateMedia.Model.SecondScene");
			model.MediaStatus = _ctx.StringValue("CreateMedia.Model.MediaStatus");
			model.AccessStatus = _ctx.StringValue("CreateMedia.Model.AccessStatus");
			model.Os = _ctx.StringValue("CreateMedia.Model.Os");
			model.Config = _ctx.StringValue("CreateMedia.Model.Config");
			model.KeyWords = _ctx.StringValue("CreateMedia.Model.KeyWords");
			model.AccessWay = _ctx.StringValue("CreateMedia.Model.AccessWay");
			model.ExtInfo = _ctx.StringValue("CreateMedia.Model.ExtInfo");
			model.Version = _ctx.LongValue("CreateMedia.Model.Version");
			createMediaResponse.Model = model;
        
			return createMediaResponse;
        }
    }
}
