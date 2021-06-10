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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class ApplyPhysicalConnectionLOARequest : RpcAcsRequest<ApplyPhysicalConnectionLOAResponse>
    {
        public ApplyPhysicalConnectionLOARequest()
            : base("Vpc", "2016-04-28", "ApplyPhysicalConnectionLOA", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string lineType;

		private string si;

		private string peerLocation;

		private string resourceOwnerAccount;

		private int? bandwidth;

		private string ownerAccount;

		private string constructionTime;

		private long? ownerId;

		private string instanceId;

		private string companyName;

		private List<PMInfo> pMInfos = new List<PMInfo>(){ };

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
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
				DictionaryUtil.Add(QueryParameters, "LineType", value);
			}
		}

		public string Si
		{
			get
			{
				return si;
			}
			set	
			{
				si = value;
				DictionaryUtil.Add(QueryParameters, "Si", value);
			}
		}

		public string PeerLocation
		{
			get
			{
				return peerLocation;
			}
			set	
			{
				peerLocation = value;
				DictionaryUtil.Add(QueryParameters, "PeerLocation", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public int? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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
				DictionaryUtil.Add(QueryParameters, "ConstructionTime", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
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
				DictionaryUtil.Add(QueryParameters, "CompanyName", value);
			}
		}

		public List<PMInfo> PMInfos
		{
			get
			{
				return pMInfos;
			}

			set
			{
				pMInfos = value;
				for (int i = 0; i < pMInfos.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PMInfo." + (i + 1) + ".PMCertificateNo", pMInfos[i].PMCertificateNo);
					DictionaryUtil.Add(QueryParameters,"PMInfo." + (i + 1) + ".PMName", pMInfos[i].PMName);
					DictionaryUtil.Add(QueryParameters,"PMInfo." + (i + 1) + ".PMCertificateType", pMInfos[i].PMCertificateType);
					DictionaryUtil.Add(QueryParameters,"PMInfo." + (i + 1) + ".PMContactInfo", pMInfos[i].PMContactInfo);
					DictionaryUtil.Add(QueryParameters,"PMInfo." + (i + 1) + ".PMGender", pMInfos[i].PMGender);
				}
			}
		}

		public class PMInfo
		{

			private string pMCertificateNo;

			private string pMName;

			private string pMCertificateType;

			private string pMContactInfo;

			private string pMGender;

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
		}

        public override ApplyPhysicalConnectionLOAResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ApplyPhysicalConnectionLOAResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
