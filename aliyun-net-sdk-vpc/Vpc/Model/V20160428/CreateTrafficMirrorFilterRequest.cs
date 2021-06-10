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
    public class CreateTrafficMirrorFilterRequest : RpcAcsRequest<CreateTrafficMirrorFilterResponse>
    {
        public CreateTrafficMirrorFilterRequest()
            : base("Vpc", "2016-04-28", "CreateTrafficMirrorFilter", "vpc", "openAPI")
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

		private List<IngressRules> ingressRuless = new List<IngressRules>(){ };

		private string trafficMirrorFilterName;

		private List<EgressRules> egressRuless = new List<EgressRules>(){ };

		private bool? dryRun;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string trafficMirrorFilterDescription;

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

		public List<IngressRules> IngressRuless
		{
			get
			{
				return ingressRuless;
			}

			set
			{
				ingressRuless = value;
				for (int i = 0; i < ingressRuless.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"IngressRules." + (i + 1) + ".Priority", ingressRuless[i].Priority);
					DictionaryUtil.Add(QueryParameters,"IngressRules." + (i + 1) + ".Action", ingressRuless[i].Action);
					DictionaryUtil.Add(QueryParameters,"IngressRules." + (i + 1) + ".Protocol", ingressRuless[i].Protocol);
					DictionaryUtil.Add(QueryParameters,"IngressRules." + (i + 1) + ".DestinationCidrBlock", ingressRuless[i].DestinationCidrBlock);
					DictionaryUtil.Add(QueryParameters,"IngressRules." + (i + 1) + ".SourceCidrBlock", ingressRuless[i].SourceCidrBlock);
					DictionaryUtil.Add(QueryParameters,"IngressRules." + (i + 1) + ".DestinationPortRange", ingressRuless[i].DestinationPortRange);
					DictionaryUtil.Add(QueryParameters,"IngressRules." + (i + 1) + ".SourcePortRange", ingressRuless[i].SourcePortRange);
				}
			}
		}

		public string TrafficMirrorFilterName
		{
			get
			{
				return trafficMirrorFilterName;
			}
			set	
			{
				trafficMirrorFilterName = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorFilterName", value);
			}
		}

		public List<EgressRules> EgressRuless
		{
			get
			{
				return egressRuless;
			}

			set
			{
				egressRuless = value;
				for (int i = 0; i < egressRuless.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"EgressRules." + (i + 1) + ".Priority", egressRuless[i].Priority);
					DictionaryUtil.Add(QueryParameters,"EgressRules." + (i + 1) + ".Action", egressRuless[i].Action);
					DictionaryUtil.Add(QueryParameters,"EgressRules." + (i + 1) + ".Protocol", egressRuless[i].Protocol);
					DictionaryUtil.Add(QueryParameters,"EgressRules." + (i + 1) + ".DestinationCidrBlock", egressRuless[i].DestinationCidrBlock);
					DictionaryUtil.Add(QueryParameters,"EgressRules." + (i + 1) + ".SourceCidrBlock", egressRuless[i].SourceCidrBlock);
					DictionaryUtil.Add(QueryParameters,"EgressRules." + (i + 1) + ".DestinationPortRange", egressRuless[i].DestinationPortRange);
					DictionaryUtil.Add(QueryParameters,"EgressRules." + (i + 1) + ".SourcePortRange", egressRuless[i].SourcePortRange);
				}
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
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

		public string TrafficMirrorFilterDescription
		{
			get
			{
				return trafficMirrorFilterDescription;
			}
			set	
			{
				trafficMirrorFilterDescription = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorFilterDescription", value);
			}
		}

		public class IngressRules
		{

			private int? priority;

			private string action;

			private string protocol;

			private string destinationCidrBlock;

			private string sourceCidrBlock;

			private string destinationPortRange;

			private string sourcePortRange;

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string Action
			{
				get
				{
					return action;
				}
				set	
				{
					action = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public string DestinationCidrBlock
			{
				get
				{
					return destinationCidrBlock;
				}
				set	
				{
					destinationCidrBlock = value;
				}
			}

			public string SourceCidrBlock
			{
				get
				{
					return sourceCidrBlock;
				}
				set	
				{
					sourceCidrBlock = value;
				}
			}

			public string DestinationPortRange
			{
				get
				{
					return destinationPortRange;
				}
				set	
				{
					destinationPortRange = value;
				}
			}

			public string SourcePortRange
			{
				get
				{
					return sourcePortRange;
				}
				set	
				{
					sourcePortRange = value;
				}
			}
		}

		public class EgressRules
		{

			private int? priority;

			private string action;

			private string protocol;

			private string destinationCidrBlock;

			private string sourceCidrBlock;

			private string destinationPortRange;

			private string sourcePortRange;

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public string Action
			{
				get
				{
					return action;
				}
				set	
				{
					action = value;
				}
			}

			public string Protocol
			{
				get
				{
					return protocol;
				}
				set	
				{
					protocol = value;
				}
			}

			public string DestinationCidrBlock
			{
				get
				{
					return destinationCidrBlock;
				}
				set	
				{
					destinationCidrBlock = value;
				}
			}

			public string SourceCidrBlock
			{
				get
				{
					return sourceCidrBlock;
				}
				set	
				{
					sourceCidrBlock = value;
				}
			}

			public string DestinationPortRange
			{
				get
				{
					return destinationPortRange;
				}
				set	
				{
					destinationPortRange = value;
				}
			}

			public string SourcePortRange
			{
				get
				{
					return sourcePortRange;
				}
				set	
				{
					sourcePortRange = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTrafficMirrorFilterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTrafficMirrorFilterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
