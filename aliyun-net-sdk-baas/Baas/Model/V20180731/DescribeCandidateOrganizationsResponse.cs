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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class DescribeCandidateOrganizationsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private List<DescribeCandidateOrganizations_DescribeCandidateOrganization> result;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public List<DescribeCandidateOrganizations_DescribeCandidateOrganization> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeCandidateOrganizations_DescribeCandidateOrganization
		{

			private string organizationId;

			private string organizationName;

			private string clusterState;

			private string serviceState;

			public string OrganizationId
			{
				get
				{
					return organizationId;
				}
				set	
				{
					organizationId = value;
				}
			}

			public string OrganizationName
			{
				get
				{
					return organizationName;
				}
				set	
				{
					organizationName = value;
				}
			}

			public string ClusterState
			{
				get
				{
					return clusterState;
				}
				set	
				{
					clusterState = value;
				}
			}

			public string ServiceState
			{
				get
				{
					return serviceState;
				}
				set	
				{
					serviceState = value;
				}
			}
		}
	}
}