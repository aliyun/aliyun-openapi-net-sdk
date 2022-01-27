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
    public class DescribeServiceMeshDetailResponseUnmarshaller
    {
        public static DescribeServiceMeshDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeServiceMeshDetailResponse describeServiceMeshDetailResponse = new DescribeServiceMeshDetailResponse();

			describeServiceMeshDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeServiceMeshDetailResponse.RequestId = _ctx.StringValue("DescribeServiceMeshDetail.RequestId");

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh serviceMesh = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh();

			List<string> serviceMesh_clusters = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeServiceMeshDetail.ServiceMesh.Clusters.Length"); i++) {
				serviceMesh_clusters.Add(_ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Clusters["+ i +"]"));
			}
			serviceMesh.Clusters = serviceMesh_clusters;

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Endpoints endpoints = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Endpoints();
			endpoints.IntranetApiServerEndpoint = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Endpoints.IntranetApiServerEndpoint");
			endpoints.IntranetPilotEndpoint = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Endpoints.IntranetPilotEndpoint");
			endpoints.PublicApiServerEndpoint = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Endpoints.PublicApiServerEndpoint");
			endpoints.PublicPilotEndpoint = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Endpoints.PublicPilotEndpoint");
			serviceMesh.Endpoints = endpoints;

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_ServiceMeshInfo serviceMeshInfo = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_ServiceMeshInfo();
			serviceMeshInfo.CreationTime = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.ServiceMeshInfo.CreationTime");
			serviceMeshInfo.ErrorMessage = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.ServiceMeshInfo.ErrorMessage");
			serviceMeshInfo.Name = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.ServiceMeshInfo.Name");
			serviceMeshInfo.RegionId = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.ServiceMeshInfo.RegionId");
			serviceMeshInfo.ServiceMeshId = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.ServiceMeshInfo.ServiceMeshId");
			serviceMeshInfo.State = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.ServiceMeshInfo.State");
			serviceMeshInfo.UpdateTime = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.ServiceMeshInfo.UpdateTime");
			serviceMeshInfo.Version = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.ServiceMeshInfo.Version");
			serviceMesh.ServiceMeshInfo = serviceMeshInfo;

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec spec = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec();

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_LoadBalancer loadBalancer = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_LoadBalancer();
			loadBalancer.ApiServerLoadbalancerId = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.LoadBalancer.ApiServerLoadbalancerId");
			loadBalancer.ApiServerPublicEip = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.LoadBalancer.ApiServerPublicEip");
			loadBalancer.PilotPublicEip = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.LoadBalancer.PilotPublicEip");
			loadBalancer.PilotPublicLoadbalancerId = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.LoadBalancer.PilotPublicLoadbalancerId");
			spec.LoadBalancer = loadBalancer;

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig meshConfig = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig();
			meshConfig.EnableLocalityLB = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.EnableLocalityLB");
			meshConfig.Telemetry = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.Telemetry");
			meshConfig.Tracing = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.Tracing");
			meshConfig.CustomizedZipkin = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.CustomizedZipkin");
			meshConfig.OutboundTrafficPolicy = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.OutboundTrafficPolicy");
			meshConfig.IncludeIPRanges = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.IncludeIPRanges");

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_Pilot pilot = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_Pilot();
			pilot.TraceSampling = _ctx.FloatValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.Pilot.TraceSampling");
			pilot.Http10Enabled = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.Pilot.Http10Enabled");
			meshConfig.Pilot = pilot;

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_OPA oPA = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_OPA();
			oPA.Enabled = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.OPA.Enabled");
			oPA.LogLevel = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.OPA.LogLevel");
			oPA.RequestCPU = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.OPA.RequestCPU");
			oPA.RequestMemory = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.OPA.RequestMemory");
			oPA.LimitCPU = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.OPA.LimitCPU");
			oPA.LimitMemory = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.OPA.LimitMemory");
			meshConfig.OPA = oPA;

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_Audit audit = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_Audit();
			audit.Enabled = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.Audit.Enabled");
			audit.Project = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.Audit.Project");
			meshConfig.Audit = audit;

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_Proxy proxy = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_Proxy();
			proxy.ClusterDomain = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.Proxy.ClusterDomain");
			proxy.RequestCPU = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.Proxy.RequestCPU");
			proxy.RequestMemory = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.Proxy.RequestMemory");
			proxy.LimitCPU = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.Proxy.LimitCPU");
			proxy.LimitMemory = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.Proxy.LimitMemory");
			meshConfig.Proxy = proxy;

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_SidecarInjector sidecarInjector = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_SidecarInjector();
			sidecarInjector.EnableNamespacesByDefault = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.SidecarInjector.EnableNamespacesByDefault");
			sidecarInjector.AutoInjectionPolicyEnabled = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.SidecarInjector.AutoInjectionPolicyEnabled");
			sidecarInjector.RequestCPU = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.SidecarInjector.RequestCPU");
			sidecarInjector.RequestMemory = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.SidecarInjector.RequestMemory");
			sidecarInjector.LimitCPU = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.SidecarInjector.LimitCPU");
			sidecarInjector.LimitMemory = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.SidecarInjector.LimitMemory");
			sidecarInjector.SidecarInjectorWebhookAsYaml = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.SidecarInjector.SidecarInjectorWebhookAsYaml");

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_SidecarInjector.DescribeServiceMeshDetail_InitCNIConfiguration initCNIConfiguration = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_MeshConfig.DescribeServiceMeshDetail_SidecarInjector.DescribeServiceMeshDetail_InitCNIConfiguration();
			initCNIConfiguration.Enabled = _ctx.BooleanValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.SidecarInjector.InitCNIConfiguration.Enabled");
			initCNIConfiguration.ExcludeNamespaces = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.MeshConfig.SidecarInjector.InitCNIConfiguration.ExcludeNamespaces");
			sidecarInjector.InitCNIConfiguration = initCNIConfiguration;
			meshConfig.SidecarInjector = sidecarInjector;
			spec.MeshConfig = meshConfig;

			DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_Network network = new DescribeServiceMeshDetailResponse.DescribeServiceMeshDetail_ServiceMesh.DescribeServiceMeshDetail_Spec.DescribeServiceMeshDetail_Network();
			network.SecurityGroupId = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.Network.SecurityGroupId");
			network.VpcId = _ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.Network.VpcId");

			List<string> network_vSwitches = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeServiceMeshDetail.ServiceMesh.Spec.Network.VSwitches.Length"); i++) {
				network_vSwitches.Add(_ctx.StringValue("DescribeServiceMeshDetail.ServiceMesh.Spec.Network.VSwitches["+ i +"]"));
			}
			network.VSwitches = network_vSwitches;
			spec.Network = network;
			serviceMesh.Spec = spec;
			describeServiceMeshDetailResponse.ServiceMesh = serviceMesh;
        
			return describeServiceMeshDetailResponse;
        }
    }
}
