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
    public class ModifyFlowLogAttributeRequest : RpcAcsRequest<ModifyFlowLogAttributeResponse>
    {
        public ModifyFlowLogAttributeRequest()
            : base("Smartag", "2018-03-13", "ModifyFlowLogAttribute", "smartag", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string netflowVersion;

		private string description;

		private int? inactiveAging;

		private string slsRegionId;

		private int? activeAging;

		private string outputType;

		private string projectName;

		private string logstoreName;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? netflowServerPort;

		private long? ownerId;

		private string netflowServerIp;

		private string name;

		private string flowLogId;

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

		public string NetflowVersion
		{
			get
			{
				return netflowVersion;
			}
			set	
			{
				netflowVersion = value;
				DictionaryUtil.Add(QueryParameters, "NetflowVersion", value);
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

		public int? InactiveAging
		{
			get
			{
				return inactiveAging;
			}
			set	
			{
				inactiveAging = value;
				DictionaryUtil.Add(QueryParameters, "InactiveAging", value.ToString());
			}
		}

		public string SlsRegionId
		{
			get
			{
				return slsRegionId;
			}
			set	
			{
				slsRegionId = value;
				DictionaryUtil.Add(QueryParameters, "SlsRegionId", value);
			}
		}

		public int? ActiveAging
		{
			get
			{
				return activeAging;
			}
			set	
			{
				activeAging = value;
				DictionaryUtil.Add(QueryParameters, "ActiveAging", value.ToString());
			}
		}

		public string OutputType
		{
			get
			{
				return outputType;
			}
			set	
			{
				outputType = value;
				DictionaryUtil.Add(QueryParameters, "OutputType", value);
			}
		}

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(QueryParameters, "ProjectName", value);
			}
		}

		public string LogstoreName
		{
			get
			{
				return logstoreName;
			}
			set	
			{
				logstoreName = value;
				DictionaryUtil.Add(QueryParameters, "LogstoreName", value);
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

		public int? NetflowServerPort
		{
			get
			{
				return netflowServerPort;
			}
			set	
			{
				netflowServerPort = value;
				DictionaryUtil.Add(QueryParameters, "NetflowServerPort", value.ToString());
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

		public string NetflowServerIp
		{
			get
			{
				return netflowServerIp;
			}
			set	
			{
				netflowServerIp = value;
				DictionaryUtil.Add(QueryParameters, "NetflowServerIp", value);
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

		public string FlowLogId
		{
			get
			{
				return flowLogId;
			}
			set	
			{
				flowLogId = value;
				DictionaryUtil.Add(QueryParameters, "FlowLogId", value);
			}
		}

        public override ModifyFlowLogAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyFlowLogAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
