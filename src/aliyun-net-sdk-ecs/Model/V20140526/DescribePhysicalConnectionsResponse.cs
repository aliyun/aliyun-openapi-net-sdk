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
	public class DescribePhysicalConnectionsResponse : AcsResponse
	{
	    public int? PageNumber { get; set; }

	    public int? PageSize { get; set; }

	    public int? TotalCount { get; set; }

	    public List<PhysicalConnectionType> PhysicalConnectionSet { get; set; }

	    public class PhysicalConnectionType{
	        public string PhysicalConnectionId { get; set; }

	        public string AccessPointId { get; set; }

	        public string Type { get; set; }

	        public string Status { get; set; }

	        public string BusinessStatus { get; set; }

	        public string CreationTime { get; set; }

	        public string EnabledTime { get; set; }

	        public string LineOperator { get; set; }

	        public string Spec { get; set; }

	        public string PeerLocation { get; set; }

	        public string PortType { get; set; }

	        public string RedundantPhysicalConnectionId { get; set; }

	        public string Name { get; set; }

	        public string Description { get; set; }

	        public string AdLocation { get; set; }

	        public string PortNumber { get; set; }

	        public string CircuitCode { get; set; }

	        public long? Bandwidth { get; set; }
	    }
	}
}