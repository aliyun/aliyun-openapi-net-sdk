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
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class DescribeLoadBalancerHttpsListenerAttributeResponse : AcsResponse
	{
	    public int? ListenerPort { get; set; }

	    public int? BackendServerPort { get; set; }

	    public int? Bandwidth { get; set; }

	    public string Status { get; set; }

	    public string SecurityStatus { get; set; }

	    public string XForwardedFor { get; set; }

	    public string Scheduler { get; set; }

	    public string StickySession { get; set; }

	    public string StickySessionType { get; set; }

	    public int? CookieTimeout { get; set; }

	    public string Cookie { get; set; }

	    public string HealthCheck { get; set; }

	    public string HealthCheckDomain { get; set; }

	    public string HealthCheckUri { get; set; }

	    public int? HealthyThreshold { get; set; }

	    public int? UnhealthyThreshold { get; set; }

	    public int? HealthCheckTimeout { get; set; }

	    public int? HealthCheckInterval { get; set; }

	    public int? HealthCheckConnectPort { get; set; }

	    public string HealthCheckHttpCode { get; set; }

	    public string ServerCertificateId { get; set; }

	    public string CaCertificateId { get; set; }

	    public int? MaxConnection { get; set; }

	    public string VServerGroupId { get; set; }
	}
}