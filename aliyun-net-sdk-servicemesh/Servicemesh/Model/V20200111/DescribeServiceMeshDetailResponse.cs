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

namespace Aliyun.Acs.servicemesh.Model.V20200111
{
	public class DescribeServiceMeshDetailResponse : AcsResponse
	{

		private string requestId;

		private DescribeServiceMeshDetail_ServiceMesh serviceMesh;

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

		public DescribeServiceMeshDetail_ServiceMesh ServiceMesh
		{
			get
			{
				return serviceMesh;
			}
			set	
			{
				serviceMesh = value;
			}
		}

		public class DescribeServiceMeshDetail_ServiceMesh
		{

			private List<string> clusters;

			private DescribeServiceMeshDetail_Endpoints endpoints;

			private DescribeServiceMeshDetail_ServiceMeshInfo serviceMeshInfo;

			private DescribeServiceMeshDetail_Spec spec;

			public List<string> Clusters
			{
				get
				{
					return clusters;
				}
				set	
				{
					clusters = value;
				}
			}

			public DescribeServiceMeshDetail_Endpoints Endpoints
			{
				get
				{
					return endpoints;
				}
				set	
				{
					endpoints = value;
				}
			}

			public DescribeServiceMeshDetail_ServiceMeshInfo ServiceMeshInfo
			{
				get
				{
					return serviceMeshInfo;
				}
				set	
				{
					serviceMeshInfo = value;
				}
			}

			public DescribeServiceMeshDetail_Spec Spec
			{
				get
				{
					return spec;
				}
				set	
				{
					spec = value;
				}
			}

			public class DescribeServiceMeshDetail_Endpoints
			{

				private string intranetApiServerEndpoint;

				private string intranetPilotEndpoint;

				private string publicApiServerEndpoint;

				private string publicPilotEndpoint;

				public string IntranetApiServerEndpoint
				{
					get
					{
						return intranetApiServerEndpoint;
					}
					set	
					{
						intranetApiServerEndpoint = value;
					}
				}

				public string IntranetPilotEndpoint
				{
					get
					{
						return intranetPilotEndpoint;
					}
					set	
					{
						intranetPilotEndpoint = value;
					}
				}

				public string PublicApiServerEndpoint
				{
					get
					{
						return publicApiServerEndpoint;
					}
					set	
					{
						publicApiServerEndpoint = value;
					}
				}

				public string PublicPilotEndpoint
				{
					get
					{
						return publicPilotEndpoint;
					}
					set	
					{
						publicPilotEndpoint = value;
					}
				}
			}

			public class DescribeServiceMeshDetail_ServiceMeshInfo
			{

				private string creationTime;

				private string errorMessage;

				private string name;

				private string regionId;

				private string serviceMeshId;

				private string state;

				private string updateTime;

				private string version;

				public string CreationTime
				{
					get
					{
						return creationTime;
					}
					set	
					{
						creationTime = value;
					}
				}

				public string ErrorMessage
				{
					get
					{
						return errorMessage;
					}
					set	
					{
						errorMessage = value;
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

				public string ServiceMeshId
				{
					get
					{
						return serviceMeshId;
					}
					set	
					{
						serviceMeshId = value;
					}
				}

				public string State
				{
					get
					{
						return state;
					}
					set	
					{
						state = value;
					}
				}

				public string UpdateTime
				{
					get
					{
						return updateTime;
					}
					set	
					{
						updateTime = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}
			}

			public class DescribeServiceMeshDetail_Spec
			{

				private DescribeServiceMeshDetail_LoadBalancer loadBalancer;

				private DescribeServiceMeshDetail_MeshConfig meshConfig;

				private DescribeServiceMeshDetail_Network network;

				public DescribeServiceMeshDetail_LoadBalancer LoadBalancer
				{
					get
					{
						return loadBalancer;
					}
					set	
					{
						loadBalancer = value;
					}
				}

				public DescribeServiceMeshDetail_MeshConfig MeshConfig
				{
					get
					{
						return meshConfig;
					}
					set	
					{
						meshConfig = value;
					}
				}

				public DescribeServiceMeshDetail_Network Network
				{
					get
					{
						return network;
					}
					set	
					{
						network = value;
					}
				}

				public class DescribeServiceMeshDetail_LoadBalancer
				{

					private string apiServerLoadbalancerId;

					private bool? apiServerPublicEip;

					private bool? pilotPublicEip;

					private string pilotPublicLoadbalancerId;

					public string ApiServerLoadbalancerId
					{
						get
						{
							return apiServerLoadbalancerId;
						}
						set	
						{
							apiServerLoadbalancerId = value;
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
						}
					}

					public string PilotPublicLoadbalancerId
					{
						get
						{
							return pilotPublicLoadbalancerId;
						}
						set	
						{
							pilotPublicLoadbalancerId = value;
						}
					}
				}

				public class DescribeServiceMeshDetail_MeshConfig
				{

					private bool? enableLocalityLB;

					private bool? telemetry;

					private bool? tracing;

					private bool? customizedZipkin;

					private string outboundTrafficPolicy;

					private string includeIPRanges;

					private DescribeServiceMeshDetail_Pilot pilot;

					private DescribeServiceMeshDetail_OPA oPA;

					private DescribeServiceMeshDetail_Audit audit;

					private DescribeServiceMeshDetail_Proxy proxy;

					private DescribeServiceMeshDetail_SidecarInjector sidecarInjector;

					public bool? EnableLocalityLB
					{
						get
						{
							return enableLocalityLB;
						}
						set	
						{
							enableLocalityLB = value;
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
						}
					}

					public DescribeServiceMeshDetail_Pilot Pilot
					{
						get
						{
							return pilot;
						}
						set	
						{
							pilot = value;
						}
					}

					public DescribeServiceMeshDetail_OPA OPA
					{
						get
						{
							return oPA;
						}
						set	
						{
							oPA = value;
						}
					}

					public DescribeServiceMeshDetail_Audit Audit
					{
						get
						{
							return audit;
						}
						set	
						{
							audit = value;
						}
					}

					public DescribeServiceMeshDetail_Proxy Proxy
					{
						get
						{
							return proxy;
						}
						set	
						{
							proxy = value;
						}
					}

					public DescribeServiceMeshDetail_SidecarInjector SidecarInjector
					{
						get
						{
							return sidecarInjector;
						}
						set	
						{
							sidecarInjector = value;
						}
					}

					public class DescribeServiceMeshDetail_Pilot
					{

						private float? traceSampling;

						private bool? http10Enabled;

						public float? TraceSampling
						{
							get
							{
								return traceSampling;
							}
							set	
							{
								traceSampling = value;
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
							}
						}
					}

					public class DescribeServiceMeshDetail_OPA
					{

						private bool? enabled;

						private string logLevel;

						private string requestCPU;

						private string requestMemory;

						private string limitCPU;

						private string limitMemory;

						public bool? Enabled
						{
							get
							{
								return enabled;
							}
							set	
							{
								enabled = value;
							}
						}

						public string LogLevel
						{
							get
							{
								return logLevel;
							}
							set	
							{
								logLevel = value;
							}
						}

						public string RequestCPU
						{
							get
							{
								return requestCPU;
							}
							set	
							{
								requestCPU = value;
							}
						}

						public string RequestMemory
						{
							get
							{
								return requestMemory;
							}
							set	
							{
								requestMemory = value;
							}
						}

						public string LimitCPU
						{
							get
							{
								return limitCPU;
							}
							set	
							{
								limitCPU = value;
							}
						}

						public string LimitMemory
						{
							get
							{
								return limitMemory;
							}
							set	
							{
								limitMemory = value;
							}
						}
					}

					public class DescribeServiceMeshDetail_Audit
					{

						private bool? enabled;

						private string project;

						public bool? Enabled
						{
							get
							{
								return enabled;
							}
							set	
							{
								enabled = value;
							}
						}

						public string Project
						{
							get
							{
								return project;
							}
							set	
							{
								project = value;
							}
						}
					}

					public class DescribeServiceMeshDetail_Proxy
					{

						private string clusterDomain;

						private string requestCPU;

						private string requestMemory;

						private string limitCPU;

						private string limitMemory;

						public string ClusterDomain
						{
							get
							{
								return clusterDomain;
							}
							set	
							{
								clusterDomain = value;
							}
						}

						public string RequestCPU
						{
							get
							{
								return requestCPU;
							}
							set	
							{
								requestCPU = value;
							}
						}

						public string RequestMemory
						{
							get
							{
								return requestMemory;
							}
							set	
							{
								requestMemory = value;
							}
						}

						public string LimitCPU
						{
							get
							{
								return limitCPU;
							}
							set	
							{
								limitCPU = value;
							}
						}

						public string LimitMemory
						{
							get
							{
								return limitMemory;
							}
							set	
							{
								limitMemory = value;
							}
						}
					}

					public class DescribeServiceMeshDetail_SidecarInjector
					{

						private bool? enableNamespacesByDefault;

						private bool? autoInjectionPolicyEnabled;

						private string requestCPU;

						private string requestMemory;

						private string limitCPU;

						private string limitMemory;

						private string sidecarInjectorWebhookAsYaml;

						private DescribeServiceMeshDetail_InitCNIConfiguration initCNIConfiguration;

						public bool? EnableNamespacesByDefault
						{
							get
							{
								return enableNamespacesByDefault;
							}
							set	
							{
								enableNamespacesByDefault = value;
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
							}
						}

						public string RequestCPU
						{
							get
							{
								return requestCPU;
							}
							set	
							{
								requestCPU = value;
							}
						}

						public string RequestMemory
						{
							get
							{
								return requestMemory;
							}
							set	
							{
								requestMemory = value;
							}
						}

						public string LimitCPU
						{
							get
							{
								return limitCPU;
							}
							set	
							{
								limitCPU = value;
							}
						}

						public string LimitMemory
						{
							get
							{
								return limitMemory;
							}
							set	
							{
								limitMemory = value;
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
							}
						}

						public DescribeServiceMeshDetail_InitCNIConfiguration InitCNIConfiguration
						{
							get
							{
								return initCNIConfiguration;
							}
							set	
							{
								initCNIConfiguration = value;
							}
						}

						public class DescribeServiceMeshDetail_InitCNIConfiguration
						{

							private bool? enabled;

							private string excludeNamespaces;

							public bool? Enabled
							{
								get
								{
									return enabled;
								}
								set	
								{
									enabled = value;
								}
							}

							public string ExcludeNamespaces
							{
								get
								{
									return excludeNamespaces;
								}
								set	
								{
									excludeNamespaces = value;
								}
							}
						}
					}
				}

				public class DescribeServiceMeshDetail_Network
				{

					private string securityGroupId;

					private string vpcId;

					private List<string> vSwitches;

					public string SecurityGroupId
					{
						get
						{
							return securityGroupId;
						}
						set	
						{
							securityGroupId = value;
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
						}
					}

					public List<string> VSwitches
					{
						get
						{
							return vSwitches;
						}
						set	
						{
							vSwitches = value;
						}
					}
				}
			}
		}
	}
}
