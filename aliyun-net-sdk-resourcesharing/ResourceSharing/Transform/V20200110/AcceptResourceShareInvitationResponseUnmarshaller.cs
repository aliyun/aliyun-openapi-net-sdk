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
    public class AcceptResourceShareInvitationResponseUnmarshaller
    {
        public static AcceptResourceShareInvitationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AcceptResourceShareInvitationResponse acceptResourceShareInvitationResponse = new AcceptResourceShareInvitationResponse();

			acceptResourceShareInvitationResponse.HttpResponse = _ctx.HttpResponse;
			acceptResourceShareInvitationResponse.RequestId = _ctx.StringValue("AcceptResourceShareInvitation.RequestId");

			AcceptResourceShareInvitationResponse.AcceptResourceShareInvitation_ResourceShareInvitation resourceShareInvitation = new AcceptResourceShareInvitationResponse.AcceptResourceShareInvitation_ResourceShareInvitation();
			resourceShareInvitation.ResourceShareInvitationId = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.ResourceShareInvitationId");
			resourceShareInvitation.ResourceShareId = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.ResourceShareId");
			resourceShareInvitation.ResourceShareName = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.ResourceShareName");
			resourceShareInvitation.SenderAccountId = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.SenderAccountId");
			resourceShareInvitation.ReceiverAccountId = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.ReceiverAccountId");
			resourceShareInvitation.CreateTime = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.CreateTime");
			resourceShareInvitation.Status = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.Status");

			List<AcceptResourceShareInvitationResponse.AcceptResourceShareInvitation_ResourceShareInvitation.AcceptResourceShareInvitation_AcceptInvitationFailedDetail> resourceShareInvitation_acceptInvitationFailedDetails = new List<AcceptResourceShareInvitationResponse.AcceptResourceShareInvitation_ResourceShareInvitation.AcceptResourceShareInvitation_AcceptInvitationFailedDetail>();
			for (int i = 0; i < _ctx.Length("AcceptResourceShareInvitation.ResourceShareInvitation.AcceptInvitationFailedDetails.Length"); i++) {
				AcceptResourceShareInvitationResponse.AcceptResourceShareInvitation_ResourceShareInvitation.AcceptResourceShareInvitation_AcceptInvitationFailedDetail acceptInvitationFailedDetail = new AcceptResourceShareInvitationResponse.AcceptResourceShareInvitation_ResourceShareInvitation.AcceptResourceShareInvitation_AcceptInvitationFailedDetail();
				acceptInvitationFailedDetail.Status = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.AcceptInvitationFailedDetails["+ i +"].Status");
				acceptInvitationFailedDetail.StatusMessage = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.AcceptInvitationFailedDetails["+ i +"].StatusMessage");
				acceptInvitationFailedDetail.AssociateType = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.AcceptInvitationFailedDetails["+ i +"].AssociateType");
				acceptInvitationFailedDetail.ResourceId = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.AcceptInvitationFailedDetails["+ i +"].ResourceId");
				acceptInvitationFailedDetail.ResourceType = _ctx.StringValue("AcceptResourceShareInvitation.ResourceShareInvitation.AcceptInvitationFailedDetails["+ i +"].ResourceType");

				resourceShareInvitation_acceptInvitationFailedDetails.Add(acceptInvitationFailedDetail);
			}
			resourceShareInvitation.AcceptInvitationFailedDetails = resourceShareInvitation_acceptInvitationFailedDetails;
			acceptResourceShareInvitationResponse.ResourceShareInvitation = resourceShareInvitation;
        
			return acceptResourceShareInvitationResponse;
        }
    }
}
