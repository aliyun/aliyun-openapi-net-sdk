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
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeDnsProductInstanceResponse : AcsResponse
	{
	    public string InstanceId { get; set; }

	    public string VersionCode { get; set; }

	    public string VersionName { get; set; }

	    public string StartTime { get; set; }

	    public long? StartTimestamp { get; set; }

	    public string EndTime { get; set; }

	    public long? EndTimestamp { get; set; }

	    public string Domain { get; set; }

	    public long? BindCount { get; set; }

	    public long? BindUsedCount { get; set; }

	    public long? TTLMinValue { get; set; }

	    public long? SubDomainLevel { get; set; }

	    public long? DnsSLBCount { get; set; }

	    public long? URLForwardCount { get; set; }

	    public long? DDosDefendFlow { get; set; }

	    public long? DDosDefendQuery { get; set; }

	    public long? OverseaDDosDefendFlow { get; set; }

	    public string SearchEngineLines { get; set; }

	    public string ISPLines { get; set; }

	    public string ISPRegionLines { get; set; }

	    public string OverseaLine { get; set; }

	    public long? MonitorNodeCount { get; set; }

	    public long? MonitorFrequency { get; set; }

	    public long? MonitorTaskCount { get; set; }

	    public List<string> DnsServers { get; set; }
	}
}
