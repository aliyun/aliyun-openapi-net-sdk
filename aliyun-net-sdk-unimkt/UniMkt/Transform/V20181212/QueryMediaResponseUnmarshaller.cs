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
    public class QueryMediaResponseUnmarshaller
    {
        public static QueryMediaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMediaResponse queryMediaResponse = new QueryMediaResponse();

			queryMediaResponse.HttpResponse = _ctx.HttpResponse;
			queryMediaResponse.Code = _ctx.StringValue("QueryMedia.Code");
			queryMediaResponse.Success = _ctx.BooleanValue("QueryMedia.Success");
			queryMediaResponse.Message = _ctx.StringValue("QueryMedia.Message");
			queryMediaResponse.RequestId = _ctx.StringValue("QueryMedia.RequestId");

			QueryMediaResponse.QueryMedia_Model model = new QueryMediaResponse.QueryMedia_Model();
			model.CreateTime = _ctx.LongValue("QueryMedia.Model.CreateTime");
			model.ModifyTime = _ctx.LongValue("QueryMedia.Model.ModifyTime");
			model.TenantId = _ctx.StringValue("QueryMedia.Model.TenantId");
			model.MediaName = _ctx.StringValue("QueryMedia.Model.MediaName");
			model.MediaId = _ctx.StringValue("QueryMedia.Model.MediaId");
			model.MediaType = _ctx.StringValue("QueryMedia.Model.MediaType");
			model.FirstScene = _ctx.StringValue("QueryMedia.Model.FirstScene");
			model.SecondScene = _ctx.StringValue("QueryMedia.Model.SecondScene");
			model.MediaStatus = _ctx.StringValue("QueryMedia.Model.MediaStatus");
			model.AccessStatus = _ctx.StringValue("QueryMedia.Model.AccessStatus");
			model.Os = _ctx.StringValue("QueryMedia.Model.Os");
			model.Config = _ctx.StringValue("QueryMedia.Model.Config");
			model.KeyWords = _ctx.StringValue("QueryMedia.Model.KeyWords");
			model.AccessWay = _ctx.StringValue("QueryMedia.Model.AccessWay");
			model.ExtInfo = _ctx.StringValue("QueryMedia.Model.ExtInfo");
			model.Version = _ctx.LongValue("QueryMedia.Model.Version");
			queryMediaResponse.Model = model;
        
			return queryMediaResponse;
        }
    }
}
