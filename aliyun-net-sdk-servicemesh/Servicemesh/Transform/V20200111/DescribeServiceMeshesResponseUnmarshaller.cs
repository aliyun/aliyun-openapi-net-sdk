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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.servicemesh.Model.V20200111;

namespace Aliyun.Acs.servicemesh.Transform.V20200111
{
    public class DescribeServiceMeshesResponseUnmarshaller
    {
        public static DescribeServiceMeshesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeServiceMeshesResponse describeServiceMeshesResponse = new DescribeServiceMeshesResponse();

			describeServiceMeshesResponse.HttpResponse = _ctx.HttpResponse;
			describeServiceMeshesResponse.RequestId = _ctx.StringValue("DescribeServiceMeshes.RequestId");

			List<DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh> describeServiceMeshesResponse_serviceMeshes = new List<DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh>();
			for (int i = 0; i < _ctx.Length("DescribeServiceMeshes.ServiceMeshes.Length"); i++) {
				DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh serviceMesh = new DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh();

				List<string> serviceMesh_clusters = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeServiceMeshes.ServiceMeshes["+ i +"].Clusters.Length"); j++) {
					serviceMesh_clusters.Add(_ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Clusters["+ j +"]"));
				}
				serviceMesh.Clusters = serviceMesh_clusters;

				DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Endpoints endpoints = new DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Endpoints();
				endpoints.IntranetApiServerEndpoint = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Endpoints.IntranetApiServerEndpoint");
				endpoints.IntranetPilotEndpoint = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Endpoints.IntranetPilotEndpoint");
				endpoints.PublicApiServerEndpoint = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Endpoints.PublicApiServerEndpoint");
				endpoints.PublicPilotEndpoint = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Endpoints.PublicPilotEndpoint");
				endpoints.ReverseTunnelEndpoint = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Endpoints.ReverseTunnelEndpoint");
				serviceMesh.Endpoints = endpoints;

				DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_ServiceMeshInfo serviceMeshInfo = new DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_ServiceMeshInfo();
				serviceMeshInfo.CreationTime = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].ServiceMeshInfo.CreationTime");
				serviceMeshInfo.ErrorMessage = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].ServiceMeshInfo.ErrorMessage");
				serviceMeshInfo.Name = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].ServiceMeshInfo.Name");
				serviceMeshInfo.RegionId = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].ServiceMeshInfo.RegionId");
				serviceMeshInfo.ServiceMeshId = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].ServiceMeshInfo.ServiceMeshId");
				serviceMeshInfo.State = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].ServiceMeshInfo.State");
				serviceMeshInfo.UpdateTime = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].ServiceMeshInfo.UpdateTime");
				serviceMeshInfo.Version = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].ServiceMeshInfo.Version");
				serviceMesh.ServiceMeshInfo = serviceMeshInfo;

				DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec spec = new DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec();

				DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_LoadBalancer loadBalancer = new DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_LoadBalancer();
				loadBalancer.ApiServerLoadbalancerId = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.LoadBalancer.ApiServerLoadbalancerId");
				loadBalancer.ApiServerPublicEip = _ctx.BooleanValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.LoadBalancer.ApiServerPublicEip");
				loadBalancer.PilotPublicEip = _ctx.BooleanValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.LoadBalancer.PilotPublicEip");
				loadBalancer.PilotPublicLoadbalancerId = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.LoadBalancer.PilotPublicLoadbalancerId");
				spec.LoadBalancer = loadBalancer;

				DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_MeshConfig meshConfig = new DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_MeshConfig();
				meshConfig.Mtls = _ctx.BooleanValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.MeshConfig.Mtls");
				meshConfig.OutboundTrafficPolicy = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.MeshConfig.OutboundTrafficPolicy");
				meshConfig.StrictMtls = _ctx.BooleanValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.MeshConfig.StrictMtls");
				meshConfig.Tracing = _ctx.BooleanValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.MeshConfig.Tracing");
				meshConfig.Telemetry = _ctx.BooleanValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.MeshConfig.Telemetry");

				DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_MeshConfig.DescribeServiceMeshes_Pilot pilot = new DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_MeshConfig.DescribeServiceMeshes_Pilot();
				pilot.TraceSampling = _ctx.FloatValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.MeshConfig.Pilot.TraceSampling");
				pilot.Http10Enabled = _ctx.BooleanValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.MeshConfig.Pilot.Http10Enabled");
				meshConfig.Pilot = pilot;

				DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_MeshConfig.DescribeServiceMeshes_SidecarInjector sidecarInjector = new DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_MeshConfig.DescribeServiceMeshes_SidecarInjector();
				sidecarInjector.EnableNamespacesByDefault = _ctx.BooleanValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.MeshConfig.SidecarInjector.EnableNamespacesByDefault");
				sidecarInjector.AutoInjectionPolicyEnabled = _ctx.BooleanValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.MeshConfig.SidecarInjector.AutoInjectionPolicyEnabled");

				DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_MeshConfig.DescribeServiceMeshes_SidecarInjector.DescribeServiceMeshes_InitCNIConfiguration initCNIConfiguration = new DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_MeshConfig.DescribeServiceMeshes_SidecarInjector.DescribeServiceMeshes_InitCNIConfiguration();
				initCNIConfiguration.Enabled = _ctx.BooleanValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.MeshConfig.SidecarInjector.InitCNIConfiguration.Enabled");
				initCNIConfiguration.ExcludeNamespaces = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.MeshConfig.SidecarInjector.InitCNIConfiguration.ExcludeNamespaces");
				sidecarInjector.InitCNIConfiguration = initCNIConfiguration;
				meshConfig.SidecarInjector = sidecarInjector;
				spec.MeshConfig = meshConfig;

				DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_Network network = new DescribeServiceMeshesResponse.DescribeServiceMeshes_ServiceMesh.DescribeServiceMeshes_Spec.DescribeServiceMeshes_Network();
				network.SecurityGroupId = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.Network.SecurityGroupId");
				network.VpcId = _ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.Network.VpcId");

				List<string> network_vSwitches = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.Network.VSwitches.Length"); j++) {
					network_vSwitches.Add(_ctx.StringValue("DescribeServiceMeshes.ServiceMeshes["+ i +"].Spec.Network.VSwitches["+ j +"]"));
				}
				network.VSwitches = network_vSwitches;
				spec.Network = network;
				serviceMesh.Spec = spec;

				describeServiceMeshesResponse_serviceMeshes.Add(serviceMesh);
			}
			describeServiceMeshesResponse.ServiceMeshes = describeServiceMeshesResponse_serviceMeshes;
        
			return describeServiceMeshesResponse;
        }
    }
}
