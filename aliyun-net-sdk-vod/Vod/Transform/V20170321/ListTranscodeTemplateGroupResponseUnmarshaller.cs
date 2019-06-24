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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListTranscodeTemplateGroupResponseUnmarshaller
    {
        public static ListTranscodeTemplateGroupResponse Unmarshall(UnmarshallerContext context)
        {
			ListTranscodeTemplateGroupResponse listTranscodeTemplateGroupResponse = new ListTranscodeTemplateGroupResponse();

			listTranscodeTemplateGroupResponse.HttpResponse = context.HttpResponse;
			listTranscodeTemplateGroupResponse.RequestId = context.StringValue("ListTranscodeTemplateGroup.RequestId");

			List<ListTranscodeTemplateGroupResponse.ListTranscodeTemplateGroup_TranscodeTemplateGroup> listTranscodeTemplateGroupResponse_transcodeTemplateGroupList = new List<ListTranscodeTemplateGroupResponse.ListTranscodeTemplateGroup_TranscodeTemplateGroup>();
			for (int i = 0; i < context.Length("ListTranscodeTemplateGroup.TranscodeTemplateGroupList.Length"); i++) {
				ListTranscodeTemplateGroupResponse.ListTranscodeTemplateGroup_TranscodeTemplateGroup transcodeTemplateGroup = new ListTranscodeTemplateGroupResponse.ListTranscodeTemplateGroup_TranscodeTemplateGroup();
				transcodeTemplateGroup.CreationTime = context.StringValue("ListTranscodeTemplateGroup.TranscodeTemplateGroupList["+ i +"].CreationTime");
				transcodeTemplateGroup.ModifyTime = context.StringValue("ListTranscodeTemplateGroup.TranscodeTemplateGroupList["+ i +"].ModifyTime");
				transcodeTemplateGroup.Name = context.StringValue("ListTranscodeTemplateGroup.TranscodeTemplateGroupList["+ i +"].Name");
				transcodeTemplateGroup.IsDefault = context.StringValue("ListTranscodeTemplateGroup.TranscodeTemplateGroupList["+ i +"].IsDefault");
				transcodeTemplateGroup.Locked = context.StringValue("ListTranscodeTemplateGroup.TranscodeTemplateGroupList["+ i +"].Locked");
				transcodeTemplateGroup.TranscodeTemplateGroupId = context.StringValue("ListTranscodeTemplateGroup.TranscodeTemplateGroupList["+ i +"].TranscodeTemplateGroupId");
				transcodeTemplateGroup.TranscodeMode = context.StringValue("ListTranscodeTemplateGroup.TranscodeTemplateGroupList["+ i +"].TranscodeMode");
				transcodeTemplateGroup.AppId = context.StringValue("ListTranscodeTemplateGroup.TranscodeTemplateGroupList["+ i +"].AppId");

				listTranscodeTemplateGroupResponse_transcodeTemplateGroupList.Add(transcodeTemplateGroup);
			}
			listTranscodeTemplateGroupResponse.TranscodeTemplateGroupList = listTranscodeTemplateGroupResponse_transcodeTemplateGroupList;
        
			return listTranscodeTemplateGroupResponse;
        }
    }
}
