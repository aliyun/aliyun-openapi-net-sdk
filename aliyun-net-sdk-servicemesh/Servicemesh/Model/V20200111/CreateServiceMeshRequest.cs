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
using Aliyun.Acs.servicemesh.Transform;
using Aliyun.Acs.servicemesh.Transform.V20200111;

namespace Aliyun.Acs.servicemesh.Model.V20200111
{
    public class CreateServiceMeshRequest : RpcAcsRequest<CreateServiceMeshResponse>
    {
        public CreateServiceMeshRequest()
            : base("servicemesh", "2020-01-11", "CreateServiceMesh", "servicemesh", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.servicemesh.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.servicemesh.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string proxyRequestCPU;

		private string oPALimitCPU;

		private bool? openAgentPolicy;

		private bool? opaEnabled;

		private string proxyLimitMemory;

		private string oPALogLevel;

		private string excludeIPRanges;

		private string istioVersion;

		private bool? tracing;

		private string includeIPRanges;

		private string excludeInboundPorts;

		private string oPALimitMemory;

		private string vSwitches;

		private string proxyLimitCPU;

		private string proxyRequestMemory;

		private string name;

		private bool? telemetry;

		private string oPARequestCPU;

		private string oPARequestMemory;

		private bool? enableAudit;

		private bool? localityLoadBalancing;

		private bool? apiServerPublicEip;

		private float? traceSampling;

		private bool? pilotPublicEip;

		private string auditProject;

		private string vpcId;

		private string excludeOutboundPorts;

		public string ProxyRequestCPU
		{
			get
			{
				return proxyRequestCPU;
			}
			set	
			{
				proxyRequestCPU = value;
				DictionaryUtil.Add(BodyParameters, "ProxyRequestCPU", value);
			}
		}

		public string OPALimitCPU
		{
			get
			{
				return oPALimitCPU;
			}
			set	
			{
				oPALimitCPU = value;
				DictionaryUtil.Add(BodyParameters, "OPALimitCPU", value);
			}
		}

		public bool? OpenAgentPolicy
		{
			get
			{
				return openAgentPolicy;
			}
			set	
			{
				openAgentPolicy = value;
				DictionaryUtil.Add(BodyParameters, "OpenAgentPolicy", value.ToString());
			}
		}

		public bool? OpaEnabled
		{
			get
			{
				return opaEnabled;
			}
			set	
			{
				opaEnabled = value;
				DictionaryUtil.Add(BodyParameters, "OpaEnabled", value.ToString());
			}
		}

		public string ProxyLimitMemory
		{
			get
			{
				return proxyLimitMemory;
			}
			set	
			{
				proxyLimitMemory = value;
				DictionaryUtil.Add(BodyParameters, "ProxyLimitMemory", value);
			}
		}

		public string OPALogLevel
		{
			get
			{
				return oPALogLevel;
			}
			set	
			{
				oPALogLevel = value;
				DictionaryUtil.Add(BodyParameters, "OPALogLevel", value);
			}
		}

		public string ExcludeIPRanges
		{
			get
			{
				return excludeIPRanges;
			}
			set	
			{
				excludeIPRanges = value;
				DictionaryUtil.Add(BodyParameters, "ExcludeIPRanges", value);
			}
		}

		public string IstioVersion
		{
			get
			{
				return istioVersion;
			}
			set	
			{
				istioVersion = value;
				DictionaryUtil.Add(BodyParameters, "IstioVersion", value);
			}
		}

		public bool? Tracing
		{
			get
			{
				return tracing;
			}
			set	
			{
				tracing = value;
				DictionaryUtil.Add(BodyParameters, "Tracing", value.ToString());
			}
		}

		public string IncludeIPRanges
		{
			get
			{
				return includeIPRanges;
			}
			set	
			{
				includeIPRanges = value;
				DictionaryUtil.Add(BodyParameters, "IncludeIPRanges", value);
			}
		}

		public string ExcludeInboundPorts
		{
			get
			{
				return excludeInboundPorts;
			}
			set	
			{
				excludeInboundPorts = value;
				DictionaryUtil.Add(BodyParameters, "ExcludeInboundPorts", value);
			}
		}

		public string OPALimitMemory
		{
			get
			{
				return oPALimitMemory;
			}
			set	
			{
				oPALimitMemory = value;
				DictionaryUtil.Add(BodyParameters, "OPALimitMemory", value);
			}
		}

		public string VSwitches
		{
			get
			{
				return vSwitches;
			}
			set	
			{
				vSwitches = value;
				DictionaryUtil.Add(BodyParameters, "VSwitches", value);
			}
		}

		public string ProxyLimitCPU
		{
			get
			{
				return proxyLimitCPU;
			}
			set	
			{
				proxyLimitCPU = value;
				DictionaryUtil.Add(BodyParameters, "ProxyLimitCPU", value);
			}
		}

		public string ProxyRequestMemory
		{
			get
			{
				return proxyRequestMemory;
			}
			set	
			{
				proxyRequestMemory = value;
				DictionaryUtil.Add(BodyParameters, "ProxyRequestMemory", value);
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
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public bool? Telemetry
		{
			get
			{
				return telemetry;
			}
			set	
			{
				telemetry = value;
				DictionaryUtil.Add(BodyParameters, "Telemetry", value.ToString());
			}
		}

		public string OPARequestCPU
		{
			get
			{
				return oPARequestCPU;
			}
			set	
			{
				oPARequestCPU = value;
				DictionaryUtil.Add(BodyParameters, "OPARequestCPU", value);
			}
		}

		public string OPARequestMemory
		{
			get
			{
				return oPARequestMemory;
			}
			set	
			{
				oPARequestMemory = value;
				DictionaryUtil.Add(BodyParameters, "OPARequestMemory", value);
			}
		}

		public bool? EnableAudit
		{
			get
			{
				return enableAudit;
			}
			set	
			{
				enableAudit = value;
				DictionaryUtil.Add(BodyParameters, "EnableAudit", value.ToString());
			}
		}

		public bool? LocalityLoadBalancing
		{
			get
			{
				return localityLoadBalancing;
			}
			set	
			{
				localityLoadBalancing = value;
				DictionaryUtil.Add(BodyParameters, "LocalityLoadBalancing", value.ToString());
			}
		}

		public bool? ApiServerPublicEip
		{
			get
			{
				return apiServerPublicEip;
			}
			set	
			{
				apiServerPublicEip = value;
				DictionaryUtil.Add(BodyParameters, "ApiServerPublicEip", value.ToString());
			}
		}

		public float? TraceSampling
		{
			get
			{
				return traceSampling;
			}
			set	
			{
				traceSampling = value;
				DictionaryUtil.Add(BodyParameters, "TraceSampling", value.ToString());
			}
		}

		public bool? PilotPublicEip
		{
			get
			{
				return pilotPublicEip;
			}
			set	
			{
				pilotPublicEip = value;
				DictionaryUtil.Add(BodyParameters, "PilotPublicEip", value.ToString());
			}
		}

		public string AuditProject
		{
			get
			{
				return auditProject;
			}
			set	
			{
				auditProject = value;
				DictionaryUtil.Add(BodyParameters, "AuditProject", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(BodyParameters, "VpcId", value);
			}
		}

		public string ExcludeOutboundPorts
		{
			get
			{
				return excludeOutboundPorts;
			}
			set	
			{
				excludeOutboundPorts = value;
				DictionaryUtil.Add(BodyParameters, "ExcludeOutboundPorts", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateServiceMeshResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateServiceMeshResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
