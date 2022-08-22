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
	public class DescribePhysicalConnectionLOAResponse : AcsResponse
	{

		private string requestId;

		private DescribePhysicalConnectionLOA_PhysicalConnectionLOAType physicalConnectionLOAType;

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

		public DescribePhysicalConnectionLOA_PhysicalConnectionLOAType PhysicalConnectionLOAType
		{
			get
			{
				return physicalConnectionLOAType;
			}
			set	
			{
				physicalConnectionLOAType = value;
			}
		}

		public class DescribePhysicalConnectionLOA_PhysicalConnectionLOAType
		{

			private string status;

			private string lineLabel;

			private string lineCode;

			private string constructionTime;

			private string sI;

			private string loaUrl;

			private string companyLocalizedName;

			private string instanceId;

			private string lineType;

			private string companyName;

			private List<DescribePhysicalConnectionLOA_PMInfoItem> pMInfo;

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string LineLabel
			{
				get
				{
					return lineLabel;
				}
				set	
				{
					lineLabel = value;
				}
			}

			public string LineCode
			{
				get
				{
					return lineCode;
				}
				set	
				{
					lineCode = value;
				}
			}

			public string ConstructionTime
			{
				get
				{
					return constructionTime;
				}
				set	
				{
					constructionTime = value;
				}
			}

			public string SI
			{
				get
				{
					return sI;
				}
				set	
				{
					sI = value;
				}
			}

			public string LoaUrl
			{
				get
				{
					return loaUrl;
				}
				set	
				{
					loaUrl = value;
				}
			}

			public string CompanyLocalizedName
			{
				get
				{
					return companyLocalizedName;
				}
				set	
				{
					companyLocalizedName = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string LineType
			{
				get
				{
					return lineType;
				}
				set	
				{
					lineType = value;
				}
			}

			public string CompanyName
			{
				get
				{
					return companyName;
				}
				set	
				{
					companyName = value;
				}
			}

			public List<DescribePhysicalConnectionLOA_PMInfoItem> PMInfo
			{
				get
				{
					return pMInfo;
				}
				set	
				{
					pMInfo = value;
				}
			}

			public class DescribePhysicalConnectionLOA_PMInfoItem
			{

				private string pMGender;

				private string pMCertificateNo;

				private string pMName;

				private string pMCertificateType;

				private string pMContactInfo;

				public string PMGender
				{
					get
					{
						return pMGender;
					}
					set	
					{
						pMGender = value;
					}
				}

				public string PMCertificateNo
				{
					get
					{
						return pMCertificateNo;
					}
					set	
					{
						pMCertificateNo = value;
					}
				}

				public string PMName
				{
					get
					{
						return pMName;
					}
					set	
					{
						pMName = value;
					}
				}

				public string PMCertificateType
				{
					get
					{
						return pMCertificateType;
					}
					set	
					{
						pMCertificateType = value;
					}
				}

				public string PMContactInfo
				{
					get
					{
						return pMContactInfo;
					}
					set	
					{
						pMContactInfo = value;
					}
				}
			}
		}
	}
}
