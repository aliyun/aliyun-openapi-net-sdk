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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeInstanceMonitorDataResponse : AcsResponse
	{
	    public List<InstanceMonitorData> MonitorData { get; set; }

	    public class InstanceMonitorData{
	        public string InstanceId { get; set; }

	        public int? Cpu { get; set; }

	        public int? IntranetRx { get; set; }

	        public int? IntranetTx { get; set; }

	        public int? IntranetBandwidth { get; set; }

	        public int? InternetRx { get; set; }

	        public int? InternetTx { get; set; }

	        public int? InternetBandwidth { get; set; }

	        public int? IopsRead { get; set; }

	        public int? IopsWrite { get; set; }

	        public int? BpsRead { get; set; }

	        public int? BpsWrite { get; set; }

	        public string TimeStamp { get; set; }
	    }
	}
}