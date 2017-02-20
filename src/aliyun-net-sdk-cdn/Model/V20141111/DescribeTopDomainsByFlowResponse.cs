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

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeTopDomainsByFlowResponse : AcsResponse
	{
	    public string StartTime { get; set; }

	    public string EndTime { get; set; }

	    public long? DomainCount { get; set; }

	    public long? DomainOnlineCount { get; set; }

	    public List<TopDomain> TopDomains { get; set; }

	    public class TopDomain{
	        public string DomainName { get; set; }

	        public long? Rank { get; set; }

	        public string TotalTraffic { get; set; }

	        public string TrafficPercent { get; set; }

	        public long? MaxBps { get; set; }

	        public string MaxBpsTime { get; set; }

	        public long? TotalAccess { get; set; }
	    }
	}
}