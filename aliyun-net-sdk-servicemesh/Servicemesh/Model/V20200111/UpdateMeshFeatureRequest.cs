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
    public class UpdateMeshFeatureRequest : RpcAcsRequest<UpdateMeshFeatureResponse>
    {
        public UpdateMeshFeatureRequest()
            : base("servicemesh", "2020-01-11", "UpdateMeshFeature", "servicemesh", "openAPI")
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

		private string cniExcludeNamespaces;

		private string oPALogLevel;

		private bool? customizedZipkin;

		private string sidecarInjectorRequestCPU;

		private bool? cniEnabled;

		private bool? tracing;

		private string includeIPRanges;

		private string oPALimitMemory;

		private string proxyLimitCPU;

		private string proxyRequestMemory;

		private bool? telemetry;

		private string oPARequestCPU;

		private string sidecarInjectorWebhookAsYaml;

		private string oPARequestMemory;

		private bool? autoInjectionPolicyEnabled;

		private string sidecarInjectorLimitMemory;

		private bool? enableAudit;

		private string clusterDomain;

		private string sidecarInjectorRequestMemory;

		private string serviceMeshId;

		private bool? localityLoadBalancing;

		private string sidecarInjectorLimitCPU;

		private float? traceSampling;

		private bool? http10Enabled;

		private string auditProject;

		private string outboundTrafficPolicy;

		private bool? enableNamespacesByDefault;

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

		public string CniExcludeNamespaces
		{
			get
			{
				return cniExcludeNamespaces;
			}
			set	
			{
				cniExcludeNamespaces = value;
				DictionaryUtil.Add(BodyParameters, "CniExcludeNamespaces", value);
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

		public bool? CustomizedZipkin
		{
			get
			{
				return customizedZipkin;
			}
			set	
			{
				customizedZipkin = value;
				DictionaryUtil.Add(BodyParameters, "CustomizedZipkin", value.ToString());
			}
		}

		public string SidecarInjectorRequestCPU
		{
			get
			{
				return sidecarInjectorRequestCPU;
			}
			set	
			{
				sidecarInjectorRequestCPU = value;
				DictionaryUtil.Add(BodyParameters, "SidecarInjectorRequestCPU", value);
			}
		}

		public bool? CniEnabled
		{
			get
			{
				return cniEnabled;
			}
			set	
			{
				cniEnabled = value;
				DictionaryUtil.Add(BodyParameters, "CniEnabled", value.ToString());
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

		public string SidecarInjectorWebhookAsYaml
		{
			get
			{
				return sidecarInjectorWebhookAsYaml;
			}
			set	
			{
				sidecarInjectorWebhookAsYaml = value;
				DictionaryUtil.Add(BodyParameters, "SidecarInjectorWebhookAsYaml", value);
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

		public bool? AutoInjectionPolicyEnabled
		{
			get
			{
				return autoInjectionPolicyEnabled;
			}
			set	
			{
				autoInjectionPolicyEnabled = value;
				DictionaryUtil.Add(BodyParameters, "AutoInjectionPolicyEnabled", value.ToString());
			}
		}

		public string SidecarInjectorLimitMemory
		{
			get
			{
				return sidecarInjectorLimitMemory;
			}
			set	
			{
				sidecarInjectorLimitMemory = value;
				DictionaryUtil.Add(BodyParameters, "SidecarInjectorLimitMemory", value);
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

		public string ClusterDomain
		{
			get
			{
				return clusterDomain;
			}
			set	
			{
				clusterDomain = value;
				DictionaryUtil.Add(BodyParameters, "ClusterDomain", value);
			}
		}

		public string SidecarInjectorRequestMemory
		{
			get
			{
				return sidecarInjectorRequestMemory;
			}
			set	
			{
				sidecarInjectorRequestMemory = value;
				DictionaryUtil.Add(BodyParameters, "SidecarInjectorRequestMemory", value);
			}
		}

		public string ServiceMeshId
		{
			get
			{
				return serviceMeshId;
			}
			set	
			{
				serviceMeshId = value;
				DictionaryUtil.Add(BodyParameters, "ServiceMeshId", value);
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

		public string SidecarInjectorLimitCPU
		{
			get
			{
				return sidecarInjectorLimitCPU;
			}
			set	
			{
				sidecarInjectorLimitCPU = value;
				DictionaryUtil.Add(BodyParameters, "SidecarInjectorLimitCPU", value);
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

		public bool? Http10Enabled
		{
			get
			{
				return http10Enabled;
			}
			set	
			{
				http10Enabled = value;
				DictionaryUtil.Add(BodyParameters, "Http10Enabled", value.ToString());
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

		public string OutboundTrafficPolicy
		{
			get
			{
				return outboundTrafficPolicy;
			}
			set	
			{
				outboundTrafficPolicy = value;
				DictionaryUtil.Add(BodyParameters, "OutboundTrafficPolicy", value);
			}
		}

		public bool? EnableNamespacesByDefault
		{
			get
			{
				return enableNamespacesByDefault;
			}
			set	
			{
				enableNamespacesByDefault = value;
				DictionaryUtil.Add(BodyParameters, "EnableNamespacesByDefault", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateMeshFeatureResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateMeshFeatureResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
