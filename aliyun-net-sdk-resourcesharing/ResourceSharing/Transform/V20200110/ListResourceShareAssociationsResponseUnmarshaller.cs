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
    public class ListResourceShareAssociationsResponseUnmarshaller
    {
        public static ListResourceShareAssociationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListResourceShareAssociationsResponse listResourceShareAssociationsResponse = new ListResourceShareAssociationsResponse();

			listResourceShareAssociationsResponse.HttpResponse = _ctx.HttpResponse;
			listResourceShareAssociationsResponse.NextToken = _ctx.StringValue("ListResourceShareAssociations.NextToken");
			listResourceShareAssociationsResponse.RequestId = _ctx.StringValue("ListResourceShareAssociations.RequestId");

			List<ListResourceShareAssociationsResponse.ListResourceShareAssociations_ResourceShareAssociation> listResourceShareAssociationsResponse_resourceShareAssociations = new List<ListResourceShareAssociationsResponse.ListResourceShareAssociations_ResourceShareAssociation>();
			for (int i = 0; i < _ctx.Length("ListResourceShareAssociations.ResourceShareAssociations.Length"); i++) {
				ListResourceShareAssociationsResponse.ListResourceShareAssociations_ResourceShareAssociation resourceShareAssociation = new ListResourceShareAssociationsResponse.ListResourceShareAssociations_ResourceShareAssociation();
				resourceShareAssociation.UpdateTime = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].UpdateTime");
				resourceShareAssociation.EntityId = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].EntityId");
				resourceShareAssociation.ResourceShareName = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].ResourceShareName");
				resourceShareAssociation.CreateTime = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].CreateTime");
				resourceShareAssociation.EntityType = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].EntityType");
				resourceShareAssociation.ResourceShareId = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].ResourceShareId");
				resourceShareAssociation.AssociationStatusMessage = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].AssociationStatusMessage");
				resourceShareAssociation.AssociationType = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].AssociationType");
				resourceShareAssociation.AssociationStatus = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].AssociationStatus");
				resourceShareAssociation.External = _ctx.BooleanValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].External");
				resourceShareAssociation.TargetProperty = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].TargetProperty");

				List<ListResourceShareAssociationsResponse.ListResourceShareAssociations_ResourceShareAssociation.ListResourceShareAssociations_AssociationFailedDetail> resourceShareAssociation_associationFailedDetails = new List<ListResourceShareAssociationsResponse.ListResourceShareAssociations_ResourceShareAssociation.ListResourceShareAssociations_AssociationFailedDetail>();
				for (int j = 0; j < _ctx.Length("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].AssociationFailedDetails.Length"); j++) {
					ListResourceShareAssociationsResponse.ListResourceShareAssociations_ResourceShareAssociation.ListResourceShareAssociations_AssociationFailedDetail associationFailedDetail = new ListResourceShareAssociationsResponse.ListResourceShareAssociations_ResourceShareAssociation.ListResourceShareAssociations_AssociationFailedDetail();
					associationFailedDetail.Status = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].AssociationFailedDetails["+ j +"].Status");
					associationFailedDetail.StatusMessage = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].AssociationFailedDetails["+ j +"].StatusMessage");
					associationFailedDetail.AssociateType = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].AssociationFailedDetails["+ j +"].AssociateType");
					associationFailedDetail.EntityId = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].AssociationFailedDetails["+ j +"].EntityId");
					associationFailedDetail.EntityType = _ctx.StringValue("ListResourceShareAssociations.ResourceShareAssociations["+ i +"].AssociationFailedDetails["+ j +"].EntityType");

					resourceShareAssociation_associationFailedDetails.Add(associationFailedDetail);
				}
				resourceShareAssociation.AssociationFailedDetails = resourceShareAssociation_associationFailedDetails;

				listResourceShareAssociationsResponse_resourceShareAssociations.Add(resourceShareAssociation);
			}
			listResourceShareAssociationsResponse.ResourceShareAssociations = listResourceShareAssociationsResponse_resourceShareAssociations;
        
			return listResourceShareAssociationsResponse;
        }
    }
}
