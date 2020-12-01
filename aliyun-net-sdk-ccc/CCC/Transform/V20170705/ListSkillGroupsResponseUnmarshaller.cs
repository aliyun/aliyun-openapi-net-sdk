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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class ListSkillGroupsResponseUnmarshaller
    {
        public static ListSkillGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSkillGroupsResponse listSkillGroupsResponse = new ListSkillGroupsResponse();

			listSkillGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listSkillGroupsResponse.RequestId = _ctx.StringValue("ListSkillGroups.RequestId");
			listSkillGroupsResponse.Success = _ctx.BooleanValue("ListSkillGroups.Success");
			listSkillGroupsResponse.Code = _ctx.StringValue("ListSkillGroups.Code");
			listSkillGroupsResponse.Message = _ctx.StringValue("ListSkillGroups.Message");
			listSkillGroupsResponse.HttpStatusCode = _ctx.IntegerValue("ListSkillGroups.HttpStatusCode");

			List<ListSkillGroupsResponse.ListSkillGroups_SkillGroup> listSkillGroupsResponse_skillGroups = new List<ListSkillGroupsResponse.ListSkillGroups_SkillGroup>();
			for (int i = 0; i < _ctx.Length("ListSkillGroups.SkillGroups.Length"); i++) {
				ListSkillGroupsResponse.ListSkillGroups_SkillGroup skillGroup = new ListSkillGroupsResponse.ListSkillGroups_SkillGroup();
				skillGroup.SkillGroupId = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].SkillGroupId");
				skillGroup.InstanceId = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].InstanceId");
				skillGroup.SkillGroupName = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].SkillGroupName");
				skillGroup.AccSkillGroupName = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].AccSkillGroupName");
				skillGroup.AccQueueName = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].AccQueueName");
				skillGroup.SkillGroupDescription = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].SkillGroupDescription");
				skillGroup.RoutingStrategy = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].RoutingStrategy");
				skillGroup.UserCount = _ctx.IntegerValue("ListSkillGroups.SkillGroups["+ i +"].UserCount");

				List<ListSkillGroupsResponse.ListSkillGroups_SkillGroup.ListSkillGroups_PhoneNumber> skillGroup_outboundPhoneNumbers = new List<ListSkillGroupsResponse.ListSkillGroups_SkillGroup.ListSkillGroups_PhoneNumber>();
				for (int j = 0; j < _ctx.Length("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers.Length"); j++) {
					ListSkillGroupsResponse.ListSkillGroups_SkillGroup.ListSkillGroups_PhoneNumber phoneNumber = new ListSkillGroupsResponse.ListSkillGroups_SkillGroup.ListSkillGroups_PhoneNumber();
					phoneNumber.PhoneNumberId = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].PhoneNumberId");
					phoneNumber.InstanceId = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].InstanceId");
					phoneNumber.Number = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].Number");
					phoneNumber.PhoneNumberDescription = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].PhoneNumberDescription");
					phoneNumber.TestOnly = _ctx.BooleanValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].TestOnly");
					phoneNumber.RemainingTime = _ctx.IntegerValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].RemainingTime");
					phoneNumber.AllowOutbound = _ctx.BooleanValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].AllowOutbound");
					phoneNumber.Usage = _ctx.StringValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].Usage");
					phoneNumber.Trunks = _ctx.IntegerValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].Trunks");

					skillGroup_outboundPhoneNumbers.Add(phoneNumber);
				}
				skillGroup.OutboundPhoneNumbers = skillGroup_outboundPhoneNumbers;

				listSkillGroupsResponse_skillGroups.Add(skillGroup);
			}
			listSkillGroupsResponse.SkillGroups = listSkillGroupsResponse_skillGroups;
        
			return listSkillGroupsResponse;
        }
    }
}
