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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class ListVpnCertificateAssociationsResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? totalCount;

		private int? maxResults;

		private List<ListVpnCertificateAssociations_VpnCertificateRelation> vpnCertificateRelations;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<ListVpnCertificateAssociations_VpnCertificateRelation> VpnCertificateRelations
		{
			get
			{
				return vpnCertificateRelations;
			}
			set	
			{
				vpnCertificateRelations = value;
			}
		}

		public class ListVpnCertificateAssociations_VpnCertificateRelation
		{

			private string vpnGatewayId;

			private string certificateType;

			private string certificateId;

			private string associationTime;

			private string regionId;

			public string VpnGatewayId
			{
				get
				{
					return vpnGatewayId;
				}
				set	
				{
					vpnGatewayId = value;
				}
			}

			public string CertificateType
			{
				get
				{
					return certificateType;
				}
				set	
				{
					certificateType = value;
				}
			}

			public string CertificateId
			{
				get
				{
					return certificateId;
				}
				set	
				{
					certificateId = value;
				}
			}

			public string AssociationTime
			{
				get
				{
					return associationTime;
				}
				set	
				{
					associationTime = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}
		}
	}
}
