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
    public class DisassociateResourceShareResponseUnmarshaller
    {
        public static DisassociateResourceShareResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DisassociateResourceShareResponse disassociateResourceShareResponse = new DisassociateResourceShareResponse();

			disassociateResourceShareResponse.HttpResponse = _ctx.HttpResponse;
			disassociateResourceShareResponse.RequestId = _ctx.StringValue("DisassociateResourceShare.RequestId");

			List<DisassociateResourceShareResponse.DisassociateResourceShare_ResourceShareAssociation> disassociateResourceShareResponse_resourceShareAssociations = new List<DisassociateResourceShareResponse.DisassociateResourceShare_ResourceShareAssociation>();
			for (int i = 0; i < _ctx.Length("DisassociateResourceShare.ResourceShareAssociations.Length"); i++) {
				DisassociateResourceShareResponse.DisassociateResourceShare_ResourceShareAssociation resourceShareAssociation = new DisassociateResourceShareResponse.DisassociateResourceShare_ResourceShareAssociation();
				resourceShareAssociation.UpdateTime = _ctx.StringValue("DisassociateResourceShare.ResourceShareAssociations["+ i +"].UpdateTime");
				resourceShareAssociation.EntityId = _ctx.StringValue("DisassociateResourceShare.ResourceShareAssociations["+ i +"].EntityId");
				resourceShareAssociation.ResourceShareName = _ctx.StringValue("DisassociateResourceShare.ResourceShareAssociations["+ i +"].ResourceShareName");
				resourceShareAssociation.CreateTime = _ctx.StringValue("DisassociateResourceShare.ResourceShareAssociations["+ i +"].CreateTime");
				resourceShareAssociation.EntityType = _ctx.StringValue("DisassociateResourceShare.ResourceShareAssociations["+ i +"].EntityType");
				resourceShareAssociation.ResourceShareId = _ctx.StringValue("DisassociateResourceShare.ResourceShareAssociations["+ i +"].ResourceShareId");
				resourceShareAssociation.AssociationStatusMessage = _ctx.StringValue("DisassociateResourceShare.ResourceShareAssociations["+ i +"].AssociationStatusMessage");
				resourceShareAssociation.AssociationType = _ctx.StringValue("DisassociateResourceShare.ResourceShareAssociations["+ i +"].AssociationType");
				resourceShareAssociation.AssociationStatus = _ctx.StringValue("DisassociateResourceShare.ResourceShareAssociations["+ i +"].AssociationStatus");
				resourceShareAssociation.TargetProperty = _ctx.StringValue("DisassociateResourceShare.ResourceShareAssociations["+ i +"].TargetProperty");

				disassociateResourceShareResponse_resourceShareAssociations.Add(resourceShareAssociation);
			}
			disassociateResourceShareResponse.ResourceShareAssociations = disassociateResourceShareResponse_resourceShareAssociations;
        
			return disassociateResourceShareResponse;
        }
    }
}
