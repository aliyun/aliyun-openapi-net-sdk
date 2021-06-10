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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListVpnCertificateAssociationsResponseUnmarshaller
    {
        public static ListVpnCertificateAssociationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpnCertificateAssociationsResponse listVpnCertificateAssociationsResponse = new ListVpnCertificateAssociationsResponse();

			listVpnCertificateAssociationsResponse.HttpResponse = _ctx.HttpResponse;
			listVpnCertificateAssociationsResponse.RequestId = _ctx.StringValue("ListVpnCertificateAssociations.RequestId");
			listVpnCertificateAssociationsResponse.NextToken = _ctx.StringValue("ListVpnCertificateAssociations.NextToken");
			listVpnCertificateAssociationsResponse.MaxResults = _ctx.IntegerValue("ListVpnCertificateAssociations.MaxResults");
			listVpnCertificateAssociationsResponse.TotalCount = _ctx.IntegerValue("ListVpnCertificateAssociations.TotalCount");

			List<ListVpnCertificateAssociationsResponse.ListVpnCertificateAssociations_VpnCertificateRelation> listVpnCertificateAssociationsResponse_vpnCertificateRelations = new List<ListVpnCertificateAssociationsResponse.ListVpnCertificateAssociations_VpnCertificateRelation>();
			for (int i = 0; i < _ctx.Length("ListVpnCertificateAssociations.VpnCertificateRelations.Length"); i++) {
				ListVpnCertificateAssociationsResponse.ListVpnCertificateAssociations_VpnCertificateRelation vpnCertificateRelation = new ListVpnCertificateAssociationsResponse.ListVpnCertificateAssociations_VpnCertificateRelation();
				vpnCertificateRelation.RegionId = _ctx.StringValue("ListVpnCertificateAssociations.VpnCertificateRelations["+ i +"].RegionId");
				vpnCertificateRelation.VpnGatewayId = _ctx.StringValue("ListVpnCertificateAssociations.VpnCertificateRelations["+ i +"].VpnGatewayId");
				vpnCertificateRelation.CertificateId = _ctx.StringValue("ListVpnCertificateAssociations.VpnCertificateRelations["+ i +"].CertificateId");
				vpnCertificateRelation.CertificateType = _ctx.StringValue("ListVpnCertificateAssociations.VpnCertificateRelations["+ i +"].CertificateType");
				vpnCertificateRelation.AssociationTime = _ctx.StringValue("ListVpnCertificateAssociations.VpnCertificateRelations["+ i +"].AssociationTime");

				listVpnCertificateAssociationsResponse_vpnCertificateRelations.Add(vpnCertificateRelation);
			}
			listVpnCertificateAssociationsResponse.VpnCertificateRelations = listVpnCertificateAssociationsResponse_vpnCertificateRelations;
        
			return listVpnCertificateAssociationsResponse;
        }
    }
}
