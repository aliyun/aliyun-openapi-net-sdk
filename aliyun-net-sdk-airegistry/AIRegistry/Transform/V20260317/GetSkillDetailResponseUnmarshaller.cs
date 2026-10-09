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
using Aliyun.Acs.AIRegistry.Model.V20260317;

namespace Aliyun.Acs.AIRegistry.Transform.V20260317
{
    public class GetSkillDetailResponseUnmarshaller
    {
        public static GetSkillDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSkillDetailResponse getSkillDetailResponse = new GetSkillDetailResponse();

			getSkillDetailResponse.HttpResponse = _ctx.HttpResponse;
			getSkillDetailResponse.RequestId = _ctx.StringValue("GetSkillDetail.RequestId");

			GetSkillDetailResponse.GetSkillDetail_Data data = new GetSkillDetailResponse.GetSkillDetail_Data();
			data.DraftMode = _ctx.StringValue("GetSkillDetail.Data.DraftMode");
			data.EditingVersion = _ctx.StringValue("GetSkillDetail.Data.EditingVersion");
			data.Owner = _ctx.StringValue("GetSkillDetail.Data.Owner");
			data.Description = _ctx.StringValue("GetSkillDetail.Data.Description");
			data.BizTags = _ctx.StringValue("GetSkillDetail.Data.BizTags");
			data.Labels = _ctx.StringValue("GetSkillDetail.Data.Labels");
			data.From = _ctx.StringValue("GetSkillDetail.Data.From");
			data.Name = _ctx.StringValue("GetSkillDetail.Data.Name");
			data.Scope = _ctx.StringValue("GetSkillDetail.Data.Scope");
			data.UpdateTime = _ctx.LongValue("GetSkillDetail.Data.UpdateTime");
			data.Enable = _ctx.BooleanValue("GetSkillDetail.Data.Enable");
			data.NamespaceId = _ctx.StringValue("GetSkillDetail.Data.NamespaceId");
			data.ReviewingVersion = _ctx.StringValue("GetSkillDetail.Data.ReviewingVersion");
			data.OnlineCnt = _ctx.IntegerValue("GetSkillDetail.Data.OnlineCnt");
			data.Writeable = _ctx.BooleanValue("GetSkillDetail.Data.Writeable");
			data.DownloadCount = _ctx.LongValue("GetSkillDetail.Data.DownloadCount");

			List<GetSkillDetailResponse.GetSkillDetail_Data.GetSkillDetail_Version> data_versions = new List<GetSkillDetailResponse.GetSkillDetail_Data.GetSkillDetail_Version>();
			for (int i = 0; i < _ctx.Length("GetSkillDetail.Data.Versions.Length"); i++) {
				GetSkillDetailResponse.GetSkillDetail_Data.GetSkillDetail_Version version = new GetSkillDetailResponse.GetSkillDetail_Data.GetSkillDetail_Version();
				version.Status = _ctx.StringValue("GetSkillDetail.Data.Versions["+ i +"].Status");
				version.Description = _ctx.StringValue("GetSkillDetail.Data.Versions["+ i +"].Description");
				version.PublishPipelineInfo = _ctx.StringValue("GetSkillDetail.Data.Versions["+ i +"].PublishPipelineInfo");
				version.Version = _ctx.StringValue("GetSkillDetail.Data.Versions["+ i +"].Version");
				version.CreateTime = _ctx.LongValue("GetSkillDetail.Data.Versions["+ i +"].CreateTime");
				version.UpdateTime = _ctx.LongValue("GetSkillDetail.Data.Versions["+ i +"].UpdateTime");
				version.Author = _ctx.StringValue("GetSkillDetail.Data.Versions["+ i +"].Author");
				version.CommitMsg = _ctx.StringValue("GetSkillDetail.Data.Versions["+ i +"].CommitMsg");
				version.DownloadCount = _ctx.LongValue("GetSkillDetail.Data.Versions["+ i +"].DownloadCount");

				data_versions.Add(version);
			}
			data.Versions = data_versions;
			getSkillDetailResponse.Data = data;
        
			return getSkillDetailResponse;
        }
    }
}
