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
	public class DescribeServiceMeshesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeServiceMeshes_ServiceMesh> serviceMeshes;

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

		public List<DescribeServiceMeshes_ServiceMesh> ServiceMeshes
		{
			get
			{
				return serviceMeshes;
			}
			set	
			{
				serviceMeshes = value;
			}
		}

		public class DescribeServiceMeshes_ServiceMesh
		{

			private List<string> clusters;

			private DescribeServiceMeshes_Endpoints endpoints;

			private DescribeServiceMeshes_ServiceMeshInfo serviceMeshInfo;

			private DescribeServiceMeshes_Spec spec;

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

			public DescribeServiceMeshes_Endpoints Endpoints
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

			public DescribeServiceMeshes_ServiceMeshInfo ServiceMeshInfo
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

			public DescribeServiceMeshes_Spec Spec
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

			public class DescribeServiceMeshes_Endpoints
			{

				private string intranetApiServerEndpoint;

				private string intranetPilotEndpoint;

				private string publicApiServerEndpoint;

				private string publicPilotEndpoint;

				private string reverseTunnelEndpoint;

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

				public string ReverseTunnelEndpoint
				{
					get
					{
						return reverseTunnelEndpoint;
					}
					set	
					{
						reverseTunnelEndpoint = value;
					}
				}
			}

			public class DescribeServiceMeshes_ServiceMeshInfo
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

			public class DescribeServiceMeshes_Spec
			{

				private DescribeServiceMeshes_LoadBalancer loadBalancer;

				private DescribeServiceMeshes_MeshConfig meshConfig;

				private DescribeServiceMeshes_Network network;

				public DescribeServiceMeshes_LoadBalancer LoadBalancer
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

				public DescribeServiceMeshes_MeshConfig MeshConfig
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

				public DescribeServiceMeshes_Network Network
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

				public class DescribeServiceMeshes_LoadBalancer
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

				public class DescribeServiceMeshes_MeshConfig
				{

					private bool? mtls;

					private string outboundTrafficPolicy;

					private bool? strictMtls;

					private bool? tracing;

					private bool? telemetry;

					private DescribeServiceMeshes_Pilot pilot;

					private DescribeServiceMeshes_SidecarInjector sidecarInjector;

					public bool? Mtls
					{
						get
						{
							return mtls;
						}
						set	
						{
							mtls = value;
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

					public bool? StrictMtls
					{
						get
						{
							return strictMtls;
						}
						set	
						{
							strictMtls = value;
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

					public DescribeServiceMeshes_Pilot Pilot
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

					public DescribeServiceMeshes_SidecarInjector SidecarInjector
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

					public class DescribeServiceMeshes_Pilot
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

					public class DescribeServiceMeshes_SidecarInjector
					{

						private bool? enableNamespacesByDefault;

						private bool? autoInjectionPolicyEnabled;

						private DescribeServiceMeshes_InitCNIConfiguration initCNIConfiguration;

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

						public DescribeServiceMeshes_InitCNIConfiguration InitCNIConfiguration
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

						public class DescribeServiceMeshes_InitCNIConfiguration
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

				public class DescribeServiceMeshes_Network
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
