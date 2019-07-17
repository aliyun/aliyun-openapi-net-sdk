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
        public static ListSkillGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			ListSkillGroupsResponse listSkillGroupsResponse = new ListSkillGroupsResponse();

			listSkillGroupsResponse.HttpResponse = context.HttpResponse;
			listSkillGroupsResponse.RequestId = context.StringValue("ListSkillGroups.RequestId");
			listSkillGroupsResponse.Success = context.BooleanValue("ListSkillGroups.Success");
			listSkillGroupsResponse.Code = context.StringValue("ListSkillGroups.Code");
			listSkillGroupsResponse.Message = context.StringValue("ListSkillGroups.Message");
			listSkillGroupsResponse.HttpStatusCode = context.IntegerValue("ListSkillGroups.HttpStatusCode");

			List<ListSkillGroupsResponse.ListSkillGroups_SkillGroup> listSkillGroupsResponse_skillGroups = new List<ListSkillGroupsResponse.ListSkillGroups_SkillGroup>();
			for (int i = 0; i < context.Length("ListSkillGroups.SkillGroups.Length"); i++) {
				ListSkillGroupsResponse.ListSkillGroups_SkillGroup skillGroup = new ListSkillGroupsResponse.ListSkillGroups_SkillGroup();
				skillGroup.SkillGroupId = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].SkillGroupId");
				skillGroup.InstanceId = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].InstanceId");
				skillGroup.SkillGroupName = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].SkillGroupName");
				skillGroup.AccSkillGroupName = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].AccSkillGroupName");
				skillGroup.AccQueueName = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].AccQueueName");
				skillGroup.SkillGroupDescription = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].SkillGroupDescription");
				skillGroup.RoutingStrategy = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].RoutingStrategy");
				skillGroup.UserCount = context.IntegerValue("ListSkillGroups.SkillGroups["+ i +"].UserCount");

				List<ListSkillGroupsResponse.ListSkillGroups_SkillGroup.ListSkillGroups_PhoneNumber> skillGroup_outboundPhoneNumbers = new List<ListSkillGroupsResponse.ListSkillGroups_SkillGroup.ListSkillGroups_PhoneNumber>();
				for (int j = 0; j < context.Length("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers.Length"); j++) {
					ListSkillGroupsResponse.ListSkillGroups_SkillGroup.ListSkillGroups_PhoneNumber phoneNumber = new ListSkillGroupsResponse.ListSkillGroups_SkillGroup.ListSkillGroups_PhoneNumber();
					phoneNumber.PhoneNumberId = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].PhoneNumberId");
					phoneNumber.InstanceId = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].InstanceId");
					phoneNumber.Number = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].Number");
					phoneNumber.PhoneNumberDescription = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].PhoneNumberDescription");
					phoneNumber.TestOnly = context.BooleanValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].TestOnly");
					phoneNumber.RemainingTime = context.IntegerValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].RemainingTime");
					phoneNumber.AllowOutbound = context.BooleanValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].AllowOutbound");
					phoneNumber.Usage = context.StringValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].Usage");
					phoneNumber.Trunks = context.IntegerValue("ListSkillGroups.SkillGroups["+ i +"].OutboundPhoneNumbers["+ j +"].Trunks");

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
