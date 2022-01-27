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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ModifyTagGroupsResponseUnmarshaller
    {
        public static ModifyTagGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyTagGroupsResponse modifyTagGroupsResponse = new ModifyTagGroupsResponse();

			modifyTagGroupsResponse.HttpResponse = _ctx.HttpResponse;
			modifyTagGroupsResponse.Code = _ctx.StringValue("ModifyTagGroups.Code");
			modifyTagGroupsResponse.HttpStatusCode = _ctx.IntegerValue("ModifyTagGroups.HttpStatusCode");
			modifyTagGroupsResponse.Message = _ctx.StringValue("ModifyTagGroups.Message");
			modifyTagGroupsResponse.RequestId = _ctx.StringValue("ModifyTagGroups.RequestId");
			modifyTagGroupsResponse.Success = _ctx.BooleanValue("ModifyTagGroups.Success");

			List<ModifyTagGroupsResponse.ModifyTagGroups_TagGroup> modifyTagGroupsResponse_tagGroups = new List<ModifyTagGroupsResponse.ModifyTagGroups_TagGroup>();
			for (int i = 0; i < _ctx.Length("ModifyTagGroups.TagGroups.Length"); i++) {
				ModifyTagGroupsResponse.ModifyTagGroups_TagGroup tagGroup = new ModifyTagGroupsResponse.ModifyTagGroups_TagGroup();
				tagGroup.ScriptId = _ctx.StringValue("ModifyTagGroups.TagGroups["+ i +"].ScriptId");
				tagGroup.TagGroup = _ctx.StringValue("ModifyTagGroups.TagGroups["+ i +"].TagGroup");
				tagGroup.TagGroupId = _ctx.StringValue("ModifyTagGroups.TagGroups["+ i +"].TagGroupId");
				tagGroup.TagGroupIndex = _ctx.IntegerValue("ModifyTagGroups.TagGroups["+ i +"].TagGroupIndex");

				modifyTagGroupsResponse_tagGroups.Add(tagGroup);
			}
			modifyTagGroupsResponse.TagGroups = modifyTagGroupsResponse_tagGroups;

			List<ModifyTagGroupsResponse.ModifyTagGroups_Tag> modifyTagGroupsResponse_tags = new List<ModifyTagGroupsResponse.ModifyTagGroups_Tag>();
			for (int i = 0; i < _ctx.Length("ModifyTagGroups.Tags.Length"); i++) {
				ModifyTagGroupsResponse.ModifyTagGroups_Tag tag = new ModifyTagGroupsResponse.ModifyTagGroups_Tag();
				tag.ScriptId = _ctx.StringValue("ModifyTagGroups.Tags["+ i +"].ScriptId");
				tag.TagGroup = _ctx.StringValue("ModifyTagGroups.Tags["+ i +"].TagGroup");
				tag.TagId = _ctx.StringValue("ModifyTagGroups.Tags["+ i +"].TagId");
				tag.TagIndex = _ctx.IntegerValue("ModifyTagGroups.Tags["+ i +"].TagIndex");
				tag.TagName = _ctx.StringValue("ModifyTagGroups.Tags["+ i +"].TagName");

				modifyTagGroupsResponse_tags.Add(tag);
			}
			modifyTagGroupsResponse.Tags = modifyTagGroupsResponse_tags;
        
			return modifyTagGroupsResponse;
        }
    }
}
