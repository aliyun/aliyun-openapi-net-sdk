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
using Aliyun.Acs.ResourceSharing.Model.V20200110;

namespace Aliyun.Acs.ResourceSharing.Transform.V20200110
{
    public class ListResourceShareInvitationsResponseUnmarshaller
    {
        public static ListResourceShareInvitationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListResourceShareInvitationsResponse listResourceShareInvitationsResponse = new ListResourceShareInvitationsResponse();

			listResourceShareInvitationsResponse.HttpResponse = _ctx.HttpResponse;
			listResourceShareInvitationsResponse.NextToken = _ctx.StringValue("ListResourceShareInvitations.NextToken");
			listResourceShareInvitationsResponse.RequestId = _ctx.StringValue("ListResourceShareInvitations.RequestId");

			List<ListResourceShareInvitationsResponse.ListResourceShareInvitations_ResourceShareInvitation> listResourceShareInvitationsResponse_resourceShareInvitations = new List<ListResourceShareInvitationsResponse.ListResourceShareInvitations_ResourceShareInvitation>();
			for (int i = 0; i < _ctx.Length("ListResourceShareInvitations.ResourceShareInvitations.Length"); i++) {
				ListResourceShareInvitationsResponse.ListResourceShareInvitations_ResourceShareInvitation resourceShareInvitation = new ListResourceShareInvitationsResponse.ListResourceShareInvitations_ResourceShareInvitation();
				resourceShareInvitation.Status = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].Status");
				resourceShareInvitation.CreateTime = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].CreateTime");
				resourceShareInvitation.ResourceShareId = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].ResourceShareId");
				resourceShareInvitation.ResourceShareName = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].ResourceShareName");
				resourceShareInvitation.SenderAccountId = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].SenderAccountId");
				resourceShareInvitation.ReceiverAccountId = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].ReceiverAccountId");
				resourceShareInvitation.ResourceShareInvitationId = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].ResourceShareInvitationId");

				List<ListResourceShareInvitationsResponse.ListResourceShareInvitations_ResourceShareInvitation.ListResourceShareInvitations_InvitationFailedDetail> resourceShareInvitation_invitationFailedDetails = new List<ListResourceShareInvitationsResponse.ListResourceShareInvitations_ResourceShareInvitation.ListResourceShareInvitations_InvitationFailedDetail>();
				for (int j = 0; j < _ctx.Length("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].InvitationFailedDetails.Length"); j++) {
					ListResourceShareInvitationsResponse.ListResourceShareInvitations_ResourceShareInvitation.ListResourceShareInvitations_InvitationFailedDetail invitationFailedDetail = new ListResourceShareInvitationsResponse.ListResourceShareInvitations_ResourceShareInvitation.ListResourceShareInvitations_InvitationFailedDetail();
					invitationFailedDetail.Status = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].InvitationFailedDetails["+ j +"].Status");
					invitationFailedDetail.StatusMessage = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].InvitationFailedDetails["+ j +"].StatusMessage");
					invitationFailedDetail.AssociateType = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].InvitationFailedDetails["+ j +"].AssociateType");
					invitationFailedDetail.ResourceId = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].InvitationFailedDetails["+ j +"].ResourceId");
					invitationFailedDetail.ResourceType = _ctx.StringValue("ListResourceShareInvitations.ResourceShareInvitations["+ i +"].InvitationFailedDetails["+ j +"].ResourceType");

					resourceShareInvitation_invitationFailedDetails.Add(invitationFailedDetail);
				}
				resourceShareInvitation.InvitationFailedDetails = resourceShareInvitation_invitationFailedDetails;

				listResourceShareInvitationsResponse_resourceShareInvitations.Add(resourceShareInvitation);
			}
			listResourceShareInvitationsResponse.ResourceShareInvitations = listResourceShareInvitationsResponse_resourceShareInvitations;
        
			return listResourceShareInvitationsResponse;
        }
    }
}
