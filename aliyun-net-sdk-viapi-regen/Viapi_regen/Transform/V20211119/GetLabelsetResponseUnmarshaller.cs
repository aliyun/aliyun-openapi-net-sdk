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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class GetLabelsetResponseUnmarshaller
    {
        public static GetLabelsetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLabelsetResponse getLabelsetResponse = new GetLabelsetResponse();

			getLabelsetResponse.HttpResponse = _ctx.HttpResponse;
			getLabelsetResponse.Message = _ctx.StringValue("GetLabelset.Message");
			getLabelsetResponse.RequestId = _ctx.StringValue("GetLabelset.RequestId");
			getLabelsetResponse.Code = _ctx.StringValue("GetLabelset.Code");

			GetLabelsetResponse.GetLabelset_Data data = new GetLabelsetResponse.GetLabelset_Data();
			data.Id = _ctx.LongValue("GetLabelset.Data.Id");
			data.GmtCreate = _ctx.LongValue("GetLabelset.Data.GmtCreate");
			data.Name = _ctx.StringValue("GetLabelset.Data.Name");
			data.Description = _ctx.StringValue("GetLabelset.Data.Description");
			data.LabelType = _ctx.StringValue("GetLabelset.Data.LabelType");
			data.TagUserList = _ctx.StringValue("GetLabelset.Data.TagUserList");
			data.Tags = _ctx.StringValue("GetLabelset.Data.Tags");
			data.SubTaskPackageSize = _ctx.StringValue("GetLabelset.Data.SubTaskPackageSize");
			data.Status = _ctx.StringValue("GetLabelset.Data.Status");
			data.Total = _ctx.LongValue("GetLabelset.Data.Total");
			getLabelsetResponse.Data = data;
        
			return getLabelsetResponse;
        }
    }
}
