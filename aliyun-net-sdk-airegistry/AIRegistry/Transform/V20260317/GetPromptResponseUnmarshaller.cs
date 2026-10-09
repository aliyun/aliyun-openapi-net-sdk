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
    public class GetPromptResponseUnmarshaller
    {
        public static GetPromptResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPromptResponse getPromptResponse = new GetPromptResponse();

			getPromptResponse.HttpResponse = _ctx.HttpResponse;
			getPromptResponse.RequestId = _ctx.StringValue("GetPrompt.RequestId");

			GetPromptResponse.GetPrompt_Data data = new GetPromptResponse.GetPrompt_Data();
			data.EditingVersion = _ctx.StringValue("GetPrompt.Data.EditingVersion");
			data.Description = _ctx.StringValue("GetPrompt.Data.Description");
			data.SchemaVersion = _ctx.IntegerValue("GetPrompt.Data.SchemaVersion");
			data.LatestVersion = _ctx.StringValue("GetPrompt.Data.LatestVersion");
			data.PromptKey = _ctx.StringValue("GetPrompt.Data.PromptKey");
			data.GmtModified = _ctx.LongValue("GetPrompt.Data.GmtModified");
			data.Labels = _ctx.StringValue("GetPrompt.Data.Labels");
			data.ReviewingVersion = _ctx.StringValue("GetPrompt.Data.ReviewingVersion");
			data.OnlineCnt = _ctx.IntegerValue("GetPrompt.Data.OnlineCnt");

			List<string> data_versions = new List<string>();
			for (int i = 0; i < _ctx.Length("GetPrompt.Data.Versions.Length"); i++) {
				data_versions.Add(_ctx.StringValue("GetPrompt.Data.Versions["+ i +"]"));
			}
			data.Versions = data_versions;

			List<string> data_bizTags = new List<string>();
			for (int i = 0; i < _ctx.Length("GetPrompt.Data.BizTags.Length"); i++) {
				data_bizTags.Add(_ctx.StringValue("GetPrompt.Data.BizTags["+ i +"]"));
			}
			data.BizTags = data_bizTags;

			List<GetPromptResponse.GetPrompt_Data.GetPrompt_VersionDetail> data_versionDetails = new List<GetPromptResponse.GetPrompt_Data.GetPrompt_VersionDetail>();
			for (int i = 0; i < _ctx.Length("GetPrompt.Data.VersionDetails.Length"); i++) {
				GetPromptResponse.GetPrompt_Data.GetPrompt_VersionDetail versionDetail = new GetPromptResponse.GetPrompt_Data.GetPrompt_VersionDetail();
				versionDetail.Status = _ctx.StringValue("GetPrompt.Data.VersionDetails["+ i +"].Status");
				versionDetail.Version = _ctx.StringValue("GetPrompt.Data.VersionDetails["+ i +"].Version");
				versionDetail.SrcUser = _ctx.StringValue("GetPrompt.Data.VersionDetails["+ i +"].SrcUser");
				versionDetail.PromptKey = _ctx.StringValue("GetPrompt.Data.VersionDetails["+ i +"].PromptKey");
				versionDetail.GmtModified = _ctx.LongValue("GetPrompt.Data.VersionDetails["+ i +"].GmtModified");
				versionDetail.CommitMsg = _ctx.StringValue("GetPrompt.Data.VersionDetails["+ i +"].CommitMsg");

				data_versionDetails.Add(versionDetail);
			}
			data.VersionDetails = data_versionDetails;
			getPromptResponse.Data = data;
        
			return getPromptResponse;
        }
    }
}
