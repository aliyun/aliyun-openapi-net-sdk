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
using Aliyun.Acs.Smartag.Transform;
using Aliyun.Acs.Smartag.Transform.V20180313;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
    public class CreateHealthCheckRequest : RpcAcsRequest<CreateHealthCheckResponse>
    {
        public CreateHealthCheckRequest()
            : base("Smartag", "2018-03-13", "CreateHealthCheck", "smartag", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private int? probeInterval;

		private long? resourceOwnerId;

		private int? dstPort;

		private string description;

		private string type;

		private int? failCountThreshold;

		private int? probeTimeout;

		private int? rttFailThreshold;

		private int? rttThreshold;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string dstIpAddr;

		private long? ownerId;

		private string srcIpAddr;

		private string name;

		private string smartAGId;

		private int? srcPort;

		private int? probeCount;

		public int? ProbeInterval
		{
			get
			{
				return probeInterval;
			}
			set	
			{
				probeInterval = value;
				DictionaryUtil.Add(QueryParameters, "ProbeInterval", value.ToString());
			}
		}

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

		public int? DstPort
		{
			get
			{
				return dstPort;
			}
			set	
			{
				dstPort = value;
				DictionaryUtil.Add(QueryParameters, "DstPort", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public int? FailCountThreshold
		{
			get
			{
				return failCountThreshold;
			}
			set	
			{
				failCountThreshold = value;
				DictionaryUtil.Add(QueryParameters, "FailCountThreshold", value.ToString());
			}
		}

		public int? ProbeTimeout
		{
			get
			{
				return probeTimeout;
			}
			set	
			{
				probeTimeout = value;
				DictionaryUtil.Add(QueryParameters, "ProbeTimeout", value.ToString());
			}
		}

		public int? RttFailThreshold
		{
			get
			{
				return rttFailThreshold;
			}
			set	
			{
				rttFailThreshold = value;
				DictionaryUtil.Add(QueryParameters, "RttFailThreshold", value.ToString());
			}
		}

		public int? RttThreshold
		{
			get
			{
				return rttThreshold;
			}
			set	
			{
				rttThreshold = value;
				DictionaryUtil.Add(QueryParameters, "RttThreshold", value.ToString());
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

		public string DstIpAddr
		{
			get
			{
				return dstIpAddr;
			}
			set	
			{
				dstIpAddr = value;
				DictionaryUtil.Add(QueryParameters, "DstIpAddr", value);
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

		public string SrcIpAddr
		{
			get
			{
				return srcIpAddr;
			}
			set	
			{
				srcIpAddr = value;
				DictionaryUtil.Add(QueryParameters, "SrcIpAddr", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string SmartAGId
		{
			get
			{
				return smartAGId;
			}
			set	
			{
				smartAGId = value;
				DictionaryUtil.Add(QueryParameters, "SmartAGId", value);
			}
		}

		public int? SrcPort
		{
			get
			{
				return srcPort;
			}
			set	
			{
				srcPort = value;
				DictionaryUtil.Add(QueryParameters, "SrcPort", value.ToString());
			}
		}

		public int? ProbeCount
		{
			get
			{
				return probeCount;
			}
			set	
			{
				probeCount = value;
				DictionaryUtil.Add(QueryParameters, "ProbeCount", value.ToString());
			}
		}

        public override CreateHealthCheckResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateHealthCheckResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
